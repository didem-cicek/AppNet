﻿namespace AppNet.WinFormUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductSearch = new System.Windows.Forms.TextBox();
            this.btnProductSearch = new System.Windows.Forms.Button();
            this.cbbProductSearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grdProductList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnAddProduct.FlatAppearance.BorderSize = 3;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddProduct.ImageIndex = 0;
            this.btnAddProduct.ImageList = this.imageList1;
            this.btnAddProduct.Location = new System.Drawing.Point(22, 30);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(168, 109);
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
            // 
            // btnUpdatedProduct
            // 
            this.btnUpdatedProduct.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdatedProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatedProduct.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.btnUpdatedProduct.FlatAppearance.BorderSize = 3;
            this.btnUpdatedProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatedProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdatedProduct.ForeColor = System.Drawing.Color.White;
            this.btnUpdatedProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdatedProduct.ImageKey = "edit.png";
            this.btnUpdatedProduct.ImageList = this.imageList1;
            this.btnUpdatedProduct.Location = new System.Drawing.Point(198, 30);
            this.btnUpdatedProduct.Name = "btnUpdatedProduct";
            this.btnUpdatedProduct.Size = new System.Drawing.Size(200, 109);
            this.btnUpdatedProduct.TabIndex = 1;
            this.btnUpdatedProduct.Text = "ÜRÜN GÜNCELLE";
            this.btnUpdatedProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdatedProduct.UseVisualStyleBackColor = false;
            this.btnUpdatedProduct.Click += new System.EventHandler(this.btnUpdatedProduct_Click);
            // 
            // btnDeletedProduct
            // 
            this.btnDeletedProduct.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeletedProduct.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnDeletedProduct.FlatAppearance.BorderSize = 3;
            this.btnDeletedProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletedProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeletedProduct.ForeColor = System.Drawing.Color.White;
            this.btnDeletedProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeletedProduct.ImageKey = "deleted.png";
            this.btnDeletedProduct.ImageList = this.imageList1;
            this.btnDeletedProduct.Location = new System.Drawing.Point(406, 30);
            this.btnDeletedProduct.Name = "btnDeletedProduct";
            this.btnDeletedProduct.Size = new System.Drawing.Size(167, 109);
            this.btnDeletedProduct.TabIndex = 2;
            this.btnDeletedProduct.Text = "ÜRÜN SİL";
            this.btnDeletedProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeletedProduct.UseVisualStyleBackColor = false;
            this.btnDeletedProduct.Click += new System.EventHandler(this.btnDeletedProduct_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddCategory.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnAddCategory.FlatAppearance.BorderSize = 3;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddCategory.ImageIndex = 0;
            this.btnAddCategory.ImageList = this.imageList1;
            this.btnAddCategory.Location = new System.Drawing.Point(22, 145);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(168, 109);
            this.btnAddCategory.TabIndex = 0;
            this.btnAddCategory.Text = "KATEGORİ EKLE";
            this.btnAddCategory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click_1);
            // 
            // btnUpdatedCategory
            // 
            this.btnUpdatedCategory.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdatedCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatedCategory.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.btnUpdatedCategory.FlatAppearance.BorderSize = 3;
            this.btnUpdatedCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatedCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdatedCategory.ForeColor = System.Drawing.Color.White;
            this.btnUpdatedCategory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdatedCategory.ImageKey = "edit.png";
            this.btnUpdatedCategory.ImageList = this.imageList1;
            this.btnUpdatedCategory.Location = new System.Drawing.Point(198, 145);
            this.btnUpdatedCategory.Name = "btnUpdatedCategory";
            this.btnUpdatedCategory.Size = new System.Drawing.Size(200, 109);
            this.btnUpdatedCategory.TabIndex = 1;
            this.btnUpdatedCategory.Text = "KATEGORİ GÜNCELLE";
            this.btnUpdatedCategory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdatedCategory.UseVisualStyleBackColor = false;
            this.btnUpdatedCategory.Click += new System.EventHandler(this.btnUpdatedCategory_Click);
            // 
            // btnDeletedCategory
            // 
            this.btnDeletedCategory.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeletedCategory.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnDeletedCategory.FlatAppearance.BorderSize = 3;
            this.btnDeletedCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletedCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeletedCategory.ForeColor = System.Drawing.Color.White;
            this.btnDeletedCategory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeletedCategory.ImageKey = "deleted.png";
            this.btnDeletedCategory.ImageList = this.imageList1;
            this.btnDeletedCategory.Location = new System.Drawing.Point(406, 145);
            this.btnDeletedCategory.Name = "btnDeletedCategory";
            this.btnDeletedCategory.Size = new System.Drawing.Size(167, 109);
            this.btnDeletedCategory.TabIndex = 2;
            this.btnDeletedCategory.Text = "KATEGORİ SİL";
            this.btnDeletedCategory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeletedCategory.UseVisualStyleBackColor = false;
            this.btnDeletedCategory.Click += new System.EventHandler(this.btnDeletedCategory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(606, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "ARAMA ALANI";
            // 
            // txtProductSearch
            // 
            this.txtProductSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductSearch.Location = new System.Drawing.Point(745, 167);
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.Size = new System.Drawing.Size(214, 29);
            this.txtProductSearch.TabIndex = 4;
            this.txtProductSearch.TextChanged += new System.EventHandler(this.txtProductSearch_TextChanged);
            // 
            // btnProductSearch
            // 
            this.btnProductSearch.BackColor = System.Drawing.Color.Gray;
            this.btnProductSearch.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnProductSearch.FlatAppearance.BorderSize = 3;
            this.btnProductSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProductSearch.ForeColor = System.Drawing.Color.White;
            this.btnProductSearch.Location = new System.Drawing.Point(859, 216);
            this.btnProductSearch.Name = "btnProductSearch";
            this.btnProductSearch.Size = new System.Drawing.Size(100, 40);
            this.btnProductSearch.TabIndex = 5;
            this.btnProductSearch.Text = "ARA";
            this.btnProductSearch.UseVisualStyleBackColor = false;
            // 
            // cbbProductSearch
            // 
            this.cbbProductSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbProductSearch.FormattingEnabled = true;
            this.cbbProductSearch.Location = new System.Drawing.Point(745, 116);
            this.cbbProductSearch.Name = "cbbProductSearch";
            this.cbbProductSearch.Size = new System.Drawing.Size(214, 29);
            this.cbbProductSearch.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(606, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Arama Kriteri : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(606, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Aranacak Kelime : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(610, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(352, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "---------------------------------------------------------------------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(17, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "ÜRÜN LİSTESİ";
            // 
            // grdProductList
            // 
            this.grdProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProductList.BackgroundColor = System.Drawing.Color.White;
            this.grdProductList.Location = new System.Drawing.Point(22, 352);
            this.grdProductList.MultiSelect = false;
            this.grdProductList.Name = "grdProductList";
            this.grdProductList.RowHeadersVisible = false;
            this.grdProductList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grdProductList.RowTemplate.Height = 25;
            this.grdProductList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProductList.Size = new System.Drawing.Size(965, 197);
            this.grdProductList.TabIndex = 9;
            this.grdProductList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProductList_CellContentClick);
            // 
            // ProductFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.grdProductList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbProductSearch);
            this.Controls.Add(this.btnProductSearch);
            this.Controls.Add(this.txtProductSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeletedCategory);
            this.Controls.Add(this.btnDeletedProduct);
            this.Controls.Add(this.btnUpdatedCategory);
            this.Controls.Add(this.btnUpdatedProduct);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.btnAddProduct);
            this.Name = "ProductFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ÜRÜN YÖNETİMİ";
            this.Load += new System.EventHandler(this.ProductFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProductList)).EndInit();
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
        private Label label1;
        public TextBox txtProductSearch;
        public Button btnProductSearch;
        public ComboBox cbbProductSearch;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView grdProductList;
    }
}