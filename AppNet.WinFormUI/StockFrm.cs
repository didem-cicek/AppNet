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
    public partial class StockFrm : Form
    {
        private readonly IStockService ss;
        private readonly ISupplierService sup;
        private readonly IProductService p;
        public StockFrm(IStockService ss, ISupplierService sup, IProductService p)
        {
            InitializeComponent();
            this.ss = ss;
            this.sup = sup;
            this.p = p;
        }

        private void StockFrm_Load(object sender, EventArgs e)
        {
            if (grdData.Rows.Count == 0)
            {
                grdData.Rows.Clear();
                grdData.Refresh();
                grdData.Columns.Add("StockID", "Stok ID");
                grdData.Columns.Add("ProductName", "Ürün Adı");
                grdData.Columns.Add("Color", "Renk");
                grdData.Columns.Add("Size", "Beden");
                grdData.Columns.Add("StockPiece", "Adet");
                grdData.Columns.Add("StockPrice", "Birim Fiyat");
                grdData.Columns.Add("SupplierName", "Tedarikçi Adı");
                grdData.Columns.Add("CritialStock", "Kritik Stok");
                grdData.Columns.Add("StockTotalPrice", "Toplam Fiyat");
                grdData.Columns.Add("StockDate", "Ekleme Tarihi");
                grdData.Columns.Add("StockModifitedDate", "Düzenleme Tarihi");
                LoadGridData();
                grdData.Columns[0].Visible = false;
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
                           Color = p.Color,
                           Size = p.Size,
                           StockPiece = p.StockPiece,
                           StockPrice = p.PurchaseUnitPrice,
                           SupplierName = c.SupplierName,
                           CritialStock = p.StockCritical,
                           StockTotalPrice = p.StockTotalPrice,
                           Date = p.StockDate,
                           ModifiedTime = p.StockModifitedDate,
                       };
            foreach (var item in data)
            {
                AddRowToGrid(item);
            }
            for (int i = 0; i <= grdData.Rows.Count - 1; i++)
            {
                DataGridViewCellStyle color = new DataGridViewCellStyle();
                if (Convert.ToUInt32(grdData.Rows[i].Cells[4].Value) > Convert.ToUInt32(grdData.Rows[i].Cells[7].Value ) + 50)
                {
                    color.BackColor = Color.Green;
                    color.ForeColor = Color.White;
                } else if (Convert.ToUInt32(grdData.Rows[i].Cells[4].Value) >= Convert.ToUInt32(grdData.Rows[i].Cells[7].Value))
                {
                    color.BackColor = Color.Orange;
                    color.ForeColor = Color.White;
                }
                else
                {
                    color.BackColor = Color.Red;
                    color.ForeColor = Color.White;
                }
                grdData.Rows[i].DefaultCellStyle = color;
            }
            grdData.Refresh();
        }
        private void AddRowToGrid(StockViewModel model)
        {
            DataGridViewRow row = (DataGridViewRow)grdData.Rows[0].Clone();
            row.Cells[0].Value = model.StockID;
            row.Cells[1].Value = model.ProductName;
            row.Cells[2].Value = model.Color;
            row.Cells[3].Value = model.Size;
            row.Cells[4].Value = model.StockPiece;
            row.Cells[5].Value = model.StockPrice;
            row.Cells[6].Value = model.SupplierName;
            row.Cells[7].Value = model.CritialStock;
            row.Cells[8].Value = model.StockTotalPrice;
            row.Cells[9].Value = model.Date;
            row.Cells[10].Value = model.ModifiedTime;


            grdData.Rows.Add(row);
        }
    }
}
