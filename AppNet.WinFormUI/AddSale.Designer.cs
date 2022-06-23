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
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.txtAddSaleDescription = new System.Windows.Forms.TextBox();
            this.cbbAddSalePrice = new System.Windows.Forms.ComboBox();
            this.txtAddSalePiece = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbAddSaleName = new System.Windows.Forms.ComboBox();
            this.cbbAddSaleProduct = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbAddSalePay = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
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
            this.btnAddProduct.Location = new System.Drawing.Point(241, 353);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(150, 40);
            this.btnAddProduct.TabIndex = 7;
            this.btnAddProduct.Text = "SİPARİŞ EKLE";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // txtAddSaleDescription
            // 
            this.txtAddSaleDescription.Location = new System.Drawing.Point(148, 295);
            this.txtAddSaleDescription.Name = "txtAddSaleDescription";
            this.txtAddSaleDescription.Size = new System.Drawing.Size(243, 29);
            this.txtAddSaleDescription.TabIndex = 6;
            // 
            // cbbAddSalePrice
            // 
            this.cbbAddSalePrice.FormattingEnabled = true;
            this.cbbAddSalePrice.Location = new System.Drawing.Point(149, 113);
            this.cbbAddSalePrice.Name = "cbbAddSalePrice";
            this.cbbAddSalePrice.Size = new System.Drawing.Size(242, 29);
            this.cbbAddSalePrice.TabIndex = 3;
            // 
            // txtAddSalePiece
            // 
            this.txtAddSalePiece.Location = new System.Drawing.Point(149, 157);
            this.txtAddSalePiece.Name = "txtAddSalePiece";
            this.txtAddSalePiece.Size = new System.Drawing.Size(242, 29);
            this.txtAddSalePiece.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(19, 299);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Açıklama : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(20, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adet : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fiyat : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Firma Adı : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ürün Adı : ";
            // 
            // cbbAddSaleName
            // 
            this.cbbAddSaleName.FormattingEnabled = true;
            this.cbbAddSaleName.Location = new System.Drawing.Point(149, 71);
            this.cbbAddSaleName.Name = "cbbAddSaleName";
            this.cbbAddSaleName.Size = new System.Drawing.Size(242, 29);
            this.cbbAddSaleName.TabIndex = 2;
            // 
            // cbbAddSaleProduct
            // 
            this.cbbAddSaleProduct.FormattingEnabled = true;
            this.cbbAddSaleProduct.Location = new System.Drawing.Point(149, 29);
            this.cbbAddSaleProduct.Name = "cbbAddSaleProduct";
            this.cbbAddSaleProduct.Size = new System.Drawing.Size(242, 29);
            this.cbbAddSaleProduct.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(18, 205);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ödeme Şekli : ";
            // 
            // cbbAddSalePay
            // 
            this.cbbAddSalePay.FormattingEnabled = true;
            this.cbbAddSalePay.Location = new System.Drawing.Point(149, 201);
            this.cbbAddSalePay.Name = "cbbAddSalePay";
            this.cbbAddSalePay.Size = new System.Drawing.Size(242, 29);
            this.cbbAddSalePay.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(19, 251);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Durum : ";
            // 
            // cbbStatus
            // 
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Location = new System.Drawing.Point(148, 247);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(242, 29);
            this.cbbStatus.TabIndex = 5;
            // 
            // AddSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(419, 413);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtAddSaleDescription);
            this.Controls.Add(this.cbbAddSaleProduct);
            this.Controls.Add(this.cbbAddSaleName);
            this.Controls.Add(this.cbbStatus);
            this.Controls.Add(this.cbbAddSalePay);
            this.Controls.Add(this.cbbAddSalePrice);
            this.Controls.Add(this.txtAddSalePiece);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SİPARİŞ EKLE";
            this.Load += new System.EventHandler(this.AddSale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Button btnAddProduct;
        public TextBox txtAddSaleDescription;
        public ComboBox cbbAddSalePrice;
        public TextBox txtAddSalePiece;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        public ComboBox cbbAddSaleName;
        public ComboBox cbbAddSaleProduct;
        private Label label6;
        public ComboBox cbbAddSalePay;
        private Label label7;
        public ComboBox cbbStatus;
    }
}