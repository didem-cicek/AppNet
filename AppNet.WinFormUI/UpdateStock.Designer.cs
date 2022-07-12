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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUpdateCriticalStock = new System.Windows.Forms.TextBox();
            this.txtUpdateStockPiece = new System.Windows.Forms.TextBox();
            this.cbbSize = new System.Windows.Forms.ComboBox();
            this.cbbUpdateSuppliers = new System.Windows.Forms.ComboBox();
            this.txtUpdateStockPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Renk = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbColor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cbbProduct = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdStockList)).BeginInit();
            this.SuspendLayout();
            // 
            // grdStockList
            // 
            this.grdStockList.BackgroundColor = System.Drawing.Color.White;
            this.grdStockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStockList.Location = new System.Drawing.Point(35, 115);
            this.grdStockList.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.grdStockList.Name = "grdStockList";
            this.grdStockList.RowTemplate.Height = 25;
            this.grdStockList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdStockList.Size = new System.Drawing.Size(420, 293);
            this.grdStockList.TabIndex = 2;
            this.grdStockList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdStockList_CellContentClick);
            // 
            // txtUpdateStockSearch
            // 
            this.txtUpdateStockSearch.Location = new System.Drawing.Point(213, 31);
            this.txtUpdateStockSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtUpdateStockSearch.Name = "txtUpdateStockSearch";
            this.txtUpdateStockSearch.Size = new System.Drawing.Size(242, 29);
            this.txtUpdateStockSearch.TabIndex = 1;
            this.txtUpdateStockSearch.TextChanged += new System.EventHandler(this.txtUpdateSupplierSearch_TextChanged);
            // 
            // btnUpdatedSupplier
            // 
            this.btnUpdatedSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btnUpdatedSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatedSupplier.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnUpdatedSupplier.FlatAppearance.BorderSize = 0;
            this.btnUpdatedSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatedSupplier.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdatedSupplier.ForeColor = System.Drawing.Color.White;
            this.btnUpdatedSupplier.Location = new System.Drawing.Point(803, 463);
            this.btnUpdatedSupplier.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnUpdatedSupplier.Name = "btnUpdatedSupplier";
            this.btnUpdatedSupplier.Size = new System.Drawing.Size(162, 44);
            this.btnUpdatedSupplier.TabIndex = 12;
            this.btnUpdatedSupplier.Text = "STOK GÜNCELLE";
            this.btnUpdatedSupplier.UseVisualStyleBackColor = false;
            this.btnUpdatedSupplier.Click += new System.EventHandler(this.btnUpdatedSupplier_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.label8.Location = new System.Drawing.Point(30, 75);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 19);
            this.label8.TabIndex = 26;
            this.label8.Text = "Bulunan Stok : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(30, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 19);
            this.label7.TabIndex = 25;
            this.label7.Text = "Stok Adı : ";
            // 
            // txtUpdateCriticalStock
            // 
            this.txtUpdateCriticalStock.Location = new System.Drawing.Point(723, 321);
            this.txtUpdateCriticalStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtUpdateCriticalStock.Name = "txtUpdateCriticalStock";
            this.txtUpdateCriticalStock.Size = new System.Drawing.Size(242, 29);
            this.txtUpdateCriticalStock.TabIndex = 9;
            this.txtUpdateCriticalStock.TextChanged += new System.EventHandler(this.txtUpdateCriticalStock_TextChanged);
            // 
            // txtUpdateStockPiece
            // 
            this.txtUpdateStockPiece.Location = new System.Drawing.Point(723, 275);
            this.txtUpdateStockPiece.Margin = new System.Windows.Forms.Padding(4);
            this.txtUpdateStockPiece.Name = "txtUpdateStockPiece";
            this.txtUpdateStockPiece.Size = new System.Drawing.Size(242, 29);
            this.txtUpdateStockPiece.TabIndex = 8;
            this.txtUpdateStockPiece.TextChanged += new System.EventHandler(this.txtUpdateStockPiece_TextChanged);
            // 
            // cbbSize
            // 
            this.cbbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSize.FormattingEnabled = true;
            this.cbbSize.Location = new System.Drawing.Point(723, 181);
            this.cbbSize.Margin = new System.Windows.Forms.Padding(4);
            this.cbbSize.Name = "cbbSize";
            this.cbbSize.Size = new System.Drawing.Size(242, 29);
            this.cbbSize.TabIndex = 6;
            this.cbbSize.SelectedIndexChanged += new System.EventHandler(this.cbbUpdateProductType_SelectedIndexChanged);
            // 
            // cbbUpdateSuppliers
            // 
            this.cbbUpdateSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUpdateSuppliers.FormattingEnabled = true;
            this.cbbUpdateSuppliers.Location = new System.Drawing.Point(723, 88);
            this.cbbUpdateSuppliers.Margin = new System.Windows.Forms.Padding(4);
            this.cbbUpdateSuppliers.Name = "cbbUpdateSuppliers";
            this.cbbUpdateSuppliers.Size = new System.Drawing.Size(242, 29);
            this.cbbUpdateSuppliers.TabIndex = 4;
            this.cbbUpdateSuppliers.SelectedIndexChanged += new System.EventHandler(this.cbbUpdateSuppliers_SelectedIndexChanged);
            // 
            // txtUpdateStockPrice
            // 
            this.txtUpdateStockPrice.Location = new System.Drawing.Point(723, 227);
            this.txtUpdateStockPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtUpdateStockPrice.Name = "txtUpdateStockPrice";
            this.txtUpdateStockPrice.Size = new System.Drawing.Size(242, 29);
            this.txtUpdateStockPrice.TabIndex = 7;
            this.txtUpdateStockPrice.TextChanged += new System.EventHandler(this.txtUpdateStockPrice_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(569, 327);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Kritik Stok : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(568, 281);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 19);
            this.label5.TabIndex = 31;
            this.label5.Text = "Ürün Adedi : ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(569, 234);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Alış Fiyatı : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(569, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "Tedarikçi : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Renk
            // 
            this.Renk.AutoSize = true;
            this.Renk.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Renk.Location = new System.Drawing.Point(569, 187);
            this.Renk.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Renk.Name = "Renk";
            this.Renk.Size = new System.Drawing.Size(64, 19);
            this.Renk.TabIndex = 34;
            this.Renk.Text = "Beden : ";
            this.Renk.Click += new System.EventHandler(this.label2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(569, 39);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 19);
            this.label9.TabIndex = 35;
            this.label9.Text = "Ürün Adı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(569, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 34;
            this.label2.Text = "Renk : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbbColor
            // 
            this.cbbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbColor.FormattingEnabled = true;
            this.cbbColor.Location = new System.Drawing.Point(723, 136);
            this.cbbColor.Margin = new System.Windows.Forms.Padding(4);
            this.cbbColor.Name = "cbbColor";
            this.cbbColor.Size = new System.Drawing.Size(242, 29);
            this.cbbColor.TabIndex = 5;
            this.cbbColor.SelectedIndexChanged += new System.EventHandler(this.cbbUpdateProductType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(569, 419);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "Toplam Fiyat : ";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(723, 413);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(242, 29);
            this.txtTotal.TabIndex = 11;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtUpdateCriticalStock_TextChanged);
            // 
            // cbbProduct
            // 
            this.cbbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProduct.FormattingEnabled = true;
            this.cbbProduct.Location = new System.Drawing.Point(723, 39);
            this.cbbProduct.Margin = new System.Windows.Forms.Padding(4);
            this.cbbProduct.Name = "cbbProduct";
            this.cbbProduct.Size = new System.Drawing.Size(242, 29);
            this.cbbProduct.TabIndex = 3;
            this.cbbProduct.SelectedIndexChanged += new System.EventHandler(this.cbbUpdateSuppliers_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(569, 374);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 19);
            this.label10.TabIndex = 30;
            this.label10.Text = "Açıklama : ";
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(723, 368);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(242, 29);
            this.txtDescription.TabIndex = 10;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtUpdateCriticalStock_TextChanged);
            // 
            // UpdateStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 522);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtUpdateCriticalStock);
            this.Controls.Add(this.txtUpdateStockPiece);
            this.Controls.Add(this.cbbColor);
            this.Controls.Add(this.cbbSize);
            this.Controls.Add(this.cbbProduct);
            this.Controls.Add(this.cbbUpdateSuppliers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtUpdateStockPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Renk);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grdStockList);
            this.Controls.Add(this.txtUpdateStockSearch);
            this.Controls.Add(this.btnUpdatedSupplier);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
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
        private Label label8;
        private Label label7;
        public TextBox txtUpdateCriticalStock;
        public TextBox txtUpdateStockPiece;
        public ComboBox cbbSize;
        public ComboBox cbbUpdateSuppliers;
        public TextBox txtUpdateStockPrice;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label Renk;
        private Label label9;
        private Label label2;
        public ComboBox cbbColor;
        private Label label6;
        public TextBox txtTotal;
        public ComboBox cbbProduct;
        private Label label10;
        public TextBox txtDescription;
    }
}