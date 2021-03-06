﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarService.BindingModels;
using BarService.Interfaces;
using BarService.ViewModel;
using BarModel;

namespace BarService.ServicesList
{
    public class MainList : IMainService
    {
        private DataListSingleton source;

        public MainList()
        {
            source = DataListSingleton.GetInstance();
        }

        public void CreateOrder(OrderBindModel model)
        {
            int maxId = 0;
            for (int i = 0; i < source.Orders.Count; ++i)
            {
                if (source.Orders[i].ID > maxId)
                {
                    maxId = source.Customers[i].ID;
                }
            }
            source.Orders.Add(new Order
            {
                ID = maxId + 1,
                CustomerID = model.CustomerID,
                SushiID = model.SushiID,
                DateCreate = DateTime.Now,
                Count = model.Count,
                Sum = model.Sum,
                Status = OrderStatus.Принят
            });
        }

        public void FinishOrder(int id)
        {
            int index = -1;
            for (int i = 0; i < source.Orders.Count; ++i)
            {
                if (source.Customers[i].ID == id)
                {
                    index = i;
                    break;
                }
            }
            if (index == -1)
            {
                throw new Exception("Элемент не найден");
            }
            source.Orders[index].Status = OrderStatus.Готов;
        }

        public List<OrderViewModel> GetList()
        {
            List<OrderViewModel> result = new List<OrderViewModel>();
            for (int i = 0; i < source.Orders.Count; ++i)
            {
                string CustomerFIO = string.Empty;
                for (int j = 0; j < source.Customers.Count; ++j)
                {
                    if (source.Customers[j].ID == source.Orders[i].CustomerID)
                    {
                        CustomerFIO = source.Customers[j].CustomerFIO;
                        break;
                    }
                }
                string SushiName = string.Empty;
                for (int j = 0; j < source.Sushis.Count; ++j)
                {
                    if (source.Sushis[j].ID == source.Orders[i].SushiID)
                    {
                        SushiName = source.Sushis[j].SushiName;
                        break;
                    }
                }
                string ExecutorFIO = string.Empty;
                if (source.Orders[i].ExecutorID.HasValue)
                {
                    for (int j = 0; j < source.Executors.Count; ++j)
                    {
                        if (source.Executors[j].ID == source.Orders[i].ExecutorID.Value)
                        {
                            ExecutorFIO = source.Executors[j].ExecutorFIO;
                            break;
                        }
                    }
                }
                result.Add(new OrderViewModel
                {
                    ID = source.Orders[i].ID,
                    CustomerID = source.Orders[i].CustomerID,
                    CustomerFIO = CustomerFIO,
                    SushiID = source.Orders[i].SushiID,
                    SushiName = SushiName,
                    ExecutorID = source.Orders[i].ExecutorID,
                    ExecutorName = ExecutorFIO,
                    Count = source.Orders[i].Count,
                    Sum = source.Orders[i].Sum,
                    DateCreate = source.Orders[i].DateCreate.ToLongDateString(),
                    DateImplement = source.Orders[i].DateImplement?.ToLongDateString(),
                    Status = source.Orders[i].Status.ToString()
                });
            }
            return result;
        }

        public void PayOrder(int id)
        {
            int index = -1;
            for (int i = 0; i < source.Orders.Count; ++i)
            {
                if (source.Customers[i].ID == id)
                {
                    index = i;
                    break;
                }
            }
            if (index == -1)
            {
                throw new Exception("Элемент не найден");
            }
            source.Orders[index].Status = OrderStatus.Оплачен;
        }

        public void PutElementOnStorage(ElementStorageBindModel model)
        {
            int maxId = 0;
            for (int i = 0; i < source.ElementStorages.Count; ++i)
            {
                if (source.ElementStorages[i].StorageID == model.StorageID &&
                    source.ElementStorages[i].ElementID == model.ElementID)
                {
                    source.ElementStorages[i].Count += model.Count;
                    return;
                }
                if (source.ElementStorages[i].ID > maxId)
                {
                    maxId = source.ElementStorages[i].ID;
                }
            }
            source.ElementStorages.Add(new ElementStorage
            {
                ID = ++maxId,
                StorageID = model.StorageID,
                ElementID = model.ElementID,
                Count = model.Count
            });
        }


        public void TakeOrderInWork(OrderBindModel model)
        {
            int index = -1;
            for (int i = 0; i < source.Orders.Count; ++i)
            {
                if (source.Orders[i].ID == model.ID)
                {
                    index = i;
                    break;
                }
            }
            if (index == -1)
            {
                throw new Exception("Элемент не найден");
            }
            for (int i = 0; i < source.ElementRequirements.Count; ++i)
            {
                if (source.ElementRequirements[i].SushiID == source.Orders[index].SushiID)
                {
                    int countOnStorages = 0;
                    for (int j = 0; j < source.ElementStorages.Count; ++j)
                    {
                        if (source.ElementStorages[j].ElementID == source.ElementRequirements[i].ElementID)
                        {
                            countOnStorages += source.ElementStorages[j].Count;
                        }
                    }
                    if (countOnStorages < source.ElementRequirements[i].Count * source.Orders[index].Count)
                    {
                        for (int j = 0; j < source.Elements.Count; ++j)
                        {
                            if (source.Elements[j].ID == source.ElementRequirements[i].ElementID)
                            {
                                throw new Exception("Не достаточно компонента " + source.Elements[j].ElementName +
                                    " требуется " + source.ElementRequirements[i].Count * source.Orders.Count + ", в наличии " + countOnStorages);
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < source.ElementRequirements.Count; ++i)
            {
                if (source.ElementRequirements[i].SushiID == source.Orders[index].SushiID)
                {
                    int countOnStorages = source.ElementRequirements[i].Count * source.Orders[index].Count;
                    for (int j = 0; j < source.ElementStorages.Count; ++j)
                    {
                        if (source.ElementStorages[j].ElementID == source.ElementRequirements[i].ElementID)
                        {
                            if (source.ElementStorages[j].Count >= countOnStorages)
                            {
                                source.ElementStorages[j].Count -= countOnStorages;
                                break;
                            }
                            else
                            {
                                countOnStorages -= source.ElementStorages[j].Count;
                                source.ElementStorages[j].Count = 0;
                            }
                        }
                    }
                }
            }
            source.Orders[index].ExecutorID = model.ExecutorID;
            source.Orders[index].DateImplement = DateTime.Now;
            source.Orders[index].Status = OrderStatus.Выполняется;
        }
    }
}

