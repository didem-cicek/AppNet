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
    public partial class DeleteSupplier : Form
    {
        private readonly ISupplierService ss;
        public DeleteSupplier(ISupplierService ss)
        {
            InitializeComponent();
            this.ss = ss;
        }

        private void DeleteSupplier_Load(object sender, EventArgs e)
        {
            
        }

        private async void btnDeleted_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchDelete_Click(object sender, EventArgs e)
        {
            DialogResult question = MessageBox.Show("Bulunan tedarikçiyi silmek istediğinize emin misiniz?", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (question == DialogResult.Yes)
            {
                ss.Remove(Convert.ToInt32(grdDeletedList.CurrentRow.Cells[0].Value));
                DialogResult result = MessageBox.Show("Tedarikçi başarıyla silinmiştir.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                where q.SupplierName.ToLower().Contains((txtDeletedSearch.Text).ToLower())
                                orderby q.SupplierName ascending
                                select new
                                {
                                    ID = q.SupplierID,
                                    TedarikçiAdı = q.SupplierName,
                                }).ToList();
                grdDeletedList.DataSource = gridList;

            }
            catch
            {
                DialogResult dialogResult = MessageBox.Show("Aradığınız tedarikçi bulunamamıştır!", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
