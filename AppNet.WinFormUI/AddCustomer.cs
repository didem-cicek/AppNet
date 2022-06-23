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

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try { 
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
            catch
            {
                MessageBox.Show("Müşteri eklenemedi, lütfen girdiğiniz değerlerin doğru olduğuna emin olunuz!", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

        }
    }
}
