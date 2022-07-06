using AppNet.AppService;
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
    public partial class UpdateStock : Form
    {
        private readonly IStockService ss;
        private readonly ISupplierService sup;
        public UpdateStock(IStockService ss, ISupplierService sup)
        {
            InitializeComponent();
            this.ss = ss;
            this.sup = sup;
        }

        private void cbbUpdateSupplierSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtUpdateSupplierSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUpdateStockName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbUpdateProductType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUpdateStockPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbUpdateSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtUpdateStockPiece_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUpdateCriticalStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UpdateStock_Load(object sender, EventArgs e)
        {
            cbbUpdateStockSearch.Items.Clear();
            cbbUpdateStockSearch.Items.Add("Stok ID'sine Göre");
            cbbUpdateStockSearch.Items.Add("Teadrikçi Adına Göre");
            cbbUpdateStockSearch.SelectedIndex = 0;
        }

        private async void btnSearchUpdate_Click(object sender, EventArgs e)
        {
            var stock = (await ss.GetAll()).ToList();
            var supplier = (await sup.GetAll()).ToList();
            if (cbbUpdateStockSearch.SelectedItem == "Stok ID'sine Göree")
            {
                try
                {
                    var gridList = (from q in stock
                                    join c in supplier
                                    on q.SupplierID equals c.SupplierID
                                    where q.SupplierID == Convert.ToInt32(txtUpdateStockSearch.Text)
                                    select new
                                    {
                                        ÜrünAdı = q.Product.ProductName,
                                        Tedarikçi = c.SupplierName,
                                        Fiyat = q.PurchaseUnitPrice,
                                        Adet = q.StockPiece,
                                        KritikStok = q.StockCritical,

                                    }).ToList();
                    grdStockList.DataSource = gridList;
                    foreach (var i in gridList)
                    {
                        txtUpdateStockName.Text = i.ÜrünAdı;
                        cbbUpdateSuppliers.SelectedItem = i.Tedarikçi;
                        txtUpdateStockPrice.Text = i.Fiyat.ToString();
                        txtUpdateStockPiece.Text = i.Adet.ToString();
                        txtUpdateCriticalStock.Text = i.KritikStok.ToString();
                    }
                }
                catch
                {
                    DialogResult dialogResult = MessageBox.Show("Yazdığınız arama kelimesinde sorun bulundu, lütfen kontrol ediniz!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else if (cbbUpdateStockSearch.SelectedItem == "Tedarikçi Adına Göre")
            {
                try
                {
                    var gridList = (from q in stock
                                    where q.Supplier.SupplierName == txtUpdateStockSearch.Text
                                    select new
                                    {
                                        ÜrünAdı = q.Product.ProductName,
                                        Tedarikçi = q.Supplier.SupplierName,
                                        Fiyat = q.PurchaseUnitPrice,
                                        Adet = q.StockPiece,
                                        KritikStok = q.StockCritical,

                                    }).ToList();
                    grdStockList.DataSource = gridList;
                    foreach (var i in gridList)
                    {
                        txtUpdateStockName.Text = i.ÜrünAdı;
                        cbbUpdateSuppliers.SelectedItem = i.Tedarikçi;
                        txtUpdateStockPrice.Text = i.Fiyat.ToString();
                        txtUpdateStockPiece.Text = i.Adet.ToString();
                        txtUpdateCriticalStock.Text = i.KritikStok.ToString();
                    }
                }
                catch
                {
                    DialogResult dialogResult = MessageBox.Show("Yazdığınız arama kelimesinde sorun bulundu, lütfen kontrol ediniz!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Aradığınız stok bulunamamıştır!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
    }
    }
}
