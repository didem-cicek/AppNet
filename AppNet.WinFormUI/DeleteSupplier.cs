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
            btnSearchDelete.Visible = false;
            cbbDeletedSearch.Items.Clear();
            cbbDeletedSearch.Items.Add("Tedarikçi ID'sine Göre");
            cbbDeletedSearch.Items.Add("Tedarikçi Adına Göre");
            cbbDeletedSearch.SelectedIndex = 0;
        }

        private async void btnDeleted_Click(object sender, EventArgs e)
        {
            var list = (await ss.GetAll()).ToList();
            if (cbbDeletedSearch.SelectedItem == "Tedarikçi ID'sine Göre")
            {
                try
                {
                    var gridList = (from q in list
                                    where q.SupplierID == Convert.ToInt32(txtDeletedSearch.Text)
                                    select new
                                    {
                                        ID = q.SupplierID,
                                        TedarikçiAdı = q.SupplierName
                                    }).ToList();
                    grdDeletedList.DataSource = gridList;
                    btnSearchDelete.Visible = true;
                }
                catch (Exception ex)
                {
                    DialogResult dialogResult = MessageBox.Show("Yazdığınız arama kelimesinde sorun bulundu, lütfen kontrol ediniz!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else if (cbbDeletedSearch.SelectedItem == "Tedarikçi Adına Göre")
            {
                try
                {
                    var gridList = (from q in list
                                    where q.SupplierName == txtDeletedSearch.Text
                                    select new
                                    {
                                        ID = q.SupplierID,
                                        TedarikçiAdı = q.SupplierName
                                    }).ToList();
                    grdDeletedList.DataSource = gridList;
                    btnSearchDelete.Visible = true;
                }
                catch (Exception ex)
                {
                    DialogResult dialogResult = MessageBox.Show("Yazdığınız arama kelimesinde sorun bulundu, lütfen kontrol ediniz!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Aradığınız tedarikçi bulunamamıştır!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

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
    }
}
