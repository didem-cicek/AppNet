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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSale));
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.productLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.cbbAddSalePay = new System.Windows.Forms.ComboBox();
            this.grdProduct = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProductFind = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.addCustomer = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDesciption = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.grdList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(426, 560);
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
            this.productLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.productLabel.Location = new System.Drawing.Point(33, 28);
            this.productLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(139, 30);
            this.productLabel.TabIndex = 11;
            this.productLabel.Text = "ÜRÜN EKLE  ";
            this.productLabel.Click += new System.EventHandler(this.productLabel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(362, 395);
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
            this.label5.Location = new System.Drawing.Point(-520, 523);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Açıklama : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(18, 393);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ödeme Şekli : ";
            // 
            // cbbStatus
            // 
            this.cbbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Location = new System.Drawing.Point(363, 426);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(213, 29);
            this.cbbStatus.TabIndex = 5;
            // 
            // cbbAddSalePay
            // 
            this.cbbAddSalePay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAddSalePay.FormattingEnabled = true;
            this.cbbAddSalePay.Location = new System.Drawing.Point(23, 426);
            this.cbbAddSalePay.Name = "cbbAddSalePay";
            this.cbbAddSalePay.Size = new System.Drawing.Size(301, 29);
            this.cbbAddSalePay.TabIndex = 5;
            // 
            // grdProduct
            // 
            this.grdProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProduct.BackgroundColor = System.Drawing.Color.White;
            this.grdProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProduct.Location = new System.Drawing.Point(33, 159);
            this.grdProduct.Name = "grdProduct";
            this.grdProduct.RowTemplate.Height = 25;
            this.grdProduct.Size = new System.Drawing.Size(615, 431);
            this.grdProduct.TabIndex = 13;
            this.grdProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProduct_CellContentClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Müşteri Adı : ";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(137, 104);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(444, 29);
            this.txtCustomerName.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(17, 159);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ürün Bilgisi : ";
            // 
            // txtProductFind
            // 
            this.txtProductFind.Location = new System.Drawing.Point(160, 104);
            this.txtProductFind.Name = "txtProductFind";
            this.txtProductFind.Size = new System.Drawing.Size(488, 29);
            this.txtProductFind.TabIndex = 17;
            this.txtProductFind.TextChanged += new System.EventHandler(this.txtProductFind_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(36, 107);
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
            this.label12.Location = new System.Drawing.Point(38, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 21);
            this.label12.TabIndex = 14;
            this.label12.Text = "Müşteri Ekle : ";
            this.label12.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCustomer);
            this.panel1.Controls.Add(this.addCustomer);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 78);
            this.panel1.TabIndex = 18;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(160, 26);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.ReadOnly = true;
            this.txtCustomer.Size = new System.Drawing.Size(488, 29);
            this.txtCustomer.TabIndex = 16;
            // 
            // addCustomer
            // 
            this.addCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.addCustomer.FlatAppearance.BorderSize = 0;
            this.addCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCustomer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addCustomer.ImageKey = "add.png";
            this.addCustomer.ImageList = this.imageList1;
            this.addCustomer.Location = new System.Drawing.Point(668, 24);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(30, 30);
            this.addCustomer.TabIndex = 15;
            this.addCustomer.UseVisualStyleBackColor = false;
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.productLabel);
            this.panel2.Controls.Add(this.txtProductFind);
            this.panel2.Controls.Add(this.grdProduct);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(680, 613);
            this.panel2.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.label10.Location = new System.Drawing.Point(33, 70);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(603, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------";
            this.label10.Click += new System.EventHandler(this.productLabel_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtDesciption);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtTotalPrice);
            this.panel3.Controls.Add(this.grdList);
            this.panel3.Controls.Add(this.txtCustomerName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cbbStatus);
            this.panel3.Controls.Add(this.btnAddProduct);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.cbbAddSalePay);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(747, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(603, 613);
            this.panel3.TabIndex = 20;
            // 
            // txtDesciption
            // 
            this.txtDesciption.Location = new System.Drawing.Point(23, 506);
            this.txtDesciption.Name = "txtDesciption";
            this.txtDesciption.Size = new System.Drawing.Size(301, 29);
            this.txtDesciption.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.label11.Location = new System.Drawing.Point(14, 63);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(573, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------";
            this.label11.Click += new System.EventHandler(this.productLabel_Click);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(363, 506);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(213, 29);
            this.txtTotalPrice.TabIndex = 11;
            // 
            // grdList
            // 
            this.grdList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdList.BackgroundColor = System.Drawing.Color.White;
            this.grdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdList.GridColor = System.Drawing.Color.White;
            this.grdList.Location = new System.Drawing.Point(137, 159);
            this.grdList.Name = "grdList";
            this.grdList.RowTemplate.Height = 25;
            this.grdList.Size = new System.Drawing.Size(444, 218);
            this.grdList.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.label2.Location = new System.Drawing.Point(14, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "SİPARİŞ BİLGİLERİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(18, 472);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Açıklama : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(363, 472);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Toplam Tutar";
            // 
            // AddSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 691);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SİPARİŞ EKLE";
            this.Load += new System.EventHandler(this.AddSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Button btnAddProduct;
        private Label productLabel;
        private Label label7;
        private Label label5;
        private Label label6;
        public ComboBox cbbStatus;
        public ComboBox cbbAddSalePay;
        public DataGridView grdProduct;
        private Label label1;
        public TextBox txtCustomerName;
        private Label label8;
        private TextBox txtProductFind;
        private Label label9;
        private Label label12;
        private Panel panel1;
        private TextBox txtCustomer;
        private Button addCustomer;
        private ImageList imageList1;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtDesciption;
        private TextBox txtTotalPrice;
        private DataGridView grdList;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label10;
        private Label label11;
        
    }
}