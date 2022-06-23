using AppNet.AppService;
using AppNet.Infrastructer.Persistence.ViewModels;

namespace AppNet.WinFormUI
{
    public partial class DeleteProduct : Form
    {
        private readonly IServiceProvider sp;
        private readonly IProductService ps;
        public DeleteProduct(IServiceProvider sp, IProductService ps)
        {
            InitializeComponent();
            this.sp = sp;
            this.ps = ps;
        }

        private void DeleteProduct_Load(object sender, EventArgs e)
        {
            btnselectdel.Visible = false;
            cbbDeletedSearch.Items.Clear();
            cbbDeletedSearch.Items.Add("Ürün ID'sine Göre");
            cbbDeletedSearch.Items.Add("Ürün Adýna Göre");
            cbbDeletedSearch.SelectedIndex = 0;
        }

        private async void btnDeleted_Click(object sender, EventArgs e)
        {
            var list = (await ps.GetAll()).ToList();
            if (cbbDeletedSearch.SelectedItem == "Ürün ID'sine Göre")
            {
                try { 
                var gridList = (from q in list
                                where q.ProductID == Convert.ToInt32(txtDeletedSearch.Text)
                                select new
                                {
                                    ID = q.ProductID,
                                    ÜrünAdý = q.ProductName
                                }).ToList();
                grdDeletedList.DataSource = gridList;
                btnselectdel.Visible = true;
                }
                catch (Exception ex)
                {
                    DialogResult dialogResult = MessageBox.Show("Yazdýðýnýz arama kelimesinde sorun bulundu, lütfen kontrol ediniz!", "Uyarý Mesajý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else if (cbbDeletedSearch.SelectedItem == "Ürün Adýna Göre")
            {
                try { 
                var gridList = (from q in list
                                where q.ProductName == txtDeletedSearch.Text
                                select new
                                {
                                    ID = q.ProductID,
                                    ÜrünAdý = q.ProductName
                                }).ToList();
                grdDeletedList.DataSource = gridList;
                btnselectdel.Visible = true;
                }
                catch (Exception ex)
                {
                    DialogResult dialogResult = MessageBox.Show("Yazdýðýnýz arama kelimesinde sorun bulundu, lütfen kontrol ediniz!", "Uyarý Mesajý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Aradýðýnýz ürün bulunamamýþtýr!", "Uyarý Mesajý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        
        private async void btnselectdel_Click(object sender, EventArgs e)
        {
            DialogResult question = MessageBox.Show("Bulunan ürünü silmek istediðinize emin misiniz?", "Uyarý Mesajý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (question == DialogResult.Yes)
            {
                ps.Remove(Convert.ToInt32(grdDeletedList.CurrentRow.Cells[0].Value));
                DialogResult result = MessageBox.Show("Ürün baþarýyla silinmiþtir.", "Bilgilendirme Mesajý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtDeletedSearch.Text = "";
            this.Close();
            grdDeletedList.DataSource = null;
            grdDeletedList.Refresh();
        }
    }
}