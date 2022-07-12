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
    public partial class AddCustomer : Form
    {
        private readonly IServiceProvider sp;
        private readonly ICustomerService cs;
        public AddCustomer(IServiceProvider sp, ICustomerService cs)
        {
            InitializeComponent();
            this.sp = sp;
            this.cs = cs;
        }

        private void txtAddCustomerDesriciption_TextChanged(object sender, EventArgs e)
        {
            txtAddCustomerDesriciption.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtAddCustomerDesriciption.Text);
            txtAddCustomerDesriciption.SelectionStart = txtAddCustomerDesriciption.Text.Length;
        }

        private async void btnAddCustomer_Click(object sender, EventArgs e)
        {
            var Müşteri_Adı = txtAddCustomerName.Text;
            var Telefon_Numarası = txtAddCustomerPhone.Text;
            var Mail_Adresi = txtAddCustomerEmail.Text;
            var Adres = txtAddCustomerAddress.Text;
            var Sevk_Adresi = txtAddCustomerShippingAddress.Text;
            var Vergi_Numarası = txtAddCustomerTaxNo.Text;
            var Vergi_Dairesi = txtAddCustomerTaxOffice.Text;
            try
            {
                Müşteri_Adı.NullOrEmpty(nameof(Müşteri_Adı));
                Telefon_Numarası.NullOrEmpty(nameof(Telefon_Numarası));
                Mail_Adresi.NullOrEmpty(nameof(Mail_Adresi));
                Adres.NullOrEmpty(nameof(Adres));
                Sevk_Adresi.NullOrEmpty(nameof(Sevk_Adresi));
                Vergi_Numarası.NullOrEmpty(nameof(Vergi_Numarası));
                Vergi_Dairesi.NullOrEmpty(nameof(Vergi_Dairesi));

                try
                {
                    var list = (await cs.GetAll()).ToList();
                    var find = list.FirstOrDefault(u => u.CustomerPhone == txtAddCustomerPhone.Text.ToLower());
                    if (find == null)
                    {
                        cs.Add(txtAddCustomerName.Text, txtAddCustomerPhone.Text, txtAddCustomerEmail.Text, txtAddCustomerAddress.Text, txtAddCustomerShippingAddress.Text, Convert.ToInt32(txtAddCustomerTaxNo.Text), txtAddCustomerTaxOffice.Text, txtAddCustomerDesriciption.Text);
                        DialogResult dialogResult = MessageBox.Show("Müşteri başarıyla eklenmiştir. Bir müşteri daha eklemek ister misiniz?", "Bilgilendirme Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dialogResult == DialogResult.Yes)
                        {
                            txtAddCustomerName.Text = "";
                            txtAddCustomerPhone.Text = "";
                            txtAddCustomerEmail.Text = "";
                            txtAddCustomerAddress.Text = "";
                            txtAddCustomerShippingAddress.Text = "";
                            txtAddCustomerTaxNo.Text = "";
                            txtAddCustomerTaxOffice.Text = "";
                            txtAddCustomerDesriciption.Text = "";
                        }
                        else
                        {
                            this.Close();
                        }
                        txtAddCustomerName.Text = "";
                        txtAddCustomerPhone.Text = "";
                        txtAddCustomerEmail.Text = "";
                        txtAddCustomerAddress.Text = "";
                        txtAddCustomerShippingAddress.Text = "";
                        txtAddCustomerTaxNo.Text = "";
                        txtAddCustomerTaxOffice.Text = "";
                        txtAddCustomerDesriciption.Text = "";
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Müşteri eklenemedi, girdiğiniz telefon numarası ile daha önce bir müşteri kaydı yapılmışdır! Lütfen bilgilerinizi kontrol ediniz.", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    MessageBox.Show("Müşteri eklenemedi, lütfen girdiğiniz değerlerin doğru olduğuna emin olunuz!", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
            }
            catch(ArgumentNullException ex)
            {
                DialogResult dialogResult = MessageBox.Show($" {ex.ParamName} alanı boş bırakamazsınız!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
           
           
        }

        private void txtAddCustomerName_TextChanged(object sender, EventArgs e)
        {
            txtAddCustomerName.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtAddCustomerName.Text);
            txtAddCustomerName.SelectionStart = txtAddCustomerName.Text.Length;
        }

        private void txtAddCustomerPhone_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtAddCustomerPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAddCustomerTaxNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAddCustomerEmail_TextChanged(object sender, EventArgs e)
        {
            txtAddCustomerEmail.Text = txtAddCustomerEmail.Text.ToLower();
            txtAddCustomerEmail.SelectionStart = txtAddCustomerEmail.Text.Length;
        }

        private void txtAddCustomerAddress_TextChanged(object sender, EventArgs e)
        {
            txtAddCustomerAddress.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtAddCustomerAddress.Text);
            txtAddCustomerAddress.SelectionStart = txtAddCustomerName.Text.Length;
        }

        private void txtAddCustomerShippingAddress_TextChanged(object sender, EventArgs e)
        {
            txtAddCustomerShippingAddress.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtAddCustomerShippingAddress.Text);
            txtAddCustomerShippingAddress.SelectionStart = txtAddCustomerShippingAddress.Text.Length;
        }

        private void txtAddCustomerTaxOffice_TextChanged(object sender, EventArgs e)
        {
            txtAddCustomerTaxOffice.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtAddCustomerTaxOffice.Text);
            txtAddCustomerTaxOffice.SelectionStart = txtAddCustomerTaxOffice.Text.Length;
        }
    }
}
