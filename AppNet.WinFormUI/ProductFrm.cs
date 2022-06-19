using AppNet.AppService;
using Microsoft.Extensions.DependencyInjection;

namespace AppNet.WinFormUI
{
    public partial class ProductFrm : Form
    {
        private readonly ICategoryService categoryService;
        public ProductFrm()
        {
            InitializeComponent();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {

        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //AddProduct addProduct = new AddProduct();
            //addProduct.ShowDialog();
        }

        private void btnUpdatedProduct_Click(object sender, EventArgs e)
        {
            //UpdateProduct updateProduct = new UpdateProduct(services);
            //updateProduct.ShowDialog();
        }

        private void btnDeletedProduct_Click(object sender, EventArgs e)
        {
            //DeleteProduct deleteProduct = new DeleteProduct(services);
            //deleteProduct.ShowDialog();
        }

        private void btnAddCategory_Click_1(object sender, EventArgs e)
        {
            AddCategory addCategory = new AddCategory(categoryService);
            addCategory.ShowDialog();
        }

        private void btnUpdatedCategory_Click(object sender, EventArgs e)
        {
            //UpdateCategory updateCategory = new UpdateCategory(services);
            //updateCategory.ShowDialog();
        }

        private void btnDeletedCategory_Click(object sender, EventArgs e)
        {
            //DeleteProduct deleteProduct = new DeleteProduct(services);
            //deleteProduct.ShowDialog();
        }
    }
}