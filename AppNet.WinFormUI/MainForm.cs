
namespace AppNet.WinFormUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            ProductFrm productFrm = new ProductFrm();
            productFrm.ShowDialog();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            SuppliersFrm supplierFrm = new SuppliersFrm();
            supplierFrm.ShowDialog();
        }

        private void btnStockManagement_Click(object sender, EventArgs e)
        {
            PurchasingFrm stockFrm = new PurchasingFrm();
            stockFrm.ShowDialog();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomerFrm customerFrm = new CustomerFrm();
            customerFrm.ShowDialog();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            SalesFrm saleFrm = new SalesFrm();
            saleFrm.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsFrm settingFrm = new SettingsFrm();
            settingFrm.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}