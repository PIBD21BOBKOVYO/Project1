﻿namespace BarView
{
    partial class SushiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Name = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(16, 11);
            this.Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(72, 17);
            this.Name.TabIndex = 0;
            this.Name.Text = "Название";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(16, 46);
            this.Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(43, 17);
            this.Price.TabIndex = 2;
            this.Price.Text = "Цена";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(100, 7);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(261, 22);
            this.NameTextBox.TabIndex = 3;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(100, 42);
            this.PriceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(132, 22);
            this.PriceTextBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Update);
            this.groupBox1.Controls.Add(this.Delete);
            this.groupBox1.Controls.Add(this.Change);
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(16, 74);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(556, 308);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Компоненты";
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(448, 130);
            this.Update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(100, 28);
            this.Update.TabIndex = 4;
            this.Update.Text = "Обновить";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(448, 95);
            this.Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(100, 28);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(448, 59);
            this.Change.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(100, 28);
            this.Change.TabIndex = 2;
            this.Change.Text = "Изменить";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(448, 23);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(100, 28);
            this.Add.TabIndex = 1;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(4, 19);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(436, 285);
            this.dataGridView1.TabIndex = 0;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(364, 389);
            this.Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 28);
            this.Save.TabIndex = 5;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(472, 389);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(100, 28);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // SushiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 432);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Name);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            //this.Name = "SushiForm";
            this.Text = "Создать суши";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
    }
}