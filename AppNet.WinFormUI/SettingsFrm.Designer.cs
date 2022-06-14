namespace AppNet.WinFormUI
{
    partial class SettingsFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
            this.btnAddDatabase = new System.Windows.Forms.Button();
            this.txtAddDatabaseName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddDataBaseUser = new System.Windows.Forms.TextBox();
            this.txtAddPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddDatabase
            // 
            this.btnAddDatabase.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddDatabase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDatabase.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnAddDatabase.FlatAppearance.BorderSize = 3;
            this.btnAddDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDatabase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddDatabase.ForeColor = System.Drawing.Color.White;
            this.btnAddDatabase.Location = new System.Drawing.Point(216, 182);
            this.btnAddDatabase.Name = "btnAddDatabase";
            this.btnAddDatabase.Size = new System.Drawing.Size(200, 40);
            this.btnAddDatabase.TabIndex = 4;
            this.btnAddDatabase.Text = "VERİ TABANI OLUŞTUR";
            this.btnAddDatabase.UseVisualStyleBackColor = false;
            this.btnAddDatabase.Click += new System.EventHandler(this.btnAddDatabase_Click);
            // 
            // txtAddDatabaseName
            // 
            this.txtAddDatabaseName.Location = new System.Drawing.Point(174, 40);
            this.txtAddDatabaseName.Name = "txtAddDatabaseName";
            this.txtAddDatabaseName.Size = new System.Drawing.Size(242, 29);
            this.txtAddDatabaseName.TabIndex = 1;
            this.txtAddDatabaseName.TextChanged += new System.EventHandler(this.txtAddDatabaseName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Şifre : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Kullanıcı Adı : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Veri Tabanı Adı : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAddDataBaseUser
            // 
            this.txtAddDataBaseUser.Location = new System.Drawing.Point(174, 86);
            this.txtAddDataBaseUser.Name = "txtAddDataBaseUser";
            this.txtAddDataBaseUser.Size = new System.Drawing.Size(242, 29);
            this.txtAddDataBaseUser.TabIndex = 2;
            this.txtAddDataBaseUser.TextChanged += new System.EventHandler(this.txtAddDataBaseUser_TextChanged);
            // 
            // txtAddPassword
            // 
            this.txtAddPassword.Location = new System.Drawing.Point(174, 130);
            this.txtAddPassword.Name = "txtAddPassword";
            this.txtAddPassword.Size = new System.Drawing.Size(242, 29);
            this.txtAddPassword.TabIndex = 3;
            this.txtAddPassword.TextChanged += new System.EventHandler(this.txtAddDatabasePassword_TextChanged);
            // 
            // SettingsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(447, 257);
            this.Controls.Add(this.btnAddDatabase);
            this.Controls.Add(this.txtAddPassword);
            this.Controls.Add(this.txtAddDataBaseUser);
            this.Controls.Add(this.txtAddDatabaseName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AYARLAR";
            this.Load += new System.EventHandler(this.SettingsFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Button btnAddDatabase;
        public TextBox txtAddDatabaseName;
        private Label label3;
        private Label label2;
        private Label label1;
        public TextBox txtAddDataBaseUser;
        public TextBox txtAddPassword;
    }
}