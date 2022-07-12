namespace AppNet.WinFormUI
{
    partial class AddCustomer
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
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.txtAddCustomerTaxNo = new System.Windows.Forms.TextBox();
            this.txtAddCustomerShippingAddress = new System.Windows.Forms.TextBox();
            this.txtAddCustomerAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddCustomerName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtAddCustomerEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddCustomerTaxOffice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddCustomerDesriciption = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustomer.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnAddCustomer.FlatAppearance.BorderSize = 0;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.Location = new System.Drawing.Point(283, 402);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(150, 40);
            this.btnAddCustomer.TabIndex = 9;
            this.btnAddCustomer.Text = "MÜŞTERİ EKLE";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // txtAddCustomerTaxNo
            // 
            this.txtAddCustomerTaxNo.Location = new System.Drawing.Point(191, 252);
            this.txtAddCustomerTaxNo.Name = "txtAddCustomerTaxNo";
            this.txtAddCustomerTaxNo.Size = new System.Drawing.Size(243, 29);
            this.txtAddCustomerTaxNo.TabIndex = 6;
            this.txtAddCustomerTaxNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddCustomerTaxNo_KeyPress);
            // 
            // txtAddCustomerShippingAddress
            // 
            this.txtAddCustomerShippingAddress.Location = new System.Drawing.Point(190, 208);
            this.txtAddCustomerShippingAddress.Name = "txtAddCustomerShippingAddress";
            this.txtAddCustomerShippingAddress.Size = new System.Drawing.Size(243, 29);
            this.txtAddCustomerShippingAddress.TabIndex = 5;
            this.txtAddCustomerShippingAddress.TextChanged += new System.EventHandler(this.txtAddCustomerShippingAddress_TextChanged);
            // 
            // txtAddCustomerAddress
            // 
            this.txtAddCustomerAddress.Location = new System.Drawing.Point(189, 163);
            this.txtAddCustomerAddress.Name = "txtAddCustomerAddress";
            this.txtAddCustomerAddress.Size = new System.Drawing.Size(242, 29);
            this.txtAddCustomerAddress.TabIndex = 4;
            this.txtAddCustomerAddress.TextChanged += new System.EventHandler(this.txtAddCustomerAddress_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(23, 255);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "Vergi Numarası : ";
            // 
            // txtAddCustomerName
            // 
            this.txtAddCustomerName.Location = new System.Drawing.Point(190, 30);
            this.txtAddCustomerName.Name = "txtAddCustomerName";
            this.txtAddCustomerName.Size = new System.Drawing.Size(242, 29);
            this.txtAddCustomerName.TabIndex = 1;
            this.txtAddCustomerName.TextChanged += new System.EventHandler(this.txtAddCustomerName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(25, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Sevk Adresi : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(25, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Adresi : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Mail Adresi : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Telefon : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Müşteri Adı : ";
            // 
            // txtAddCustomerPhone
            // 
            this.txtAddCustomerPhone.Location = new System.Drawing.Point(189, 72);
            this.txtAddCustomerPhone.Name = "txtAddCustomerPhone";
            this.txtAddCustomerPhone.Size = new System.Drawing.Size(242, 29);
            this.txtAddCustomerPhone.TabIndex = 2;
            this.txtAddCustomerPhone.TextChanged += new System.EventHandler(this.txtAddCustomerPhone_TextChanged);
            this.txtAddCustomerPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddCustomerPhone_KeyPress);
            // 
            // txtAddCustomerEmail
            // 
            this.txtAddCustomerEmail.Location = new System.Drawing.Point(189, 117);
            this.txtAddCustomerEmail.Name = "txtAddCustomerEmail";
            this.txtAddCustomerEmail.Size = new System.Drawing.Size(242, 29);
            this.txtAddCustomerEmail.TabIndex = 3;
            this.txtAddCustomerEmail.TextChanged += new System.EventHandler(this.txtAddCustomerEmail_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(24, 300);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "Vergi Dairesi : ";
            // 
            // txtAddCustomerTaxOffice
            // 
            this.txtAddCustomerTaxOffice.Location = new System.Drawing.Point(191, 300);
            this.txtAddCustomerTaxOffice.Name = "txtAddCustomerTaxOffice";
            this.txtAddCustomerTaxOffice.Size = new System.Drawing.Size(243, 29);
            this.txtAddCustomerTaxOffice.TabIndex = 7;
            this.txtAddCustomerTaxOffice.TextChanged += new System.EventHandler(this.txtAddCustomerTaxOffice_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(25, 346);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 21);
            this.label8.TabIndex = 20;
            this.label8.Text = "Açıklama : ";
            // 
            // txtAddCustomerDesriciption
            // 
            this.txtAddCustomerDesriciption.Location = new System.Drawing.Point(191, 346);
            this.txtAddCustomerDesriciption.Name = "txtAddCustomerDesriciption";
            this.txtAddCustomerDesriciption.Size = new System.Drawing.Size(243, 29);
            this.txtAddCustomerDesriciption.TabIndex = 8;
            this.txtAddCustomerDesriciption.TextChanged += new System.EventHandler(this.txtAddCustomerDesriciption_TextChanged);
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 461);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.txtAddCustomerDesriciption);
            this.Controls.Add(this.txtAddCustomerTaxOffice);
            this.Controls.Add(this.txtAddCustomerTaxNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAddCustomerShippingAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAddCustomerAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAddCustomerEmail);
            this.Controls.Add(this.txtAddCustomerPhone);
            this.Controls.Add(this.txtAddCustomerName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÜŞTERİ EKLE";
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Button btnAddCustomer;
        public TextBox txtAddCustomerTaxNo;
        public TextBox txtAddCustomerShippingAddress;
        public TextBox txtAddCustomerAddress;
        private Label label6;
        public TextBox txtAddCustomerName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        public TextBox txtAddCustomerPhone;
        public TextBox txtAddCustomerEmail;
        private Label label7;
        public TextBox txtAddCustomerTaxOffice;
        private Label label8;
        public TextBox txtAddCustomerDesriciption;
    }
}