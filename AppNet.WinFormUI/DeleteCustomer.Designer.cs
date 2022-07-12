namespace AppNet.WinFormUI
{
    partial class DeleteCustomer
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
            this.grdDeleteCustomerList = new System.Windows.Forms.DataGridView();
            this.txtDeleteCustomerSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncustomerDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdDeleteCustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDeleteCustomerList
            // 
            this.grdDeleteCustomerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDeleteCustomerList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdDeleteCustomerList.BackgroundColor = System.Drawing.Color.White;
            this.grdDeleteCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDeleteCustomerList.Location = new System.Drawing.Point(25, 111);
            this.grdDeleteCustomerList.Name = "grdDeleteCustomerList";
            this.grdDeleteCustomerList.RowTemplate.Height = 25;
            this.grdDeleteCustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDeleteCustomerList.Size = new System.Drawing.Size(428, 196);
            this.grdDeleteCustomerList.TabIndex = 10;
            // 
            // txtDeleteCustomerSearch
            // 
            this.txtDeleteCustomerSearch.Location = new System.Drawing.Point(209, 21);
            this.txtDeleteCustomerSearch.Name = "txtDeleteCustomerSearch";
            this.txtDeleteCustomerSearch.Size = new System.Drawing.Size(244, 29);
            this.txtDeleteCustomerSearch.TabIndex = 9;
            this.txtDeleteCustomerSearch.TextChanged += new System.EventHandler(this.txtDeleteCustomerSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bulunan Müşteri : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Aranacak Kelime : ";
            // 
            // btncustomerDelete
            // 
            this.btncustomerDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btncustomerDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncustomerDelete.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btncustomerDelete.FlatAppearance.BorderSize = 0;
            this.btncustomerDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncustomerDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncustomerDelete.ForeColor = System.Drawing.Color.White;
            this.btncustomerDelete.Location = new System.Drawing.Point(294, 337);
            this.btncustomerDelete.Name = "btncustomerDelete";
            this.btncustomerDelete.Size = new System.Drawing.Size(159, 40);
            this.btncustomerDelete.TabIndex = 11;
            this.btncustomerDelete.Text = "SEÇİLENİ SİL";
            this.btncustomerDelete.UseVisualStyleBackColor = false;
            this.btncustomerDelete.Click += new System.EventHandler(this.btncustomerDelete_Click);
            // 
            // DeleteCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(479, 396);
            this.Controls.Add(this.btncustomerDelete);
            this.Controls.Add(this.grdDeleteCustomerList);
            this.Controls.Add(this.txtDeleteCustomerSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeleteCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÜŞTERİ SİL";
            this.Load += new System.EventHandler(this.DeleteCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDeleteCustomerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView grdDeleteCustomerList;
        private TextBox txtDeleteCustomerSearch;
        private Label label3;
        private Label label2;
        private Button btncustomerDelete;
    }
}