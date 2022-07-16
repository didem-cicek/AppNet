using AppNet.AppService;
using AppNet.Domain.Validations;
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
    public partial class SelectProductFrm : Form
    {
        private readonly IServiceProvider sp;
        private readonly IProductService ps;
        private readonly IStockService sts;
        public int ID { get; set; }
        public decimal Total { get; set; }
        public SelectProductFrm(IServiceProvider sp, IProductService ps, IStockService sts)
        {
            InitializeComponent();
            this.sp = sp;
            this.ps = ps;
            this.sts = sts;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void SelectProductFrm_Load(object sender, EventArgs e)
        {
            txtPiece.Text = "";
            txtProductName.Text = "";
            txtPrice.Text = "";
            cbbSize.Items.Clear();
            cbbColor.Items.Clear();
            var frm = sp.GetRequiredService<AddSale>();
            txtProductName.Text = frm.grdProduct.CurrentRow.Cells[1].Value.ToString();
            var p = (await ps.GetAll()).ToList();
            var s=(await sts.GetAll()).ToList();
            var find = s.FirstOrDefault(u => u.ProductID == Convert.ToInt32(frm.grdProduct.CurrentRow.Cells[0].Value));
            if(find != null) { 
            var productList = (from q in p
                               join st in s
                               on q.ProductID equals st.ProductID
                               where q.ProductName.ToLower() == (txtProductName.Text).ToLower()
                               select new
                               {
                                   ProductID = q.ProductID,
                                   ProductName = q.ProductName,
                                   color = st.Color,
                                   size = st.Size,

                               }).ToList();

                foreach (var item in productList.Distinct())
                {
                        cbbSize.Items.Add(item.size);
                }

            
        }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Stokta ürün yok, satışını yapamazsınız!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();    
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<AddSale>();
            var Satış_Fiyatı = txtPrice.Text;
            var Beden = cbbSize.Text;
            var Renk = cbbColor.Text;
            var Adet = txtPiece.Text;
            try
            {
                Satış_Fiyatı.NullOrEmpty(nameof(Satış_Fiyatı));
                Beden.NullOrEmpty(nameof(Beden));
                Renk.NullOrEmpty(nameof(Renk));
                Adet.NullOrEmpty(nameof(Adet));
                Total = Convert.ToInt32(txtPiece.Text) * Convert.ToDecimal(txtPrice.Text);
                this.Close();
            }
            catch (ArgumentNullException ex)
            {
                DialogResult dialogResult = MessageBox.Show($" {ex.ParamName} alanı boş bırakamazsınız!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txtPiece_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void txtPiece_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private async void cbbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            var p = (await ps.GetAll()).ToList();
            var s = (await sts.GetAll()).ToList();
            cbbColor.Items.Clear();
            var List = (from q in p
                               join st in s
                               on q.ProductID equals st.ProductID
                               where st.Size == (cbbSize.Text).ToLower() && q.ProductName.ToLower() == (txtProductName.Text).ToLower()
                        select new
                               {
                                   ProductID = q.ProductID,
                                   ProductName = q.ProductName,
                                   color = st.Color,
                                   size = st.Size,
                                   StockID = st.StockID,

                               }).ToList();

            foreach (var item in List)
            {
                ID = item.ProductID;
                cbbColor.Items.Add(item.color);
            }
        }
    }
}
