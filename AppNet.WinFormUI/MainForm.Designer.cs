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
            this.btnCash = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grdUpdate = new System.Windows.Forms.DataGridView();
            this.grdTotal = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grdInfo = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProductManagement
            // 
            this.btnProductManagement.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnProductManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductManagement.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnProductManagement.FlatAppearance.BorderSize = 3;
            this.btnProductManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductManagement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProductManagement.ForeColor = System.Drawing.Color.White;
            this.btnProductManagement.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProductManagement.ImageIndex = 0;
            this.btnProductManagement.ImageList = this.imageList1;
            this.btnProductManagement.Location = new System.Drawing.Point(22, 25);
            this.btnProductManagement.Name = "btnProductManagement";
            this.btnProductManagement.Size = new System.Drawing.Size(168, 109);
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
            this.btnSuppliers.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSuppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuppliers.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnSuppliers.FlatAppearance.BorderSize = 3;
            this.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuppliers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSuppliers.ForeColor = System.Drawing.Color.White;
            this.btnSuppliers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSuppliers.ImageIndex = 1;
            this.btnSuppliers.ImageList = this.imageList1;
            this.btnSuppliers.Location = new System.Drawing.Point(198, 25);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(168, 109);
            this.btnSuppliers.TabIndex = 1;
            this.btnSuppliers.Text = "TEDARİKÇİLER";
            this.btnSuppliers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSuppliers.UseVisualStyleBackColor = false;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnStockManagement
            // 
            this.btnStockManagement.BackColor = System.Drawing.Color.Crimson;
            this.btnStockManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStockManagement.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnStockManagement.FlatAppearance.BorderSize = 3;
            this.btnStockManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockManagement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStockManagement.ForeColor = System.Drawing.Color.White;
            this.btnStockManagement.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStockManagement.ImageIndex = 7;
            this.btnStockManagement.ImageList = this.imageList1;
            this.btnStockManagement.Location = new System.Drawing.Point(373, 26);
            this.btnStockManagement.Name = "btnStockManagement";
            this.btnStockManagement.Size = new System.Drawing.Size(168, 109);
            this.btnStockManagement.TabIndex = 2;
            this.btnStockManagement.Text = "SATIN ALMA";
            this.btnStockManagement.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStockManagement.UseVisualStyleBackColor = false;
            this.btnStockManagement.Click += new System.EventHandler(this.btnStockManagement_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomers.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnCustomers.FlatAppearance.BorderSize = 3;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCustomers.ImageIndex = 3;
            this.btnCustomers.ImageList = this.imageList1;
            this.btnCustomers.Location = new System.Drawing.Point(22, 141);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(169, 109);
            this.btnCustomers.TabIndex = 3;
            this.btnCustomers.Text = "MÜŞTERİLER";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.Firebrick;
            this.btnSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSales.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnSales.FlatAppearance.BorderSize = 3;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSales.ForeColor = System.Drawing.Color.White;
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSales.ImageKey = "sales.png";
            this.btnSales.ImageList = this.imageList1;
            this.btnSales.Location = new System.Drawing.Point(197, 141);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(169, 109);
            this.btnSales.TabIndex = 4;
            this.btnSales.Text = "SATIŞ";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCash.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnCash.FlatAppearance.BorderSize = 3;
            this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCash.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCash.ForeColor = System.Drawing.Color.White;
            this.btnCash.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCash.ImageKey = "stock-management.png";
            this.btnCash.ImageList = this.imageList1;
            this.btnCash.Location = new System.Drawing.Point(372, 142);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(169, 109);
            this.btnCash.TabIndex = 5;
            this.btnCash.Text = "STOK";
            this.btnCash.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCash.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.SlateGray;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSettings.FlatAppearance.BorderSize = 3;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.ImageIndex = 6;
            this.btnSettings.ImageList = this.imageList1;
            this.btnSettings.Location = new System.Drawing.Point(811, 25);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(170, 70);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "AYARLAR";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Teal;
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnReports.FlatAppearance.BorderSize = 3;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReports.ImageKey = "reports.png";
            this.btnReports.ImageList = this.imageList1;
            this.btnReports.Location = new System.Drawing.Point(547, 141);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(169, 109);
            this.btnReports.TabIndex = 7;
            this.btnReports.Text = "RAPORLAR";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReports.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(29, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "GÜNCEL İŞLEMLER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(29, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(437, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "-----";
            // 
            // grdUpdate
            // 
            this.grdUpdate.BackgroundColor = System.Drawing.Color.White;
            this.grdUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUpdate.Location = new System.Drawing.Point(29, 423);
            this.grdUpdate.Name = "grdUpdate";
            this.grdUpdate.RowTemplate.Height = 25;
            this.grdUpdate.Size = new System.Drawing.Size(436, 126);
            this.grdUpdate.TabIndex = 9;
            // 
            // grdTotal
            // 
            this.grdTotal.BackgroundColor = System.Drawing.Color.White;
            this.grdTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTotal.Location = new System.Drawing.Point(545, 423);
            this.grdTotal.Name = "grdTotal";
            this.grdTotal.RowTemplate.Height = 25;
            this.grdTotal.Size = new System.Drawing.Size(436, 126);
            this.grdTotal.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(544, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "TOPLAM İŞLEMLER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(544, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(437, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "---------------------------------------------------------------------------------" +
    "-----";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(869, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "BİLDİRİMLER";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // grdInfo
            // 
            this.grdInfo.BackgroundColor = System.Drawing.Color.White;
            this.grdInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdInfo.Location = new System.Drawing.Point(760, 142);
            this.grdInfo.Name = "grdInfo";
            this.grdInfo.RowTemplate.Height = 25;
            this.grdInfo.Size = new System.Drawing.Size(221, 108);
            this.grdInfo.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImageKey = "cash.png";
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(547, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 109);
            this.button1.TabIndex = 5;
            this.button1.Text = "KASA";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.grdInfo);
            this.Controls.Add(this.grdTotal);
            this.Controls.Add(this.grdUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnStockManagement);
            this.Controls.Add(this.btnSuppliers);
            this.Controls.Add(this.btnProductManagement);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppNet - ERP";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdInfo)).EndInit();
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
        public Button btnCash;
        public Button btnSettings;
        public Button btnReports;
        private Label label1;
        private Label label2;
        public DataGridView grdUpdate;
        public DataGridView grdTotal;
        private Label label3;
        private Label label4;
        private Label label5;
        public DataGridView grdInfo;
        public Button button1;
    }
}