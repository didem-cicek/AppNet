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
    public partial class DeleteSale : Form
    {
        private readonly ISalesService ss;
        public DeleteSale()
        {
            InitializeComponent();
            this.ss = ss;
        }

        private void DeleteSale_Load(object sender, EventArgs e)
        {
           
        }

        private async void btnDeleted_Click(object sender, EventArgs e)
        {
            
        }

        private void btnsearchdelete_Click(object sender, EventArgs e)
        {
            DialogResult question = MessageBox.Show("Bulunan siparişi silmek istediğinize emin misiniz?", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (question == DialogResult.Yes)
            {
                ss.Remove(Convert.ToInt32(grdDeletedList.CurrentRow.Cells[0].Value));
                DialogResult result = MessageBox.Show("Sipariş başarıyla silinmiştir.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtDeletedSearch.Text = "";
            this.Close();
            grdDeletedList.DataSource = null;
            grdDeletedList.Refresh();
        }

        private async void txtDeletedSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var list = (await ss.GetAll()).ToList();
                var gridList = (from q in list
                                where q.Customer.CustomerName.ToLower().Contains((txtDeletedSearch.Text).ToLower())
                                orderby q.Customer.CustomerName ascending
                                select new
                                {
                                    ID = q.SaleID,
                                    MüşteriAdı = q.Customer.CustomerName,
                                }).ToList();
                grdDeletedList.DataSource = gridList;

            }
            catch
            {
                DialogResult dialogResult = MessageBox.Show("Aradığınız ürün bulunamamıştır!", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
