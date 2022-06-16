namespace AppNet.WinFormUI
{
    partial class AddCategory
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
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı : ";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(148, 74);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(242, 29);
            this.txtCategoryName.TabIndex = 1;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddCategory.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnAddCategory.FlatAppearance.BorderSize = 3;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.Location = new System.Drawing.Point(240, 128);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(150, 40);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "KATEGORİ EKLE";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kategori ID : ";
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(148, 28);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(242, 29);
            this.txtCategoryID.TabIndex = 1;
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(419, 190);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.txtCategoryID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KATEGORİ EKLE";
            this.Load += new System.EventHandler(this.AddCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtCategoryName;
        private Button btnAddCategory;
        private Label label2;
        private TextBox txtCategoryID;
    }
}