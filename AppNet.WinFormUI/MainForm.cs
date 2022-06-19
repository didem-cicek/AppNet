
using AppNet.AppService;
using Microsoft.Extensions.DependencyInjection;

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
            var services = new ServiceCollection();
            services.AddScoped<SuppliersFrm>();
            using (ServiceProvider sp = services.BuildServiceProvider())
            {
                var frm = sp.GetRequiredService<SuppliersFrm>();
                frm.ShowDialog();
            }
        }

        private void btnStockManagement_Click(object sender, EventArgs e)
        {
            var services = new ServiceCollection();
            services.AddScoped<PurchasingFrm>();
            using (ServiceProvider sp = services.BuildServiceProvider())
            {
                var frm = sp.GetRequiredService<PurchasingFrm>();
                frm.ShowDialog();
            }
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            var services = new ServiceCollection();
            services.AddScoped<CustomerFrm>();
            using (ServiceProvider sp = services.BuildServiceProvider())
            {
                var frm = sp.GetRequiredService<CustomerFrm>();
                frm.ShowDialog();
            }
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            var services = new ServiceCollection();
            services.AddScoped<SalesFrm>();
            using (ServiceProvider sp = services.BuildServiceProvider())
            {
                var frm = sp.GetRequiredService<SalesFrm>();
                frm.ShowDialog();
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var services = new ServiceCollection();
            services.AddScoped<SettingsFrm>();
            using (ServiceProvider sp = services.BuildServiceProvider())
            {
                var frm = sp.GetRequiredService<SettingsFrm>();
                frm.ShowDialog();
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}