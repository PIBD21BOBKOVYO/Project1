﻿namespace BarView
{
    partial class AddExecutorForm
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
            this.FIOTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FIOTextBox
            // 
            this.FIOTextBox.Location = new System.Drawing.Point(112, 6);
            this.FIOTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FIOTextBox.Name = "FIOTextBox";
            this.FIOTextBox.Size = new System.Drawing.Size(249, 22);
            this.FIOTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(263, 38);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 28);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(112, 38);
            this.Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 28);
            this.Save.TabIndex = 6;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // AddExecutorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 76);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FIOTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddExecutorForm";
            this.Text = "Добавить исполнителя";
            this.Load += new System.EventHandler(this.AddExecutorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FIOTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button Save;
    }
}