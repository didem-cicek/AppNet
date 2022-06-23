namespace AppNet.WinFormUI
{
    partial class UpdateSupplier
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
            this.grdSupplierList = new System.Windows.Forms.DataGridView();
            this.txtUpdateSupplierSearch = new System.Windows.Forms.TextBox();
            this.btnUpdatedSupplier = new System.Windows.Forms.Button();
            this.txtUpdateSupplierPhoneNumber = new System.Windows.Forms.TextBox();
            this.cbbUpdateSupplierSearch = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUpdateSupplierName = new System.Windows.Forms.TextBox();
            this.txtUpdateSupplierAddress = new System.Windows.Forms.TextBox();
            this.btnSearchUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtShippingAdress = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdSupplierList)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSupplierList
            // 
            this.grdSupplierList.BackgroundColor = System.Drawing.Color.White;
            this.grdSupplierList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSupplierList.Location = new System.Drawing.Point(28, 198);
            this.grdSupplierList.Margin = new System.Windows.Forms.Padding(4);
            this.grdSupplierList.Name = "grdSupplierList";
            this.grdSupplierList.RowTemplate.Height = 25;
            this.grdSupplierList.Size = new System.Drawing.Size(420, 153);
            this.grdSupplierList.TabIndex = 3;
            // 
            // txtUpdateSupplierSearch
            // 
            this.txtUpdateSupplierSearch.Location = new System.Drawing.Point(193, 87);
            this.txtUpdateSupplierSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtUpdateSupplierSearch.Name = "txtUpdateSupplierSearch";
            this.txtUpdateSupplierSearch.Size = new System.Drawing.Size(241, 29);
            this.txtUpdateSupplierSearch.TabIndex = 2;
            // 
            // btnUpdatedSupplier
            // 
            this.btnUpdatedSupplier.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdatedSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatedSupplier.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnUpdatedSupplier.FlatAppearance.BorderSize = 3;
            this.btnUpdatedSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatedSupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdatedSupplier.ForeColor = System.Drawing.Color.White;
            this.btnUpdatedSupplier.Location = new System.Drawing.Point(776, 231);
            this.btnUpdatedSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdatedSupplier.Name = "btnUpdatedSupplier";
            this.btnUpdatedSupplier.Size = new System.Drawing.Size(200, 54);
            this.btnUpdatedSupplier.TabIndex = 7;
            this.btnUpdatedSupplier.Text = "TEDARİKÇİ GÜNCELLE";
            this.btnUpdatedSupplier.UseVisualStyleBackColor = false;
            this.btnUpdatedSupplier.Click += new System.EventHandler(this.btnUpdatedSupplier_Click);
            // 
            // txtUpdateSupplierPhoneNumber
            // 
            this.txtUpdateSupplierPhoneNumber.Location = new System.Drawing.Point(734, 82);
            this.txtUpdateSupplierPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtUpdateSupplierPhoneNumber.Name = "txtUpdateSupplierPhoneNumber";
            this.txtUpdateSupplierPhoneNumber.Size = new System.Drawing.Size(242, 29);
            this.txtUpdateSupplierPhoneNumber.TabIndex = 5;
            // 
            // cbbUpdateSupplierSearch
            // 
            this.cbbUpdateSupplierSearch.FormattingEnabled = true;
            this.cbbUpdateSupplierSearch.Location = new System.Drawing.Point(193, 37);
            this.cbbUpdateSupplierSearch.Margin = new System.Windows.Forms.Padding(4);
            this.cbbUpdateSupplierSearch.Name = "cbbUpdateSupplierSearch";
            this.cbbUpdateSupplierSearch.Size = new System.Drawing.Size(241, 29);
            this.cbbUpdateSupplierSearch.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(520, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Adres :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(516, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = " Telefon Numarası :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(24, 142);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "Bulunan Tedarikçi : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(24, 92);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tedarikçi Adı : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(23, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kriter Seçiniz : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(520, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tedarikçi Adı :";
            // 
            // txtUpdateSupplierName
            // 
            this.txtUpdateSupplierName.Location = new System.Drawing.Point(734, 36);
            this.txtUpdateSupplierName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUpdateSupplierName.Name = "txtUpdateSupplierName";
            this.txtUpdateSupplierName.Size = new System.Drawing.Size(242, 29);
            this.txtUpdateSupplierName.TabIndex = 4;
            // 
            // txtUpdateSupplierAddress
            // 
            this.txtUpdateSupplierAddress.Location = new System.Drawing.Point(734, 130);
            this.txtUpdateSupplierAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtUpdateSupplierAddress.Name = "txtUpdateSupplierAddress";
            this.txtUpdateSupplierAddress.Size = new System.Drawing.Size(242, 29);
            this.txtUpdateSupplierAddress.TabIndex = 6;
            // 
            // btnSearchUpdate
            // 
            this.btnSearchUpdate.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSearchUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchUpdate.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnSearchUpdate.FlatAppearance.BorderSize = 3;
            this.btnSearchUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchUpdate.ForeColor = System.Drawing.Color.White;
            this.btnSearchUpdate.Location = new System.Drawing.Point(248, 379);
            this.btnSearchUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchUpdate.Name = "btnSearchUpdate";
            this.btnSearchUpdate.Size = new System.Drawing.Size(200, 56);
            this.btnSearchUpdate.TabIndex = 7;
            this.btnSearchUpdate.Text = "TEDARİKÇİ BUL";
            this.btnSearchUpdate.UseVisualStyleBackColor = false;
            this.btnSearchUpdate.Click += new System.EventHandler(this.btnSearchUpdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(520, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Sevk Adresi :";
            // 
            // txtShippingAdress
            // 
            this.txtShippingAdress.Location = new System.Drawing.Point(734, 176);
            this.txtShippingAdress.Margin = new System.Windows.Forms.Padding(4);
            this.txtShippingAdress.Name = "txtShippingAdress";
            this.txtShippingAdress.Size = new System.Drawing.Size(242, 29);
            this.txtShippingAdress.TabIndex = 6;
            // 
            // UpdateSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 448);
            this.Controls.Add(this.grdSupplierList);
            this.Controls.Add(this.txtUpdateSupplierSearch);
            this.Controls.Add(this.btnSearchUpdate);
            this.Controls.Add(this.btnUpdatedSupplier);
            this.Controls.Add(this.txtUpdateSupplierName);
            this.Controls.Add(this.txtShippingAdress);
            this.Controls.Add(this.txtUpdateSupplierAddress);
            this.Controls.Add(this.txtUpdateSupplierPhoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbUpdateSupplierSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TEDARİKÇİ GÜNCELLE";
            this.Load += new System.EventHandler(this.UpdateSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSupplierList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grdSupplierList;
        private TextBox txtUpdateSupplierSearch;
        private Button btnUpdatedSupplier;
        private TextBox txtUpdateSupplierPhoneNumber;
        private ComboBox cbbUpdateSupplierSearch;
        private Label label3;
        private Label label2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label1;
        private TextBox txtUpdateSupplierName;
        private TextBox txtUpdateSupplierAddress;
        private Button btnSearchUpdate;
        private Label label4;
        private TextBox txtShippingAdress;
    }
}