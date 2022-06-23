namespace AppNet.WinFormUI
{
    partial class UpdateStock
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
            this.grdStockList = new System.Windows.Forms.DataGridView();
            this.txtUpdateStockSearch = new System.Windows.Forms.TextBox();
            this.btnUpdatedSupplier = new System.Windows.Forms.Button();
            this.cbbUpdateStockSearch = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUpdateCriticalStock = new System.Windows.Forms.TextBox();
            this.txtUpdateStockPiece = new System.Windows.Forms.TextBox();
            this.cbbUpdateProductType = new System.Windows.Forms.ComboBox();
            this.cbbUpdateSuppliers = new System.Windows.Forms.ComboBox();
            this.txtUpdateStockPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUpdateStockName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearchUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdStockList)).BeginInit();
            this.SuspendLayout();
            // 
            // grdStockList
            // 
            this.grdStockList.BackgroundColor = System.Drawing.Color.White;
            this.grdStockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStockList.Location = new System.Drawing.Point(35, 217);
            this.grdStockList.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.grdStockList.Name = "grdStockList";
            this.grdStockList.RowTemplate.Height = 25;
            this.grdStockList.Size = new System.Drawing.Size(420, 112);
            this.grdStockList.TabIndex = 3;
            // 
            // txtUpdateStockSearch
            // 
            this.txtUpdateStockSearch.Location = new System.Drawing.Point(213, 90);
            this.txtUpdateStockSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtUpdateStockSearch.Name = "txtUpdateStockSearch";
            this.txtUpdateStockSearch.Size = new System.Drawing.Size(242, 29);
            this.txtUpdateStockSearch.TabIndex = 2;
            this.txtUpdateStockSearch.TextChanged += new System.EventHandler(this.txtUpdateSupplierSearch_TextChanged);
            // 
            // btnUpdatedSupplier
            // 
            this.btnUpdatedSupplier.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdatedSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatedSupplier.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnUpdatedSupplier.FlatAppearance.BorderSize = 3;
            this.btnUpdatedSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatedSupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdatedSupplier.ForeColor = System.Drawing.Color.White;
            this.btnUpdatedSupplier.Location = new System.Drawing.Point(765, 337);
            this.btnUpdatedSupplier.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnUpdatedSupplier.Name = "btnUpdatedSupplier";
            this.btnUpdatedSupplier.Size = new System.Drawing.Size(200, 56);
            this.btnUpdatedSupplier.TabIndex = 10;
            this.btnUpdatedSupplier.Text = "STOK GÜNCELLE";
            this.btnUpdatedSupplier.UseVisualStyleBackColor = false;
            // 
            // cbbUpdateStockSearch
            // 
            this.cbbUpdateStockSearch.FormattingEnabled = true;
            this.cbbUpdateStockSearch.Location = new System.Drawing.Point(213, 44);
            this.cbbUpdateStockSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbbUpdateStockSearch.Name = "cbbUpdateStockSearch";
            this.cbbUpdateStockSearch.Size = new System.Drawing.Size(242, 29);
            this.cbbUpdateStockSearch.TabIndex = 1;
            this.cbbUpdateStockSearch.SelectedIndexChanged += new System.EventHandler(this.cbbUpdateSupplierSearch_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(30, 177);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 21);
            this.label8.TabIndex = 26;
            this.label8.Text = "Bulunan Stok : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(30, 94);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 21);
            this.label7.TabIndex = 25;
            this.label7.Text = "Stok Adı : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(28, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = "Kriter Seçiniz : ";
            // 
            // txtUpdateCriticalStock
            // 
            this.txtUpdateCriticalStock.Location = new System.Drawing.Point(723, 273);
            this.txtUpdateCriticalStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtUpdateCriticalStock.Name = "txtUpdateCriticalStock";
            this.txtUpdateCriticalStock.Size = new System.Drawing.Size(242, 29);
            this.txtUpdateCriticalStock.TabIndex = 9;
            this.txtUpdateCriticalStock.TextChanged += new System.EventHandler(this.txtUpdateCriticalStock_TextChanged);
            // 
            // txtUpdateStockPiece
            // 
            this.txtUpdateStockPiece.Location = new System.Drawing.Point(723, 226);
            this.txtUpdateStockPiece.Margin = new System.Windows.Forms.Padding(4);
            this.txtUpdateStockPiece.Name = "txtUpdateStockPiece";
            this.txtUpdateStockPiece.Size = new System.Drawing.Size(242, 29);
            this.txtUpdateStockPiece.TabIndex = 8;
            this.txtUpdateStockPiece.TextChanged += new System.EventHandler(this.txtUpdateStockPiece_TextChanged);
            // 
            // cbbUpdateProductType
            // 
            this.cbbUpdateProductType.FormattingEnabled = true;
            this.cbbUpdateProductType.Location = new System.Drawing.Point(723, 90);
            this.cbbUpdateProductType.Margin = new System.Windows.Forms.Padding(4);
            this.cbbUpdateProductType.Name = "cbbUpdateProductType";
            this.cbbUpdateProductType.Size = new System.Drawing.Size(242, 29);
            this.cbbUpdateProductType.TabIndex = 5;
            this.cbbUpdateProductType.SelectedIndexChanged += new System.EventHandler(this.cbbUpdateProductType_SelectedIndexChanged);
            // 
            // cbbUpdateSuppliers
            // 
            this.cbbUpdateSuppliers.FormattingEnabled = true;
            this.cbbUpdateSuppliers.Location = new System.Drawing.Point(723, 138);
            this.cbbUpdateSuppliers.Margin = new System.Windows.Forms.Padding(4);
            this.cbbUpdateSuppliers.Name = "cbbUpdateSuppliers";
            this.cbbUpdateSuppliers.Size = new System.Drawing.Size(242, 29);
            this.cbbUpdateSuppliers.TabIndex = 6;
            this.cbbUpdateSuppliers.SelectedIndexChanged += new System.EventHandler(this.cbbUpdateSuppliers_SelectedIndexChanged);
            // 
            // txtUpdateStockPrice
            // 
            this.txtUpdateStockPrice.Location = new System.Drawing.Point(723, 183);
            this.txtUpdateStockPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtUpdateStockPrice.Name = "txtUpdateStockPrice";
            this.txtUpdateStockPrice.Size = new System.Drawing.Size(242, 29);
            this.txtUpdateStockPrice.TabIndex = 7;
            this.txtUpdateStockPrice.TextChanged += new System.EventHandler(this.txtUpdateStockPrice_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(569, 273);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "Kritik Stok : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUpdateStockName
            // 
            this.txtUpdateStockName.Location = new System.Drawing.Point(723, 42);
            this.txtUpdateStockName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUpdateStockName.Name = "txtUpdateStockName";
            this.txtUpdateStockName.Size = new System.Drawing.Size(242, 29);
            this.txtUpdateStockName.TabIndex = 4;
            this.txtUpdateStockName.TextChanged += new System.EventHandler(this.txtUpdateStockName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(569, 226);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 21);
            this.label5.TabIndex = 31;
            this.label5.Text = "Ürün Adedi : ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(569, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 21);
            this.label4.TabIndex = 32;
            this.label4.Text = "Alış Fiyatı : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(569, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 33;
            this.label3.Text = "Tedarikçi : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(569, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Ürün Cinsi : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(569, 39);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 35;
            this.label9.Text = "Ürün Adı : ";
            // 
            // btnSearchUpdate
            // 
            this.btnSearchUpdate.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSearchUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchUpdate.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnSearchUpdate.FlatAppearance.BorderSize = 3;
            this.btnSearchUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchUpdate.ForeColor = System.Drawing.Color.White;
            this.btnSearchUpdate.Location = new System.Drawing.Point(255, 341);
            this.btnSearchUpdate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSearchUpdate.Name = "btnSearchUpdate";
            this.btnSearchUpdate.Size = new System.Drawing.Size(200, 56);
            this.btnSearchUpdate.TabIndex = 10;
            this.btnSearchUpdate.Text = "STOK BUL";
            this.btnSearchUpdate.UseVisualStyleBackColor = false;
            this.btnSearchUpdate.Click += new System.EventHandler(this.btnSearchUpdate_Click);
            // 
            // UpdateStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 421);
            this.Controls.Add(this.txtUpdateCriticalStock);
            this.Controls.Add(this.txtUpdateStockPiece);
            this.Controls.Add(this.cbbUpdateProductType);
            this.Controls.Add(this.cbbUpdateSuppliers);
            this.Controls.Add(this.txtUpdateStockPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUpdateStockName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grdStockList);
            this.Controls.Add(this.txtUpdateStockSearch);
            this.Controls.Add(this.btnSearchUpdate);
            this.Controls.Add(this.btnUpdatedSupplier);
            this.Controls.Add(this.cbbUpdateStockSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STOK GÜNCELLE";
            this.Load += new System.EventHandler(this.UpdateStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdStockList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grdStockList;
        private TextBox txtUpdateStockSearch;
        private Button btnUpdatedSupplier;
        private ComboBox cbbUpdateStockSearch;
        private Label label8;
        private Label label7;
        private Label label6;
        public TextBox txtUpdateCriticalStock;
        public TextBox txtUpdateStockPiece;
        public ComboBox cbbUpdateProductType;
        public ComboBox cbbUpdateSuppliers;
        public TextBox txtUpdateStockPrice;
        private Label label1;
        public TextBox txtUpdateStockName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label9;
        private Button btnSearchUpdate;
    }
}