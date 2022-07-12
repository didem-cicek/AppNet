namespace AppNet.WinFormUI
{
    partial class PurchasingFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchasingFrm));
            this.grdStockList = new System.Windows.Forms.DataGridView();
            this.txtStockSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeletedStock = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnUpdatedStock = new System.Windows.Forms.Button();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdStockList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdStockList
            // 
            this.grdStockList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdStockList.BackgroundColor = System.Drawing.Color.White;
            this.grdStockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStockList.GridColor = System.Drawing.Color.Black;
            this.grdStockList.Location = new System.Drawing.Point(247, 209);
            this.grdStockList.Name = "grdStockList";
            this.grdStockList.RowHeadersVisible = false;
            this.grdStockList.RowTemplate.Height = 25;
            this.grdStockList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdStockList.Size = new System.Drawing.Size(1064, 389);
            this.grdStockList.TabIndex = 7;
            // 
            // txtStockSearch
            // 
            this.txtStockSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStockSearch.Location = new System.Drawing.Point(397, 45);
            this.txtStockSearch.Name = "txtStockSearch";
            this.txtStockSearch.Size = new System.Drawing.Size(390, 29);
            this.txtStockSearch.TabIndex = 5;
            this.txtStockSearch.TextChanged += new System.EventHandler(this.txtStockSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(608, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Aranacak Kelime : ";
            // 
            // btnDeletedStock
            // 
            this.btnDeletedStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btnDeletedStock.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnDeletedStock.FlatAppearance.BorderSize = 0;
            this.btnDeletedStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletedStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeletedStock.ForeColor = System.Drawing.Color.White;
            this.btnDeletedStock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeletedStock.ImageKey = "deleted.png";
            this.btnDeletedStock.ImageList = this.imageList1;
            this.btnDeletedStock.Location = new System.Drawing.Point(-2, 173);
            this.btnDeletedStock.Name = "btnDeletedStock";
            this.btnDeletedStock.Size = new System.Drawing.Size(205, 85);
            this.btnDeletedStock.TabIndex = 3;
            this.btnDeletedStock.Text = "STOK SİL";
            this.btnDeletedStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeletedStock.UseVisualStyleBackColor = false;
            this.btnDeletedStock.Click += new System.EventHandler(this.btnDeletedStock_Click);
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
            // btnUpdatedStock
            // 
            this.btnUpdatedStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btnUpdatedStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatedStock.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnUpdatedStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatedStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdatedStock.ForeColor = System.Drawing.Color.White;
            this.btnUpdatedStock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdatedStock.ImageKey = "edit.png";
            this.btnUpdatedStock.ImageList = this.imageList1;
            this.btnUpdatedStock.Location = new System.Drawing.Point(-3, 88);
            this.btnUpdatedStock.Name = "btnUpdatedStock";
            this.btnUpdatedStock.Size = new System.Drawing.Size(205, 85);
            this.btnUpdatedStock.TabIndex = 2;
            this.btnUpdatedStock.Text = "STOK GÜNCELLE";
            this.btnUpdatedStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdatedStock.UseVisualStyleBackColor = false;
            this.btnUpdatedStock.Click += new System.EventHandler(this.btnUpdatedStock_Click);
            // 
            // btnAddStock
            // 
            this.btnAddStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btnAddStock.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnAddStock.FlatAppearance.BorderSize = 0;
            this.btnAddStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddStock.ForeColor = System.Drawing.Color.White;
            this.btnAddStock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddStock.ImageIndex = 0;
            this.btnAddStock.ImageList = this.imageList1;
            this.btnAddStock.Location = new System.Drawing.Point(-2, 3);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(205, 85);
            this.btnAddStock.TabIndex = 1;
            this.btnAddStock.Text = "STOK EKLE";
            this.btnAddStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddStock.UseVisualStyleBackColor = false;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.panel1.Controls.Add(this.btnAddStock);
            this.panel1.Controls.Add(this.btnUpdatedStock);
            this.panel1.Controls.Add(this.btnDeletedStock);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 691);
            this.panel1.TabIndex = 32;
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
            this.panel3.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.label7.Location = new System.Drawing.Point(244, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 26);
            this.label7.TabIndex = 36;
            this.label7.Text = "STOK LİSTESİ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.label8.Location = new System.Drawing.Point(245, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(542, 15);
            this.label8.TabIndex = 35;
            this.label8.Text = "---------------------------------------------------------------------------------" +
    "--------------------------";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(244, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "Aranacak Kelime : ";
            // 
            // PurchasingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 691);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grdStockList);
            this.Controls.Add(this.txtStockSearch);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "PurchasingFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SATIN ALMA YÖNETİMİ";
            this.Load += new System.EventHandler(this.PurchasingFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdStockList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grdStockList;
        public TextBox txtStockSearch;
        private Label label3;
        public Button btnDeletedStock;
        private ImageList imageList1;
        public Button btnUpdatedStock;
        public Button btnAddStock;
        private Panel panel1;
        private Label label6;
        private Panel panel3;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}