namespace AppNet.WinFormUI
{
    partial class UpdateCustomer
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
            this.grdUpdateCustomerList = new System.Windows.Forms.DataGridView();
            this.txtUpdateCustomerSearch = new System.Windows.Forms.TextBox();
            this.btnUpdatedCustomer = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUpdateCustomerDesriciption = new System.Windows.Forms.TextBox();
            this.txtUpdateCustomerTaxOffice = new System.Windows.Forms.TextBox();
            this.txtUpdateCustomerTaxNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUpdateCustomerShippingAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUpdateCustomerAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUpdateCustomerEmail = new System.Windows.Forms.TextBox();
            this.txtUpdateCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtUpdateCustomerName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdUpdateCustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // grdUpdateCustomerList
            // 
            this.grdUpdateCustomerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdUpdateCustomerList.BackgroundColor = System.Drawing.Color.White;
            this.grdUpdateCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUpdateCustomerList.Location = new System.Drawing.Point(24, 119);
            this.grdUpdateCustomerList.Name = "grdUpdateCustomerList";
            this.grdUpdateCustomerList.RowTemplate.Height = 25;
            this.grdUpdateCustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdUpdateCustomerList.Size = new System.Drawing.Size(420, 254);
            this.grdUpdateCustomerList.TabIndex = 3;
            this.grdUpdateCustomerList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUpdateCustomerList_CellContentClick);
            // 
            // txtUpdateCustomerSearch
            // 
            this.txtUpdateCustomerSearch.Location = new System.Drawing.Point(202, 28);
            this.txtUpdateCustomerSearch.Name = "txtUpdateCustomerSearch";
            this.txtUpdateCustomerSearch.Size = new System.Drawing.Size(242, 29);
            this.txtUpdateCustomerSearch.TabIndex = 2;
            this.txtUpdateCustomerSearch.TextChanged += new System.EventHandler(this.txtUpdateCustomerSearch_TextChanged);
            // 
            // btnUpdatedCustomer
            // 
            this.btnUpdatedCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btnUpdatedCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatedCustomer.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnUpdatedCustomer.FlatAppearance.BorderSize = 0;
            this.btnUpdatedCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatedCustomer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdatedCustomer.ForeColor = System.Drawing.Color.White;
            this.btnUpdatedCustomer.Location = new System.Drawing.Point(786, 399);
            this.btnUpdatedCustomer.Name = "btnUpdatedCustomer";
            this.btnUpdatedCustomer.Size = new System.Drawing.Size(180, 40);
            this.btnUpdatedCustomer.TabIndex = 13;
            this.btnUpdatedCustomer.Text = "MÜŞTERİ GÜNCELLE";
            this.btnUpdatedCustomer.UseVisualStyleBackColor = false;
            this.btnUpdatedCustomer.Click += new System.EventHandler(this.btnUpdatedCustomer_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.label8.Location = new System.Drawing.Point(20, 79);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Bulunan Müşteri : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(22, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Müşteri Adı : ";
            // 
            // txtUpdateCustomerDesriciption
            // 
            this.txtUpdateCustomerDesriciption.Location = new System.Drawing.Point(723, 344);
            this.txtUpdateCustomerDesriciption.Name = "txtUpdateCustomerDesriciption";
            this.txtUpdateCustomerDesriciption.Size = new System.Drawing.Size(243, 29);
            this.txtUpdateCustomerDesriciption.TabIndex = 12;
            this.txtUpdateCustomerDesriciption.TextChanged += new System.EventHandler(this.txtUpdateCustomerDesriciption_TextChanged);
            // 
            // txtUpdateCustomerTaxOffice
            // 
            this.txtUpdateCustomerTaxOffice.Location = new System.Drawing.Point(723, 298);
            this.txtUpdateCustomerTaxOffice.Name = "txtUpdateCustomerTaxOffice";
            this.txtUpdateCustomerTaxOffice.Size = new System.Drawing.Size(243, 29);
            this.txtUpdateCustomerTaxOffice.TabIndex = 10;
            this.txtUpdateCustomerTaxOffice.TextChanged += new System.EventHandler(this.txtUpdateCustomerTaxOffice_TextChanged);
            // 
            // txtUpdateCustomerTaxNo
            // 
            this.txtUpdateCustomerTaxNo.Location = new System.Drawing.Point(723, 250);
            this.txtUpdateCustomerTaxNo.Name = "txtUpdateCustomerTaxNo";
            this.txtUpdateCustomerTaxNo.Size = new System.Drawing.Size(243, 29);
            this.txtUpdateCustomerTaxNo.TabIndex = 9;
            this.txtUpdateCustomerTaxNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpdateCustomerTaxNo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(557, 349);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "Açıklama : ";
            // 
            // txtUpdateCustomerShippingAddress
            // 
            this.txtUpdateCustomerShippingAddress.Location = new System.Drawing.Point(722, 206);
            this.txtUpdateCustomerShippingAddress.Name = "txtUpdateCustomerShippingAddress";
            this.txtUpdateCustomerShippingAddress.Size = new System.Drawing.Size(243, 29);
            this.txtUpdateCustomerShippingAddress.TabIndex = 8;
            this.txtUpdateCustomerShippingAddress.TextChanged += new System.EventHandler(this.txtUpdateCustomerShippingAddress_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(556, 303);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "Vergi Dairesi : ";
            // 
            // txtUpdateCustomerAddress
            // 
            this.txtUpdateCustomerAddress.Location = new System.Drawing.Point(721, 161);
            this.txtUpdateCustomerAddress.Name = "txtUpdateCustomerAddress";
            this.txtUpdateCustomerAddress.Size = new System.Drawing.Size(242, 29);
            this.txtUpdateCustomerAddress.TabIndex = 7;
            this.txtUpdateCustomerAddress.TextChanged += new System.EventHandler(this.txtUpdateCustomerAddress_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(555, 254);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 19);
            this.label3.TabIndex = 36;
            this.label3.Text = "Vergi Numarası : ";
            // 
            // txtUpdateCustomerEmail
            // 
            this.txtUpdateCustomerEmail.Location = new System.Drawing.Point(721, 115);
            this.txtUpdateCustomerEmail.Name = "txtUpdateCustomerEmail";
            this.txtUpdateCustomerEmail.Size = new System.Drawing.Size(242, 29);
            this.txtUpdateCustomerEmail.TabIndex = 6;
            this.txtUpdateCustomerEmail.TextChanged += new System.EventHandler(this.txtUpdateCustomerEmail_TextChanged);
            // 
            // txtUpdateCustomerPhone
            // 
            this.txtUpdateCustomerPhone.Location = new System.Drawing.Point(721, 70);
            this.txtUpdateCustomerPhone.Name = "txtUpdateCustomerPhone";
            this.txtUpdateCustomerPhone.Size = new System.Drawing.Size(242, 29);
            this.txtUpdateCustomerPhone.TabIndex = 5;
            this.txtUpdateCustomerPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpdateCustomerPhone_KeyPress);
            // 
            // txtUpdateCustomerName
            // 
            this.txtUpdateCustomerName.Location = new System.Drawing.Point(722, 28);
            this.txtUpdateCustomerName.Name = "txtUpdateCustomerName";
            this.txtUpdateCustomerName.Size = new System.Drawing.Size(242, 29);
            this.txtUpdateCustomerName.TabIndex = 4;
            this.txtUpdateCustomerName.TextChanged += new System.EventHandler(this.txtUpdateCustomerName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(557, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.TabIndex = 37;
            this.label5.Text = "Sevk Adresi : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(557, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 38;
            this.label4.Text = "Adresi : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(557, 119);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 19);
            this.label9.TabIndex = 39;
            this.label9.Text = "Mail Adresi : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(557, 73);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 19);
            this.label10.TabIndex = 40;
            this.label10.Text = "Telefon : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(557, 31);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 19);
            this.label11.TabIndex = 41;
            this.label11.Text = "Müşteri Adı : ";
            // 
            // UpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 462);
            this.Controls.Add(this.txtUpdateCustomerDesriciption);
            this.Controls.Add(this.txtUpdateCustomerTaxOffice);
            this.Controls.Add(this.txtUpdateCustomerTaxNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUpdateCustomerShippingAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUpdateCustomerAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUpdateCustomerEmail);
            this.Controls.Add(this.txtUpdateCustomerPhone);
            this.Controls.Add(this.txtUpdateCustomerName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.grdUpdateCustomerList);
            this.Controls.Add(this.txtUpdateCustomerSearch);
            this.Controls.Add(this.btnUpdatedCustomer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÜŞTERİ GÜNCELLE";
            this.Load += new System.EventHandler(this.UpdateCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUpdateCustomerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grdUpdateCustomerList;
        private TextBox txtUpdateCustomerSearch;
        private Button btnUpdatedCustomer;
        private Label label8;
        private Label label7;
        public TextBox txtUpdateCustomerDesriciption;
        public TextBox txtUpdateCustomerTaxOffice;
        public TextBox txtUpdateCustomerTaxNo;
        private Label label1;
        public TextBox txtUpdateCustomerShippingAddress;
        private Label label2;
        public TextBox txtUpdateCustomerAddress;
        private Label label3;
        public TextBox txtUpdateCustomerEmail;
        public TextBox txtUpdateCustomerPhone;
        public TextBox txtUpdateCustomerName;
        private Label label5;
        private Label label4;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}