
namespace AppNet.WinFormUI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
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
    }
}