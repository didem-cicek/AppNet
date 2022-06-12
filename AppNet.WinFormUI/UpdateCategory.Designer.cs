namespace AppNet.WinFormUI
{
    partial class UpdateCategory
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
            this.cbbCategorySearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategorySearch = new System.Windows.Forms.TextBox();
            this.grdUpdateCategory = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUpdateCategory = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdUpdateCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kriter Seçiniz : ";
            // 
            // cbbCategorySearch
            // 
            this.cbbCategorySearch.FormattingEnabled = true;
            this.cbbCategorySearch.Location = new System.Drawing.Point(212, 30);
            this.cbbCategorySearch.Name = "cbbCategorySearch";
            this.cbbCategorySearch.Size = new System.Drawing.Size(243, 29);
            this.cbbCategorySearch.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Yeni Kategori Adı : ";
            // 
            // txtCategorySearch
            // 
            this.txtCategorySearch.Location = new System.Drawing.Point(212, 73);
            this.txtCategorySearch.Name = "txtCategorySearch";
            this.txtCategorySearch.Size = new System.Drawing.Size(243, 29);
            this.txtCategorySearch.TabIndex = 2;
            // 
            // grdUpdateCategory
            // 
            this.grdUpdateCategory.BackgroundColor = System.Drawing.Color.White;
            this.grdUpdateCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUpdateCategory.Location = new System.Drawing.Point(21, 157);
            this.grdUpdateCategory.Name = "grdUpdateCategory";
            this.grdUpdateCategory.RowTemplate.Height = 25;
            this.grdUpdateCategory.Size = new System.Drawing.Size(434, 150);
            this.grdUpdateCategory.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bulunan Kategori : ";
            // 
            // txtUpdateCategory
            // 
            this.txtUpdateCategory.Location = new System.Drawing.Point(212, 338);
            this.txtUpdateCategory.Name = "txtUpdateCategory";
            this.txtUpdateCategory.Size = new System.Drawing.Size(243, 29);
            this.txtUpdateCategory.TabIndex = 2;
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdateCategory.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnUpdateCategory.FlatAppearance.BorderSize = 3;
            this.btnUpdateCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateCategory.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCategory.Location = new System.Drawing.Point(255, 397);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(200, 40);
            this.btnUpdateCategory.TabIndex = 4;
            this.btnUpdateCategory.Text = "KATEGORİYİ GÜNCELLE";
            this.btnUpdateCategory.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(21, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kategori Adı : ";
            // 
            // UpdateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(479, 466);
            this.Controls.Add(this.btnUpdateCategory);
            this.Controls.Add(this.grdUpdateCategory);
            this.Controls.Add(this.txtUpdateCategory);
            this.Controls.Add(this.txtCategorySearch);
            this.Controls.Add(this.cbbCategorySearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KATEGORİ GÜNCELLE";
            this.Load += new System.EventHandler(this.UpdateCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUpdateCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cbbCategorySearch;
        private Label label2;
        private TextBox txtCategorySearch;
        private DataGridView grdUpdateCategory;
        private Label label3;
        private TextBox txtUpdateCategory;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnUpdateCategory;
        private Label label4;
    }
}