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
    public partial class AddSale : Form
    {
        private readonly IProductService ps;
        private readonly ICustomerService cs;
        private readonly IStockService sts;
        private readonly ISalesService ss;

        public AddSale(IProductService ps, ICustomerService cs, IStockService sts, ISalesService ss)
        {
            InitializeComponent();
            this.ps = ps;
            this.cs = cs;
            this.sts = sts;
            this.ss = ss;
        }

        private async void AddSale_Load(object sender, EventArgs e)
        {
            if (grdProduct.Rows.Count == 0 && grdcustomer.Rows.Count ==0)
            {
                grdProduct.Rows.Clear();
                grdProduct.Columns.Add("Product ID", "Ürün ID");
                grdProduct.Columns.Add("ProductName", "Ürün Adı");
                grdProduct.Columns.Add("ProductPrice", "Fiyat");
                grdProduct.Columns.Add("ProductCount", "Adet");
                grdProduct.Columns.Add("ProductDescription", "Açıklama");
                grdProduct.Columns.Add("StockID", "Stok Numarası");
                grdcustomer.Columns.Add("CustomerID", "Müşteri ID");
                grdcustomer.Columns.Add("CustomerName", "Müşteri Adı");
                LoadGridData();

                grdProduct.Columns[0].Visible = false;
                grdcustomer.Columns[0].Visible = false;
            }
            
            
            cbbAddSalePay.Items.Clear();
            cbbAddSalePay.Items.Add("Kredi Kartı");
            cbbAddSalePay.Items.Add("Peşin");
            cbbAddSalePay.SelectedIndex = 0;

            cbbStatus.Items.Clear();
            cbbStatus.Items.Add("Beklemede");
            cbbStatus.Items.Add("Ödeme Yapıldı");
            cbbStatus.Items.Add("Sipariş Başarılı");
            cbbStatus.Items.Add("Sipariş İptal Edildi");
            cbbStatus.SelectedIndex = 0;


        }
        private async void LoadGridData()
        {
            grdProduct.Rows.Clear();
            grdProduct.Refresh();
            var p = (await ps.GetAll()).ToList();
            var c = (await cs.GetAll()).ToList();
            var st = (await sts.GetAll()).ToList();
            var sa = (await ss.GetAll()).ToList();
            
            var productList = (from q in p
                               join s in st
                               on q.ProductID equals s.ProductID
                               select new SaleProductListViewModel
                               {
                                   ProductID = q.ProductID,
                                   ProductName = q.ProductName,
                                   ProductPrice = s.PurchaseUnitPrice,
                                   ProductCount = s.StockPiece,
                                   ProductDescription = q.ProductDesriciption,
                                   StockID = s.StockID,

                               }).ToList();
            foreach (var product in productList)
            {
                AddRowToGridProduct(product);
            }
            var customerList = (from q in c
                                select new SaleCustomerViewModel
                                {
                                    CustomerID = q.CustomerID,
                                    CustomerName = q.CustomerName,

                                }).ToList();
            foreach (var customer in customerList)
            {
                AddRowToGridCustomer(customer);
            }
           

        }
        private void AddRowToGridProduct(SaleProductListViewModel model)
        {
            DataGridViewRow row = (DataGridViewRow)grdProduct.Rows[0].Clone();
            row.Cells[0].Value = model.ProductID;
            row.Cells[1].Value = model.ProductName;
            row.Cells[2].Value = model.ProductPrice;
            row.Cells[3].Value = model.ProductCount;
            row.Cells[4].Value = model.ProductDescription;
            row.Cells[5].Value = model.StockID;

            grdProduct.Rows.Add(row);
        }
        private void AddRowToGridCustomer(SaleCustomerViewModel model)
        {
            DataGridViewRow row = (DataGridViewRow)grdcustomer.Rows[0].Clone();
            row.Cells[0].Value = model.CustomerID;
            row.Cells[1].Value = model.CustomerName;

            grdcustomer.Rows.Add(row);
        }

        private async void btnAddProduct_Click(object sender, EventArgs e)
        {
            decimal TotalPrice = Convert.ToDecimal(txtPrice.Text) * Convert.ToInt16(txtAddSalePiece.Text);
            ss.Add(Convert.ToInt32(grdProduct.CurrentRow.Cells[5].Value), Convert.ToInt32(grdcustomer.CurrentRow.Cells[0].Value), Convert.ToInt16(txtAddSalePiece.Text), Convert.ToDecimal(txtPrice.Text), TotalPrice, txtAddSaleDescription.Text, cbbStatus.Text,cbbAddSalePay.Text);
            DialogResult dialogResult = MessageBox.Show("Sipariş başarıyla eklenmiştir. Bir sipariş daha eklemek ister misiniz?", "Bilgilendirme Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                txtAddSaleDescription.Text = "";
                txtAddSalePiece.Text = "";
            }
            else
            {
                this.Close();
            }
            txtAddSaleDescription.Text = "";
            txtAddSalePiece.Text = "";
        }

        private void grdProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cbbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void btnFind_Click(object sender, EventArgs e)
        {
            
        }

        private async void txtProductFind_TextChanged(object sender, EventArgs e)
        {
            grdProduct.Rows.Clear();
            grdProduct.Refresh();
            var p = (await ps.GetAll()).ToList();
            var st = (await sts.GetAll()).ToList();
            var searchProduct = (from q in p
                                 join s in st
                                 on q.ProductID equals s.ProductID
                                 where q.ProductName.ToLower().Contains((txtProductFind.Text).ToLower())
                                 orderby q.ProductName ascending
                                 select new SaleProductListViewModel
                                 {
                                     ProductID = q.ProductID,
                                     ProductName = q.ProductName,
                                     ProductPrice = s.PurchaseUnitPrice,
                                     ProductCount = s.StockPiece,
                                     ProductDescription = q.ProductDesriciption,
                                     StockID = s.StockID,

                                 }).ToList();

            foreach (var product in searchProduct)
            {
                
                AddRowToGridProduct(product);
            }
        }

        private async void txtCustomerFind_TextChanged(object sender, EventArgs e)
        {
            grdcustomer.Rows.Clear();
            grdcustomer.Refresh();
            var customer = (await cs.GetAll()).ToList();
            var searchCustomer = (from q in customer
                                 where q.CustomerName.ToLower().Contains((txtCustomerFind.Text).ToLower())
                                 orderby q.CustomerName ascending
                                 select new SaleCustomerViewModel
                                 {
                                     CustomerID = q.CustomerID,
                                     CustomerName = q.CustomerName,

                                 }).ToList();

            foreach (var customerFind in searchCustomer)
            {

                AddRowToGridCustomer(customerFind);
            }
           
        }

        private void grdProduct_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtProductName.Text = grdProduct.CurrentRow.Cells[1].Value.ToString();
        }

        private void grdcustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCustomerName.Text = grdcustomer.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
