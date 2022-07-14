using AppNet.AppService;
using AppNet.Domain.Validations;
using System.Globalization;

namespace AppNet.WinFormUI
{
    public partial class UpdateProduct : Form
    {
        private readonly IServiceProvider sp;
        private readonly IProductService ps;
        private readonly ICategoryService cs;
        public UpdateProduct(IServiceProvider sp, IProductService ps, ICategoryService cs)
        {
            InitializeComponent();
            this.sp = sp;
            this.ps = ps;
            this.cs = cs;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private async void UpdateProduct_Load(object sender, EventArgs e)
        {
            var category = (await cs.GetAll()).ToList();
            foreach (var item in category)
            {
                cbbUpdatedCategory.DataSource = category;
                cbbUpdatedCategory.DisplayMember = nameof(item.CategoryName);
                cbbUpdatedCategory.ValueMember = nameof(item.CategoryId);
                
            }
        }

        private void btnUpdatedProduct_Click(object sender, EventArgs e)
        {
            
        }

        private async void txtUpdateProductSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var category = (await cs.GetAll()).ToList();
                var list = (await ps.GetAll()).ToList();
                var gridList = (from q in list
                                join c in category
                                on q.CategoryID equals c.CategoryId
                                where q.ProductName.ToLower().Contains((txtUpdateProductSearch.Text).ToLower())
                                orderby q.ProductName ascending
                                select new
                                {
                                    ID = q.ProductID,
                                    ÜrünAdý = q.ProductName,
                                    KategoriAdý = c.CategoryName,
                                    Acýklama = q.ProductDesriciption
                                }).ToList();
                grdUpdateProductList.DataSource = gridList;
                
            }
            catch
            {
                DialogResult dialogResult = MessageBox.Show("Aradýðýnýz ürün bulunamamýþtýr!", "Bilgilendirme Mesajý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnUpdateSearch_Click(object sender, EventArgs e)
        {
            var Ürün_Adý = updatedProductName.Text;
            var Kategori_Adý = cbbUpdatedCategory.Text;
            try {
                Kategori_Adý.NullOrEmpty(nameof(Kategori_Adý));
                Ürün_Adý.NullOrEmpty(nameof(Ürün_Adý));
                try
                {
                    ps.Update(Convert.ToInt32(grdUpdateProductList.CurrentRow.Cells[0].Value), updatedProductName.Text, Convert.ToInt32(cbbUpdatedCategory.SelectedValue), txtUpdatedDescription.Text);
                    DialogResult result = MessageBox.Show("Ürün baþarýyla güncellenmiþtir.", "Bilgilendirme Mesajý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    updatedProductName.Text = "";
                    txtUpdatedDescription.Text = "";
                    grdUpdateProductList.DataSource = null;
                    grdUpdateProductList.Refresh();
                    this.Close();
                 }
                catch
                {
                DialogResult dialogResult = MessageBox.Show("Bilinmeyen bir hata oluþtu, güncelleme iþleminiz baþarýz!", "Uyarý Mesajý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }
            catch (ArgumentNullException ex)
            {
                DialogResult dialogResult = MessageBox.Show($" {ex.ParamName} alaný boþ býrakamazsýnýz!", "Uyarý Mesajý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void grdUpdateProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            updatedProductName.Text = grdUpdateProductList.CurrentRow.Cells[1].Value.ToString();
            cbbUpdatedCategory.Text = grdUpdateProductList.CurrentRow.Cells[2].Value.ToString();
            txtUpdatedDescription.Text = grdUpdateProductList.CurrentRow.Cells[3].Value.ToString();
        }

        private void updatedProductName_TextChanged(object sender, EventArgs e)
        {
            updatedProductName.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(updatedProductName.Text);
            updatedProductName.SelectionStart = updatedProductName.Text.Length;
        }

        private void txtUpdatedDescription_TextChanged(object sender, EventArgs e)
        {
            txtUpdatedDescription.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtUpdatedDescription.Text);
            txtUpdatedDescription.SelectionStart = txtUpdatedDescription.Text.Length;
        }
    }

}