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
            this.grdDeletedList = new System.Windows.Forms.DataGridView();
            this.txtDeletedSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsearchdelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdDeletedList)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDeletedList
            // 
            this.grdDeletedList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDeletedList.BackgroundColor = System.Drawing.Color.White;
            this.grdDeletedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDeletedList.Location = new System.Drawing.Point(23, 111);
            this.grdDeletedList.Name = "grdDeletedList";
            this.grdDeletedList.RowTemplate.Height = 25;
            this.grdDeletedList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDeletedList.Size = new System.Drawing.Size(428, 189);
            this.grdDeletedList.TabIndex = 3;
            // 
            // txtDeletedSearch
            // 
            this.txtDeletedSearch.Location = new System.Drawing.Point(207, 21);
            this.txtDeletedSearch.Name = "txtDeletedSearch";
            this.txtDeletedSearch.Size = new System.Drawing.Size(244, 29);
            this.txtDeletedSearch.TabIndex = 2;
            this.txtDeletedSearch.TextChanged += new System.EventHandler(this.txtDeletedSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bulunan Ürünler : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Aranacak Kelime : ";
            // 
            // btnsearchdelete
            // 
            this.btnsearchdelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btnsearchdelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsearchdelete.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnsearchdelete.FlatAppearance.BorderSize = 0;
            this.btnsearchdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearchdelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsearchdelete.ForeColor = System.Drawing.Color.White;
            this.btnsearchdelete.Location = new System.Drawing.Point(299, 329);
            this.btnsearchdelete.Name = "btnsearchdelete";
            this.btnsearchdelete.Size = new System.Drawing.Size(152, 40);
            this.btnsearchdelete.TabIndex = 4;
            this.btnsearchdelete.Text = "SEÇİLENİ SİL";
            this.btnsearchdelete.UseVisualStyleBackColor = false;
            this.btnsearchdelete.Visible = false;
            this.btnsearchdelete.Click += new System.EventHandler(this.btnsearchdelete_Click);
            // 
            // DeleteSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(479, 392);
            this.Controls.Add(this.btnsearchdelete);
            this.Controls.Add(this.grdDeletedList);
            this.Controls.Add(this.txtDeletedSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
        private DataGridView grdDeletedList;
        private TextBox txtDeletedSearch;
        private Label label3;
        private Label label2;
        private Button btnsearchdelete;
    }
}