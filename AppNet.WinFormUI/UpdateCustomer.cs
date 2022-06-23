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
    public partial class UpdateCustomer : Form
    {
        private readonly ICustomerService cs;
        public UpdateCustomer(ICustomerService cs)
        {
            InitializeComponent();
            this.cs = cs;
        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {
            cbbUpdateCustomer.Items.Clear();
            cbbUpdateCustomer.Items.Add("Müşteri ID'sine Göre");
            cbbUpdateCustomer.Items.Add("Müşteri Adına Göre");
            cbbUpdateCustomer.SelectedIndex = 0;
        }

        private async void btnSearchUpdate_Click(object sender, EventArgs e)
        {
            var customer = (await cs.GetAll()).ToList();
            if (cbbUpdateCustomer.SelectedItem == "Müşteri ID'sine Göre")
            {
                try
                {
                    var gridList = (from q in customer
                                    where q.CustomerID == Convert.ToInt32(txtUpdateCustomerSearch.Text)
                                    select new
                                    {
                                        ID = q.CustomerID,
                                        MüşteriAdı = q.CustomerName,
                                    }).ToList();
                    grdUpdateCustomerList.DataSource = gridList;
                }
                catch
                {
                    DialogResult dialogResult = MessageBox.Show("Yazdığınız arama kelimesinde sorun bulundu, lütfen kontrol ediniz!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }else if(cbbUpdateCustomer.SelectedItem == "Müşteri Adına Göre")
            {
                try
                {
                    var gridList = (from q in customer
                                    where q.CustomerName == txtUpdateCustomerSearch.Text
                                    select new
                                    {
                                        ID = q.CustomerID,
                                        MüşteriAdı = q.CustomerName,
                                    }).ToList();
                    grdUpdateCustomerList.DataSource = gridList;
                }
                catch
                {
                    DialogResult dialogResult = MessageBox.Show("Yazdığınız arama kelimesinde sorun bulundu, lütfen kontrol ediniz!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Aradığınız müşteri bulunamamıştır!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdatedCustomer_Click(object sender, EventArgs e)
        {
            cs.Update(Convert.ToInt32(grdUpdateCustomerList.CurrentRow.Cells[0].Value), txtUpdateCustomerName.Text, txtUpdateCustomerPhone.Text, txtUpdateCustomerEmail.Text, txtUpdateCustomerAddress.Text, txtUpdateCustomerShippingAddress.Text, Convert.ToInt32(txtUpdateCustomerTaxNo.Text), txtUpdateCustomerTaxOffice.Text, txtUpdateCustomerDesriciption.Text);
            DialogResult result = MessageBox.Show("Müşteri başarıyla güncellenmiştir.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cbbUpdateCustomer.Items.Clear();
            txtUpdateCustomerName.Text = "";
            txtUpdateCustomerPhone.Text = "";
            txtUpdateCustomerEmail.Text = "";
            txtUpdateCustomerDesriciption.Text = "";
            txtUpdateCustomerAddress.Text = "";
            txtUpdateCustomerShippingAddress.Text = "";
            txtUpdateCustomerTaxNo.Text = "";
            txtUpdateCustomerTaxOffice.Text = "";
            grdUpdateCustomerList.DataSource = null;
            grdUpdateCustomerList.Refresh();
            this.Close();
        }
    }
}
