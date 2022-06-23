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
            btnsearchdelete.Visible = false;
            cbbDeletedSearch.Items.Clear();
            cbbDeletedSearch.Items.Add("Sipariş ID'sine Göre");
            cbbDeletedSearch.Items.Add("Müşteri Adına Göre");
            cbbDeletedSearch.SelectedIndex = 0;
        }

        private async void btnDeleted_Click(object sender, EventArgs e)
        {
            var list = (await ss.GetAll()).ToList();
            if (cbbDeletedSearch.SelectedItem == "Sipariş ID'sine Göre")
            {
                try
                {
                    var gridList = (from q in list
                                    where q.SaleID == Convert.ToInt32(txtDeletedSearch.Text)
                                    select new
                                    {
                                        ID = q.SaleID,
                                        MüşteriAdı = q.CustomerName
                                    }).ToList();
                    grdDeletedList.DataSource = gridList;
                    btnsearchdelete.Visible = true;
                }
                catch (Exception ex)
                {
                    DialogResult dialogResult = MessageBox.Show("Yazdığınız arama kelimesinde sorun bulundu, lütfen kontrol ediniz!", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            else if (cbbDeletedSearch.SelectedItem == "Müşteri Adına Göre")
            {
                try
                {
                    var gridList = (from q in list
                                    where q.CustomerName == txtDeletedSearch.Text
                                    select new
                                    {
                                        ID = q.SaleID,
                                        MüşteriAdı = q.CustomerName
                                    }).ToList();
                    grdDeletedList.DataSource = gridList;
                    btnsearchdelete.Visible = true;
                }
                catch (Exception ex)
                {
                    DialogResult dialogResult = MessageBox.Show("Yazdığınız arama kelimesinde sorun bulundu, lütfen kontrol ediniz!", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Aradığınız sipariş bulunamamıştır!", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
    }
}
