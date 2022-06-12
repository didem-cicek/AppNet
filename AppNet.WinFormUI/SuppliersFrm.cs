namespace AppNet.WinFormUI
{
    public partial class SuppliersFrm : Form
    {
        public SuppliersFrm()
        {
            InitializeComponent();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            AddSupplier addFrm = new AddSupplier();
            addFrm.ShowDialog();
        }

        private void btnUpdatedSupplier_Click(object sender, EventArgs e)
        {
            UpdateSupplier updateFrm = new UpdateSupplier();
            updateFrm.ShowDialog();
        }

        private void SuppliersFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnDeletedSupplier_Click(object sender, EventArgs e)
        {
            DeleteSupplier deleteFrm = new DeleteSupplier();
            deleteFrm.ShowDialog();
        }
    }
}