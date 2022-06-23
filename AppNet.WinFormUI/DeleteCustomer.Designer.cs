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
            this.btnDeleted = new System.Windows.Forms.Button();
            this.grdDeleteCustomerList = new System.Windows.Forms.DataGridView();
            this.txtDeleteCustomerSearch = new System.Windows.Forms.TextBox();
            this.cbbDeleteCustomerSearch = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btncustomerDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdDeleteCustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleted
            // 
            this.btnDeleted.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeleted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleted.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnDeleted.FlatAppearance.BorderSize = 3;
            this.btnDeleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleted.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleted.ForeColor = System.Drawing.Color.White;
            this.btnDeleted.Location = new System.Drawing.Point(303, 327);
            this.btnDeleted.Name = "btnDeleted";
            this.btnDeleted.Size = new System.Drawing.Size(150, 40);
            this.btnDeleted.TabIndex = 11;
            this.btnDeleted.Text = "MÜŞTERİ BUL";
            this.btnDeleted.UseVisualStyleBackColor = false;
            this.btnDeleted.Click += new System.EventHandler(this.btnDeleted_Click);
            // 
            // grdDeleteCustomerList
            // 
            this.grdDeleteCustomerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDeleteCustomerList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdDeleteCustomerList.BackgroundColor = System.Drawing.Color.White;
            this.grdDeleteCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDeleteCustomerList.Location = new System.Drawing.Point(25, 169);
            this.grdDeleteCustomerList.Name = "grdDeleteCustomerList";
            this.grdDeleteCustomerList.RowTemplate.Height = 25;
            this.grdDeleteCustomerList.Size = new System.Drawing.Size(428, 128);
            this.grdDeleteCustomerList.TabIndex = 10;
            // 
            // txtDeleteCustomerSearch
            // 
            this.txtDeleteCustomerSearch.Location = new System.Drawing.Point(209, 79);
            this.txtDeleteCustomerSearch.Name = "txtDeleteCustomerSearch";
            this.txtDeleteCustomerSearch.Size = new System.Drawing.Size(244, 29);
            this.txtDeleteCustomerSearch.TabIndex = 9;
            // 
            // cbbDeleteCustomerSearch
            // 
            this.cbbDeleteCustomerSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDeleteCustomerSearch.FormattingEnabled = true;
            this.cbbDeleteCustomerSearch.Location = new System.Drawing.Point(209, 29);
            this.cbbDeleteCustomerSearch.Name = "cbbDeleteCustomerSearch";
            this.cbbDeleteCustomerSearch.Size = new System.Drawing.Size(244, 29);
            this.cbbDeleteCustomerSearch.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bulunan Müşteri : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Aranacak Kelime : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kriter Seçiniz : ";
            // 
            // btncustomerDelete
            // 
            this.btncustomerDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btncustomerDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncustomerDelete.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btncustomerDelete.FlatAppearance.BorderSize = 3;
            this.btncustomerDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncustomerDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncustomerDelete.ForeColor = System.Drawing.Color.White;
            this.btncustomerDelete.Location = new System.Drawing.Point(25, 327);
            this.btncustomerDelete.Name = "btncustomerDelete";
            this.btncustomerDelete.Size = new System.Drawing.Size(262, 40);
            this.btncustomerDelete.TabIndex = 11;
            this.btncustomerDelete.Text = "BULUNAN MÜŞTERİ SİL";
            this.btncustomerDelete.UseVisualStyleBackColor = false;
            this.btncustomerDelete.Visible = false;
            this.btncustomerDelete.Click += new System.EventHandler(this.btncustomerDelete_Click);
            // 
            // DeleteCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(479, 396);
            this.Controls.Add(this.btncustomerDelete);
            this.Controls.Add(this.btnDeleted);
            this.Controls.Add(this.grdDeleteCustomerList);
            this.Controls.Add(this.txtDeleteCustomerSearch);
            this.Controls.Add(this.cbbDeleteCustomerSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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

        private Button btnDeleted;
        private DataGridView grdDeleteCustomerList;
        private TextBox txtDeleteCustomerSearch;
        private ComboBox cbbDeleteCustomerSearch;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btncustomerDelete;
    }
}