using AppNet.AppService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppNet.WinFormUI
{
    public partial class DeleteStock : Form
    {
        private readonly IStockService ss;
        public DeleteStock()
        {
            InitializeComponent();
            this.ss = ss;
        }

        private void DeleteStock_Load(object sender, EventArgs e)
        {
            
        }

        private async void btnDeleted_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSearchDelete_Click(object sender, EventArgs e)
        {
            DialogResult question = MessageBox.Show("Bulunan stoğu silmek istediğinize emin misiniz?", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (question == DialogResult.Yes)
            {
                ss.Remove(Convert.ToInt32(grdDeleteStockList.CurrentRow.Cells[0].Value));
                DialogResult result = MessageBox.Show("Stok başarıyla silinmiştir.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtDeleteStockSearch.Text = "";
            this.Close();
            grdDeleteStockList.DataSource = null;
            grdDeleteStockList.Refresh();
        }

        private async void txtDeleteStockSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var list = (await ss.GetAll()).ToList();
                var gridList = (from q in list
                                where q.Supplier.SupplierName.ToLower().Contains((txtDeleteStockSearch.Text).ToLower())
                                orderby q.Supplier.SupplierName ascending
                                select new
                                {
                                    ID = q.SupplierID,
                                    TedarikçiAdı = q.Supplier.SupplierName,
                                }).ToList();
                grdDeleteStockList.DataSource = gridList;

            }
            catch
            {
                DialogResult dialogResult = MessageBox.Show("Aradığınız tedarikçi bulunamamıştır!", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
