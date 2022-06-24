
using AppNet.AppService;
using AppNet.Infrastructer.Persistence.ViewModels;
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
        private readonly INotificationsService n;
        public MainForm(IServiceProvider sp, IReportService rs, ISalesService sss, ICustomerService cs, IStockService ss, ICashService css, INotificationsService n)
        {
            InitializeComponent();
            this.sp = sp;
            this.rs = rs;
            this.sss = sss;
            this.cs = cs;
            this.ss = ss;
            this.css = css;
            this.n = n;
        }

        private async void FrmMain_Load(object sender, EventArgs e)
        {
            if (grdNot.Rows.Count == 0)
            {
                grdNot.Rows.Clear();
                grdNot.Refresh();
                grdNot.Columns.Add("NotificationID", "ID");
                grdNot.Columns.Add("NotificationName", "Bildirim");
                LoadGridData();
                grdNot.Columns[0].Visible = false;
            }
        }
        private async void LoadGridData()
        {
            var not = (await n.GetAll()).ToList();
            var data = from q in not
                       select new NotificationViewModel
                       {
                           NotificationID = q.NotificationsID,
                           NotificationName = q.NotificationsName,
                       };
            foreach (var item in data)
            {
                AddRowToGrid(item);
            }

        }

        private void AddRowToGrid(NotificationViewModel model)
        {
            DataGridViewRow row = (DataGridViewRow)grdNot.Rows[0].Clone();
            row.Cells[0].Value = model.NotificationID;
            row.Cells[1].Value = model.NotificationName;
            grdNot.Rows.Add(row);
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

        private void btnCash_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<cashForm>();
            frm.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<ReportFrm>();
            frm.ShowDialog();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<StockFrm>();
            frm.ShowDialog();
        }

        public void grdInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}