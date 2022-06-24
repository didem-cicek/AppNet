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
    public partial class DeleteStock : Form
    {
        private readonly IStockService ss;
        public DeleteStock()
        {
            InitializeComponent();
            this.ss = ss;
        }

        private void DeleteStock_Load(object sender, EventArgs e)
        {
            btnSearchDelete.Visible = false;
            cbbDeleteStockSearch.Items.Clear();
            cbbDeleteStockSearch.Items.Add("Stok ID'sine Göre");
            cbbDeleteStockSearch.Items.Add("Tedarikçi Adına Göre");
            cbbDeleteStockSearch.SelectedIndex = 0;
        }

        private async void btnDeleted_Click(object sender, EventArgs e)
        {
            var list = (await ss.GetAll()).ToList();
            if (cbbDeleteStockSearch.SelectedItem == "Stok ID'sine Göre")
            {
                try
                {
                    var gridList = (from q in list
                                    where q.StockID == Convert.ToInt32(txtDeleteStockSearch.Text)
                                    select new
                                    {
                                        ID = q.StockID,
                                        TedarikçiAdı = q.Supplier.SupplierName,
                                    }).ToList();
                    grdDeleteStockList.DataSource = gridList;
                }
                catch (Exception ex)
                {
                    DialogResult dialogResult = MessageBox.Show("Yazdığınız arama kelimesinde sorun bulundu, lütfen kontrol ediniz!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            else if (cbbDeleteStockSearch.SelectedItem == "Tedarikçi Adına Göre")
            {
                try
                {
                    var gridList = (from q in list
                                    where q.Supplier.SupplierName == txtDeleteStockSearch.Text
                                    select new
                                    {
                                        ID = q.StockID,
                                        TedarikçiAdı = q.Supplier.SupplierName,
                                    }).ToList();
                    grdDeleteStockList.DataSource = gridList;
                }
                catch (Exception ex)
                {
                    DialogResult dialogResult = MessageBox.Show("Yazdığınız arama kelimesinde sorun bulundu, lütfen kontrol ediniz!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Aradığınız stok bulunamamıştır!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearchDelete_Click(object sender, EventArgs e)
        {
            DialogResult question = MessageBox.Show("Bulunan stoğu silmek istediğinize emin misiniz?", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (question == DialogResult.Yes)
            {
                ss.Remove(Convert.ToInt32(grdDeleteStockList.CurrentRow.Cells[0].Value));
                DialogResult result = MessageBox.Show("Stok başarıyla silinmiştir.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtDeleteStockSearch.Text = "";
            this.Close();
            grdDeleteStockList.DataSource = null;
            grdDeleteStockList.Refresh();
        }
    }
}
