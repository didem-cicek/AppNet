namespace AppNet.WinFormUI
{
    partial class UpdateProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProduct));
            this.label1 = new System.Windows.Forms.Label();
            this.cbbUpdatedCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.updatedProductName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUpdatedDescription = new System.Windows.Forms.TextBox();
            this.btnUpdatedProduct = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUpdateProductSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grdUpdateProductList = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdUpdateProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(512, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori :";
            // 
            // cbbUpdatedCategory
            // 
            this.cbbUpdatedCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUpdatedCategory.FormattingEnabled = true;
            this.cbbUpdatedCategory.Location = new System.Drawing.Point(652, 28);
            this.cbbUpdatedCategory.Name = "cbbUpdatedCategory";
            this.cbbUpdatedCategory.Size = new System.Drawing.Size(216, 27);
            this.cbbUpdatedCategory.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(512, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Adı :";
            // 
            // updatedProductName
            // 
            this.updatedProductName.Location = new System.Drawing.Point(652, 73);
            this.updatedProductName.Name = "updatedProductName";
            this.updatedProductName.Size = new System.Drawing.Size(216, 27);
            this.updatedProductName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(513, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Açıklama :";
            // 
            // txtUpdatedDescription
            // 
            this.txtUpdatedDescription.Location = new System.Drawing.Point(652, 116);
            this.txtUpdatedDescription.Name = "txtUpdatedDescription";
            this.txtUpdatedDescription.Size = new System.Drawing.Size(216, 27);
            this.txtUpdatedDescription.TabIndex = 8;
            // 
            // btnUpdatedProduct
            // 
            this.btnUpdatedProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btnUpdatedProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatedProduct.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnUpdatedProduct.FlatAppearance.BorderSize = 0;
            this.btnUpdatedProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatedProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdatedProduct.ForeColor = System.Drawing.Color.White;
            this.btnUpdatedProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdatedProduct.ImageKey = "edit.png";
            this.btnUpdatedProduct.ImageList = this.imageList1;
            this.btnUpdatedProduct.Location = new System.Drawing.Point(676, 168);
            this.btnUpdatedProduct.Name = "btnUpdatedProduct";
            this.btnUpdatedProduct.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnUpdatedProduct.Size = new System.Drawing.Size(192, 36);
            this.btnUpdatedProduct.TabIndex = 9;
            this.btnUpdatedProduct.Text = "ÜRÜNÜ GÜNCELLE";
            this.btnUpdatedProduct.UseVisualStyleBackColor = false;
            this.btnUpdatedProduct.Click += new System.EventHandler(this.btnUpdateSearch_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(20, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Aranacak Kelime : ";
            this.label7.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtUpdateProductSearch
            // 
            this.txtUpdateProductSearch.Location = new System.Drawing.Point(179, 25);
            this.txtUpdateProductSearch.Name = "txtUpdateProductSearch";
            this.txtUpdateProductSearch.Size = new System.Drawing.Size(216, 27);
            this.txtUpdateProductSearch.TabIndex = 2;
            this.txtUpdateProductSearch.TextChanged += new System.EventHandler(this.txtUpdateProductSearch_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.label8.Location = new System.Drawing.Point(20, 73);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Güncellenecek Ürünü Seçiniz : ";
            this.label8.Click += new System.EventHandler(this.label6_Click);
            // 
            // grdUpdateProductList
            // 
            this.grdUpdateProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdUpdateProductList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdUpdateProductList.BackgroundColor = System.Drawing.Color.White;
            this.grdUpdateProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUpdateProductList.Location = new System.Drawing.Point(24, 116);
            this.grdUpdateProductList.Name = "grdUpdateProductList";
            this.grdUpdateProductList.RowTemplate.Height = 25;
            this.grdUpdateProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdUpdateProductList.Size = new System.Drawing.Size(373, 182);
            this.grdUpdateProductList.TabIndex = 3;
            this.grdUpdateProductList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUpdateProductList_CellContentClick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "edit.png");
            // 
            // UpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 325);
            this.Controls.Add(this.grdUpdateProductList);
            this.Controls.Add(this.txtUpdateProductSearch);
            this.Controls.Add(this.btnUpdatedProduct);
            this.Controls.Add(this.txtUpdatedDescription);
            this.Controls.Add(this.updatedProductName);
            this.Controls.Add(this.cbbUpdatedCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜRÜN GÜNCELLE";
            this.Load += new System.EventHandler(this.UpdateProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUpdateProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        public ComboBox cbbUpdatedCategory;
        private Label label2;
        public TextBox updatedProductName;
        private Label label5;
        public TextBox txtUpdatedDescription;
        private Button btnUpdatedProduct;
        private Label label7;
        public TextBox txtUpdateProductSearch;
        private Label label8;
        public DataGridView grdUpdateProductList;
        private ImageList imageList1;
    }
}