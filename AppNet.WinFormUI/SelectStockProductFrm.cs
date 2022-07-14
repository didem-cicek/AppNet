using AppNet.AppService;
using AppNet.Domain.Validations;
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
            var Adet = txtPiece.Text;
            var Renk = txtColor.Text;
            var Beden = txtSize.Text;
            var Birim_Fiyatı = txtPrice.Text;
            var Kritik_Stok = txtCritialStock.Text;
            try
            {
                Adet.NullOrEmpty(nameof(Adet));
                Renk.NullOrEmpty(nameof(Renk));
                Adet.NullOrEmpty(nameof(Adet));
                Beden.NullOrEmpty(nameof(Beden));
                Birim_Fiyatı.NullOrEmpty(nameof(Birim_Fiyatı));
                Kritik_Stok.NullOrEmpty(nameof(Kritik_Stok));
                try {
                    Convert.ToDecimal(Birim_Fiyatı).Zero(nameof(Birim_Fiyatı));
                    Convert.ToInt32(Kritik_Stok).Zero(nameof(Kritik_Stok));
                    this.Close();
                }
                catch (ArgumentException ex)
                {
                    DialogResult dialogResult = MessageBox.Show($" {ex.ParamName}", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (ArgumentNullException ex)
            {
                DialogResult dialogResult = MessageBox.Show($" {ex.ParamName} alanı boş bırakamazsınız!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void txtPiece_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void txtColor_TextChanged(object sender, EventArgs e)
        {
            txtColor.Text = txtColor.Text.ToLower();
            txtColor.SelectionStart = txtColor.Text.Length;
        }

        private void txtSize_TextChanged(object sender, EventArgs e)
        {
            txtSize.Text = txtSize.Text.ToLower();
            txtSize.SelectionStart = txtSize.Text.Length;
        }

        private void txtCritialStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
