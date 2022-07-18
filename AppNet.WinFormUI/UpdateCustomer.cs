using AppNet.AppService;
using AppNet.Domain.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        private async void btnUpdatedCustomer_Click(object sender, EventArgs e)
        {
            var Müşteri_Adı = txtUpdateCustomerName.Text;
            var Telefon_Numarası = txtUpdateCustomerPhone.Text;
            var Mail_Adresi = txtUpdateCustomerEmail.Text;
            var Adres = txtUpdateCustomerAddress.Text;
            var Sevk_Adresi = txtUpdateCustomerShippingAddress.Text;
            var Vergi_Numarası = txtUpdateCustomerTaxNo.Text;
            var Vergi_Dairesi = txtUpdateCustomerTaxOffice.Text;
            try
            {
                Müşteri_Adı.NullOrEmpty(nameof(Müşteri_Adı));
                Telefon_Numarası.NullOrEmpty(nameof(Telefon_Numarası));
                Mail_Adresi.NullOrEmpty(nameof(Mail_Adresi));
                Adres.NullOrEmpty(nameof(Adres));
                Sevk_Adresi.NullOrEmpty(nameof(Sevk_Adresi));
                Vergi_Numarası.NullOrEmpty(nameof(Telefon_Numarası));
                Vergi_Dairesi.NullOrEmpty(nameof(Vergi_Dairesi));
                try
                {
                    var c = (await cs.GetAll()).ToList();
                    decimal debt = 0;
                    decimal receivable = 0;
                    foreach (var item in c)
                    {
                        if (item.CustomerID == Convert.ToInt32(grdUpdateCustomerList.CurrentRow.Cells[0].Value)) { 
                        debt = item.CustomerDebt;
                        receivable = item.CustomerReceivable;}
                    }

                    cs.Update(Convert.ToInt32(grdUpdateCustomerList.CurrentRow.Cells[0].Value), txtUpdateCustomerName.Text, txtUpdateCustomerPhone.Text, txtUpdateCustomerEmail.Text, txtUpdateCustomerAddress.Text, txtUpdateCustomerShippingAddress.Text, Convert.ToInt32(txtUpdateCustomerTaxNo.Text), txtUpdateCustomerTaxOffice.Text, txtUpdateCustomerDesriciption.Text, debt, receivable);
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
                catch
                {
                    DialogResult dialogResult = MessageBox.Show("Bilinmeyen bir hata oluştu, güncelleme işleminiz başarız!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (ArgumentNullException ex)
            {
                DialogResult dialogResult = MessageBox.Show($" {ex.ParamName} alanı boş bırakamazsınız!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
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

        private void txtUpdateCustomerPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtUpdateCustomerName_TextChanged(object sender, EventArgs e)
        {
            txtUpdateCustomerName.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtUpdateCustomerName.Text);
            txtUpdateCustomerName.SelectionStart = txtUpdateCustomerName.Text.Length;
        }

        private void txtUpdateCustomerEmail_TextChanged(object sender, EventArgs e)
        {
            txtUpdateCustomerEmail.Text = txtUpdateCustomerEmail.Text.ToLower();
            txtUpdateCustomerEmail.SelectionStart = txtUpdateCustomerEmail.Text.Length;
        }

        private void txtUpdateCustomerAddress_TextChanged(object sender, EventArgs e)
        {
            txtUpdateCustomerAddress.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtUpdateCustomerAddress.Text);
            txtUpdateCustomerAddress.SelectionStart = txtUpdateCustomerAddress.Text.Length;
        }

        private void txtUpdateCustomerShippingAddress_TextChanged(object sender, EventArgs e)
        {
            txtUpdateCustomerShippingAddress.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtUpdateCustomerShippingAddress.Text);
            txtUpdateCustomerShippingAddress.SelectionStart = txtUpdateCustomerShippingAddress.Text.Length;
        }

        private void txtUpdateCustomerTaxNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtUpdateCustomerTaxOffice_TextChanged(object sender, EventArgs e)
        {
            txtUpdateCustomerTaxOffice.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtUpdateCustomerTaxOffice.Text);
            txtUpdateCustomerTaxOffice.SelectionStart = txtUpdateCustomerTaxOffice.Text.Length;
        }

        private void txtUpdateCustomerDesriciption_TextChanged(object sender, EventArgs e)
        {
            txtUpdateCustomerDesriciption.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtUpdateCustomerDesriciption.Text);
            txtUpdateCustomerDesriciption.SelectionStart = txtUpdateCustomerDesriciption.Text.Length;
        }
    }
}
