namespace AppNet.WinFormUI
{
    partial class SuppliersFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuppliersFrm));
            this.grdSupplierList = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbProductSearch = new System.Windows.Forms.ComboBox();
            this.btnSupplierSearch = new System.Windows.Forms.Button();
            this.txtProductSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeletedSupplier = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnUpdatedSupplier = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdSupplierList)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSupplierList
            // 
            this.grdSupplierList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdSupplierList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdSupplierList.BackgroundColor = System.Drawing.Color.White;
            this.grdSupplierList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSupplierList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grdSupplierList.Location = new System.Drawing.Point(24, 343);
            this.grdSupplierList.MultiSelect = false;
            this.grdSupplierList.Name = "grdSupplierList";
            this.grdSupplierList.RowTemplate.Height = 25;
            this.grdSupplierList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdSupplierList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSupplierList.Size = new System.Drawing.Size(965, 197);
            this.grdSupplierList.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(19, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "TEDARİKÇİ LİSTESİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(612, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(352, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "---------------------------------------------------------------------";
            // 
            // cbbProductSearch
            // 
            this.cbbProductSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbProductSearch.FormattingEnabled = true;
            this.cbbProductSearch.Location = new System.Drawing.Point(747, 107);
            this.cbbProductSearch.Name = "cbbProductSearch";
            this.cbbProductSearch.Size = new System.Drawing.Size(214, 29);
            this.cbbProductSearch.TabIndex = 4;
            // 
            // btnSupplierSearch
            // 
            this.btnSupplierSearch.BackColor = System.Drawing.Color.Gray;
            this.btnSupplierSearch.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSupplierSearch.FlatAppearance.BorderSize = 3;
            this.btnSupplierSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplierSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSupplierSearch.ForeColor = System.Drawing.Color.White;
            this.btnSupplierSearch.Location = new System.Drawing.Point(861, 207);
            this.btnSupplierSearch.Name = "btnSupplierSearch";
            this.btnSupplierSearch.Size = new System.Drawing.Size(100, 40);
            this.btnSupplierSearch.TabIndex = 6;
            this.btnSupplierSearch.Text = "ARA";
            this.btnSupplierSearch.UseVisualStyleBackColor = false;
            // 
            // txtProductSearch
            // 
            this.txtProductSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductSearch.Location = new System.Drawing.Point(747, 158);
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.Size = new System.Drawing.Size(214, 29);
            this.txtProductSearch.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(608, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Aranacak Kelime : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(608, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Arama Kriteri : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(608, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "ARAMA ALANI";
            // 
            // btnDeletedSupplier
            // 
            this.btnDeletedSupplier.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeletedSupplier.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnDeletedSupplier.FlatAppearance.BorderSize = 3;
            this.btnDeletedSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletedSupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeletedSupplier.ForeColor = System.Drawing.Color.White;
            this.btnDeletedSupplier.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeletedSupplier.ImageKey = "deleted.png";
            this.btnDeletedSupplier.ImageList = this.imageList1;
            this.btnDeletedSupplier.Location = new System.Drawing.Point(408, 21);
            this.btnDeletedSupplier.Name = "btnDeletedSupplier";
            this.btnDeletedSupplier.Size = new System.Drawing.Size(167, 109);
            this.btnDeletedSupplier.TabIndex = 3;
            this.btnDeletedSupplier.Text = "TEDARİKÇİ SİL";
            this.btnDeletedSupplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeletedSupplier.UseVisualStyleBackColor = false;
            this.btnDeletedSupplier.Click += new System.EventHandler(this.btnDeletedSupplier_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            this.imageList1.Images.SetKeyName(1, "deleted.png");
            this.imageList1.Images.SetKeyName(2, "edit.png");
            // 
            // btnUpdatedSupplier
            // 
            this.btnUpdatedSupplier.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdatedSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatedSupplier.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.btnUpdatedSupplier.FlatAppearance.BorderSize = 3;
            this.btnUpdatedSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatedSupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdatedSupplier.ForeColor = System.Drawing.Color.White;
            this.btnUpdatedSupplier.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdatedSupplier.ImageKey = "edit.png";
            this.btnUpdatedSupplier.ImageList = this.imageList1;
            this.btnUpdatedSupplier.Location = new System.Drawing.Point(200, 21);
            this.btnUpdatedSupplier.Name = "btnUpdatedSupplier";
            this.btnUpdatedSupplier.Size = new System.Drawing.Size(200, 109);
            this.btnUpdatedSupplier.TabIndex = 2;
            this.btnUpdatedSupplier.Text = "TEDARİKÇİ GÜNCELLE";
            this.btnUpdatedSupplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdatedSupplier.UseVisualStyleBackColor = false;
            this.btnUpdatedSupplier.Click += new System.EventHandler(this.btnUpdatedSupplier_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddSupplier.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnAddSupplier.FlatAppearance.BorderSize = 3;
            this.btnAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddSupplier.ForeColor = System.Drawing.Color.White;
            this.btnAddSupplier.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddSupplier.ImageIndex = 0;
            this.btnAddSupplier.ImageList = this.imageList1;
            this.btnAddSupplier.Location = new System.Drawing.Point(24, 21);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(168, 109);
            this.btnAddSupplier.TabIndex = 1;
            this.btnAddSupplier.Text = "TEDARİKÇİ EKLE";
            this.btnAddSupplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddSupplier.UseVisualStyleBackColor = false;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // SuppliersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.grdSupplierList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbProductSearch);
            this.Controls.Add(this.btnSupplierSearch);
            this.Controls.Add(this.txtProductSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeletedSupplier);
            this.Controls.Add(this.btnUpdatedSupplier);
            this.Controls.Add(this.btnAddSupplier);
            this.Name = "SuppliersFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TEDARİKÇİLER";
            this.Load += new System.EventHandler(this.SuppliersFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSupplierList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grdSupplierList;
        private Label label5;
        private Label label4;
        public ComboBox cbbProductSearch;
        public Button btnSupplierSearch;
        public TextBox txtProductSearch;
        private Label label3;
        private Label label2;
        private Label label1;
        public Button btnDeletedSupplier;
        public Button btnUpdatedSupplier;
        private ImageList imageList1;
        public Button btnAddSupplier;
    }
}