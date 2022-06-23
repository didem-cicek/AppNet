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
            var p = (await ps.GetAll()).ToList();
            var c = (await cs.GetAll()).ToList();
            var st = (await sts.GetAll()).ToList();
            var sa = (await ss.GetAll()).ToList();
            foreach (var pr in p)
            {
                cbbAddSaleProduct.DataSource = p;
                cbbAddSaleProduct.DisplayMember = nameof(pr.ProductName);
                cbbAddSaleProduct.ValueMember = nameof(pr.ProductID);
            }
            foreach (var cs in c)
            {
                cbbAddSaleName.DataSource = c;
                cbbAddSaleName.DisplayMember = nameof(cs.CustomerName);
                cbbAddSaleName.ValueMember = nameof(cs.CustomerID);
            }
            var price = (from q in st
                         join w in p
                         on q.ProductID equals w.ProductID
                         where q.ProductID == Convert.ToInt32(cbbAddSaleName.SelectedValue)
                         select new
                         {
                             ID = q.ProductID,
                             Fiyat = q.PurchaseUnitPrice
                         }).ToList();
            foreach (var i in price)
            {
                cbbAddSalePrice.DataSource = price;
                cbbAddSalePrice.DisplayMember = nameof(i.Fiyat);
                cbbAddSalePrice.ValueMember = nameof(i.ID);
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

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            decimal TotalPrice = Convert.ToDecimal(cbbAddSalePrice.Text) * Convert.ToInt16(txtAddSalePiece);
            ss.Add(Convert.ToInt32(cbbAddSaleProduct.SelectedValue), Convert.ToInt32(cbbAddSaleName.SelectedValue), Convert.ToInt16(txtAddSalePiece.Text), Convert.ToDecimal(cbbAddSalePrice), TotalPrice, txtAddSaleDescription.Text, cbbStatus.SelectedText,cbbAddSalePay.SelectedText);
        }
    }
}
