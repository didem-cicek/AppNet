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
    public partial class DeleteCustomer : Form
    {
        private readonly ICustomerService cs;
        public DeleteCustomer(ICustomerService cs)
        {
            InitializeComponent();
            this.cs = cs;
        }

        private async void btnDeleted_Click(object sender, EventArgs e)
        {
            var list = (await cs.GetAll()).ToList();
            if (cbbDeleteCustomerSearch.SelectedItem == "Müşteri ID'sine Göre")
            {
                try
                {
                    var gridList = (from q in list
                                    where q.CustomerID == Convert.ToInt32(txtDeleteCustomerSearch.Text)
                                    select new
                                    {
                                        ID = q.CustomerID,
                                        MüşteriAdı = q.CustomerName
                                    }).ToList();
                    grdDeleteCustomerList.DataSource = gridList;
                    btncustomerDelete.Visible = true;
                }
                catch (Exception ex)
                {
                    DialogResult dialogResult = MessageBox.Show("Yazdığınız arama kelimesinde sorun bulundu, lütfen kontrol ediniz!", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            else if (cbbDeleteCustomerSearch.SelectedItem == "Müşteri Adına Göre")
            {
                try
                {
                    var gridList = (from q in list
                                    where q.CustomerName == txtDeleteCustomerSearch.Text
                                    select new
                                    {
                                        ID = q.CustomerID,
                                        ÜrünAdı = q.CustomerName
                                    }).ToList();
                    grdDeleteCustomerList.DataSource = gridList;
                    btncustomerDelete.Visible = true;
                }
                catch (Exception ex)
                {
                    DialogResult dialogResult = MessageBox.Show("Yazdığınız arama kelimesinde sorun bulundu, lütfen kontrol ediniz!", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Aradığınız müşteri bulunamamıştır!", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteCustomer_Load(object sender, EventArgs e)
        {
            btncustomerDelete.Visible = false;
            cbbDeleteCustomerSearch.Items.Clear();
            cbbDeleteCustomerSearch.Items.Add("Müşteri ID'sine Göre");
            cbbDeleteCustomerSearch.Items.Add("Müşteri Adına Göre");
            cbbDeleteCustomerSearch.SelectedIndex = 0;
        }

        private void btncustomerDelete_Click(object sender, EventArgs e)
        {
            DialogResult question = MessageBox.Show("Bulunan müşteriyi silmek istediğinize emin misiniz?", "Bilgilendirme Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (question == DialogResult.Yes)
            {
                cs.Remove(Convert.ToInt32(grdDeleteCustomerList.CurrentRow.Cells[0].Value));
                DialogResult result = MessageBox.Show("Müşteri başarıyla silinmiştir.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtDeleteCustomerSearch.Text = "";
            this.Close();
            grdDeleteCustomerList.DataSource = null;
            grdDeleteCustomerList.Refresh();
        }
    }
}
