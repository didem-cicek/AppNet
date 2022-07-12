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
    public partial class PurchasingFrm : Form
    {
        private readonly IServiceProvider sp;
        private readonly IStockService ss;
        private readonly ISupplierService sup;
        private readonly IProductService p;
        public PurchasingFrm(IServiceProvider sp, IStockService ss, ISupplierService sup, IProductService p)
        {
            InitializeComponent();
            this.sp = sp;
            this.ss = ss;
            this.sup = sup;
            this.p = p;
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<AddStock>();
            frm.ShowDialog();
            grdStockList.Rows.Clear();
            LoadGridData();
        }

        private void btnUpdatedStock_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<UpdateStock>();
            frm.ShowDialog();
            grdStockList.Rows.Clear();
            LoadGridData();
        }

        private void btnDeletedStock_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<DeleteStock>();
            frm.ShowDialog();
            grdStockList.Rows.Clear();
            LoadGridData();
        }

        private void PurchasingFrm_Load(object sender, EventArgs e)
        {
            if (grdStockList.Rows.Count == 0)
            {
                grdStockList.Rows.Clear();
                grdStockList.Refresh();
                grdStockList.Columns.Add("StockID", "Stok ID");
                grdStockList.Columns.Add("ProductName", "Ürün Adı");
                grdStockList.Columns.Add("SupplierName", "Tedarikçi Adı");
                grdStockList.Columns.Add("StockPiece", "Adet");
                grdStockList.Columns.Add("ProductType", "Ürün Tipi");
                grdStockList.Columns.Add("CritialStock", "Kritik Stok");
                grdStockList.Columns.Add("StockPrice", "Birim Fiyat");
                grdStockList.Columns.Add("StockTotalPrice", "Toplam Fiyat");
                grdStockList.Columns.Add("StockDate", "Ekleme Tarihi");
                grdStockList.Columns.Add("StockModifitedDate", "Düzenleme Tarihi");
                LoadGridData();
                grdStockList.Columns[0].Visible = false;
            }
        }
        private async void LoadGridData()
        {
            var supplier = (await sup.GetAll()).ToList();
            var stock = (await ss.GetAll()).ToList();
            var product = (await p.GetAll()).ToList();
            var data = from p in stock
                       join c in supplier
                       on p.SupplierID equals c.SupplierID
                       join pr in product
                       on p.ProductID equals pr.ProductID
                       select new StockViewModel
                       {
                           StockID = p.StockID,
                           ProductName = pr.ProductName,
                           SupplierName = c.SupplierName,
                           StockPiece = p.StockPiece,
                           CritialStock = p.StockCritical,
                           StockPrice = p.PurchaseUnitPrice,
                           StockTotalPrice = p.StockTotalPrice,
                           Date = p.StockDate,
                           ModifiedTime = p.StockModifitedDate,
                       };
            foreach (var item in data)
            {
                AddRowToGrid(item);
            }
        }
        private void AddRowToGrid(StockViewModel model)
        {
            DataGridViewRow row = (DataGridViewRow)grdStockList.Rows[0].Clone();
            row.Cells[0].Value = model.StockID;
            row.Cells[1].Value = model.ProductName;
            row.Cells[2].Value = model.SupplierName;
            row.Cells[3].Value = model.StockPiece;
            row.Cells[4].Value = model.CritialStock;
            row.Cells[5].Value = model.StockPrice;
            row.Cells[6].Value = model.StockTotalPrice;
            row.Cells[7].Value = model.Date;
            row.Cells[8].Value = model.ModifiedTime;


            grdStockList.Rows.Add(row);
        }

        private async void txtStockSearch_TextChanged(object sender, EventArgs e)
        {
            grdStockList.Rows.Clear();
            grdStockList.Refresh();
            var supplier = (await sup.GetAll()).ToList();
            var stock = (await ss.GetAll()).ToList();
            var product = (await p.GetAll()).ToList();
            var find = (from q in stock
                        join c in supplier
                        on q.SupplierID equals c.SupplierID
                        join pr in product
                        on q.ProductID equals pr.ProductID
                        where c.SupplierName.ToLower().Contains((txtStockSearch.Text).ToLower())
                        orderby c.SupplierName ascending
                        select new StockViewModel
                        {
                            StockID = q.StockID,
                            ProductName = pr.ProductName,
                            SupplierName = c.SupplierName,
                            StockPiece = q.StockPiece,
                            CritialStock = q.StockCritical,
                            StockPrice = q.PurchaseUnitPrice,
                            StockTotalPrice = q.StockTotalPrice,
                            Date = q.StockDate,
                            ModifiedTime = q.StockModifitedDate,

                        }).ToList();

            foreach (var f in find)
            {

                AddRowToGrid(f);
            }
        }
    }
}
