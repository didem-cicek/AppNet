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
    public partial class cashForm : Form
    {
        private readonly ICashService cs;
        private readonly IStockService sc;
        private readonly ISalesService ss;
        private readonly IProductService p;
        public decimal TotalCash;
        public int CashID;
        public decimal debt;
        public decimal receivable;
        public cashForm(ICashService cs, IStockService sc, ISalesService ss, IProductService p)
        {
            InitializeComponent();
            this.cs = cs;
            this.ss = ss;
            this.p = p;
            this.sc = sc;
        }

        private async void cashForm_Load(object sender, EventArgs e)
        {
            
            if (grdData.DataSource == null)
            {
                AddData();
              if (grdData.Rows.Count == 0) { 
                    grdData.Rows.Clear();
                    grdData.Columns.Add("CashID", "Kasa ID");
                    grdData.Columns.Add("Debt", "Borç");
                    grdData.Columns.Add("Receivable", "Alacak");
                    grdData.Columns.Add("TotalCash", "Toplam Bakiye");
                    grdData.Columns.Add("Date", "Eklenme Tarihi");
                    grdData.Columns.Add("ModifiedDate", "Güncellenme Tarihi");
                    LoadGridData();
                    grdData.Columns[0].Visible = false;}
                else
                {
                    var cash = (await cs.GetAll()).ToList();
                    foreach (var item in cash)
                    {
                        CashID = item.CashID;
                    }
                    cs.Remove(CashID);
                }

            }
            
        }
        public async void AddData()
        {
            grdData.Rows.Clear();
            grdData.Refresh();
            debt = 0;
            receivable = 0;
            var cash = (await cs.GetAll()).ToList();
            var stock = (await sc.GetAll()).ToList();
            var sale = (await ss.GetAll()).ToList();
            var product = (await p.GetAll()).ToList();

            foreach (var s in stock)
            {
                debt = s.StockTotalPrice + debt;
            }
            foreach (var sa in sale)
            {
                receivable = sa.TotalPrice + receivable;
            }
            TotalCash = receivable - debt;
            cs.Add(debt, receivable, TotalCash);
        }
        private async void LoadGridData()
        {
            grdData.Rows.Clear();
            grdData.Refresh();

            var cash = (await cs.GetAll()).ToList();
            
            var data = from p in cash
                       select new CashViewModel
                       {
                           CashID = p.CashID,
                           Debt = p.Debt,
                           Receivable = p.Receivable,
                           TotalCash = p.TotalCash,
                       };

            foreach (var item in data)
            {
                AddRowToGrid(item);
            }
            
        }
        private void AddRowToGrid(CashViewModel model)
        {
            DataGridViewRow row = (DataGridViewRow)grdData.Rows[0].Clone();
            row.Cells[0].Value = model.CashID;
            row.Cells[1].Value = model.Debt;
            row.Cells[2].Value = model.Receivable;
            row.Cells[3].Value = model.TotalCash;
            row.Cells[4].Value = model.Date;
            row.Cells[5].Value = model.ModifiedDate;

            grdData.Rows.Add(row);
        }
    }
}
