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
    public partial class AddStock : Form
    {
        private readonly IStockService ss;
        private readonly IProductService ps;
        private readonly ISupplierService sps;
        private readonly IServiceProvider sp;
        public int supllierID;

        public AddStock(IStockService ss, IProductService ps, ISupplierService sps, IServiceProvider sp)
        {
            InitializeComponent();
            this.ss = ss;
            this.ps = ps;
            this.sps = sps;
            this.sp = sp;
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            
        }


        private async void AddStock_Load(object sender, EventArgs e)
        {
            if (grdList.Rows.Count == 0)
            {
                grdList.Rows.Clear();
                grdList.Columns.Add("Product ID", "Ürün ID");
                grdList.Columns.Add("ProductName", "Ürün Adı");
                grdList.Columns.Add("Color", "Renk");
                grdList.Columns.Add("Size", "Beden");
                grdList.Columns.Add("Piece", "Adet");
                grdList.Columns.Add("Price", "Fiyat");
                grdList.Columns.Add("CritialStok", "Kritik Stok");
                grdList.Columns[0].Visible = false;
            }
            if (grdProduct.Rows.Count == 0)
            {
                grdProduct.Rows.Clear();
                grdProduct.Columns.Add("Product ID", "Ürün ID");
                grdProduct.Columns.Add("ProductName", "Ürün Adı");
                grdProduct.Columns.Add("Desciription", "Açıklama");
                LoadGridData();
                grdList.Columns[0].Visible = false;
            }
            
        }
        private async void LoadGridData()
        {
            var p = (await ps.GetAll()).ToList();
            var sp = (await sps.GetAll()).ToList();
            var s = (await ss.GetAll()).ToList();
            grdProduct.Rows.Clear();
            grdProduct.Refresh();

            var productList = (from q in p
                               select new StockProductViewModel
                               {
                                   ProductID = q.ProductID,
                                   ProductName = q.ProductName,
                                   Desciription = q.ProductDesriciption


                               }).ToList();
            foreach (var product in productList)
            {
                AddRowToGridProduct(product);
            }
            var supllierID = (from q in sp
                                select new SupplierViewModel
                                {
                                    SupplierID = q.SupplierID,
                                    SupplierName = q.SupplierName,

                                }).ToList();

        }
        private void AddRowToGridProduct(StockProductViewModel model)
        {
            DataGridViewRow row = (DataGridViewRow)grdProduct.Rows[0].Clone();
            row.Cells[0].Value = model.ProductID;
            row.Cells[1].Value = model.ProductName;
            row.Cells[2].Value = model.Desciription;

            grdProduct.Rows.Add(row);
        }

        private void addSupplier_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<SelectSupplierFrm>();
            frm.ShowDialog();
            txtSupplierName.Text = frm.grdSupplier.CurrentRow.Cells[1].Value.ToString();
            txtSupplier.Text = frm.grdSupplier.CurrentRow.Cells[1].Value.ToString();
            supllierID = Convert.ToInt32(frm.grdSupplier.CurrentRow.Cells[0].Value);
        }

        private async void txtProductFind_TextChanged(object sender, EventArgs e)
        {
            grdProduct.Rows.Clear();
            grdProduct.Refresh();
            var p = (await ps.GetAll()).ToList();
            var st = (await ss.GetAll()).ToList();
            var searchProduct = (from q in p
                                 join s in st
                                 on q.ProductID equals s.ProductID
                                 where q.ProductName.ToLower().Contains((txtProductFind.Text).ToLower())
                                 orderby q.ProductName ascending
                                 select new StockProductViewModel
                                 {
                                     ProductID = q.ProductID,
                                     ProductName = q.ProductName,
                                     Desciription = q.ProductDesriciption

                                 }).ToList();

            foreach (var product in searchProduct)
            {

                AddRowToGridProduct(product);
            }
        }

        private async void grdProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var frm = sp.GetRequiredService<SelectStockProductFrm>();
            frm.ShowDialog();
            

        }
        private void AddRowToGridProductStock(StockAddListViewModel model)
        {
            DataGridViewRow row = (DataGridViewRow)grdList.Rows[0].Clone();
            row.Cells[0].Value = model.ProductID;
            row.Cells[1].Value = model.ProductName;
            row.Cells[2].Value = model.Color;
            row.Cells[3].Value = model.Size;
            row.Cells[4].Value = model.Piece;
            row.Cells[5].Value = model.Price;
            row.Cells[6].Value = model.CritialStock;

            grdList.Rows.Add(row);
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            decimal StockTotalPrice = Convert.ToDecimal(grdProduct.CurrentRow.Cells[5].Value) * Convert.ToInt32(grdProduct.CurrentRow.Cells[4].Value);
            ss.Add(Convert.ToDecimal(grdProduct.CurrentRow.Cells[5].Value), StockTotalPrice, Convert.ToInt16(grdProduct.CurrentRow.Cells[4].Value), Convert.ToInt16(grdProduct.CurrentRow.Cells[6].Value), Convert.ToString(grdProduct.CurrentRow.Cells[2].Value), Convert.ToString(grdProduct.CurrentRow.Cells[4].Value),supllierID, Convert.ToInt32(grdProduct.CurrentRow.Cells[0].Value));
            DialogResult dialogResult = MessageBox.Show("Stok başarıyla eklenmiştir. Bir stok daha eklemek ister misiniz?", "Bilgilendirme Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                txtSupplier.Text = "";
                txtSupplierName.Text = "";
                txtProductFind.Text = "";
                txtTotalPrice.Text = "";
            }
            else
            {
                this.Close();
            }
            txtSupplier.Text = "";
            txtSupplierName.Text = "";
            txtProductFind.Text = "";
            txtTotalPrice.Text = "";
        }
    }
}