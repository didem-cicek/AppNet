namespace AppNet.WinFormUI
{
    partial class AddStock
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
            this.btnAddStock = new System.Windows.Forms.Button();
            this.txtAddStockPiece = new System.Windows.Forms.TextBox();
            this.cbbAddProductType = new System.Windows.Forms.ComboBox();
            this.cbbSelectedSuppliers = new System.Windows.Forms.ComboBox();
            this.txtAddStockPrice = new System.Windows.Forms.TextBox();
            this.txtAddStockName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddCriticalStock = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddStock
            // 
            this.btnAddStock.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStock.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnAddStock.FlatAppearance.BorderSize = 3;
            this.btnAddStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddStock.ForeColor = System.Drawing.Color.White;
            this.btnAddStock.Location = new System.Drawing.Point(237, 310);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(150, 40);
            this.btnAddStock.TabIndex = 7;
            this.btnAddStock.Text = "STOK EKLE";
            this.btnAddStock.UseVisualStyleBackColor = false;
            // 
            // txtAddStockPiece
            // 
            this.txtAddStockPiece.Location = new System.Drawing.Point(144, 210);
            this.txtAddStockPiece.Name = "txtAddStockPiece";
            this.txtAddStockPiece.Size = new System.Drawing.Size(243, 29);
            this.txtAddStockPiece.TabIndex = 5;
            // 
            // cbbAddProductType
            // 
            this.cbbAddProductType.FormattingEnabled = true;
            this.cbbAddProductType.ItemHeight = 21;
            this.cbbAddProductType.Location = new System.Drawing.Point(145, 76);
            this.cbbAddProductType.Name = "cbbAddProductType";
            this.cbbAddProductType.Size = new System.Drawing.Size(242, 29);
            this.cbbAddProductType.TabIndex = 12;
            // 
            // cbbSelectedSuppliers
            // 
            this.cbbSelectedSuppliers.FormattingEnabled = true;
            this.cbbSelectedSuppliers.ItemHeight = 21;
            this.cbbSelectedSuppliers.Location = new System.Drawing.Point(145, 119);
            this.cbbSelectedSuppliers.Name = "cbbSelectedSuppliers";
            this.cbbSelectedSuppliers.Size = new System.Drawing.Size(242, 29);
            this.cbbSelectedSuppliers.TabIndex = 14;
            // 
            // txtAddStockPrice
            // 
            this.txtAddStockPrice.Location = new System.Drawing.Point(145, 165);
            this.txtAddStockPrice.Name = "txtAddStockPrice";
            this.txtAddStockPrice.Size = new System.Drawing.Size(242, 29);
            this.txtAddStockPrice.TabIndex = 4;
            // 
            // txtAddStockName
            // 
            this.txtAddStockName.Location = new System.Drawing.Point(144, 32);
            this.txtAddStockName.Name = "txtAddStockName";
            this.txtAddStockName.Size = new System.Drawing.Size(242, 29);
            this.txtAddStockName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(25, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ürün Adedi : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(26, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Alış Fiyatı : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(24, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tedarikçi : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ürün Cinsi : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ürün Adı : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(25, 260);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Kritik Stok : ";
            // 
            // txtAddCriticalStock
            // 
            this.txtAddCriticalStock.Location = new System.Drawing.Point(144, 256);
            this.txtAddCriticalStock.Name = "txtAddCriticalStock";
            this.txtAddCriticalStock.Size = new System.Drawing.Size(243, 29);
            this.txtAddCriticalStock.TabIndex = 6;
            // 
            // AddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(419, 371);
            this.Controls.Add(this.btnAddStock);
            this.Controls.Add(this.txtAddCriticalStock);
            this.Controls.Add(this.txtAddStockPiece);
            this.Controls.Add(this.cbbAddProductType);
            this.Controls.Add(this.cbbSelectedSuppliers);
            this.Controls.Add(this.txtAddStockPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAddStockName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STOK EKLE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Button btnAddStock;
        public TextBox txtAddStockPiece;
        public ComboBox cbbAddProductType;
        public ComboBox cbbSelectedSuppliers;
        public TextBox txtAddStockPrice;
        public TextBox txtAddStockName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        public TextBox txtAddCriticalStock;
    }
}