namespace AppNet.WinFormUI
{
    partial class CustomerFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerFrm));
            this.grdCustomerList = new System.Windows.Forms.DataGridView();
            this.txtCustomerSearch = new System.Windows.Forms.TextBox();
            this.btnDeletedCustomer = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnUpdatedCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomerList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdCustomerList
            // 
            this.grdCustomerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCustomerList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdCustomerList.BackgroundColor = System.Drawing.Color.White;
            this.grdCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomerList.Location = new System.Drawing.Point(244, 201);
            this.grdCustomerList.MultiSelect = false;
            this.grdCustomerList.Name = "grdCustomerList";
            this.grdCustomerList.RowHeadersVisible = false;
            this.grdCustomerList.RowTemplate.Height = 25;
            this.grdCustomerList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdCustomerList.Size = new System.Drawing.Size(1064, 393);
            this.grdCustomerList.TabIndex = 7;
            this.grdCustomerList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCustomerList_CellContentClick);
            // 
            // txtCustomerSearch
            // 
            this.txtCustomerSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCustomerSearch.Location = new System.Drawing.Point(384, 46);
            this.txtCustomerSearch.Name = "txtCustomerSearch";
            this.txtCustomerSearch.Size = new System.Drawing.Size(291, 29);
            this.txtCustomerSearch.TabIndex = 5;
            this.txtCustomerSearch.TextChanged += new System.EventHandler(this.txtCustomerSearch_TextChanged);
            // 
            // btnDeletedCustomer
            // 
            this.btnDeletedCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btnDeletedCustomer.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnDeletedCustomer.FlatAppearance.BorderSize = 0;
            this.btnDeletedCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletedCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeletedCustomer.ForeColor = System.Drawing.Color.White;
            this.btnDeletedCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeletedCustomer.ImageKey = "deleted.png";
            this.btnDeletedCustomer.ImageList = this.imageList1;
            this.btnDeletedCustomer.Location = new System.Drawing.Point(0, 171);
            this.btnDeletedCustomer.Name = "btnDeletedCustomer";
            this.btnDeletedCustomer.Size = new System.Drawing.Size(205, 85);
            this.btnDeletedCustomer.TabIndex = 3;
            this.btnDeletedCustomer.Text = "MÜŞTERİ SİL";
            this.btnDeletedCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeletedCustomer.UseVisualStyleBackColor = false;
            this.btnDeletedCustomer.Click += new System.EventHandler(this.btnDeletedCustomer_Click);
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
            // btnUpdatedCustomer
            // 
            this.btnUpdatedCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btnUpdatedCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatedCustomer.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnUpdatedCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatedCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdatedCustomer.ForeColor = System.Drawing.Color.White;
            this.btnUpdatedCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdatedCustomer.ImageKey = "edit.png";
            this.btnUpdatedCustomer.ImageList = this.imageList1;
            this.btnUpdatedCustomer.Location = new System.Drawing.Point(-4, 86);
            this.btnUpdatedCustomer.Name = "btnUpdatedCustomer";
            this.btnUpdatedCustomer.Size = new System.Drawing.Size(205, 85);
            this.btnUpdatedCustomer.TabIndex = 2;
            this.btnUpdatedCustomer.Text = "MÜŞTERİ GÜNCELLE";
            this.btnUpdatedCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdatedCustomer.UseVisualStyleBackColor = false;
            this.btnUpdatedCustomer.Click += new System.EventHandler(this.btnUpdatedCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btnAddCustomer.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnAddCustomer.FlatAppearance.BorderSize = 0;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddCustomer.ImageIndex = 0;
            this.btnAddCustomer.ImageList = this.imageList1;
            this.btnAddCustomer.Location = new System.Drawing.Point(-3, 1);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(205, 85);
            this.btnAddCustomer.TabIndex = 1;
            this.btnAddCustomer.Text = "MÜŞTERİ EKLE";
            this.btnAddCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.panel1.Controls.Add(this.btnAddCustomer);
            this.panel1.Controls.Add(this.btnUpdatedCustomer);
            this.panel1.Controls.Add(this.btnDeletedCustomer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 691);
            this.panel1.TabIndex = 43;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(200, 635);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1150, 56);
            this.panel3.TabIndex = 44;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.label1.Location = new System.Drawing.Point(243, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 26);
            this.label1.TabIndex = 48;
            this.label1.Text = "MÜŞTERİ LİSTESİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.label4.Location = new System.Drawing.Point(244, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(435, 14);
            this.label4.TabIndex = 47;
            this.label4.Text = "---------------------------------------------------------------------------------" +
    "--------------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(243, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Aranacak Kelime : ";
            // 
            // CustomerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 691);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grdCustomerList);
            this.Controls.Add(this.txtCustomerSearch);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "CustomerFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÜŞTERİ YÖNETİMİ";
            this.Load += new System.EventHandler(this.CustomerFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomerList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DataGridView grdCustomerList;
        public TextBox txtCustomerSearch;
        public Button btnDeletedCustomer;
        public Button btnUpdatedCustomer;
        public Button btnAddCustomer;
        public ImageList imageList1;
        public Panel panel1;
        public Panel panel3;
        public Label label6;
        public Label label1;
        public Label label4;
        public Label label2;
    }
}