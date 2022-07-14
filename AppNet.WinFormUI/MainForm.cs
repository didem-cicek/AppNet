
using AppNet.AppService;
using AppNet.Infrastructer.Notification;
using AppNet.Infrastructer.Persistence.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace AppNet.WinFormUI
{
    public partial class MainForm : Form
    {
        private readonly IServiceProvider sp;
        private readonly IProductService p;
        private readonly IReportService rs;
        private readonly ISalesService sss;
        private readonly ICustomerService cs;
        private readonly IStockService ss;
        private readonly ICashService css;
        public MainForm(IProductService p, IServiceProvider sp, IReportService rs, ISalesService sss, ICustomerService cs, IStockService ss, ICashService css)
        {
            InitializeComponent();
            this.sp = sp;
            this.rs = rs;
            this.sss = sss;
            this.cs = cs;
            this.ss = ss;
            this.css = css;
            this.p = p;
        }

        private async void FrmMain_Load(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private async void LoadGridData()
        {
            CustomerTotal.Text = "";
            ProductTotal.Text = "";
            SaleTotal.Text = "";
            lastProduct.Text = "";
            lastCustomer.Text = "";
            lastSaleCustomer.Text = "";
            CustomerTotal.Refresh();
            ProductTotal.Refresh();
            SaleTotal.Refresh();
            lastCustomer.Refresh();
            lastProduct.Refresh();
            lastSaleCustomer.Refresh();

            var customer = (await cs.GetAll()).ToList();
            var product = (await p.GetAll()).ToList();
            var sale = (await sss.GetAll()).ToList();
            var stock = (await ss.GetAll()).ToList();
            var cash = (await css.GetAll()).ToList();
            CustomerTotal.Text = customer.Count.ToString();
            ProductTotal.Text = product.Count.ToString();
            SaleTotal.Text = sale.Count.ToString();

            var customerList = (from q in customer
                                join s in sale
                                on q.CustomerID equals s.CustomerID
                                orderby s.CustomerID descending
                                select new
                                {
                                    CustomerID = q.CustomerID,
                                    CustomerName = q.CustomerName,

                                }).ToList();
            var LastCustomer = (from q in customer
                                orderby q.CustomerID descending
                                select new
                                {
                                    CustomerID = q.CustomerID,
                                    CustomerName = q.CustomerName,

                                }).ToList();
            var saleList = (from q in product
                            join s in stock
                            on q.ProductID equals s.ProductID
                            orderby s.StockID descending
                            select new
                            {
                                ProductID = q.ProductID,
                                ProductName = q.ProductName,

                            }).ToList();
            var critialstock = (from q in product
                             join s in stock
                             on q.ProductID equals s.ProductID
                             orderby s.StockID descending
                             where s.StockPiece <= s.StockCritical
                                select new
                             {
                                 ProductID = q.ProductID,
                                 ProductName = q.ProductName,
                                 UnitPiece = s.StockPiece,

                             }).ToList();
            var totalCash = (from q in cash
                             orderby q.CashID descending
                             select new
                             {
                                 totalCash = q.TotalCash,

                             }).ToList();
            foreach (var c in totalCash)
            {
                TotalCash.Text = c.totalCash.ToString();
                break;
            }
            foreach (var item in LastCustomer)
            {
                lastCustomer.Text = item.CustomerName;
                break;
            }
            foreach (var item in saleList)
            {
                lastProduct.Text = item.ProductName;
                break;
            }
            foreach (var item in customerList)
            {
                lastSaleCustomer.Text = item.CustomerName;
                break;
            }
            if (critialstock == null)
            {
                critialStok.Text = "Kritik stokda bir ürün bulunmuyor.";
                critialStok.ForeColor = Color.Green;
            }
            else
            {
                
                foreach (var item in critialstock)
                {
                    critialStok.Text = item.ProductName + " isimli üründen " + item.UnitPiece.ToString() + " adet vardýr,\nadet 0 olunca satýþ durdurulacaktýr.";
                    critialStok.ForeColor = Color.Red;
                    break;
                }
            }
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
            LoadGridData();
        }

        private void btnStockManagement_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<PurchasingFrm>();
            frm.ShowDialog();
            LoadGridData();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<CustomerFrm>();
            frm.ShowDialog();
            LoadGridData();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<SalesFrm>();
            frm.ShowDialog();
            LoadGridData();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<SettingsFrm>();
            frm.ShowDialog();
            LoadGridData();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<cashForm>();
            frm.ShowDialog();
            LoadGridData();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<ReportFrm>();
            frm.ShowDialog();
            LoadGridData();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<StockFrm>();
            frm.ShowDialog();
            LoadGridData();
        }

        public void grdInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}