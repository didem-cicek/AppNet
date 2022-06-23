namespace AppNet.WinFormUI
{
    partial class DeleteStock
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
            this.grdDeleteStockList = new System.Windows.Forms.DataGridView();
            this.txtDeleteStockSearch = new System.Windows.Forms.TextBox();
            this.cbbDeleteStockSearch = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdDeleteStockList)).BeginInit();
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
            this.btnDeleted.TabIndex = 11;
            this.btnDeleted.Text = "STOK BUL";
            this.btnDeleted.UseVisualStyleBackColor = false;
            this.btnDeleted.Click += new System.EventHandler(this.btnDeleted_Click);
            // 
            // grdDeleteStockList
            // 
            this.grdDeleteStockList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDeleteStockList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdDeleteStockList.BackgroundColor = System.Drawing.Color.White;
            this.grdDeleteStockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDeleteStockList.Location = new System.Drawing.Point(25, 167);
            this.grdDeleteStockList.Name = "grdDeleteStockList";
            this.grdDeleteStockList.RowTemplate.Height = 25;
            this.grdDeleteStockList.Size = new System.Drawing.Size(428, 128);
            this.grdDeleteStockList.TabIndex = 10;
            // 
            // txtDeleteStockSearch
            // 
            this.txtDeleteStockSearch.Location = new System.Drawing.Point(209, 77);
            this.txtDeleteStockSearch.Name = "txtDeleteStockSearch";
            this.txtDeleteStockSearch.Size = new System.Drawing.Size(244, 23);
            this.txtDeleteStockSearch.TabIndex = 9;
            // 
            // cbbDeleteStockSearch
            // 
            this.cbbDeleteStockSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDeleteStockSearch.FormattingEnabled = true;
            this.cbbDeleteStockSearch.Location = new System.Drawing.Point(209, 27);
            this.cbbDeleteStockSearch.Name = "cbbDeleteStockSearch";
            this.cbbDeleteStockSearch.Size = new System.Drawing.Size(244, 23);
            this.cbbDeleteStockSearch.TabIndex = 8;
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
            // btnSearchDelete
            // 
            this.btnSearchDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnSearchDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchDelete.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnSearchDelete.FlatAppearance.BorderSize = 3;
            this.btnSearchDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchDelete.ForeColor = System.Drawing.Color.White;
            this.btnSearchDelete.Location = new System.Drawing.Point(25, 325);
            this.btnSearchDelete.Name = "btnSearchDelete";
            this.btnSearchDelete.Size = new System.Drawing.Size(235, 40);
            this.btnSearchDelete.TabIndex = 11;
            this.btnSearchDelete.Text = "BULUNAN STOĞU SİL";
            this.btnSearchDelete.UseVisualStyleBackColor = false;
            this.btnSearchDelete.Click += new System.EventHandler(this.btnSearchDelete_Click);
            // 
            // DeleteStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(479, 392);
            this.Controls.Add(this.btnSearchDelete);
            this.Controls.Add(this.btnDeleted);
            this.Controls.Add(this.grdDeleteStockList);
            this.Controls.Add(this.txtDeleteStockSearch);
            this.Controls.Add(this.cbbDeleteStockSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeleteStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STOK SİL";
            this.Load += new System.EventHandler(this.DeleteStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDeleteStockList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDeleted;
        private DataGridView grdDeleteStockList;
        private TextBox txtDeleteStockSearch;
        private ComboBox cbbDeleteStockSearch;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSearchDelete;
    }
}