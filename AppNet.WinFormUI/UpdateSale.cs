using AppNet.AppService;
using AppNet.Domain.Validations;
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
    public partial class UpdateSale : Form
    {
        private readonly IProductService ps;
        private readonly ICustomerService cs;
        private readonly IStockService sts;
        private readonly ISalesService ss;
        private readonly IServiceProvider sp;
        public UpdateSale(IServiceProvider sp, IProductService ps, ICustomerService cs, IStockService sts, ISalesService ss)
        {
            InitializeComponent();
            this.ps = ps;
            this.cs = cs;
            this.sts = sts;
            this.ss = ss;
            this.sp = sp;
        }

        private async void UpdateSale_Load(object sender, EventArgs e)
        {
            grdUpdateSaleList.Rows.Clear();
            grdUpdateSaleList.Refresh();
            cbbCustomer.Items.Clear();
            cbbName.Items.Clear();
            cbbSale.Items.Clear();
            cbbSize.Items.Clear();
            var p = (await ps.GetAll()).ToList();
            var st = (await sts.GetAll()).ToList();
            var c = (await cs.GetAll()).ToList();
            var customerlist= (from q in c
                               select new
                               {
                                  CustomerID = q.CustomerID,
                                  CustomerName = q.CustomerName,

                               }).ToList();
            foreach (var item in customerlist)
            {
                cbbCustomer.Items.Add(item.CustomerName);

            }
            var productList = (from q in p
                               join s in st
                               on q.ProductID equals s.ProductID
                               where q.ProductName.ToLower() == (cbbName.Text).ToLower()
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
            cbbSale.Items.Clear();
            cbbSale.Items.Add("Kredi Kartı");
            cbbSale.Items.Add("Peşin");

            cbbStatus.Items.Clear();
            cbbStatus.Items.Add("Beklemede");
            cbbStatus.Items.Add("Ödeme Yapıldı");
            cbbStatus.Items.Add("Sipariş Başarılı");
            cbbStatus.Items.Add("Sipariş İptal Edildi");
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
 

        private async void txtUpdateSaleSearch_TextChanged(object sender, EventArgs e)
        {
            var p = (await ps.GetAll()).ToList();
            var st = (await sts.GetAll()).ToList();
            var sa = (await ss.GetAll()).ToList();
            var c = (await cs.GetAll()).ToList();
            var find = (from q in p
                                 join s in st
                                 on q.ProductID equals s.ProductID
                                 join sl in sa
                                 on s.StockID equals sl.StockID
                                 join cu in c
                                 on sl.CustomerID equals cu.CustomerID
                                 where cu.CustomerName.ToLower().Contains((txtUpdateSaleSearch.Text).ToLower())
                                 orderby q.ProductName ascending
                                 select new 
                                 {
                                     ÜrünID = q.ProductID,
                                     ÜrünAdi = q.ProductName,
                                     MüsteriAdi = cu.CustomerName,
                                     Renk = s.Color,
                                     Beden = s.Size,
                                     Adet = s.StockPiece,
                                     Fiyat = s.PurchaseUnitPrice,
                                     ÖdemeSekli = sl.SalePaymentMethod,
                                     Durum = sl.SaleStatus,
                                     StokID = s.StockID,
                                     MusteriID = sl.CustomerID,

                                 }).ToList();

            grdUpdateSaleList.DataSource = find;
            
        }
       

        private async void grdUpdateSaleList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbCustomer.SelectedText = grdUpdateSaleList.CurrentRow.Cells[2].Value.ToString();
            cbbName.SelectedText = grdUpdateSaleList.CurrentRow.Cells[1].Value.ToString();
            cbbColor.SelectedText = grdUpdateSaleList.CurrentRow.Cells[3].Value.ToString();
            cbbSize.SelectedText = grdUpdateSaleList.CurrentRow.Cells[4].Value.ToString();
            cbbStatus.SelectedText = grdUpdateSaleList.CurrentRow.Cells[8].Value.ToString();
            cbbSale.SelectedText = grdUpdateSaleList.CurrentRow.Cells[7].Value.ToString();
            txtPiece.Text = grdUpdateSaleList.CurrentRow.Cells[5].Value.ToString();
            txtPrice.Text = grdUpdateSaleList.CurrentRow.Cells[6].Value.ToString();
            txtTotalPrice.Text = Convert.ToString(Convert.ToInt32(txtPiece.Text) * Convert.ToDecimal(txtPrice.Text));
            
        }

        private void btnUpdatedSale_Click(object sender, EventArgs e)
        {
            var Ürün_Adı = cbbName.Text;
            var Firma_Adı = cbbCustomer.Text;
            var Fiyat = txtPrice.Text;
            var Beden = cbbSize.Text;
            var Renk = cbbColor.Text;
            var Adet = txtPiece.Text;
            var Ödeme_Şekli = cbbSale.Text;
            var Durum = cbbStatus.Text;
            txtTotalPrice.Text = Convert.ToString(Convert.ToDecimal(txtPrice.Text) * Convert.ToInt32(txtPiece.Text));
            try
            {
                Ürün_Adı.NullOrEmpty(nameof(Ürün_Adı));
                Firma_Adı.NullOrEmpty(nameof(Firma_Adı));
                Fiyat.NullOrEmpty(nameof(Fiyat));
                Beden.NullOrEmpty(nameof(Beden));
                Renk.NullOrEmpty(nameof(Renk));
                Adet.NullOrEmpty(nameof(Adet));
                Ödeme_Şekli.NullOrEmpty(nameof(Ödeme_Şekli));
                Durum.NullOrEmpty(nameof(Durum));

                try {
                ss.Update(Convert.ToInt32(grdUpdateSaleList.CurrentRow.Cells[0].Value), Convert.ToInt32(grdUpdateSaleList.CurrentRow.Cells[9].Value), Convert.ToInt32(grdUpdateSaleList.CurrentRow.Cells[10].Value), Convert.ToInt16(txtPiece.Text), Convert.ToDecimal(txtPrice.Text), Convert.ToDecimal(txtTotalPrice.Text), txtAUpdateSaleDescription.Text, cbbStatus.Text, cbbSale.Text);
                DialogResult result = MessageBox.Show("Satış başarıyla güncellenmiştir.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAUpdateSaleDescription.Text = "";
                txtPiece.Text = "";
                txtPrice.Text = "";
                txtAUpdateSaleDescription.Text = "";
                grdUpdateSaleList.DataSource = null;
                grdUpdateSaleList.Refresh();
                cbbCustomer.Items.Clear();
                cbbName.Items.Clear();
                cbbSale.Items.Clear();
                cbbSize.Items.Clear();
                this.Close();
                }
                catch
                {
                    DialogResult dialogResult = MessageBox.Show("Bilinmeyen bir hata oluştu, güncelleme işleminiz başarız!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (ArgumentNullException ex)
            {
                DialogResult dialogResult = MessageBox.Show($" {ex.ParamName} alanı boş bırakamazsınız!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void NullOrEmpty(object p)
        {
            throw new NotImplementedException();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void txtPiece_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
