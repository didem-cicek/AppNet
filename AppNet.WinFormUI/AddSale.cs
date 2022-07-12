using AppNet.AppService;
using AppNet.Domain.Validations;
using AppNet.Infrastructer.Notification;
using AppNet.Infrastructer.Persistence.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private readonly IServiceProvider sp;
        public int customerID;
        public int Piece;
        public AddSale(IServiceProvider sp, IProductService ps, ICustomerService cs, IStockService sts, ISalesService ss)
        {
            InitializeComponent();
            this.ps = ps;
            this.cs = cs;
            this.sts = sts;
            this.ss = ss;
            this.sp = sp;
        }

        private async void AddSale_Load(object sender, EventArgs e)
        {
            if (grdProduct.Rows.Count == 0)
            {
                grdProduct.Rows.Clear();
                grdProduct.Columns.Add("Product ID", "Ürün ID");
                grdProduct.Columns.Add("ProductName", "Ürün Adı");
                grdProduct.Columns.Add("ProductPrice", "Fiyat");
                grdProduct.Columns.Add("ProductCount", "Adet");
                grdProduct.Columns.Add("ProductDescription", "Açıklama");
                grdProduct.Columns.Add("StockID", "Stok Numarası");
                LoadGridData();

                grdProduct.Columns[0].Visible = false;
            }
            if (grdList.Rows.Count == 0)
            {
                grdList.Rows.Clear();
                grdList.Columns.Add("Product ID", "Ürün ID");
                grdList.Columns.Add("ProductName", "Ürün Adı");
                grdList.Columns.Add("Color", "Renk");
                grdList.Columns.Add("Size", "Beden");
                grdList.Columns.Add("Piece", "Adet");
                grdList.Columns.Add("Price", "Fiyat");
                grdList.Columns.Add("StockID", "Stok Numarası");
                grdList.Columns[0].Visible = false;
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

        private async void btnAddProduct_Click(object sender, EventArgs e)
        {
            var Müşteri_Adı = txtCustomerName.Text;
            var Ürün_Bilgisi = grdList.Rows.Count;
            try
            {
                Müşteri_Adı.NullOrEmpty(nameof(Müşteri_Adı));
                if (Ürün_Bilgisi != null) { 
            
                decimal TotalPrice = Convert.ToDecimal(grdList.CurrentRow.Cells[5].Value) * Convert.ToInt16(grdList.CurrentRow.Cells[4].Value);
                ss.Add(Convert.ToInt32(grdProduct.CurrentRow.Cells[5].Value), Convert.ToInt32(customerID), Convert.ToInt16(grdList.CurrentRow.Cells[4].Value), Convert.ToDecimal(grdList.CurrentRow.Cells[5].Value), TotalPrice, txtDesciption.Text, cbbStatus.Text, cbbAddSalePay.Text);
                DialogResult dialogResult = MessageBox.Show("Sipariş başarıyla eklenmiştir. Bir sipariş daha eklemek ister misiniz?", "Bilgilendirme Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                notifyIcon1.ShowBalloonTip(1000, "Siparişiniz Başarılı", "Siparişiniz başarılı ile oluşturulmuştur. Telegram bildirimi gönderilmiştir. ", ToolTipIcon.Info);
                var n = new TelegramNotification();
                n.OnMessage("Yeni Bir Sipariş Oluşturuldu");
                var product = (await ps.GetAll()).ToList();
                var stock = (await sts.GetAll()).ToList();
                var dropFromStock = (from q in product
                                 join s in stock
                                 on q.ProductID equals s.ProductID
                                 select new 
                                 {
                                     ProductID = q.ProductID,
                                     ProductName = q.ProductName,
                                     ProductPrice = s.PurchaseUnitPrice,
                                     ProductPiece = s.StockPiece - Piece,
                                     ProductDescription = q.ProductDesriciption,
                                     TotalPrice = s.StockTotalPrice,
                                     CritialStok = s.StockCritical,
                                     Color = s.Color,
                                     Size = s.Size,
                                     StockID = s.StockID,
                                     SupplierID =  s.SupplierID,

                                 }).ToList();
                foreach (var item in dropFromStock){
                sts.Update(item.StockID, item.ProductPrice, item.TotalPrice, item.ProductPiece, item.CritialStok, item.Color, item.Size, item.SupplierID, item.ProductID);
                }
            
                if (dialogResult == DialogResult.Yes)
                {
                txtDesciption.Text = "";
                txtProductFind.Text = "";
                txtTotalPrice.Text = "";
                grdList.Rows.Clear();
                }
                else
                {
                this.Close();
                }
                txtDesciption.Text = "";
                txtProductFind.Text = "";
                txtTotalPrice.Text = "";
                txtCustomer.Text = "";
                grdList.Rows.Clear();}}
            catch (ArgumentNullException ex)
            {
                DialogResult dialogResult = MessageBox.Show($" {ex.ParamName} alanı boş bırakamazsınız!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

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

            
           
           
        }

        private async void grdProduct_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            var frm = sp.GetRequiredService<SelectProductFrm>();
            frm.ShowDialog();
            try {
            var p = (await ps.GetAll()).ToList();
            var s = (await sts.GetAll()).ToList();
            var searchProduct = (from q in p
                                 join st in s
                                 on q.ProductID equals st.ProductID
                                 where q.ProductID == Convert.ToInt32(grdProduct.CurrentRow.Cells[0].Value)
                                 orderby q.ProductName ascending
                                 select new SaleProductList
                                 {
                                     ProductID = q.ProductID,
                                     ProductName = q.ProductName,
                                     Color = st.Color,
                                     Size = st.Size,
                                     Piece = Convert.ToInt32(frm.txtPiece.Text),
                                     Price = Convert.ToDecimal(frm.txtPrice.Text),
                                     stockID = st.StockID,
                                 }).ToList();
                
            txtTotalPrice.Text = Convert.ToString(Convert.ToInt32(frm.txtPiece.Text) * Convert.ToDecimal(frm.txtPrice.Text));
            foreach (var product in searchProduct)
            {
                    Piece = product.Piece;
                    AddRowToGridProductSale(product);
            } }
            catch(Exception ex)
            {

            }


        }
        private void AddRowToGridProductSale(SaleProductList model)
        {
            DataGridViewRow row = (DataGridViewRow)grdList.Rows[0].Clone();
            row.Cells[0].Value = model.ProductID;
            row.Cells[1].Value = model.ProductName;
            row.Cells[2].Value = model.Color;
            row.Cells[3].Value = model.Size;
            row.Cells[4].Value = model.Piece;
            row.Cells[5].Value = model.Price;
            row.Cells[6].Value = model.stockID;

            grdList.Rows.Add(row);
        }

        private void grdcustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void productLabel_Click(object sender, EventArgs e)
        {

        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<SelectCustomer>();
            frm.ShowDialog();
            txtCustomerName.Text = frm.grdCustomer.CurrentRow.Cells[1].Value.ToString();
            txtCustomer.Text = frm.grdCustomer.CurrentRow.Cells[1].Value.ToString();
            customerID = Convert.ToInt32(frm.grdCustomer.CurrentRow.Cells[0].Value);
        }

        private void grdList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
