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
        private readonly IProductService ps;
        private readonly ISupplierService sps;
        private readonly IServiceProvider sp;
        public int supllierID;
        public UpdateStock(IStockService ss, IProductService ps, ISupplierService sps, IServiceProvider sp)
        {
            InitializeComponent();
            this.ss = ss;
            this.ps = ps;
            this.sps = sps;
            this.sp = sp;
        }

        private void cbbUpdateSupplierSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void txtUpdateSupplierSearch_TextChanged(object sender, EventArgs e)
        {
            var p = (await ps.GetAll()).ToList();
            var st = (await ss.GetAll()).ToList();
            var sup = (await sps.GetAll()).ToList();
            var find = (from q in p
                                 join s in st
                                 on q.ProductID equals s.ProductID
                                 join j in sup
                                 on s.SupplierID equals j.SupplierID
                                 where q.ProductName.ToLower().Contains((txtUpdateStockSearch.Text).ToLower())
                                 orderby q.ProductName ascending
                                 select new 
                                 {
                                     StokID = s.StockID,
                                     ÜrünAdi = q.ProductName,
                                     ÜrünAciklamasi = q.ProductDesriciption,
                                     TedarikciAdi = j.SupplierName,
                                     Renk = s.Color,
                                     Beden = s.Size,
                                     Adet = s.StockPiece,
                                     BirimFiyati = s.PurchaseUnitPrice,
                                     ToplamFiyati = s.StockTotalPrice,
                                     TedarikciID = s.SupplierID,
                                     ProductID = q.ProductID,
                                     KritikStok = s.StockCritical,

                                 }).ToList();

            grdStockList.DataSource = find;

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

        private async void UpdateStock_Load(object sender, EventArgs e)
        {
            grdStockList.DataSource = null;
            grdStockList.Rows.Clear();
            grdStockList.Refresh();
            cbbUpdateSuppliers.Items.Clear();
            cbbSize.Items.Clear();
            cbbProduct.Items.Clear();
            cbbColor.Items.Clear();
            var p = (await ps.GetAll()).ToList();
            var st = (await ss.GetAll()).ToList();
            var sup = (await sps.GetAll()).ToList();
            var list = (from q in sup
                        select new
                        {
                            TedarilciID = q.SupplierID,
                            TedarikciAdi = q.SupplierName,

                        }).ToList();
            foreach (var item in list)
            {
                cbbUpdateSuppliers.Items.Add(item.TedarikciAdi);

            }
            var product = (from q in p
                           select new
                           {
                               Name = q.ProductName,
                           }).ToList();
            foreach (var item in product)
            {
                cbbProduct.Items.Add(item.Name);

            }
            
        }

        private async void grdStockList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbColor.Items.Clear();
            cbbSize.Items.Clear();
            cbbProduct.Text = grdStockList.CurrentRow.Cells[1].Value.ToString();
            txtDescription.Text = grdStockList.CurrentRow.Cells[2].Value.ToString();
            cbbUpdateSuppliers.Text = grdStockList.CurrentRow.Cells[3].Value.ToString();
            cbbColor.Text = grdStockList.CurrentRow.Cells[4].Value.ToString();
            cbbSize.Text = grdStockList.CurrentRow.Cells[5].Value.ToString();
            txtUpdateStockPiece.Text = grdStockList.CurrentRow.Cells[6].Value.ToString();
            txtUpdateStockPrice.Text = grdStockList.CurrentRow.Cells[7].Value.ToString();
            txtUpdateCriticalStock.Text = grdStockList.CurrentRow.Cells[11].Value.ToString();
            txtTotal.Text = (Convert.ToDecimal(txtUpdateStockPrice.Text) * Convert.ToInt32(txtUpdateStockPiece.Text)).ToString();
            var p = (await ps.GetAll()).ToList();
            var st = (await ss.GetAll()).ToList();
            var productList = (from q in p
                               join s in st
                               on q.ProductID equals s.ProductID
                               where q.ProductName.ToLower() == (cbbProduct.Text).ToLower()
                               select new
                               {
                                   color = s.Color,
                                   size = s.Size,

                               }).ToList();

            foreach (var item in productList)
            {
                cbbColor.Items.Add(item.color);
                cbbSize.Items.Add(item.size);

            }
            cbbColor.SelectedIndex = 0;
            cbbSize.SelectedIndex = 0;
            

        }

        private void btnUpdatedSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                ss.Update(Convert.ToInt32(grdStockList.CurrentRow.Cells[0].Value), Convert.ToDecimal(txtUpdateStockPrice.Text), Convert.ToDecimal(txtTotal.Text), Convert.ToInt32(txtUpdateStockPiece.Text), Convert.ToInt16(txtUpdateCriticalStock.Text), cbbColor.Text, cbbSize.Text, Convert.ToInt32(grdStockList.CurrentRow.Cells[9].Value.ToString()), Convert.ToInt32(grdStockList.CurrentRow.Cells[10].Value.ToString()) );
                DialogResult result = MessageBox.Show("Ürün başarıyla güncellenmiştir.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTotal.Text = "";
                txtUpdateCriticalStock.Text = "";
                txtDescription.Text = "";
                txtUpdateStockPiece.Text = "";
                txtUpdateStockPrice.Text = "";
                cbbColor.Items.Clear();
                cbbSize.Items.Clear();
                grdStockList.DataSource = null;
                grdStockList.Refresh();
                this.Close();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
