using AppNet.AppService;

namespace AppNet.WinFormUI
{
    public partial class AddSupplier : Form
    {
        private readonly ISupplierService ss;
        public AddSupplier(ISupplierService ss)
        {
            InitializeComponent();
            this.ss = ss;
        }

        private void AddSupplier_Load(object sender, EventArgs e)
        {

        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                ss.Add(txtSupplierName.Text, txtSupplierPhone.Text, txtSupplierAddress.Text, txtShippingAddress.Text);
                DialogResult dialogResult = MessageBox.Show("Tedarikçi baþarýyla eklenmiþtir. Bir tedarikçi daha eklemek ister misiniz?", "Bilgilendirme Mesajý", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    txtSupplierName.Text = "";
                    txtSupplierPhone.Text = "";
                    txtSupplierAddress.Text = "";
                    txtShippingAddress.Text = "";
                }
                else
                {
                    this.Close();
                }
                txtSupplierName.Text = "";
                txtSupplierPhone.Text = "";
                txtSupplierAddress.Text = "";
                txtShippingAddress.Text = "";
            }
            catch
            {
                DialogResult dialogResult = MessageBox.Show("Tedarikçi eklenemedi, lütfen girdiðiniz deðerlerin doðru olduðuna emin olunuz!", "Uyarý Mesajý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }
    }
}