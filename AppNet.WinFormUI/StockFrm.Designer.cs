namespace AppNet.WinFormUI
{
    partial class StockFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockFrm));
            this.grdStockList = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbStockSearch = new System.Windows.Forms.ComboBox();
            this.txtStockSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeletedStock = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnUpdatedStock = new System.Windows.Forms.Button();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.btnSupplierSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdStockList)).BeginInit();
            this.SuspendLayout();
            // 
            // grdStockList
            // 
            this.grdStockList.BackgroundColor = System.Drawing.Color.White;
            this.grdStockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStockList.Location = new System.Drawing.Point(24, 343);
            this.grdStockList.Name = "grdStockList";
            this.grdStockList.RowTemplate.Height = 25;
            this.grdStockList.Size = new System.Drawing.Size(965, 197);
            this.grdStockList.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(19, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "STOK LİSTESİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(612, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(352, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "---------------------------------------------------------------------";
            // 
            // cbbStockSearch
            // 
            this.cbbStockSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbStockSearch.FormattingEnabled = true;
            this.cbbStockSearch.ItemHeight = 21;
            this.cbbStockSearch.Location = new System.Drawing.Point(747, 107);
            this.cbbStockSearch.Name = "cbbStockSearch";
            this.cbbStockSearch.Size = new System.Drawing.Size(214, 29);
            this.cbbStockSearch.TabIndex = 29;
            // 
            // txtStockSearch
            // 
            this.txtStockSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStockSearch.Location = new System.Drawing.Point(747, 158);
            this.txtStockSearch.Name = "txtStockSearch";
            this.txtStockSearch.Size = new System.Drawing.Size(214, 29);
            this.txtStockSearch.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(608, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Aranacak Kelime : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(608, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Arama Kriteri : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(608, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "ARAMA ALANI";
            // 
            // btnDeletedStock
            // 
            this.btnDeletedStock.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeletedStock.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnDeletedStock.FlatAppearance.BorderSize = 3;
            this.btnDeletedStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletedStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeletedStock.ForeColor = System.Drawing.Color.White;
            this.btnDeletedStock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeletedStock.ImageKey = "deleted.png";
            this.btnDeletedStock.ImageList = this.imageList1;
            this.btnDeletedStock.Location = new System.Drawing.Point(408, 21);
            this.btnDeletedStock.Name = "btnDeletedStock";
            this.btnDeletedStock.Size = new System.Drawing.Size(167, 109);
            this.btnDeletedStock.TabIndex = 3;
            this.btnDeletedStock.Text = "STOK SİL";
            this.btnDeletedStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeletedStock.UseVisualStyleBackColor = false;
            this.btnDeletedStock.Click += new System.EventHandler(this.btnDeletedStock_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            this.imageList1.Images.SetKeyName(1, "deleted.png");
            this.imageList1.Images.SetKeyName(2, "edit.png");
            // 
            // btnUpdatedStock
            // 
            this.btnUpdatedStock.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdatedStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatedStock.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.btnUpdatedStock.FlatAppearance.BorderSize = 3;
            this.btnUpdatedStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatedStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdatedStock.ForeColor = System.Drawing.Color.White;
            this.btnUpdatedStock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdatedStock.ImageKey = "edit.png";
            this.btnUpdatedStock.ImageList = this.imageList1;
            this.btnUpdatedStock.Location = new System.Drawing.Point(200, 21);
            this.btnUpdatedStock.Name = "btnUpdatedStock";
            this.btnUpdatedStock.Size = new System.Drawing.Size(200, 109);
            this.btnUpdatedStock.TabIndex = 2;
            this.btnUpdatedStock.Text = "STOK GÜNCELLE";
            this.btnUpdatedStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdatedStock.UseVisualStyleBackColor = false;
            this.btnUpdatedStock.Click += new System.EventHandler(this.btnUpdatedStock_Click);
            // 
            // btnAddStock
            // 
            this.btnAddStock.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddStock.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnAddStock.FlatAppearance.BorderSize = 3;
            this.btnAddStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddStock.ForeColor = System.Drawing.Color.White;
            this.btnAddStock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddStock.ImageIndex = 0;
            this.btnAddStock.ImageList = this.imageList1;
            this.btnAddStock.Location = new System.Drawing.Point(24, 21);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(168, 109);
            this.btnAddStock.TabIndex = 1;
            this.btnAddStock.Text = "STOK EKLE";
            this.btnAddStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddStock.UseVisualStyleBackColor = false;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // btnSupplierSearch
            // 
            this.btnSupplierSearch.BackColor = System.Drawing.Color.Gray;
            this.btnSupplierSearch.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSupplierSearch.FlatAppearance.BorderSize = 3;
            this.btnSupplierSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplierSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSupplierSearch.ForeColor = System.Drawing.Color.White;
            this.btnSupplierSearch.Location = new System.Drawing.Point(861, 211);
            this.btnSupplierSearch.Name = "btnSupplierSearch";
            this.btnSupplierSearch.Size = new System.Drawing.Size(100, 40);
            this.btnSupplierSearch.TabIndex = 6;
            this.btnSupplierSearch.Text = "ARA";
            this.btnSupplierSearch.UseVisualStyleBackColor = false;
            // 
            // StockFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.btnSupplierSearch);
            this.Controls.Add(this.grdStockList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbStockSearch);
            this.Controls.Add(this.txtStockSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeletedStock);
            this.Controls.Add(this.btnUpdatedStock);
            this.Controls.Add(this.btnAddStock);
            this.Name = "StockFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STOK YÖNETİMİ";
            ((System.ComponentModel.ISupportInitialize)(this.grdStockList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grdStockList;
        private Label label5;
        private Label label4;
        public ComboBox cbbStockSearch;
        public TextBox txtStockSearch;
        private Label label3;
        private Label label2;
        private Label label1;
        public Button btnDeletedStock;
        private ImageList imageList1;
        public Button btnUpdatedStock;
        public Button btnAddStock;
        public Button btnSupplierSearch;
    }
}