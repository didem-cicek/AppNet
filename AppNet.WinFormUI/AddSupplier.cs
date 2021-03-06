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
                ss.Add(txtSupplierName.Text, txtSupplierPhone.Text, txtSupplierAddress.Text, Convert.ToInt32(txtTaxNumber.Text), txtTaxName.Text,0,0);
                DialogResult dialogResult = MessageBox.Show("Tedarik?i ba?ar?yla eklenmi?tir. Bir tedarik?i daha eklemek ister misiniz?", "Bilgilendirme Mesaj?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    txtSupplierName.Text = "";
                    txtSupplierPhone.Text = "";
                    txtSupplierAddress.Text = "";
                    txtTaxNumber.Text = "";
                    txtTaxName.Text = "";
                }
                else
                {
                    this.Close();
                }
                txtSupplierName.Text = "";
                txtSupplierPhone.Text = "";
                txtSupplierAddress.Text = "";
                txtTaxNumber.Text = "";
                txtTaxName.Text = "";
            }
            catch
            {
                DialogResult dialogResult = MessageBox.Show("Tedarik?i eklenemedi, l?tfen girdi?iniz de?erlerin do?ru oldu?una emin olunuz!", "Uyar? Mesaj?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }
    }
}