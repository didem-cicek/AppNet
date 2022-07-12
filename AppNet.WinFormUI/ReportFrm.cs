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
        private readonly IServiceProvider sp;
        private readonly IProductService p;
        private readonly IReportService rs;
        private readonly ISalesService sss;
        private readonly ICustomerService cs;
        private readonly IStockService ss;
        private readonly ICashService css;
        public ReportFrm(IProductService p, IServiceProvider sp, IReportService rs, ISalesService sss, ICustomerService cs, IStockService ss, ICashService css)
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

        private void ReportFrm_Load(object sender, EventArgs e)
        {
            LoadGridData();
         }
        private async void LoadGridData()
        {
            monthlySale.Text = "";
            weeklySale.Text = "";
            dailySale.Text = "";
            yearlySale.Text = "";

            monthlyExpense.Text = "";
            weeklyExpense.Text = "";
            dailyExpense.Text = "";
            yearlyExpense.Text = "";

            monthlyIncome.Text = "";
            weeklyIncome.Text = "";
            dailyIncome.Text = "";
            yearlyIncome.Text = "";

            totalSale.Text = "";
            totalSaleProduct.Text = "";
            totalCustomer.Text = "";
            stockProduct.Text = "";

            monthlySale.Refresh();
            weeklySale.Refresh();
            dailySale.Refresh();
            yearlySale.Refresh();
            weeklyExpense.Refresh();
            dailyExpense.Refresh();
            monthlyIncome.Refresh();
            weeklyIncome.Refresh();
            yearlyExpense.Refresh();
            totalSale.Refresh();
            totalSaleProduct.Refresh();
            totalCustomer.Refresh();
            stockProduct.Refresh();
            monthlyExpense.Refresh();
            dailyIncome.Refresh();
            yearlyIncome.Refresh();

            var customer = (await cs.GetAll()).ToList();
            var product = (await p.GetAll()).ToList();
            var sale = (await sss.GetAll()).ToList();
            var stock = (await ss.GetAll()).ToList();
            var cash = (await css.GetAll()).ToList();
            var totalStock = 0;
            var totalsaleProduct = 0;

            
            totalCustomer.Text = customer.Count.ToString();
            totalSale.Text = sale.Count.ToString();
            
            foreach (var item in stock)
            {
                totalStock = item.StockPiece;
                item.StockPiece++;
            }
            stockProduct.Text = totalStock.ToString();

           
            foreach (var item in sale)
            {
                totalsaleProduct = item.ProductPiece;
                item.ProductPiece++;
            }
            totalSaleProduct.Text = totalsaleProduct.ToString(); ;

            var i = 0;
            foreach(var item in sale)
            {
                weeklySale.Text = "0";
                var date = sale.GroupBy(x => x.SaleDate.Month).Select(x => x.Key).LastOrDefault();
                if (item.SaleDate.Month == date)
                {
                    if (item.SaleDate.Day == DateTime.Now.Day || item.SaleDate.Day >= DateTime.Now.AddDays(-7).Day )
                    i++;
                }
                weeklySale.Text = i.ToString();
            }
            decimal n = 0;
            
            foreach (var item in stock)
            {
                weeklyExpense.Text = "0,00";
                var date = stock.GroupBy(x => x.StockDate.Month).Select(x => x.Key).LastOrDefault();
                if (item.StockDate.Month == date)
                {
                    if (item.StockDate.Day == DateTime.Now.Day || item.StockDate.Day >= DateTime.Now.AddDays(-7).Day)
                        n =item.StockTotalPrice+n;
                }
                weeklyExpense.Text = n.ToString();

            }
            decimal h = 0;
            foreach (var item in sale)
            {
                weeklyIncome.Text = "0,00";
                var date = sale.GroupBy(x => x.SaleDate.Month).Select(x => x.Key).LastOrDefault();
                if (item.SaleDate.Month == date)
                {
                    if (item.SaleDate.Day == DateTime.Now.Day || item.SaleDate.Day >= DateTime.Now.AddDays(-7).Day)
                        h = item.TotalPrice+h;
                }
                weeklyIncome.Text = h.ToString();

            }
            decimal b = 0;
            foreach (var item in stock)
            {
                monthlyExpense.Text = "0,00";
                var date = stock.GroupBy(x => x.StockDate.Month).Select(x => x.Key).LastOrDefault();
                if (item.StockDate.Month == date)
                {
                   b = item.StockTotalPrice+b;
                }
                monthlyExpense.Text = b.ToString();

            }
            decimal t = 0;
            foreach (var item in sale)
            {
                monthlyIncome.Text = "0,00";
                var date = sale.GroupBy(x => x.SaleDate.Month).Select(x => x.Key).LastOrDefault();
                if (item.SaleDate.Month == date)
                {
                    
                    t=item.TotalPrice+t;
                }
                
                monthlyIncome.Text = t.ToString();

            }
            var z = 0;
            foreach (var item in sale)
            {
                monthlySale.Text = "0";
                var date = sale.GroupBy(x => x.SaleDate.Month).Select(x => x.Key).LastOrDefault();
                if (item.SaleDate.Month == date)
                {
                    
                    z++;
                }
                
                monthlySale.Text = z.ToString();

            }
            decimal u = 0;
            foreach (var item in stock)
            {
                yearlyExpense.Text = "0,00";
                var date = stock.GroupBy(x => x.StockDate.Year).Select(x => x.Key).LastOrDefault();
                if (item.StockDate.Year == date)
                {
                    
                    u = item.StockTotalPrice+u;
                }
               
                yearlyExpense.Text = u.ToString();

            }
            decimal f = 0;
            foreach (var item in sale)
            {
                yearlyIncome.Text = "0,00";
                var date = sale.GroupBy(x => x.SaleDate.Year).Select(x => x.Key).LastOrDefault();
                if (item.SaleDate.Year == date)
                {
                   
                    f = item.TotalPrice+f;
                }
                
                yearlyIncome.Text = f.ToString();

            }
            decimal x = 0;
            foreach (var item in sale)
            {
                yearlySale.Text = "0";
                var date = sale.GroupBy(x => x.SaleDate.Year).Select(x => x.Key).LastOrDefault();
                if (item.SaleDate.Year == date)
                {
                    x++;
                }
                
                yearlySale.Text = x.ToString();
            }

            decimal r = 0;
            foreach (var item in stock)
            {
                dailyExpense.Text = "0,00";
                var date = stock.GroupBy(x => x.StockDate.Day).Select(x => x.Key).LastOrDefault();
                if (item.StockDate.Day == date)
                {
                    
                    r = item.StockTotalPrice+r;
                }
                
                dailyExpense.Text = item.StockTotalPrice.ToString();

            }
            decimal y = 0;
            foreach (var item in sale)
            {
                dailyIncome.Text = "0,00";
                var date = sale.GroupBy(x => x.SaleDate.Day).Select(x => x.Key).LastOrDefault();
                if (item.SaleDate.Day == date)
                {

                    y =  item.TotalPrice+y;
                }
                
                dailyIncome.Text = y.ToString();

            }
            var j = 0;
            foreach (var item in sale)
            {
               dailySale.Text = "0";
               var date = sale.GroupBy(x => x.SaleDate.Day).Select(x => x.Key).LastOrDefault();

                if (item.SaleDate.Day == date)
                {
                    j++;
                }
                else
                {
                   
                }
                dailySale.Text = j.ToString();
            }


        }
      
    }
}
