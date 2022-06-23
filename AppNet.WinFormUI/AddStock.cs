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
    public partial class AddStock : Form
    {
        private readonly IStockService ss;
        private readonly IProductService ps;
        private readonly ISupplierService sps;
        public AddStock(IStockService ss, IProductService ps, ISupplierService sps)
        {
            InitializeComponent();
            this.ss = ss;
            this.ps = ps;
            this.sps = sps;
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            decimal StockTotalPrice = Convert.ToInt32(txtAddStockPiece.Text) * Convert.ToDecimal(txtAddStockPrice.Text);
            ss.Add(cbbAddProductType.Text, Convert.ToDecimal(txtAddStockPrice.Text), StockTotalPrice, Convert.ToInt16(txtAddStockPiece.Text), Convert.ToInt16(txtAddCriticalStock.Text), Convert.ToInt32(cbbSelectedSuppliers.SelectedValue), Convert.ToInt32(cbbAddStockProductName.SelectedValue));
            DialogResult dialogResult = MessageBox.Show("Stok başarıyla eklenmiştir. Bir stok daha eklemek ister misiniz?", "Bilgilendirme Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                txtAddStockPrice.Text = "";
                txtAddCriticalStock.Text = "";
                txtAddStockPiece.Text = "";
            }
            else
            {
                this.Close();
            }
            txtAddStockPrice.Text = "";
            txtAddCriticalStock.Text = "";
            txtAddStockPiece.Text = "";
        }


        private async void AddStock_Load(object sender, EventArgs e)
        {
            var p = (await ps.GetAll()).ToList();
            var sp = (await sps.GetAll()).ToList();
            var s = (await ss.GetAll()).ToList();
            foreach (var pr in p)
            {
                cbbAddStockProductName.DataSource = p;
                cbbAddStockProductName.DisplayMember = nameof(pr.ProductName);
                cbbAddStockProductName.ValueMember = nameof(pr.ProductID);
            }
            foreach (var sup in sp)
            {
                cbbSelectedSuppliers.DataSource = sp;
                cbbSelectedSuppliers.DisplayMember = nameof(sup.SupplierName);
                cbbSelectedSuppliers.ValueMember = nameof(sup.SupplierID);
            }
            cbbAddProductType.Items.Clear();
            cbbAddProductType.Items.Add("kg");
            cbbAddProductType.Items.Add("l");
            cbbAddProductType.Items.Add("cm");
            cbbAddProductType.Items.Add("m");
            cbbAddProductType.Items.Add("ton");
            cbbAddProductType.SelectedIndex = 0;
        }
    }
}