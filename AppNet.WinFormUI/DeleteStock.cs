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
        private readonly IProductService p;
        private readonly ISupplierService sup;
        public DeleteStock(IStockService ss, ISupplierService sup, IProductService p)
        {
            InitializeComponent();
            this.ss = ss;
            this.p = p;
            this.sup = sup;
        }

        private void DeleteStock_Load(object sender, EventArgs e)
        {
            
        }

        private async void btnDeleted_Click(object sender, EventArgs e)
        {
           
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

        private async void txtDeleteStockSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var stock = (await ss.GetAll()).ToList();
                var product = (await p.GetAll()).ToList();
                var supplier = (await sup.GetAll()).ToList();
                var find = supplier.FirstOrDefault(u => u.SupplierName.ToLower() == txtDeleteStockSearch.Text.ToLower());
                if (find != null) { 
                var gridList = (from q in stock
                                join w in supplier
                                on q.SupplierID equals w.SupplierID
                                where w.SupplierName.ToLower().Contains((txtDeleteStockSearch.Text).ToLower())
                                orderby w.SupplierName ascending
                                select new
                                {
                                    ID = q.SupplierID,
                                    TedarikçiAdı = q.Supplier.SupplierName,
                                }).ToList();
                grdDeleteStockList.DataSource = gridList;}
                else
                {
                   
                    var gridList = (from q in product
                                    join w in stock
                                    on q.ProductID equals w.ProductID
                                    where q.ProductName.ToLower().Contains((txtDeleteStockSearch.Text).ToLower())
                                    orderby q.ProductName ascending
                                    select new
                                    {
                                        ID = q.ProductID,
                                        TedarikçiAdı = q.ProductName,
                                    }).ToList();
                    grdDeleteStockList.DataSource = gridList;
                }

            }
            catch
            {
                DialogResult dialogResult = MessageBox.Show("Aradığınız tedarikçi bulunamamıştır!", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
