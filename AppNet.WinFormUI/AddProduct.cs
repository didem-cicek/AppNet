using AppNet.AppService;
using AppNet.Domain.Entities;
using AppNet.Infrastructer.Persistence;

namespace AppNet.WinFormUI
{
    public partial class AddProduct : Form
    {
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;
        public AddProduct(IProductService productService, ICategoryService categoryService)
        {
            InitializeComponent();
            this.productService = productService;
            this.categoryService = categoryService;

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            cbbAddCategory.DataSource = categoryService.GetAll();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            productService.Add(Convert.ToInt32(cbbAddCategory.SelectedValue),txtAddProduct.Text, txtAddDescription.Text);
            DialogResult dialogResult = MessageBox.Show("Ürününüz baþarýyla eklenmiþtir. Bir ürün daha eklemek ister misiniz?", "Bilgilendirme Mesajý", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                txtAddProduct.Text = "";
                txtAddDescription.Text = "";
            }
            else
            {
                this.Close();
            }
        }
    }
}