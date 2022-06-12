namespace AppNet.WinFormUI
{
    public partial class ProductFrm : Form
    {
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
            AddProduct addProductFrm = new AddProduct();
            addProductFrm.ShowDialog();
        }

        private void btnUpdatedProduct_Click(object sender, EventArgs e)
        {
            UpdateProduct updateProductFrm = new UpdateProduct();
            updateProductFrm.ShowDialog();
        }

        private void btnDeletedProduct_Click(object sender, EventArgs e)
        {
            DeleteProduct deleteProductFrm = new DeleteProduct();
            deleteProductFrm.ShowDialog();
        }

        private void btnAddCategory_Click_1(object sender, EventArgs e)
        {
            AddCategory addCategoryFrm = new AddCategory();
            addCategoryFrm.ShowDialog();
        }

        private void btnUpdatedCategory_Click(object sender, EventArgs e)
        {
            UpdateCategory updateCategoryFrm = new UpdateCategory();
            updateCategoryFrm.ShowDialog();
        }

        private void btnDeletedCategory_Click(object sender, EventArgs e)
        {
            DeleteCategory deleteCategoryFrm = new DeleteCategory();
            deleteCategoryFrm.ShowDialog();
        }
    }
}