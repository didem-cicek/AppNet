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
            this.txtProductSearch = new System.Windows.Forms.TextBox();
            this.btnDeletedSupplier = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnUpdatedSupplier = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grdSupplierList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdSupplierList
            // 
            this.grdSupplierList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdSupplierList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdSupplierList.BackgroundColor = System.Drawing.Color.White;
            this.grdSupplierList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSupplierList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grdSupplierList.GridColor = System.Drawing.Color.Black;
            this.grdSupplierList.Location = new System.Drawing.Point(253, 207);
            this.grdSupplierList.MultiSelect = false;
            this.grdSupplierList.Name = "grdSupplierList";
            this.grdSupplierList.RowTemplate.Height = 25;
            this.grdSupplierList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdSupplierList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSupplierList.Size = new System.Drawing.Size(1057, 394);
            this.grdSupplierList.TabIndex = 7;
            // 
            // txtProductSearch
            // 
            this.txtProductSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductSearch.Location = new System.Drawing.Point(409, 44);
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.Size = new System.Drawing.Size(386, 29);
            this.txtProductSearch.TabIndex = 5;
            this.txtProductSearch.TextChanged += new System.EventHandler(this.txtProductSearch_TextChanged);
            // 
            // btnDeletedSupplier
            // 
            this.btnDeletedSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btnDeletedSupplier.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnDeletedSupplier.FlatAppearance.BorderSize = 0;
            this.btnDeletedSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletedSupplier.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeletedSupplier.ForeColor = System.Drawing.Color.White;
            this.btnDeletedSupplier.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeletedSupplier.ImageKey = "deleted.png";
            this.btnDeletedSupplier.ImageList = this.imageList1;
            this.btnDeletedSupplier.Location = new System.Drawing.Point(0, 170);
            this.btnDeletedSupplier.Name = "btnDeletedSupplier";
            this.btnDeletedSupplier.Size = new System.Drawing.Size(205, 85);
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
            this.btnUpdatedSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btnUpdatedSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatedSupplier.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnUpdatedSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatedSupplier.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdatedSupplier.ForeColor = System.Drawing.Color.White;
            this.btnUpdatedSupplier.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdatedSupplier.ImageKey = "edit.png";
            this.btnUpdatedSupplier.ImageList = this.imageList1;
            this.btnUpdatedSupplier.Location = new System.Drawing.Point(-1, 85);
            this.btnUpdatedSupplier.Name = "btnUpdatedSupplier";
            this.btnUpdatedSupplier.Size = new System.Drawing.Size(205, 85);
            this.btnUpdatedSupplier.TabIndex = 2;
            this.btnUpdatedSupplier.Text = "TEDARİKÇİ GÜNCELLE";
            this.btnUpdatedSupplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdatedSupplier.UseVisualStyleBackColor = false;
            this.btnUpdatedSupplier.Click += new System.EventHandler(this.btnUpdatedSupplier_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btnAddSupplier.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnAddSupplier.FlatAppearance.BorderSize = 0;
            this.btnAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSupplier.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddSupplier.ForeColor = System.Drawing.Color.White;
            this.btnAddSupplier.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddSupplier.ImageIndex = 0;
            this.btnAddSupplier.ImageList = this.imageList1;
            this.btnAddSupplier.Location = new System.Drawing.Point(0, 0);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(205, 85);
            this.btnAddSupplier.TabIndex = 1;
            this.btnAddSupplier.Text = "TEDARİKÇİ EKLE";
            this.btnAddSupplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddSupplier.UseVisualStyleBackColor = false;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.panel1.Controls.Add(this.btnAddSupplier);
            this.panel1.Controls.Add(this.btnUpdatedSupplier);
            this.panel1.Controls.Add(this.btnDeletedSupplier);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 691);
            this.panel1.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.label7.Location = new System.Drawing.Point(252, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 26);
            this.label7.TabIndex = 39;
            this.label7.Text = "TEDARİKÇİ LİSTESİ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.label8.Location = new System.Drawing.Point(253, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(542, 15);
            this.label8.TabIndex = 38;
            this.label8.Text = "---------------------------------------------------------------------------------" +
    "--------------------------";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(252, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "Aranacak Kelime : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(34)))));
            this.label6.Location = new System.Drawing.Point(910, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Copyright @ 2022 | Didem Çiçek";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(200, 635);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1150, 56);
            this.panel3.TabIndex = 40;
            // 
            // SuppliersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 691);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grdSupplierList);
            this.Controls.Add(this.txtProductSearch);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "SuppliersFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TEDARİKÇİLER";
            this.Load += new System.EventHandler(this.SuppliersFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSupplierList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grdSupplierList;
        public TextBox txtProductSearch;
        public Button btnDeletedSupplier;
        public Button btnUpdatedSupplier;
        private ImageList imageList1;
        public Button btnAddSupplier;
        private Panel panel1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label6;
        private Panel panel3;
    }
}