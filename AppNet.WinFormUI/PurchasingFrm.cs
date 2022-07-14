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
                grdStockList.Columns.Add("Color", "Renk");
                grdStockList.Columns.Add("Size", "Beden");
                grdStockList.Columns.Add("StockPiece", "Adet");
                grdStockList.Columns.Add("StockPrice", "Birim Fiyat");         
                grdStockList.Columns.Add("SupplierName", "Tedarikçi Adı");
                grdStockList.Columns.Add("CritialStock", "Kritik Stok");
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
        }
        private void AddRowToGrid(StockViewModel model)
        {
            DataGridViewRow row = (DataGridViewRow)grdStockList.Rows[0].Clone();
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
                            Color = q.Color,
                            Size = q.Size,
                            StockPiece = q.StockPiece,
                            StockPrice = q.PurchaseUnitPrice,
                            SupplierName = c.SupplierName,
                            CritialStock = q.StockCritical,
                            StockTotalPrice = q.StockTotalPrice,
                            Date = q.StockDate,
                            ModifiedTime = q.StockModifitedDate,

                        }).ToList();

            foreach (var f in find)
            {

                AddRowToGrid(f);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<UpdateStock>();
            try
            {
                if (grdStockList.CurrentRow.Cells[1].Value.ToString() != null)
                {
                    frm.txtUpdateStockSearch.Text = grdStockList.CurrentRow.Cells[1].Value.ToString();
                    frm.ShowDialog();
                }
            }
            catch (NullReferenceException ex)
            {
                DialogResult dialogResult = MessageBox.Show("Seçim yapmadınız önce satırı seçiniz!", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            }
            grdStockList.Rows.Clear();
            LoadGridData();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<DeleteStock>();
            try {
                if (grdStockList.CurrentRow.Cells[1].Value.ToString() != null) { 
                frm.txtDeleteStockSearch.Text = grdStockList.CurrentRow.Cells[1].Value.ToString();
                frm.ShowDialog(); }
            }
            catch(NullReferenceException ex)
            {
                DialogResult dialogResult = MessageBox.Show("Seçim yapmadınız önce satırı seçiniz!", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                
            }
            grdStockList.Rows.Clear();
            LoadGridData();
        }

        private void grdStockList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
