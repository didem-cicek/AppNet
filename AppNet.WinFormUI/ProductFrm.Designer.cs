namespace AppNet.WinFormUI
{
    partial class ProductFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductFrm));
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnUpdatedProduct = new System.Windows.Forms.Button();
            this.btnDeletedProduct = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnUpdatedCategory = new System.Windows.Forms.Button();
            this.btnDeletedCategory = new System.Windows.Forms.Button();
            this.txtProductSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grdProductList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btnAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddProduct.ImageIndex = 0;
            this.btnAddProduct.ImageList = this.imageList1;
            this.btnAddProduct.Location = new System.Drawing.Point(-2, 255);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(205, 85);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "ÜRÜN EKLE";
            this.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            this.imageList1.Images.SetKeyName(1, "edit.png");
            this.imageList1.Images.SetKeyName(2, "deleted.png");
            this.imageList1.Images.SetKeyName(3, "settings-1.png");
            // 
            // btnUpdatedProduct
            // 
            this.btnUpdatedProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btnUpdatedProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatedProduct.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.btnUpdatedProduct.FlatAppearance.BorderSize = 0;
            this.btnUpdatedProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatedProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdatedProduct.ForeColor = System.Drawing.Color.White;
            this.btnUpdatedProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdatedProduct.ImageKey = "edit.png";
            this.btnUpdatedProduct.ImageList = this.imageList1;
            this.btnUpdatedProduct.Location = new System.Drawing.Point(-3, 340);
            this.btnUpdatedProduct.Name = "btnUpdatedProduct";
            this.btnUpdatedProduct.Size = new System.Drawing.Size(205, 85);
            this.btnUpdatedProduct.TabIndex = 1;
            this.btnUpdatedProduct.Text = "ÜRÜN GÜNCELLE";
            this.btnUpdatedProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdatedProduct.UseVisualStyleBackColor = false;
            this.btnUpdatedProduct.Click += new System.EventHandler(this.btnUpdatedProduct_Click);
            // 
            // btnDeletedProduct
            // 
            this.btnDeletedProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btnDeletedProduct.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnDeletedProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletedProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeletedProduct.ForeColor = System.Drawing.Color.White;
            this.btnDeletedProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeletedProduct.ImageKey = "deleted.png";
            this.btnDeletedProduct.ImageList = this.imageList1;
            this.btnDeletedProduct.Location = new System.Drawing.Point(-3, 425);
            this.btnDeletedProduct.Name = "btnDeletedProduct";
            this.btnDeletedProduct.Size = new System.Drawing.Size(205, 85);
            this.btnDeletedProduct.TabIndex = 2;
            this.btnDeletedProduct.Text = "ÜRÜN SİL";
            this.btnDeletedProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeletedProduct.UseVisualStyleBackColor = false;
            this.btnDeletedProduct.Click += new System.EventHandler(this.btnDeletedProduct_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btnAddCategory.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddCategory.ImageIndex = 0;
            this.btnAddCategory.ImageList = this.imageList1;
            this.btnAddCategory.Location = new System.Drawing.Point(-3, 0);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(205, 85);
            this.btnAddCategory.TabIndex = 0;
            this.btnAddCategory.Text = "KATEGORİ EKLE";
            this.btnAddCategory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click_1);
            // 
            // btnUpdatedCategory
            // 
            this.btnUpdatedCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btnUpdatedCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatedCategory.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.btnUpdatedCategory.FlatAppearance.BorderSize = 0;
            this.btnUpdatedCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatedCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdatedCategory.ForeColor = System.Drawing.Color.White;
            this.btnUpdatedCategory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdatedCategory.ImageKey = "edit.png";
            this.btnUpdatedCategory.ImageList = this.imageList1;
            this.btnUpdatedCategory.Location = new System.Drawing.Point(-2, 85);
            this.btnUpdatedCategory.Name = "btnUpdatedCategory";
            this.btnUpdatedCategory.Size = new System.Drawing.Size(205, 85);
            this.btnUpdatedCategory.TabIndex = 1;
            this.btnUpdatedCategory.Text = "KATEGORİ GÜNCELLE";
            this.btnUpdatedCategory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdatedCategory.UseVisualStyleBackColor = false;
            this.btnUpdatedCategory.Click += new System.EventHandler(this.btnUpdatedCategory_Click);
            // 
            // btnDeletedCategory
            // 
            this.btnDeletedCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btnDeletedCategory.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnDeletedCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletedCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeletedCategory.ForeColor = System.Drawing.Color.White;
            this.btnDeletedCategory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeletedCategory.ImageKey = "deleted.png";
            this.btnDeletedCategory.ImageList = this.imageList1;
            this.btnDeletedCategory.Location = new System.Drawing.Point(-2, 170);
            this.btnDeletedCategory.Name = "btnDeletedCategory";
            this.btnDeletedCategory.Size = new System.Drawing.Size(205, 85);
            this.btnDeletedCategory.TabIndex = 2;
            this.btnDeletedCategory.Text = "KATEGORİ SİL";
            this.btnDeletedCategory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeletedCategory.UseVisualStyleBackColor = false;
            this.btnDeletedCategory.Click += new System.EventHandler(this.btnDeletedCategory_Click);
            // 
            // txtProductSearch
            // 
            this.txtProductSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductSearch.Location = new System.Drawing.Point(388, 39);
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.Size = new System.Drawing.Size(404, 29);
            this.txtProductSearch.TabIndex = 4;
            this.txtProductSearch.TextChanged += new System.EventHandler(this.txtProductSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(249, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Aranacak Kelime : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.label4.Location = new System.Drawing.Point(250, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(542, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "---------------------------------------------------------------------------------" +
    "--------------------------";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.label5.Location = new System.Drawing.Point(249, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "ÜRÜN LİSTESİ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // grdProductList
            // 
            this.grdProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProductList.BackgroundColor = System.Drawing.Color.White;
            this.grdProductList.Location = new System.Drawing.Point(250, 201);
            this.grdProductList.MultiSelect = false;
            this.grdProductList.Name = "grdProductList";
            this.grdProductList.RowHeadersVisible = false;
            this.grdProductList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grdProductList.RowTemplate.Height = 25;
            this.grdProductList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProductList.Size = new System.Drawing.Size(1057, 408);
            this.grdProductList.TabIndex = 9;
            this.grdProductList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProductList_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.panel1.Controls.Add(this.btnAddCategory);
            this.panel1.Controls.Add(this.btnDeletedCategory);
            this.panel1.Controls.Add(this.btnUpdatedCategory);
            this.panel1.Controls.Add(this.btnAddProduct);
            this.panel1.Controls.Add(this.btnUpdatedProduct);
            this.panel1.Controls.Add(this.btnDeletedProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 691);
            this.panel1.TabIndex = 10;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(200, 635);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1150, 56);
            this.panel3.TabIndex = 14;
            // 
            // ProductFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 691);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grdProductList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProductSearch);
            this.Controls.Add(this.label3);
            this.Name = "ProductFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ÜRÜN YÖNETİMİ";
            this.Load += new System.EventHandler(this.ProductFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProductList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Button btnAddProduct;
        private ImageList imageList1;
        public Button btnUpdatedProduct;
        public Button btnDeletedProduct;
        public Button btnAddCategory;
        public Button btnUpdatedCategory;
        public Button btnDeletedCategory;
        public TextBox txtProductSearch;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView grdProductList;
        private Panel panel1;
        private Label label6;
        private Panel panel3;
    }
}