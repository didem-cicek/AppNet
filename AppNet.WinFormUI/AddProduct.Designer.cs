namespace AppNet.WinFormUI
{
    partial class AddProduct
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddProduct = new System.Windows.Forms.TextBox();
            this.txtAddDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.cbbAddCategory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Adı : ";
            // 
            // txtAddProduct
            // 
            this.txtAddProduct.Location = new System.Drawing.Point(144, 75);
            this.txtAddProduct.Name = "txtAddProduct";
            this.txtAddProduct.Size = new System.Drawing.Size(242, 29);
            this.txtAddProduct.TabIndex = 2;
            // 
            // txtAddDescription
            // 
            this.txtAddDescription.Location = new System.Drawing.Point(143, 121);
            this.txtAddDescription.Name = "txtAddDescription";
            this.txtAddDescription.Size = new System.Drawing.Size(243, 29);
            this.txtAddDescription.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(24, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Açıklama : ";
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
            this.btnAddProduct.Location = new System.Drawing.Point(236, 173);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(150, 40);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "ÜRÜN EKLE";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // cbbAddCategory
            // 
            this.cbbAddCategory.FormattingEnabled = true;
            this.cbbAddCategory.Location = new System.Drawing.Point(144, 33);
            this.cbbAddCategory.Name = "cbbAddCategory";
            this.cbbAddCategory.Size = new System.Drawing.Size(242, 29);
            this.cbbAddCategory.TabIndex = 1;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(419, 235);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtAddDescription);
            this.Controls.Add(this.cbbAddCategory);
            this.Controls.Add(this.txtAddProduct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜRÜN EKLE";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        public TextBox txtAddProduct;
        public TextBox txtAddDescription;
        private Label label5;
        public Button btnAddProduct;
        public ComboBox cbbAddCategory;
    }
}