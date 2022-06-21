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
            cbbDeletedSearch.Items.Add("Ürün ID'sine Göre");
            cbbDeletedSearch.Items.Add("Ürün Adýna Göre");
            cbbDeletedSearch.SelectedIndex = 0;
        }

        private async void btnDeleted_Click(object sender, EventArgs e)
        {
            if (cbbDeletedSearch.SelectedItem == "Ürün ID'sine Göre")
            {
                var list = (await ps.GetAll()).ToList();
                foreach (var item in list)
                {
                    if (item.ProductID == Convert.ToInt32(txtDeletedSearch.Text))
                    {

                        var gridList = (from q in list
                                        where q.ProductID == Convert.ToInt32(txtDeletedSearch.Text)
                                        select new
                                        {
                                            ID = q.ProductID,
                                            ÜrünAdý = q.ProductName
                                        }).ToList();
                        grdDeletedList.DataSource = gridList;
                        if (gridList.Count == 0) { 
                            DialogResult dialogResult = MessageBox.Show("Aradýðýnýz ürün bulunamamýþtýr!", "Bilgilendirme Mesajý", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                        break;}

                    }
                }

            }
            else if (cbbDeletedSearch.SelectedItem == "Ürün Adýna Göre")
            {
                var list = (await ps.GetAll()).ToList();
                foreach (var item in list)
                {
                    if (item.ProductName == txtDeletedSearch.Text)
                    {
                        var gridList = (from q in list
                                        where q.ProductName == txtDeletedSearch.Text
                                        select new
                                        {
                                            ID = q.ProductID,
                                            ÜrünAdý = q.ProductName
                                        }).ToList();
                        grdDeletedList.DataSource = gridList;
                        if (gridList.Count == 0)
                        {
                            DialogResult dialogResult = MessageBox.Show("Aradýðýnýz ürün bulunamamýþtýr!", "Bilgilendirme Mesajý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                    }
                }
            }
            else
            {
                DialogResult error = MessageBox.Show("Bilinmeyen bir hata oluþtu!", "Bilgilendirme Mesajý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (grdDeletedList.DataSource != null)
            {
                DialogResult question = MessageBox.Show("Bulunan ürünü silmek istediðinize emin misiniz?", "Bilgilendirme Mesajý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (question == DialogResult.Yes)
                {
                    ps.Remove(Convert.ToInt32(grdDeletedList.CurrentRow.Cells[0].Value));
                    DialogResult result = MessageBox.Show("Ürün baþarýyla silinmiþtir.", "Bilgilendirme Mesajý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                txtDeletedSearch.Text = "";
                this.Close();
            }
            

        }


        private void cbbDeletedSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}