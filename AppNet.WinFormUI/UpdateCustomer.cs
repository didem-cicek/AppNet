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
         
        }

        private async void btnSearchUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdatedCustomer_Click(object sender, EventArgs e)
        {
            cs.Update(Convert.ToInt32(grdUpdateCustomerList.CurrentRow.Cells[0].Value), txtUpdateCustomerName.Text, txtUpdateCustomerPhone.Text, txtUpdateCustomerEmail.Text, txtUpdateCustomerAddress.Text, txtUpdateCustomerShippingAddress.Text, Convert.ToInt32(txtUpdateCustomerTaxNo.Text), txtUpdateCustomerTaxOffice.Text, txtUpdateCustomerDesriciption.Text);
            DialogResult result = MessageBox.Show("Müşteri başarıyla güncellenmiştir.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtUpdateCustomerName.Text = "";
            txtUpdateCustomerPhone.Text = "";
            txtUpdateCustomerEmail.Text = "";
            txtUpdateCustomerDesriciption.Text = "";
            txtUpdateCustomerAddress.Text = "";
            txtUpdateCustomerShippingAddress.Text = "";
            txtUpdateCustomerTaxNo.Text = "";
            txtUpdateCustomerTaxOffice.Text = "";
            txtUpdateCustomerSearch.Text = "";
            grdUpdateCustomerList.DataSource = null;
            grdUpdateCustomerList.Refresh();
            this.Close();
        }

        private async void txtUpdateCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var customer = (await cs.GetAll()).ToList();
                var find = (from q in customer
                            where q.CustomerName.ToLower().Contains((txtUpdateCustomerSearch.Text).ToLower())
                            orderby q.CustomerName ascending
                            select new
                            {
                                ID = q.CustomerID,
                                MüşteriAdı = q.CustomerName,
                                Telefon = q.CustomerPhone,
                                Mail = q.CustomerEmail,
                                Adres = q.CustomerAddress,
                                Sevk = q.CustomerShippingAddress,
                                VergiNo=q.CustomerTaxNumber,
                                VergiDairesi = q.CustomerTaxOffice,
                                Aciklama = q.CustomerDesription,
                            }).ToList();
                grdUpdateCustomerList.DataSource = find;

            }
            catch
            {
                DialogResult dialogResult = MessageBox.Show("Aradığınız ürün bulunamamıştır!", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void grdUpdateCustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUpdateCustomerName.Text = grdUpdateCustomerList.CurrentRow.Cells[1].Value.ToString();
            txtUpdateCustomerPhone.Text = grdUpdateCustomerList.CurrentRow.Cells[2].Value.ToString();
            txtUpdateCustomerEmail.Text = grdUpdateCustomerList.CurrentRow.Cells[3].Value.ToString();
            txtUpdateCustomerAddress.Text = grdUpdateCustomerList.CurrentRow.Cells[4].Value.ToString();
            txtUpdateCustomerShippingAddress.Text = grdUpdateCustomerList.CurrentRow.Cells[5].Value.ToString();
            txtUpdateCustomerTaxNo.Text = grdUpdateCustomerList.CurrentRow.Cells[6].Value.ToString();
            txtUpdateCustomerTaxOffice.Text = grdUpdateCustomerList.CurrentRow.Cells[7].Value.ToString();
            txtUpdateCustomerDesriciption.Text = grdUpdateCustomerList.CurrentRow.Cells[8].Value.ToString();
        }
    }
}
