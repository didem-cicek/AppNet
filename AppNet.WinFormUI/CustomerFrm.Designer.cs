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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbCustomerSearch = new System.Windows.Forms.ComboBox();
            this.txtCustomerSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeletedCustomer = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnUpdatedCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnCustomerSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCustomerList
            // 
            this.grdCustomerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCustomerList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdCustomerList.BackgroundColor = System.Drawing.Color.White;
            this.grdCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomerList.Location = new System.Drawing.Point(24, 343);
            this.grdCustomerList.MultiSelect = false;
            this.grdCustomerList.Name = "grdCustomerList";
            this.grdCustomerList.RowHeadersVisible = false;
            this.grdCustomerList.RowTemplate.Height = 25;
            this.grdCustomerList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdCustomerList.Size = new System.Drawing.Size(965, 197);
            this.grdCustomerList.TabIndex = 7;
            this.grdCustomerList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCustomerList_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(19, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "MÜŞTERİ LİSTESİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(612, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(352, 15);
            this.label4.TabIndex = 41;
            this.label4.Text = "---------------------------------------------------------------------";
            // 
            // cbbCustomerSearch
            // 
            this.cbbCustomerSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbCustomerSearch.FormattingEnabled = true;
            this.cbbCustomerSearch.Location = new System.Drawing.Point(747, 107);
            this.cbbCustomerSearch.Name = "cbbCustomerSearch";
            this.cbbCustomerSearch.Size = new System.Drawing.Size(214, 29);
            this.cbbCustomerSearch.TabIndex = 4;
            // 
            // txtCustomerSearch
            // 
            this.txtCustomerSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCustomerSearch.Location = new System.Drawing.Point(747, 158);
            this.txtCustomerSearch.Name = "txtCustomerSearch";
            this.txtCustomerSearch.Size = new System.Drawing.Size(214, 29);
            this.txtCustomerSearch.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(608, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Aranacak Kelime : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(608, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Arama Kriteri : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(608, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "ARAMA ALANI";
            // 
            // btnDeletedCustomer
            // 
            this.btnDeletedCustomer.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeletedCustomer.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnDeletedCustomer.FlatAppearance.BorderSize = 3;
            this.btnDeletedCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletedCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeletedCustomer.ForeColor = System.Drawing.Color.White;
            this.btnDeletedCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeletedCustomer.ImageKey = "deleted.png";
            this.btnDeletedCustomer.ImageList = this.imageList1;
            this.btnDeletedCustomer.Location = new System.Drawing.Point(408, 21);
            this.btnDeletedCustomer.Name = "btnDeletedCustomer";
            this.btnDeletedCustomer.Size = new System.Drawing.Size(167, 109);
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
            this.btnUpdatedCustomer.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdatedCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatedCustomer.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.btnUpdatedCustomer.FlatAppearance.BorderSize = 3;
            this.btnUpdatedCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatedCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdatedCustomer.ForeColor = System.Drawing.Color.White;
            this.btnUpdatedCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdatedCustomer.ImageKey = "edit.png";
            this.btnUpdatedCustomer.ImageList = this.imageList1;
            this.btnUpdatedCustomer.Location = new System.Drawing.Point(200, 21);
            this.btnUpdatedCustomer.Name = "btnUpdatedCustomer";
            this.btnUpdatedCustomer.Size = new System.Drawing.Size(200, 109);
            this.btnUpdatedCustomer.TabIndex = 2;
            this.btnUpdatedCustomer.Text = "MÜŞTERİ GÜNCELLE";
            this.btnUpdatedCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdatedCustomer.UseVisualStyleBackColor = false;
            this.btnUpdatedCustomer.Click += new System.EventHandler(this.btnUpdatedCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddCustomer.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnAddCustomer.FlatAppearance.BorderSize = 3;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddCustomer.ImageIndex = 0;
            this.btnAddCustomer.ImageList = this.imageList1;
            this.btnAddCustomer.Location = new System.Drawing.Point(24, 21);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(168, 109);
            this.btnAddCustomer.TabIndex = 1;
            this.btnAddCustomer.Text = "MÜŞTERİ EKLE";
            this.btnAddCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnCustomerSearch
            // 
            this.btnCustomerSearch.BackColor = System.Drawing.Color.Gray;
            this.btnCustomerSearch.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCustomerSearch.FlatAppearance.BorderSize = 3;
            this.btnCustomerSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCustomerSearch.ForeColor = System.Drawing.Color.White;
            this.btnCustomerSearch.Location = new System.Drawing.Point(861, 211);
            this.btnCustomerSearch.Name = "btnCustomerSearch";
            this.btnCustomerSearch.Size = new System.Drawing.Size(100, 40);
            this.btnCustomerSearch.TabIndex = 6;
            this.btnCustomerSearch.Text = "ARA";
            this.btnCustomerSearch.UseVisualStyleBackColor = false;
            // 
            // CustomerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.btnCustomerSearch);
            this.Controls.Add(this.grdCustomerList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbCustomerSearch);
            this.Controls.Add(this.txtCustomerSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeletedCustomer);
            this.Controls.Add(this.btnUpdatedCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Name = "CustomerFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÜŞTERİ YÖNETİMİ";
            this.Load += new System.EventHandler(this.CustomerFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grdCustomerList;
        private Label label5;
        private Label label4;
        public ComboBox cbbCustomerSearch;
        public TextBox txtCustomerSearch;
        private Label label3;
        private Label label2;
        private Label label1;
        public Button btnDeletedCustomer;
        public Button btnUpdatedCustomer;
        public Button btnAddCustomer;
        private ImageList imageList1;
        public Button btnCustomerSearch;
    }
}