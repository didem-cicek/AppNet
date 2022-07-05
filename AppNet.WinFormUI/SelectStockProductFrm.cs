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
    public partial class SelectStockProductFrm : Form
    {
        private readonly IServiceProvider sp;
        private readonly IProductService ps;
        private readonly IStockService sts;
        public SelectStockProductFrm(IServiceProvider sp, IProductService ps, IStockService sts)
        {
            InitializeComponent();
            this.sp = sp;
            this.ps = ps;
            this.sts = sts;
        }

        private async void SelectStockProductFrm_Load(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<AddStock>();
            txtProductName.Text = frm.grdProduct.CurrentRow.Cells[1].Value.ToString();
            var p = (await ps.GetAll()).ToList();
            var s = (await sts.GetAll()).ToList();
            var productList = (from q in p
                               join st in s
                               on q.ProductID equals st.ProductID
                               where ProductName.ToUpper() == (txtProductName.Text).ToUpper()
                               select new
                               {
                                   ProductID = q.ProductID,
                                   ProductName = q.ProductName,

                               }).ToList();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<AddStock>();
            var p = (await ps.GetAll()).ToList();
            var s = (await sts.GetAll()).ToList();
            var searchProduct = (from q in p
                                 join st in s
                                 on q.ProductID equals st.ProductID
                                 where q.ProductID == Convert.ToInt32(frm.grdProduct.CurrentRow.Cells[0].Value)
                                 orderby q.ProductName ascending
                                 select new StockAddListViewModel
                                 {
                                     ProductID = q.ProductID,
                                     ProductName = q.ProductName,
                                     Color = txtColor.Text,
                                     Size = txtSize.Text,
                                     Piece = Convert.ToInt32(txtPiece.Text),
                                     Price = Convert.ToDecimal(txtPrice.Text),
                                     CritialStock = Convert.ToInt16(txtCritialStock.Text),
                                 }).ToList();

            foreach (var product in searchProduct)
            {

                AddRowToGridProductStock(product);
            }
            
        }
        private void AddRowToGridProductStock(StockAddListViewModel model)
        {
            var frm = sp.GetRequiredService<AddStock>();
            DataGridViewRow row = (DataGridViewRow)frm.grdList.Rows[0].Clone();
            row.Cells[0].Value = model.ProductID;
            row.Cells[1].Value = model.ProductName;
            row.Cells[2].Value = model.Color;
            row.Cells[3].Value = model.Size;
            row.Cells[4].Value = model.Piece;
            row.Cells[5].Value = model.Price;
            row.Cells[6].Value = model.CritialStock;

            frm.grdList.Rows.Add(row);
            this.Close();
        }
    }
}
