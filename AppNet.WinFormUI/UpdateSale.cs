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
    public partial class UpdateSale : Form
    {
        private readonly ISalesService ss;
        private readonly ICustomerService cs;
        public UpdateSale(ISalesService ss, ICustomerService cs)
        {
            InitializeComponent();
            this.ss = ss;
            this.cs = cs;
        }

        private void UpdateSale_Load(object sender, EventArgs e)
        {
            cbbUpdateSale.Items.Clear();
            cbbUpdateSale.Items.Add("Sipariş ID'sine Göre");
            cbbUpdateSale.Items.Add("Müşteri Adına Göre");
            cbbUpdateSale.SelectedIndex = 0;
        }

        private async void btnSearchUpdate_Click(object sender, EventArgs e)
        {
            var sale = (await ss.GetAll()).ToList();
            var customer = (await cs.GetAll()).ToList();
            if (cbbUpdateSale.SelectedItem == "Sipariş ID'sine Göre")
            {
                try
                {
                    var gridList = (from q in sale
                                    join c in customer
                                    on q.CustomerID equals c.CustomerID
                                    where q.SaleID == Convert.ToInt32(txtUpdateSaleSearch.Text)
                                    select new
                                    {
                                        ID = q.SaleID,
                                        ÜrünAdı = q,
                                        FirmaAdı = c.CustomerName,
                                        Fiyat = q.ProductPiece,
                                        Adet = q.ProductPiece,
                                        ÖdemeŞekli = q.SalePaymentMethod,
                                        Durum = q.SaleStatus,
                                        Açıklama=q.SaleDesription

                                    }).ToList();
                    grdUpdateSaleList.DataSource = gridList;
                    foreach (var i in gridList)
                    {
                        cbbUpdateSaleProduct.SelectedItem = i.ÜrünAdı;
                        cbbUpdateSaleName.SelectedItem = i.FirmaAdı;
                        cbbUpdateSalePay.SelectedItem = i.Fiyat;
                        txtUpdateSalePiece.Text = Convert.ToString(i.Adet);
                        cbbStatus.SelectedItem = i.ÖdemeŞekli;
                        cbbStatus.SelectedItem = i.Durum;
                        txtAUpdateSaleDescription.Text = i.Açıklama;
                    }
                }
                catch
                {
                    DialogResult dialogResult = MessageBox.Show("Yazdığınız arama kelimesinde sorun bulundu, lütfen kontrol ediniz!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else if (cbbUpdateSale.SelectedItem == "Müşteri Adına Göre")
            {
                try
                {
                    var gridList = (from q in sale
                                    join c in customer
                                    on q.CustomerID equals c.CustomerID
                                    where c.CustomerName == txtUpdateSaleSearch.Text
                                    select new
                                    {
                                        ID = q.SaleID,
                                        ÜrünAdı = q.Stock.Product.ProductName,
                                        FirmaAdı = c.CustomerName,
                                        Fiyat = q.ProductPiece,
                                        Adet = q.ProductPiece,
                                        ÖdemeŞekli = q.SalePaymentMethod,
                                        Durum = q.SaleStatus,
                                        Açıklama = q.SaleDesription

                                    }).ToList();
                    grdUpdateSaleList.DataSource = gridList;
                    foreach (var i in gridList)
                    {
                        cbbUpdateSaleProduct.SelectedItem = i.ÜrünAdı;
                        cbbUpdateSaleName.SelectedItem = i.FirmaAdı;
                        cbbUpdateSalePay.SelectedItem = i.Fiyat;
                        txtUpdateSalePiece.Text = Convert.ToString(i.Adet);
                        cbbStatus.SelectedItem = i.ÖdemeŞekli;
                        cbbStatus.SelectedItem = i.Durum;
                        txtAUpdateSaleDescription.Text = i.Açıklama;
                    }
                }
                catch
                {
                    DialogResult dialogResult = MessageBox.Show("Yazdığınız arama kelimesinde sorun bulundu, lütfen kontrol ediniz!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Aradığınız tedarikçi bulunamamıştır!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
