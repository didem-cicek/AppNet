namespace AppNet.WinFormUI
{
    partial class UpdateSale
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
            this.grdUpdateSaleList = new System.Windows.Forms.DataGridView();
            this.txtUpdateSaleSearch = new System.Windows.Forms.TextBox();
            this.btnUpdatedSale = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAUpdateSaleDescription = new System.Windows.Forms.TextBox();
            this.cbbName = new System.Windows.Forms.ComboBox();
            this.cbbCustomer = new System.Windows.Forms.ComboBox();
            this.cbbSale = new System.Windows.Forms.ComboBox();
            this.txtPiece = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.Fiyat = new System.Windows.Forms.Label();
            this.cbbColor = new System.Windows.Forms.ComboBox();
            this.cbbSize = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdUpdateSaleList)).BeginInit();
            this.SuspendLayout();
            // 
            // grdUpdateSaleList
            // 
            this.grdUpdateSaleList.BackgroundColor = System.Drawing.Color.White;
            this.grdUpdateSaleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUpdateSaleList.Location = new System.Drawing.Point(26, 133);
            this.grdUpdateSaleList.Name = "grdUpdateSaleList";
            this.grdUpdateSaleList.RowTemplate.Height = 25;
            this.grdUpdateSaleList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdUpdateSaleList.Size = new System.Drawing.Size(420, 250);
            this.grdUpdateSaleList.TabIndex = 2;
            this.grdUpdateSaleList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUpdateSaleList_CellContentClick);
            // 
            // txtUpdateSaleSearch
            // 
            this.txtUpdateSaleSearch.Location = new System.Drawing.Point(200, 42);
            this.txtUpdateSaleSearch.Name = "txtUpdateSaleSearch";
            this.txtUpdateSaleSearch.Size = new System.Drawing.Size(242, 29);
            this.txtUpdateSaleSearch.TabIndex = 1;
            this.txtUpdateSaleSearch.TextChanged += new System.EventHandler(this.txtUpdateSaleSearch_TextChanged);
            // 
            // btnUpdatedSale
            // 
            this.btnUpdatedSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btnUpdatedSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatedSale.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnUpdatedSale.FlatAppearance.BorderSize = 0;
            this.btnUpdatedSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatedSale.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdatedSale.ForeColor = System.Drawing.Color.White;
            this.btnUpdatedSale.Location = new System.Drawing.Point(807, 474);
            this.btnUpdatedSale.Name = "btnUpdatedSale";
            this.btnUpdatedSale.Size = new System.Drawing.Size(169, 40);
            this.btnUpdatedSale.TabIndex = 13;
            this.btnUpdatedSale.Text = "SİPARİŞ GÜNCELLE";
            this.btnUpdatedSale.UseVisualStyleBackColor = false;
            this.btnUpdatedSale.Click += new System.EventHandler(this.btnUpdatedSale_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.label8.Location = new System.Drawing.Point(22, 93);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Güncellenecek Sipariş : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(22, 45);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Sipariş Adı : ";
            // 
            // txtAUpdateSaleDescription
            // 
            this.txtAUpdateSaleDescription.Location = new System.Drawing.Point(733, 382);
            this.txtAUpdateSaleDescription.Name = "txtAUpdateSaleDescription";
            this.txtAUpdateSaleDescription.Size = new System.Drawing.Size(243, 29);
            this.txtAUpdateSaleDescription.TabIndex = 11;
            // 
            // cbbName
            // 
            this.cbbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbName.FormattingEnabled = true;
            this.cbbName.Location = new System.Drawing.Point(733, 28);
            this.cbbName.Name = "cbbName";
            this.cbbName.Size = new System.Drawing.Size(242, 29);
            this.cbbName.TabIndex = 3;
            // 
            // cbbCustomer
            // 
            this.cbbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCustomer.FormattingEnabled = true;
            this.cbbCustomer.Location = new System.Drawing.Point(733, 71);
            this.cbbCustomer.Name = "cbbCustomer";
            this.cbbCustomer.Size = new System.Drawing.Size(242, 29);
            this.cbbCustomer.TabIndex = 4;
            // 
            // cbbSale
            // 
            this.cbbSale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSale.FormattingEnabled = true;
            this.cbbSale.Location = new System.Drawing.Point(734, 292);
            this.cbbSale.Name = "cbbSale";
            this.cbbSale.Size = new System.Drawing.Size(242, 29);
            this.cbbSale.TabIndex = 9;
            // 
            // txtPiece
            // 
            this.txtPiece.Location = new System.Drawing.Point(734, 248);
            this.txtPiece.Name = "txtPiece";
            this.txtPiece.Size = new System.Drawing.Size(242, 29);
            this.txtPiece.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(602, 387);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "Açıklama : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(601, 296);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "Ödeme Şekli : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(603, 255);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Adet : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(602, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Fiyat : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(602, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Firma Adı : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(602, 33);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 19);
            this.label9.TabIndex = 29;
            this.label9.Text = "Ürün Adı : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(601, 340);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 19);
            this.label10.TabIndex = 26;
            this.label10.Text = "Durum : ";
            // 
            // cbbStatus
            // 
            this.cbbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Location = new System.Drawing.Point(734, 336);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(242, 29);
            this.cbbStatus.TabIndex = 10;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(733, 114);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(242, 29);
            this.txtPrice.TabIndex = 5;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSize.Location = new System.Drawing.Point(602, 161);
            this.labelSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(64, 19);
            this.labelSize.TabIndex = 27;
            this.labelSize.Text = "Beden : ";
            // 
            // Fiyat
            // 
            this.Fiyat.AutoSize = true;
            this.Fiyat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Fiyat.Location = new System.Drawing.Point(603, 208);
            this.Fiyat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.Size = new System.Drawing.Size(55, 19);
            this.Fiyat.TabIndex = 27;
            this.Fiyat.Text = "Renk : ";
            // 
            // cbbColor
            // 
            this.cbbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbColor.FormattingEnabled = true;
            this.cbbColor.Location = new System.Drawing.Point(733, 201);
            this.cbbColor.Name = "cbbColor";
            this.cbbColor.Size = new System.Drawing.Size(242, 29);
            this.cbbColor.TabIndex = 7;
            // 
            // cbbSize
            // 
            this.cbbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSize.FormattingEnabled = true;
            this.cbbSize.Location = new System.Drawing.Point(733, 156);
            this.cbbSize.Name = "cbbSize";
            this.cbbSize.Size = new System.Drawing.Size(242, 29);
            this.cbbSize.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(603, 432);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Toplam : ";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(734, 427);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(243, 29);
            this.txtTotalPrice.TabIndex = 12;
            // 
            // UpdateSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 535);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.txtAUpdateSaleDescription);
            this.Controls.Add(this.cbbName);
            this.Controls.Add(this.cbbCustomer);
            this.Controls.Add(this.cbbStatus);
            this.Controls.Add(this.cbbSize);
            this.Controls.Add(this.cbbColor);
            this.Controls.Add(this.cbbSale);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtPiece);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Fiyat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grdUpdateSaleList);
            this.Controls.Add(this.txtUpdateSaleSearch);
            this.Controls.Add(this.btnUpdatedSale);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SİPARİŞ GÜNCELLE";
            this.Load += new System.EventHandler(this.UpdateSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUpdateSaleList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grdUpdateSaleList;
        private TextBox txtUpdateSaleSearch;
        private Button btnUpdatedSale;
        private Label label8;
        private Label label7;
        public TextBox txtAUpdateSaleDescription;
        public ComboBox cbbName;
        public ComboBox cbbCustomer;
        public ComboBox cbbSale;
        public TextBox txtPiece;
        private Label label5;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label9;
        private Label label10;
        public ComboBox cbbStatus;
        public TextBox txtPrice;
        private Label labelSize;
        private Label Fiyat;
        public ComboBox cbbColor;
        public ComboBox cbbSize;
        private Label label6;
        public TextBox txtTotalPrice;
    }
}