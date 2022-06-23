
using AppNet.AppService;
using Microsoft.Extensions.DependencyInjection;

namespace AppNet.WinFormUI
{
    public partial class MainForm : Form
    {
        private readonly IServiceProvider sp;
        private readonly IReportService rs;
        private readonly ISalesService sss;
        private readonly ICustomerService cs;
        private readonly IStockService ss;
        private readonly ICashService css;
        public MainForm(IServiceProvider sp, IReportService rs, ISalesService sss, ICustomerService cs, IStockService ss, ICashService css)
        {
            InitializeComponent();
            this.sp = sp;
            this.rs = rs;
            this.sss = sss;
            this.cs = cs;
            this.ss = ss;
            this.css = css;
        }

        private async void FrmMain_Load(object sender, EventArgs e)
        {
            grdInfo.Rows.Add("Sisteme giriþ yaptýnýz.");
            decimal totalsales = 0;
            int totalCustomer = 0;
            int totalStock = 0;
            string CritialStockName = string.Empty; ;
            int critialStok = 0;
            int critial = 0;
            string lastCustomer;
            string lastProduct;
            string lastSale;
            int last;
            var sales = (await sss.GetAll()).ToList();
            var customer= (await cs.GetAll()).ToList();
            var stock = (await ss.GetAll()).ToList();
            var cash = (await cs.GetAll()).ToList();
            foreach (var s in sales)
            {
                totalsales = totalsales + s.TotalPrice;
                //last = sales.LastIndexOf(s.SaleID);
            }
            totalCustomer = customer.Count;
            foreach (var s in stock)
            {
                totalStock = totalStock + s.StockPiece;
                critial = (Convert.ToInt32(s.StockPiece)) - (Convert.ToInt32(s.StockCritical));
                if (critial <= s.StockCritical)
                {
                    CritialStockName = s.ProductName;
                    critialStok = s.StockPiece;
                }
                
            }
            rs.Add(totalsales, totalStock, totalCustomer, cash.Count, CritialStockName, critialStok);
            grdTotal.Columns.Add("totalsales", "Toplam Satýþ");
            grdTotal.Columns.Add("totalStock", "Toplam Stok");
            grdTotal.Columns.Add("totalCustomer", "Toplam Müþteri");
            grdTotal.Rows.Add(totalsales, totalStock, totalCustomer);
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