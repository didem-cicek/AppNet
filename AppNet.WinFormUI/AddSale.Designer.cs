namespace AppNet.WinFormUI
{
    partial class AddSale
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
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.productLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddSaleDescription = new System.Windows.Forms.TextBox();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.cbbAddSalePay = new System.Windows.Forms.ComboBox();
            this.txtAddSalePiece = new System.Windows.Forms.TextBox();
            this.grdcustomer = new System.Windows.Forms.DataGridView();
            this.grdProduct = new System.Windows.Forms.DataGridView();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductFind = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCustomerFind = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdcustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnAddProduct.FlatAppearance.BorderSize = 3;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(1168, 637);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(150, 40);
            this.btnAddProduct.TabIndex = 7;
            this.btnAddProduct.Text = "SİPARİŞ EKLE";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productLabel.ForeColor = System.Drawing.Color.Black;
            this.productLabel.Location = new System.Drawing.Point(18, 29);
            this.productLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(134, 21);
            this.productLabel.TabIndex = 11;
            this.productLabel.Text = "ÜRÜN SEÇİNİZ : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(947, 572);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Durum : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(20, 618);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Açıklama : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(688, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "MÜŞTERİ SEÇİNİZ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(473, 568);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adet : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 568);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fiyat : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(945, 522);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ödeme Şekli : ";
            // 
            // txtAddSaleDescription
            // 
            this.txtAddSaleDescription.Location = new System.Drawing.Point(149, 614);
            this.txtAddSaleDescription.Name = "txtAddSaleDescription";
            this.txtAddSaleDescription.Size = new System.Drawing.Size(694, 29);
            this.txtAddSaleDescription.TabIndex = 6;
            // 
            // cbbStatus
            // 
            this.cbbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Location = new System.Drawing.Point(1076, 568);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(242, 29);
            this.cbbStatus.TabIndex = 5;
            // 
            // cbbAddSalePay
            // 
            this.cbbAddSalePay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAddSalePay.FormattingEnabled = true;
            this.cbbAddSalePay.Location = new System.Drawing.Point(1076, 518);
            this.cbbAddSalePay.Name = "cbbAddSalePay";
            this.cbbAddSalePay.Size = new System.Drawing.Size(242, 29);
            this.cbbAddSalePay.TabIndex = 5;
            // 
            // txtAddSalePiece
            // 
            this.txtAddSalePiece.Location = new System.Drawing.Point(602, 560);
            this.txtAddSalePiece.Name = "txtAddSalePiece";
            this.txtAddSalePiece.Size = new System.Drawing.Size(242, 29);
            this.txtAddSalePiece.TabIndex = 4;
            // 
            // grdcustomer
            // 
            this.grdcustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdcustomer.BackgroundColor = System.Drawing.Color.White;
            this.grdcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdcustomer.Location = new System.Drawing.Point(688, 122);
            this.grdcustomer.Name = "grdcustomer";
            this.grdcustomer.RowTemplate.Height = 25;
            this.grdcustomer.Size = new System.Drawing.Size(631, 365);
            this.grdcustomer.TabIndex = 12;
            this.grdcustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdcustomer_CellContentClick);
            // 
            // grdProduct
            // 
            this.grdProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProduct.BackgroundColor = System.Drawing.Color.White;
            this.grdProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProduct.Location = new System.Drawing.Point(18, 122);
            this.grdProduct.Name = "grdProduct";
            this.grdProduct.RowTemplate.Height = 25;
            this.grdProduct.Size = new System.Drawing.Size(622, 365);
            this.grdProduct.TabIndex = 13;
            this.grdProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProduct_CellContentClick_1);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(150, 565);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(242, 29);
            this.txtPrice.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 518);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Müşteri Adı : ";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(150, 515);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(242, 29);
            this.txtCustomerName.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(472, 518);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ürün Bilgisi : ";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(601, 514);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(242, 29);
            this.txtProductName.TabIndex = 4;
            // 
            // txtProductFind
            // 
            this.txtProductFind.Location = new System.Drawing.Point(133, 71);
            this.txtProductFind.Name = "txtProductFind";
            this.txtProductFind.Size = new System.Drawing.Size(507, 29);
            this.txtProductFind.TabIndex = 17;
            this.txtProductFind.TextChanged += new System.EventHandler(this.txtProductFind_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(19, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 14;
            this.label9.Text = "Ürün Ara : ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(688, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 21);
            this.label12.TabIndex = 14;
            this.label12.Text = "Müşteri Ara : ";
            this.label12.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtCustomerFind
            // 
            this.txtCustomerFind.Location = new System.Drawing.Point(827, 74);
            this.txtCustomerFind.Name = "txtCustomerFind";
            this.txtCustomerFind.Size = new System.Drawing.Size(493, 29);
            this.txtCustomerFind.TabIndex = 17;
            this.txtCustomerFind.TextChanged += new System.EventHandler(this.txtCustomerFind_TextChanged);
            // 
            // AddSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 691);
            this.Controls.Add(this.txtCustomerFind);
            this.Controls.Add(this.txtProductFind);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grdProduct);
            this.Controls.Add(this.grdcustomer);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtAddSaleDescription);
            this.Controls.Add(this.cbbStatus);
            this.Controls.Add(this.cbbAddSalePay);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtAddSalePiece);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SİPARİŞ EKLE";
            this.Load += new System.EventHandler(this.AddSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdcustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Button btnAddProduct;
        private Label productLabel;
        private Label label7;
        private Label label5;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label6;
        public TextBox txtAddSaleDescription;
        public ComboBox cbbStatus;
        public ComboBox cbbAddSalePay;
        public TextBox txtAddSalePiece;
        private DataGridView grdcustomer;
        private DataGridView grdProduct;
        public TextBox txtPrice;
        private Label label1;
        public TextBox txtCustomerName;
        private Label label8;
        public TextBox txtProductName;
        private TextBox txtProductFind;
        private Label label9;
        private Label label12;
        private TextBox txtCustomerFind;
    }
}