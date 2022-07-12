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
            this.label2 = new System.Windows.Forms.Label();
            this.txtDeletedSearch = new System.Windows.Forms.TextBox();
            this.grdDeletedList = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnselectdel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdDeletedList)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Aranacak Kelime : ";
            // 
            // txtDeletedSearch
            // 
            this.txtDeletedSearch.Location = new System.Drawing.Point(206, 24);
            this.txtDeletedSearch.Name = "txtDeletedSearch";
            this.txtDeletedSearch.Size = new System.Drawing.Size(244, 29);
            this.txtDeletedSearch.TabIndex = 1;
            this.txtDeletedSearch.TextChanged += new System.EventHandler(this.txtDeletedSearch_TextChanged);
            // 
            // grdDeletedList
            // 
            this.grdDeletedList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDeletedList.BackgroundColor = System.Drawing.Color.White;
            this.grdDeletedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDeletedList.Location = new System.Drawing.Point(22, 106);
            this.grdDeletedList.Name = "grdDeletedList";
            this.grdDeletedList.RowTemplate.Height = 25;
            this.grdDeletedList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDeletedList.Size = new System.Drawing.Size(428, 188);
            this.grdDeletedList.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bulunan Ürünler : ";
            // 
            // btnselectdel
            // 
            this.btnselectdel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btnselectdel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnselectdel.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnselectdel.FlatAppearance.BorderSize = 0;
            this.btnselectdel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnselectdel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnselectdel.ForeColor = System.Drawing.Color.White;
            this.btnselectdel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnselectdel.ImageKey = "deleted.png";
            this.btnselectdel.Location = new System.Drawing.Point(284, 316);
            this.btnselectdel.Name = "btnselectdel";
            this.btnselectdel.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnselectdel.Size = new System.Drawing.Size(166, 40);
            this.btnselectdel.TabIndex = 3;
            this.btnselectdel.Text = "SEÇİLENİ SİL";
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
            this.Controls.Add(this.grdDeletedList);
            this.Controls.Add(this.txtDeletedSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
        private Label label2;
        private TextBox txtDeletedSearch;
        private DataGridView grdDeletedList;
        private Label label3;
        private Button btnselectdel;
    }
}