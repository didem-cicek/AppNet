namespace AppNet.WinFormUI
{
    partial class DeleteProduct
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
            this.cbbDeletedSearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDeletedSearch = new System.Windows.Forms.TextBox();
            this.grdDeletedList = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeleted = new System.Windows.Forms.Button();
            this.btnselectdel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdDeletedList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kriter Seçiniz : ";
            // 
            // cbbDeletedSearch
            // 
            this.cbbDeletedSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDeletedSearch.FormattingEnabled = true;
            this.cbbDeletedSearch.Location = new System.Drawing.Point(206, 26);
            this.cbbDeletedSearch.Name = "cbbDeletedSearch";
            this.cbbDeletedSearch.Size = new System.Drawing.Size(244, 29);
            this.cbbDeletedSearch.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Aranacak Kelime : ";
            // 
            // txtDeletedSearch
            // 
            this.txtDeletedSearch.Location = new System.Drawing.Point(206, 76);
            this.txtDeletedSearch.Name = "txtDeletedSearch";
            this.txtDeletedSearch.Size = new System.Drawing.Size(244, 29);
            this.txtDeletedSearch.TabIndex = 2;
            // 
            // grdDeletedList
            // 
            this.grdDeletedList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDeletedList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdDeletedList.BackgroundColor = System.Drawing.Color.White;
            this.grdDeletedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDeletedList.Location = new System.Drawing.Point(22, 166);
            this.grdDeletedList.Name = "grdDeletedList";
            this.grdDeletedList.RowTemplate.Height = 25;
            this.grdDeletedList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDeletedList.Size = new System.Drawing.Size(428, 128);
            this.grdDeletedList.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bulunan Ürünler : ";
            // 
            // btnDeleted
            // 
            this.btnDeleted.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeleted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleted.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnDeleted.FlatAppearance.BorderSize = 3;
            this.btnDeleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleted.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleted.ForeColor = System.Drawing.Color.White;
            this.btnDeleted.Location = new System.Drawing.Point(300, 324);
            this.btnDeleted.Name = "btnDeleted";
            this.btnDeleted.Size = new System.Drawing.Size(150, 40);
            this.btnDeleted.TabIndex = 4;
            this.btnDeleted.Text = "ÜRÜNÜ BUL";
            this.btnDeleted.UseVisualStyleBackColor = false;
            this.btnDeleted.Click += new System.EventHandler(this.btnDeleted_Click);
            // 
            // btnselectdel
            // 
            this.btnselectdel.BackColor = System.Drawing.Color.Firebrick;
            this.btnselectdel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnselectdel.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnselectdel.FlatAppearance.BorderSize = 3;
            this.btnselectdel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnselectdel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnselectdel.ForeColor = System.Drawing.Color.White;
            this.btnselectdel.Location = new System.Drawing.Point(22, 324);
            this.btnselectdel.Name = "btnselectdel";
            this.btnselectdel.Size = new System.Drawing.Size(256, 40);
            this.btnselectdel.TabIndex = 4;
            this.btnselectdel.Text = "BULUNAN ÜRÜNÜ SİL";
            this.btnselectdel.UseVisualStyleBackColor = false;
            this.btnselectdel.Click += new System.EventHandler(this.btnselectdel_Click);
            // 
            // DeleteProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(479, 392);
            this.Controls.Add(this.btnselectdel);
            this.Controls.Add(this.btnDeleted);
            this.Controls.Add(this.grdDeletedList);
            this.Controls.Add(this.txtDeletedSearch);
            this.Controls.Add(this.cbbDeletedSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeleteProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ÜRÜN SİL";
            this.Load += new System.EventHandler(this.DeleteProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDeletedList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cbbDeletedSearch;
        private Label label2;
        private TextBox txtDeletedSearch;
        private DataGridView grdDeletedList;
        private Label label3;
        private Button btnDeleted;
        private Button btnselectdel;
    }
}