﻿namespace AppNet.WinFormUI
{
    partial class DeleteCategory
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdDeleteList = new System.Windows.Forms.DataGridView();
            this.txtDeleteCategory = new System.Windows.Forms.TextBox();
            this.cbbDeleteCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdDeleteList)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDeleteList
            // 
            this.grdDeleteList.BackgroundColor = System.Drawing.Color.White;
            this.grdDeleteList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDeleteList.Location = new System.Drawing.Point(22, 154);
            this.grdDeleteList.Name = "grdDeleteList";
            this.grdDeleteList.RowTemplate.Height = 25;
            this.grdDeleteList.Size = new System.Drawing.Size(434, 150);
            this.grdDeleteList.TabIndex = 9;
            // 
            // txtDeleteCategory
            // 
            this.txtDeleteCategory.Location = new System.Drawing.Point(213, 70);
            this.txtDeleteCategory.Name = "txtDeleteCategory";
            this.txtDeleteCategory.Size = new System.Drawing.Size(243, 29);
            this.txtDeleteCategory.TabIndex = 8;
            // 
            // cbbDeleteCategory
            // 
            this.cbbDeleteCategory.FormattingEnabled = true;
            this.cbbDeleteCategory.Location = new System.Drawing.Point(213, 27);
            this.cbbDeleteCategory.Name = "cbbDeleteCategory";
            this.cbbDeleteCategory.Size = new System.Drawing.Size(243, 29);
            this.cbbDeleteCategory.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(22, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kategori Adı : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bulunan Kategori : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kriter Seçiniz : ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(306, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "KATEGORİYİ SİL";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // DeleteCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(479, 391);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grdDeleteList);
            this.Controls.Add(this.txtDeleteCategory);
            this.Controls.Add(this.cbbDeleteCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeleteCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KATEGORİ SİL";
            this.Load += new System.EventHandler(this.DeleteCategory_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.grdDeleteList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grdDeleteList;
        private TextBox txtDeleteCategory;
        private ComboBox cbbDeleteCategory;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button button1;
    }
}