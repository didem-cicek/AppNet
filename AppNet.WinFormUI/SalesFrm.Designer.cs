namespace AppNet.WinFormUI
{
    partial class SalesFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesFrm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.grdSaleList = new System.Windows.Forms.DataGridView();
            this.txtProductSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeleteSale = new System.Windows.Forms.Button();
            this.btnUpdateSale = new System.Windows.Forms.Button();
            this.btnAddSale = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grdSaleList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            // grdSaleList
            // 
            this.grdSaleList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdSaleList.BackgroundColor = System.Drawing.Color.White;
            this.grdSaleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSaleList.Location = new System.Drawing.Point(231, 207);
            this.grdSaleList.Name = "grdSaleList";
            this.grdSaleList.RowHeadersVisible = false;
            this.grdSaleList.RowTemplate.Height = 25;
            this.grdSaleList.Size = new System.Drawing.Size(1073, 396);
            this.grdSaleList.TabIndex = 6;
            // 
            // txtProductSearch
            // 
            this.txtProductSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductSearch.Location = new System.Drawing.Point(383, 49);
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.Size = new System.Drawing.Size(390, 29);
            this.txtProductSearch.TabIndex = 4;
            this.txtProductSearch.TextChanged += new System.EventHandler(this.txtProductSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(608, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Aranacak Kelime : ";
            // 
            // btnDeleteSale
            // 
            this.btnDeleteSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btnDeleteSale.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnDeleteSale.FlatAppearance.BorderSize = 0;
            this.btnDeleteSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteSale.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSale.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteSale.ImageKey = "deleted.png";
            this.btnDeleteSale.ImageList = this.imageList1;
            this.btnDeleteSale.Location = new System.Drawing.Point(-3, 173);
            this.btnDeleteSale.Name = "btnDeleteSale";
            this.btnDeleteSale.Size = new System.Drawing.Size(205, 85);
            this.btnDeleteSale.TabIndex = 3;
            this.btnDeleteSale.Text = "SİPARİŞ SİL";
            this.btnDeleteSale.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteSale.UseVisualStyleBackColor = false;
            this.btnDeleteSale.Click += new System.EventHandler(this.btnDeleteSale_Click);
            // 
            // btnUpdateSale
            // 
            this.btnUpdateSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btnUpdateSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateSale.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateSale.ForeColor = System.Drawing.Color.White;
            this.btnUpdateSale.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdateSale.ImageKey = "edit.png";
            this.btnUpdateSale.ImageList = this.imageList1;
            this.btnUpdateSale.Location = new System.Drawing.Point(-2, 88);
            this.btnUpdateSale.Name = "btnUpdateSale";
            this.btnUpdateSale.Size = new System.Drawing.Size(205, 85);
            this.btnUpdateSale.TabIndex = 2;
            this.btnUpdateSale.Text = "SİPARİŞ GÜNCELLE";
            this.btnUpdateSale.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdateSale.UseVisualStyleBackColor = false;
            this.btnUpdateSale.Click += new System.EventHandler(this.btnUpdateSale_Click);
            // 
            // btnAddSale
            // 
            this.btnAddSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btnAddSale.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btnAddSale.FlatAppearance.BorderSize = 0;
            this.btnAddSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddSale.ForeColor = System.Drawing.Color.White;
            this.btnAddSale.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddSale.ImageIndex = 0;
            this.btnAddSale.ImageList = this.imageList1;
            this.btnAddSale.Location = new System.Drawing.Point(-2, 3);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(205, 85);
            this.btnAddSale.TabIndex = 1;
            this.btnAddSale.Text = "SİPARİŞ EKLE";
            this.btnAddSale.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddSale.UseVisualStyleBackColor = false;
            this.btnAddSale.Click += new System.EventHandler(this.btnAddSale_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddSale);
            this.panel1.Controls.Add(this.btnUpdateSale);
            this.panel1.Controls.Add(this.btnDeleteSale);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 691);
            this.panel1.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.label1.Location = new System.Drawing.Point(230, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 26);
            this.label1.TabIndex = 36;
            this.label1.Text = "SİPARİŞ LİSTESİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.label4.Location = new System.Drawing.Point(231, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(542, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "---------------------------------------------------------------------------------" +
    "--------------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(230, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Aranacak Kelime : ";
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
            this.panel3.TabIndex = 37;
            // 
            // SalesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 691);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grdSaleList);
            this.Controls.Add(this.txtProductSearch);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "SalesFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SATIŞ YÖNETİMİ";
            this.Load += new System.EventHandler(this.SalesFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSaleList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ImageList imageList1;
        private DataGridView grdSaleList;
        public TextBox txtProductSearch;
        private Label label3;
        public Button btnDeleteSale;
        public Button btnUpdateSale;
        public Button btnAddSale;
        private Panel panel1;
        private Label label1;
        private Label label4;
        private Label label2;
        private Label label6;
        private Panel panel3;
    }
}