namespace AppNet.WinFormUI
{
    partial class DeleteSupplier
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
            this.btnSearchDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdDeletedList)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDeletedList
            // 
            this.grdDeletedList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDeletedList.BackgroundColor = System.Drawing.Color.White;
            this.grdDeletedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDeletedList.Location = new System.Drawing.Point(25, 118);
            this.grdDeletedList.Name = "grdDeletedList";
            this.grdDeletedList.RowTemplate.Height = 25;
            this.grdDeletedList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDeletedList.Size = new System.Drawing.Size(428, 182);
            this.grdDeletedList.TabIndex = 10;
            // 
            // txtDeletedSearch
            // 
            this.txtDeletedSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDeletedSearch.Location = new System.Drawing.Point(209, 21);
            this.txtDeletedSearch.Name = "txtDeletedSearch";
            this.txtDeletedSearch.Size = new System.Drawing.Size(244, 29);
            this.txtDeletedSearch.TabIndex = 9;
            this.txtDeletedSearch.TextChanged += new System.EventHandler(this.txtDeletedSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.label3.Location = new System.Drawing.Point(25, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bulunan Tedarikçi : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Aranacak Kelime : ";
            // 
            // btnSearchDelete
            // 
            this.btnSearchDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(99)))), ((int)(((byte)(223)))));
            this.btnSearchDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchDelete.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnSearchDelete.FlatAppearance.BorderSize = 0;
            this.btnSearchDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchDelete.ForeColor = System.Drawing.Color.White;
            this.btnSearchDelete.Location = new System.Drawing.Point(298, 327);
            this.btnSearchDelete.Name = "btnSearchDelete";
            this.btnSearchDelete.Size = new System.Drawing.Size(155, 40);
            this.btnSearchDelete.TabIndex = 11;
            this.btnSearchDelete.Text = "SEÇİLENİ SİL";
            this.btnSearchDelete.UseVisualStyleBackColor = false;
            this.btnSearchDelete.Click += new System.EventHandler(this.btnSearchDelete_Click);
            // 
            // DeleteSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(479, 392);
            this.Controls.Add(this.btnSearchDelete);
            this.Controls.Add(this.grdDeletedList);
            this.Controls.Add(this.txtDeletedSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "DeleteSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TEDARİKÇİ SİL";
            this.Load += new System.EventHandler(this.DeleteSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDeletedList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView grdDeletedList;
        private TextBox txtDeletedSearch;
        private Label label3;
        private Label label2;
        private Button btnSearchDelete;
    }
}