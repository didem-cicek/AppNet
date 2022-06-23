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
            this.label1 = new System.Windows.Forms.Label();
            this.cbbUpdatedCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.updatedProductName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUpdatedDescription = new System.Windows.Forms.TextBox();
            this.btnUpdatedProduct = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbUpdateProduct = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUpdateProductSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grdUpdateProductList = new System.Windows.Forms.DataGridView();
            this.btnUpdateSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdUpdateProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(576, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori :";
            // 
            // cbbUpdatedCategory
            // 
            this.cbbUpdatedCategory.FormattingEnabled = true;
            this.cbbUpdatedCategory.Location = new System.Drawing.Point(734, 31);
            this.cbbUpdatedCategory.Name = "cbbUpdatedCategory";
            this.cbbUpdatedCategory.Size = new System.Drawing.Size(242, 29);
            this.cbbUpdatedCategory.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(576, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Adı :";
            // 
            // updatedProductName
            // 
            this.updatedProductName.Location = new System.Drawing.Point(734, 81);
            this.updatedProductName.Name = "updatedProductName";
            this.updatedProductName.Size = new System.Drawing.Size(242, 29);
            this.updatedProductName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(577, 131);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Açıklama :";
            // 
            // txtUpdatedDescription
            // 
            this.txtUpdatedDescription.Location = new System.Drawing.Point(734, 128);
            this.txtUpdatedDescription.Name = "txtUpdatedDescription";
            this.txtUpdatedDescription.Size = new System.Drawing.Size(242, 29);
            this.txtUpdatedDescription.TabIndex = 8;
            // 
            // btnUpdatedProduct
            // 
            this.btnUpdatedProduct.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdatedProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatedProduct.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnUpdatedProduct.FlatAppearance.BorderSize = 3;
            this.btnUpdatedProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatedProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdatedProduct.ForeColor = System.Drawing.Color.White;
            this.btnUpdatedProduct.Location = new System.Drawing.Point(796, 186);
            this.btnUpdatedProduct.Name = "btnUpdatedProduct";
            this.btnUpdatedProduct.Size = new System.Drawing.Size(180, 40);
            this.btnUpdatedProduct.TabIndex = 9;
            this.btnUpdatedProduct.Text = "ÜRÜNÜ GÜNCELLE";
            this.btnUpdatedProduct.UseVisualStyleBackColor = false;
            this.btnUpdatedProduct.Click += new System.EventHandler(this.btnUpdatedProduct_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(22, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kriter Seçiniz : ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cbbUpdateProduct
            // 
            this.cbbUpdateProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUpdateProduct.FormattingEnabled = true;
            this.cbbUpdateProduct.Location = new System.Drawing.Point(201, 29);
            this.cbbUpdateProduct.Name = "cbbUpdateProduct";
            this.cbbUpdateProduct.Size = new System.Drawing.Size(242, 29);
            this.cbbUpdateProduct.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(23, 88);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ürün Adı : ";
            this.label7.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtUpdateProductSearch
            // 
            this.txtUpdateProductSearch.Location = new System.Drawing.Point(201, 85);
            this.txtUpdateProductSearch.Name = "txtUpdateProductSearch";
            this.txtUpdateProductSearch.Size = new System.Drawing.Size(242, 29);
            this.txtUpdateProductSearch.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(23, 136);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Güncellenecek Ürün : ";
            this.label8.Click += new System.EventHandler(this.label6_Click);
            // 
            // grdUpdateProductList
            // 
            this.grdUpdateProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdUpdateProductList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdUpdateProductList.BackgroundColor = System.Drawing.Color.White;
            this.grdUpdateProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUpdateProductList.Location = new System.Drawing.Point(27, 176);
            this.grdUpdateProductList.Name = "grdUpdateProductList";
            this.grdUpdateProductList.RowTemplate.Height = 25;
            this.grdUpdateProductList.Size = new System.Drawing.Size(420, 86);
            this.grdUpdateProductList.TabIndex = 3;
            // 
            // btnUpdateSearch
            // 
            this.btnUpdateSearch.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdateSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateSearch.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnUpdateSearch.FlatAppearance.BorderSize = 3;
            this.btnUpdateSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateSearch.ForeColor = System.Drawing.Color.White;
            this.btnUpdateSearch.Location = new System.Drawing.Point(267, 296);
            this.btnUpdateSearch.Name = "btnUpdateSearch";
            this.btnUpdateSearch.Size = new System.Drawing.Size(180, 40);
            this.btnUpdateSearch.TabIndex = 9;
            this.btnUpdateSearch.Text = "ÜRÜNÜ BUL";
            this.btnUpdateSearch.UseVisualStyleBackColor = false;
            this.btnUpdateSearch.Click += new System.EventHandler(this.btnUpdateSearch_Click);
            // 
            // UpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 359);
            this.Controls.Add(this.grdUpdateProductList);
            this.Controls.Add(this.txtUpdateProductSearch);
            this.Controls.Add(this.btnUpdateSearch);
            this.Controls.Add(this.btnUpdatedProduct);
            this.Controls.Add(this.txtUpdatedDescription);
            this.Controls.Add(this.updatedProductName);
            this.Controls.Add(this.cbbUpdateProduct);
            this.Controls.Add(this.cbbUpdatedCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
        private ComboBox cbbUpdatedCategory;
        private Label label2;
        private TextBox updatedProductName;
        private Label label5;
        private TextBox txtUpdatedDescription;
        private Button btnUpdatedProduct;
        private Label label6;
        private ComboBox cbbUpdateProduct;
        private Label label7;
        private TextBox txtUpdateProductSearch;
        private Label label8;
        private DataGridView grdUpdateProductList;
        private Button btnUpdateSearch;
    }
}