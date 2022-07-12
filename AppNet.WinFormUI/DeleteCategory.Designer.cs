namespace AppNet.WinFormUI
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearchDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdDeleteList)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDeleteList
            // 
            this.grdDeleteList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDeleteList.BackgroundColor = System.Drawing.Color.White;
            this.grdDeleteList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDeleteList.Location = new System.Drawing.Point(22, 118);
            this.grdDeleteList.Name = "grdDeleteList";
            this.grdDeleteList.RowTemplate.Height = 25;
            this.grdDeleteList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDeleteList.Size = new System.Drawing.Size(434, 150);
            this.grdDeleteList.TabIndex = 9;
            // 
            // txtDeleteCategory
            // 
            this.txtDeleteCategory.Location = new System.Drawing.Point(213, 27);
            this.txtDeleteCategory.Name = "txtDeleteCategory";
            this.txtDeleteCategory.Size = new System.Drawing.Size(243, 29);
            this.txtDeleteCategory.TabIndex = 8;
            this.txtDeleteCategory.TextChanged += new System.EventHandler(this.txtDeleteCategory_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(22, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Aranacak Kelime : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bulunan Kategori : ";
            // 
            // btnSearchDelete
            // 
            this.btnSearchDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btnSearchDelete.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnSearchDelete.FlatAppearance.BorderSize = 0;
            this.btnSearchDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchDelete.ForeColor = System.Drawing.Color.White;
            this.btnSearchDelete.Location = new System.Drawing.Point(286, 300);
            this.btnSearchDelete.Name = "btnSearchDelete";
            this.btnSearchDelete.Size = new System.Drawing.Size(170, 40);
            this.btnSearchDelete.TabIndex = 10;
            this.btnSearchDelete.Text = "SEÇİLENİ SİL";
            this.btnSearchDelete.UseVisualStyleBackColor = false;
            this.btnSearchDelete.Click += new System.EventHandler(this.btnSearchDelete_Click);
            // 
            // DeleteCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(476, 354);
            this.Controls.Add(this.btnSearchDelete);
            this.Controls.Add(this.grdDeleteList);
            this.Controls.Add(this.txtDeleteCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private Label label4;
        private Label label3;
        private Button btnSearchDelete;
    }
}