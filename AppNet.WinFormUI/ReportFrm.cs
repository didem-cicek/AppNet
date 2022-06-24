using AppNet.AppService;
using AppNet.Infrastructer.Persistence.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppNet.WinFormUI
{
    public partial class ReportFrm : Form
    {
        private readonly IProductService ps;
        private readonly ICustomerService cs;
        private readonly IStockService sts;
        private readonly ISalesService ss;
        private readonly IReportService r;
        public ReportFrm(IProductService ps, ICustomerService cs, IStockService sts, ISalesService ss, IReportService r)
        {
            InitializeComponent();
            this.ps = ps;
            this.cs = cs;
            this.sts = sts;
            this.ss = ss;
            this.r = r;
        }

        private void ReportFrm_Load(object sender, EventArgs e)
        {
            if (grdData.Rows.Count == 0)
            {
                //grdData.Rows.Clear();
                //grdData.Columns.Add("ReportID", "Rapor ID");
                //grdData.Columns.Add("TotalSales", "Toplam Satış");
                //grdData.Columns.Add("TotalStock", "Toplam Stok");
                //grdData.Columns.Add("TotalCustomer", "Toplam Müşteri");
                //grdData.Columns.Add("TotalCash", "Toplam Bakiye");
                //grdData.Columns.Add("CritialStockName", "Kritik Stok Adı");
                //grdData.Columns.Add("CritialStok", "Kritik Adedi");
                //LoadGridData();
                //grdData.Columns[0].Visible = false;
            }
            }
        private async void LoadGridData()
        {
            //int critial = 0;
            //string CritialStockName = null;
            //int critialStok = 0;
            //var report = (await r.GetAll()).ToList();
            //var product = (await ps.GetAll()).ToList();
            //var customer = (await cs.GetAll()).ToList();
            //var stock = (await sts.GetAll()).ToList();
            //foreach (var s in stock)
            //{
            //    critial = (Convert.ToInt32(s.StockPiece)) - (Convert.ToInt32(s.StockCritical));
            //    if (critial <= s.StockCritical)
            //    {
            //        CritialStockName = s.ProductName;
            //        critialStok = s.StockPiece;
            //    }

            //}
            //var sale = (await ss.GetAll()).ToList();
            //var data = from p in product
            //           join s in sale
            //           on p.ProductID equals s.Id
            //           join st in stock
            //           on p.ProductID equals st.ProductID
            //           join c in customer
            //           on s.CustomerID equals c.CustomerID
            //           select new ReportViewModel
            //           {
            //               TotalSales = s.TotalPrice,
            //               TotalStock = Convert.ToInt32(st.StockTotalPrice),
            //               TotalCustomer = customer.Count,
            //               TotalCash = s.TotalPrice - st.StockTotalPrice,
            //               CritialStockName = CritialStockName,
            //               CritialStok = critialStok,
            //           };

            //foreach (var item in data)
            //{
            //    AddRowToGrid(item);
            //}
        }
        //private void AddRowToGrid(ReportViewModel model)
        //{
        //    DataGridViewRow row = (DataGridViewRow)grdData.Rows[0].Clone();
        //    row.Cells[0].Value = model.TotalSales;
        //    row.Cells[1].Value = model.TotalStock;
        //    row.Cells[2].Value = model.TotalCustomer;
        //    row.Cells[3].Value = model.TotalCash;
        //    row.Cells[4].Value = model.CritialStockName;
        //    row.Cells[5].Value = model.CritialStok;

        //    grdData.Rows.Add(row);
        //}
    }
}
