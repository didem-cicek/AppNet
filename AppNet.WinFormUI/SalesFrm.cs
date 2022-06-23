using AppNet.AppService;
using AppNet.Infrastructer.Persistence.ViewModels;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class SalesFrm : Form
    {
        private readonly IServiceProvider sp;
        private readonly ISalesService ss;
        private ICustomerService cs;
        public SalesFrm(IServiceProvider sp, ISalesService ss, ICustomerService cs)
        {
            InitializeComponent();
            this.sp = sp;
            this.ss = ss;
            this.cs = cs;
        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<AddSale>();
            frm.ShowDialog();
            grdSaleList.Rows.Clear();
            LoadGridData();
        }

        private void btnUpdateSale_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<UpdateSale>();
            frm.ShowDialog();
            grdSaleList.Rows.Clear();
            LoadGridData();
        }

        private void btnDeleteSale_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<DeleteSale>();
            frm.ShowDialog();
            grdSaleList.Rows.Clear();
            LoadGridData();
        }

        private void SalesFrm_Load(object sender, EventArgs e)
        {
            grdSaleList.Rows.Clear();
            grdSaleList.Columns.Add("SaleID", "Satış ID");
            grdSaleList.Columns.Add("ProductName", "Ürün Adı");
            grdSaleList.Columns.Add("CustomerName", "Müşteri Adı");
            grdSaleList.Columns.Add("Piece", "Adet");
            grdSaleList.Columns.Add("UnitPrice", "Birim Fiyat");
            grdSaleList.Columns.Add("TotalPrice", "Toplam Fiyar");
            grdSaleList.Columns.Add("Date", "Kayıt Tarihi");
            grdSaleList.Columns.Add("ModifiedDate", "Düzenlenme Tarihi");
            LoadGridData();
            grdSaleList.Columns[0].Visible = false;
        }
        private async void LoadGridData()
        {
            var sales = (await ss.GetAll()).ToList();
            var customer = (await cs.GetAll()).ToList();
            var data = from p in sales
                       join c in customer
                       on p.CustomerID equals c.CustomerID
                       select new SaleViewModel
                       {
                           SaleID = p.SaleID,
                           ProductName = p.Stock.ProductName,
                           CustomerName = c.CustomerName,
                           Piece = p.ProductPiece,
                           UnitPrice = p.SalePrice,
                           TotalPrice = p.TotalPrice,
                           Date = p.SaleDate,
                           ModifiedDate = p.SaleModifitedDate,
                       };
            foreach (var item in data)
            {
                AddRowToGrid(item);
            }
        }
        private void AddRowToGrid(SaleViewModel model)
        {
            DataGridViewRow row = (DataGridViewRow)grdSaleList.Rows[0].Clone();
            row.Cells[0].Value = model.SaleID;
            row.Cells[1].Value = model.ProductName;
            row.Cells[2].Value = model.CustomerName;
            row.Cells[3].Value = model.Piece;
            row.Cells[4].Value = model.UnitPrice;
            row.Cells[5].Value = model.TotalPrice;
            row.Cells[6].Value = model.Date;
            row.Cells[7].Value = model.ModifiedDate;

            grdSaleList.Rows.Add(row);
        }
    }
}
