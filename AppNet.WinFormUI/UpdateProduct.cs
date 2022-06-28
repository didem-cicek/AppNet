using AppNet.AppService;

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

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            cbbUpdateProduct.Items.Clear();
            cbbUpdateProduct.Items.Add("Ürün ID'sine Göre");
            cbbUpdateProduct.Items.Add("Ürün Adýna Göre");
            cbbUpdateProduct.SelectedIndex = 0;
        }

        private async void btnUpdateSearch_Click(object sender, EventArgs e)
        {
            var category = (await cs.GetAll()).ToList();
            var list = (await ps.GetAll()).ToList();
            foreach (var item in category)
            {
                cbbUpdatedCategory.Items.Add(item.CategoryName);
            }
            if (cbbUpdateProduct.SelectedItem == "Ürün ID'sine Göre")
            {
                var gridList = (from q in list
                                join c in category
                                on q.CategoryID equals c.CategoryId
                                where q.ProductID == Convert.ToInt32(txtUpdateProductSearch.Text)
                                select new
                                {
                                    ID = q.ProductID,
                                    ÜrünAdý = q.ProductName,
                                    KategoriAdý = c.CategoryName,
                                    Acýklama = q.ProductDesriciption
                                }).ToList();
                grdUpdateProductList.DataSource = gridList;
                foreach (var i in gridList)
                {
                    cbbUpdatedCategory.SelectedItem = i.KategoriAdý;
                    updatedProductName.Text = i.ÜrünAdý;
                    txtUpdatedDescription.Text = i.Acýklama;
                }
            }
            else if (cbbUpdateProduct.SelectedItem == "Ürün Adýna Göre")
            {
                var gridList = (from q in list
                                join c in category
                                on q.CategoryID equals c.CategoryId
                                where q.ProductName == txtUpdateProductSearch.Text
                                select new
                                {
                                    ID = q.ProductID,
                                    ÜrünAdý = q.ProductName,
                                    KategoriAdý = c.CategoryName,
                                    KategoriID = c.CategoryId,
                                    Acýklama = q.ProductDesriciption
                                }).ToList();
                grdUpdateProductList.DataSource = gridList;
                foreach (var i in gridList)
                {
                    //cbbUpdatedCategory.SelectedItem = i.KategoriAdý;
                    //cbbUpdatedCategory.SelectedIndex = i.KategoriID;
                    updatedProductName.Text = i.ÜrünAdý;
                    txtUpdatedDescription.Text = i.Acýklama;
                }
            } else
            {
                DialogResult dialogResult = MessageBox.Show("Aradýðýnýz ürün bulunamamýþtýr!", "Bilgilendirme Mesajý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                          
        }

        private void btnUpdatedProduct_Click(object sender, EventArgs e)
        {
            ps.Update(Convert.ToInt32(grdUpdateProductList.CurrentRow.Cells[0].Value), updatedProductName.Text, Convert.ToInt32(cbbUpdatedCategory.SelectedValue), txtUpdatedDescription.Text);
            DialogResult result = MessageBox.Show("Ürün baþarýyla güncellenmiþtir.", "Bilgilendirme Mesajý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cbbUpdatedCategory.Items.Clear();
            updatedProductName.Text = "";
            txtUpdatedDescription.Text = "";
            grdUpdateProductList.DataSource = null;
            grdUpdateProductList.Refresh();
            this.Close();
        }
    }
}

