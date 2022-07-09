namespace AppNet.WinFormUI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnProductManagement = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnStockManagement = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grdUpdate = new System.Windows.Forms.DataGridView();
            this.grdTotal = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCash = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTotal)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProductManagement
            // 
            this.btnProductManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btnProductManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductManagement.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnProductManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductManagement.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProductManagement.ForeColor = System.Drawing.Color.White;
            this.btnProductManagement.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProductManagement.ImageIndex = 0;
            this.btnProductManagement.ImageList = this.imageList1;
            this.btnProductManagement.Location = new System.Drawing.Point(-4, 0);
            this.btnProductManagement.Name = "btnProductManagement";
            this.btnProductManagement.Padding = new System.Windows.Forms.Padding(10, 5, 5, 10);
            this.btnProductManagement.Size = new System.Drawing.Size(205, 86);
            this.btnProductManagement.TabIndex = 0;
            this.btnProductManagement.Text = "ÜRÜN YÖNETİMİ";
            this.btnProductManagement.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProductManagement.UseVisualStyleBackColor = false;
            this.btnProductManagement.Click += new System.EventHandler(this.btnProductManagement_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "product-management.png");
            this.imageList1.Images.SetKeyName(1, "suppliers.png");
            this.imageList1.Images.SetKeyName(2, "stock-management.png");
            this.imageList1.Images.SetKeyName(3, "customers.png");
            this.imageList1.Images.SetKeyName(4, "sales.png");
            this.imageList1.Images.SetKeyName(5, "settings.png");
            this.imageList1.Images.SetKeyName(6, "reports.png");
            this.imageList1.Images.SetKeyName(7, "purchasing.png");
            this.imageList1.Images.SetKeyName(8, "cash.png");
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btnSuppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuppliers.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.btnSuppliers.FlatAppearance.BorderSize = 0;
            this.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuppliers.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSuppliers.ForeColor = System.Drawing.Color.White;
            this.btnSuppliers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSuppliers.ImageIndex = 1;
            this.btnSuppliers.ImageList = this.imageList1;
            this.btnSuppliers.Location = new System.Drawing.Point(0, 86);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Padding = new System.Windows.Forms.Padding(10, 5, 5, 10);
            this.btnSuppliers.Size = new System.Drawing.Size(200, 85);
            this.btnSuppliers.TabIndex = 1;
            this.btnSuppliers.Text = "TEDARİKÇİLER";
            this.btnSuppliers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSuppliers.UseVisualStyleBackColor = false;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnStockManagement
            // 
            this.btnStockManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btnStockManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStockManagement.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnStockManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockManagement.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStockManagement.ForeColor = System.Drawing.Color.White;
            this.btnStockManagement.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStockManagement.ImageIndex = 7;
            this.btnStockManagement.ImageList = this.imageList1;
            this.btnStockManagement.Location = new System.Drawing.Point(-1, 171);
            this.btnStockManagement.Name = "btnStockManagement";
            this.btnStockManagement.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.btnStockManagement.Size = new System.Drawing.Size(205, 85);
            this.btnStockManagement.TabIndex = 2;
            this.btnStockManagement.Text = "SATIN ALMA";
            this.btnStockManagement.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStockManagement.UseVisualStyleBackColor = false;
            this.btnStockManagement.Click += new System.EventHandler(this.btnStockManagement_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomers.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCustomers.ImageIndex = 3;
            this.btnCustomers.ImageList = this.imageList1;
            this.btnCustomers.Location = new System.Drawing.Point(-2, 256);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.btnCustomers.Size = new System.Drawing.Size(205, 86);
            this.btnCustomers.TabIndex = 3;
            this.btnCustomers.Text = "MÜŞTERİLER";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btnSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSales.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSales.ForeColor = System.Drawing.Color.White;
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSales.ImageKey = "sales.png";
            this.btnSales.ImageList = this.imageList1;
            this.btnSales.Location = new System.Drawing.Point(-2, 342);
            this.btnSales.Name = "btnSales";
            this.btnSales.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.btnSales.Size = new System.Drawing.Size(205, 87);
            this.btnSales.TabIndex = 4;
            this.btnSales.Text = "SATIŞ YÖNETİMİ";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btnStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStock.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStock.ImageKey = "stock-management.png";
            this.btnStock.ImageList = this.imageList1;
            this.btnStock.Location = new System.Drawing.Point(0, 429);
            this.btnStock.Name = "btnStock";
            this.btnStock.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.btnStock.Size = new System.Drawing.Size(200, 87);
            this.btnStock.TabIndex = 5;
            this.btnStock.Text = "STOK DURUMU";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(131)))), ((int)(((byte)(47)))));
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.ImageIndex = 6;
            this.btnSettings.ImageList = this.imageList1;
            this.btnSettings.Location = new System.Drawing.Point(1001, 0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(149, 55);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "AYARLAR";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReports.ImageKey = "reports.png";
            this.btnReports.ImageList = this.imageList1;
            this.btnReports.Location = new System.Drawing.Point(0, 603);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.btnReports.Size = new System.Drawing.Size(200, 87);
            this.btnReports.TabIndex = 7;
            this.btnReports.Text = "RAPORLAR";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.label1.Location = new System.Drawing.Point(784, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "GÜNCEL İŞLEMLER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(784, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(437, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "-----";
            // 
            // grdUpdate
            // 
            this.grdUpdate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdUpdate.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdUpdate.BackgroundColor = System.Drawing.Color.White;
            this.grdUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUpdate.GridColor = System.Drawing.Color.White;
            this.grdUpdate.Location = new System.Drawing.Point(785, 199);
            this.grdUpdate.Name = "grdUpdate";
            this.grdUpdate.RowTemplate.Height = 25;
            this.grdUpdate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdUpdate.Size = new System.Drawing.Size(436, 126);
            this.grdUpdate.TabIndex = 9;
            // 
            // grdTotal
            // 
            this.grdTotal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTotal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdTotal.BackgroundColor = System.Drawing.Color.White;
            this.grdTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTotal.GridColor = System.Drawing.Color.White;
            this.grdTotal.Location = new System.Drawing.Point(258, 199);
            this.grdTotal.Name = "grdTotal";
            this.grdTotal.RowTemplate.Height = 25;
            this.grdTotal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdTotal.Size = new System.Drawing.Size(436, 126);
            this.grdTotal.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.label3.Location = new System.Drawing.Point(256, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "TOPLAM İŞLEMLER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(256, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(437, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "---------------------------------------------------------------------------------" +
    "-----";
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btnCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCash.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCash.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCash.ForeColor = System.Drawing.Color.White;
            this.btnCash.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCash.ImageKey = "cash.png";
            this.btnCash.ImageList = this.imageList1;
            this.btnCash.Location = new System.Drawing.Point(-1, 516);
            this.btnCash.Name = "btnCash";
            this.btnCash.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.btnCash.Size = new System.Drawing.Size(205, 87);
            this.btnCash.TabIndex = 5;
            this.btnCash.Text = "KASA DURUMU";
            this.btnCash.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnProductManagement);
            this.panel1.Controls.Add(this.btnSuppliers);
            this.panel1.Controls.Add(this.btnStockManagement);
            this.panel1.Controls.Add(this.btnCustomers);
            this.panel1.Controls.Add(this.btnSales);
            this.panel1.Controls.Add(this.btnStock);
            this.panel1.Controls.Add(this.btnCash);
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(34)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 691);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnSettings);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1150, 55);
            this.panel2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.label5.Location = new System.Drawing.Point(57, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "ERP YAZILIMI";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(200, 635);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1150, 56);
            this.panel3.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(34)))));
            this.label6.Location = new System.Drawing.Point(910, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Copyright @ 2022 | Didem Çiçek";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 691);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grdTotal);
            this.Controls.Add(this.grdUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppNet - ERP";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTotal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Button btnProductManagement;
        private ImageList imageList1;
        public Button btnSuppliers;
        public Button btnStockManagement;
        public Button btnCustomers;
        public Button btnSales;
        public Button btnStock;
        public Button btnSettings;
        public Button btnReports;
        private Label label1;
        private Label label2;
        public DataGridView grdUpdate;
        public DataGridView grdTotal;
        private Label label3;
        private Label label4;
        public Button btnCash;
        private Panel panel1;
        private Panel panel2;
        private Label label5;
        private Panel panel3;
        private Label label6;
    }
}