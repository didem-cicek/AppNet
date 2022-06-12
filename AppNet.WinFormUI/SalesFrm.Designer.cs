namespace AppNet.WinFormUI
{
    partial class SalesFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesFrm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.grdSupplierList = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbProductSearch = new System.Windows.Forms.ComboBox();
            this.btnSupplierSearch = new System.Windows.Forms.Button();
            this.txtProductSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteSale = new System.Windows.Forms.Button();
            this.btnUpdateSale = new System.Windows.Forms.Button();
            this.btnAddSale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdSupplierList)).BeginInit();
            this.SuspendLayout();
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
            // grdSupplierList
            // 
            this.grdSupplierList.BackgroundColor = System.Drawing.Color.White;
            this.grdSupplierList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSupplierList.Location = new System.Drawing.Point(24, 343);
            this.grdSupplierList.Name = "grdSupplierList";
            this.grdSupplierList.RowTemplate.Height = 25;
            this.grdSupplierList.Size = new System.Drawing.Size(965, 197);
            this.grdSupplierList.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(19, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "SİPARİŞ LİSTESİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(612, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(352, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "---------------------------------------------------------------------";
            // 
            // cbbProductSearch
            // 
            this.cbbProductSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbProductSearch.FormattingEnabled = true;
            this.cbbProductSearch.Location = new System.Drawing.Point(747, 107);
            this.cbbProductSearch.Name = "cbbProductSearch";
            this.cbbProductSearch.Size = new System.Drawing.Size(214, 29);
            this.cbbProductSearch.TabIndex = 3;
            // 
            // btnSupplierSearch
            // 
            this.btnSupplierSearch.BackColor = System.Drawing.Color.Gray;
            this.btnSupplierSearch.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSupplierSearch.FlatAppearance.BorderSize = 3;
            this.btnSupplierSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplierSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSupplierSearch.ForeColor = System.Drawing.Color.White;
            this.btnSupplierSearch.Location = new System.Drawing.Point(861, 207);
            this.btnSupplierSearch.Name = "btnSupplierSearch";
            this.btnSupplierSearch.Size = new System.Drawing.Size(100, 40);
            this.btnSupplierSearch.TabIndex = 5;
            this.btnSupplierSearch.Text = "ARA";
            this.btnSupplierSearch.UseVisualStyleBackColor = false;
            // 
            // txtProductSearch
            // 
            this.txtProductSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductSearch.Location = new System.Drawing.Point(747, 158);
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.Size = new System.Drawing.Size(214, 29);
            this.txtProductSearch.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(608, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Aranacak Kelime : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(608, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Arama Kriteri : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(608, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "ARAMA ALANI";
            // 
            // btnDeleteSale
            // 
            this.btnDeleteSale.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeleteSale.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnDeleteSale.FlatAppearance.BorderSize = 3;
            this.btnDeleteSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteSale.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSale.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteSale.ImageKey = "deleted.png";
            this.btnDeleteSale.ImageList = this.imageList1;
            this.btnDeleteSale.Location = new System.Drawing.Point(408, 21);
            this.btnDeleteSale.Name = "btnDeleteSale";
            this.btnDeleteSale.Size = new System.Drawing.Size(167, 109);
            this.btnDeleteSale.TabIndex = 3;
            this.btnDeleteSale.Text = "SİPARİŞ SİL";
            this.btnDeleteSale.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteSale.UseVisualStyleBackColor = false;
            this.btnDeleteSale.Click += new System.EventHandler(this.btnDeleteSale_Click);
            // 
            // btnUpdateSale
            // 
            this.btnUpdateSale.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdateSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateSale.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.btnUpdateSale.FlatAppearance.BorderSize = 3;
            this.btnUpdateSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateSale.ForeColor = System.Drawing.Color.White;
            this.btnUpdateSale.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdateSale.ImageKey = "edit.png";
            this.btnUpdateSale.ImageList = this.imageList1;
            this.btnUpdateSale.Location = new System.Drawing.Point(200, 21);
            this.btnUpdateSale.Name = "btnUpdateSale";
            this.btnUpdateSale.Size = new System.Drawing.Size(200, 109);
            this.btnUpdateSale.TabIndex = 2;
            this.btnUpdateSale.Text = "SİPARİŞ GÜNCELLE";
            this.btnUpdateSale.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdateSale.UseVisualStyleBackColor = false;
            this.btnUpdateSale.Click += new System.EventHandler(this.btnUpdateSale_Click);
            // 
            // btnAddSale
            // 
            this.btnAddSale.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddSale.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnAddSale.FlatAppearance.BorderSize = 3;
            this.btnAddSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddSale.ForeColor = System.Drawing.Color.White;
            this.btnAddSale.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddSale.ImageIndex = 0;
            this.btnAddSale.ImageList = this.imageList1;
            this.btnAddSale.Location = new System.Drawing.Point(24, 21);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(168, 109);
            this.btnAddSale.TabIndex = 1;
            this.btnAddSale.Text = "SİPARİŞ EKLE";
            this.btnAddSale.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddSale.UseVisualStyleBackColor = false;
            this.btnAddSale.Click += new System.EventHandler(this.btnAddSale_Click);
            // 
            // SalesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.grdSupplierList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbProductSearch);
            this.Controls.Add(this.btnSupplierSearch);
            this.Controls.Add(this.txtProductSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteSale);
            this.Controls.Add(this.btnUpdateSale);
            this.Controls.Add(this.btnAddSale);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "SalesFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SATIŞ YÖNETİMİ";
            ((System.ComponentModel.ISupportInitialize)(this.grdSupplierList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ImageList imageList1;
        private DataGridView grdSupplierList;
        private Label label5;
        private Label label4;
        public ComboBox cbbProductSearch;
        public Button btnSupplierSearch;
        public TextBox txtProductSearch;
        private Label label3;
        private Label label2;
        private Label label1;
        public Button btnDeleteSale;
        public Button btnUpdateSale;
        public Button btnAddSale;
    }
}