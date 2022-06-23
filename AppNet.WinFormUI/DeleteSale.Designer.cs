namespace AppNet.WinFormUI
{
    partial class DeleteSale
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
            this.btnDeleted = new System.Windows.Forms.Button();
            this.grdDeletedList = new System.Windows.Forms.DataGridView();
            this.txtDeletedSearch = new System.Windows.Forms.TextBox();
            this.cbbDeletedSearch = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsearchdelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdDeletedList)).BeginInit();
            this.SuspendLayout();
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
            this.btnDeleted.Location = new System.Drawing.Point(303, 325);
            this.btnDeleted.Name = "btnDeleted";
            this.btnDeleted.Size = new System.Drawing.Size(150, 40);
            this.btnDeleted.TabIndex = 4;
            this.btnDeleted.Text = "SİPARİŞ BUL";
            this.btnDeleted.UseVisualStyleBackColor = false;
            this.btnDeleted.Click += new System.EventHandler(this.btnDeleted_Click);
            // 
            // grdDeletedList
            // 
            this.grdDeletedList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDeletedList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdDeletedList.BackgroundColor = System.Drawing.Color.White;
            this.grdDeletedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDeletedList.Location = new System.Drawing.Point(25, 167);
            this.grdDeletedList.Name = "grdDeletedList";
            this.grdDeletedList.RowTemplate.Height = 25;
            this.grdDeletedList.Size = new System.Drawing.Size(428, 128);
            this.grdDeletedList.TabIndex = 3;
            // 
            // txtDeletedSearch
            // 
            this.txtDeletedSearch.Location = new System.Drawing.Point(209, 77);
            this.txtDeletedSearch.Name = "txtDeletedSearch";
            this.txtDeletedSearch.Size = new System.Drawing.Size(244, 29);
            this.txtDeletedSearch.TabIndex = 2;
            // 
            // cbbDeletedSearch
            // 
            this.cbbDeletedSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDeletedSearch.FormattingEnabled = true;
            this.cbbDeletedSearch.Location = new System.Drawing.Point(209, 27);
            this.cbbDeletedSearch.Name = "cbbDeletedSearch";
            this.cbbDeletedSearch.Size = new System.Drawing.Size(244, 29);
            this.cbbDeletedSearch.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bulunan Ürünler : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Aranacak Kelime : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kriter Seçiniz : ";
            // 
            // btnsearchdelete
            // 
            this.btnsearchdelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnsearchdelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsearchdelete.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnsearchdelete.FlatAppearance.BorderSize = 3;
            this.btnsearchdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearchdelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsearchdelete.ForeColor = System.Drawing.Color.White;
            this.btnsearchdelete.Location = new System.Drawing.Point(25, 325);
            this.btnsearchdelete.Name = "btnsearchdelete";
            this.btnsearchdelete.Size = new System.Drawing.Size(246, 40);
            this.btnsearchdelete.TabIndex = 4;
            this.btnsearchdelete.Text = "BULUNAN SİPARİŞİ SİL";
            this.btnsearchdelete.UseVisualStyleBackColor = false;
            this.btnsearchdelete.Click += new System.EventHandler(this.btnsearchdelete_Click);
            // 
            // DeleteSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(479, 392);
            this.Controls.Add(this.btnsearchdelete);
            this.Controls.Add(this.btnDeleted);
            this.Controls.Add(this.grdDeletedList);
            this.Controls.Add(this.txtDeletedSearch);
            this.Controls.Add(this.cbbDeletedSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeleteSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SİPARİŞ SİL";
            this.Load += new System.EventHandler(this.DeleteSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDeletedList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDeleted;
        private DataGridView grdDeletedList;
        private TextBox txtDeletedSearch;
        private ComboBox cbbDeletedSearch;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnsearchdelete;
    }
}