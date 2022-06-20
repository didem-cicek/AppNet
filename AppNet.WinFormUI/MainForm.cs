
using AppNet.AppService;
using Microsoft.Extensions.DependencyInjection;

namespace AppNet.WinFormUI
{
    public partial class MainForm : Form
    {
        private readonly IServiceProvider sp;

        public MainForm(IServiceProvider sp)
        {
            InitializeComponent();
            this.sp = sp;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<ProductFrm>();
            frm.ShowDialog();

        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<SuppliersFrm>();
            frm.ShowDialog();
        }

        private void btnStockManagement_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<PurchasingFrm>();
            frm.ShowDialog();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<CustomerFrm>();
            frm.ShowDialog();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<SalesFrm>();
            frm.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<SettingsFrm>();
            frm.ShowDialog();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}