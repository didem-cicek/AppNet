using AppNet.AppService;
using AppNet.Infrastructer.Persistence.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace AppNet.WinFormUI
{
    public partial class ProductFrm : Form
    {
        private readonly ICategoryService categoryService;
        private readonly IServiceProvider sp;
        private readonly IProductService productService;
        public ProductFrm(IServiceProvider sp, ICategoryService categoryService, IProductService productService)
        {
            InitializeComponent();
            this.sp = sp;
            this.categoryService = categoryService;
            this.productService = productService;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {

        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<AddProduct>();
            frm.ShowDialog();

        }

        private void btnUpdatedProduct_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<UpdateCategory>();
            frm.ShowDialog();

        }

        private void btnDeletedProduct_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<DeleteProduct>();
            frm.ShowDialog();

        }

        private void btnAddCategory_Click_1(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<AddCategory>();
            frm.ShowDialog();

        }

        private void btnUpdatedCategory_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<UpdateCategory>();
            frm.ShowDialog();

        }

        private void btnDeletedCategory_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<DeleteCategory>();
            frm.ShowDialog();

        }

        private void grdProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void ProductFrm_Load(object sender, EventArgs e)
        {
            var list = (await productService.GetAll()).ToList();
            var data = from p in list
                       select new ProductViewModel
                       {
                           ProductId = p.ProductID,
                           ProductName = p.ProductName,
                           CategorName = p.Category.CategoryName,
                           Time = p.ProductDate,
                           ModifitedDate = p.ProductModifitedDate
                       };
            foreach (var item in data)
            {
                AddRowToGrid(item);
            }
    }
        private void AddRowToGrid(ProductViewModel model)
        {
            DataGridViewRow row = (DataGridViewRow)grdProductList.Rows[0].Clone();
            row.Cells[0].Value = model.ProductId;
            row.Cells[1].Value = model.ProductName;
            row.Cells[2].Value = model.CategorName;
            row.Cells[3].Value = model.Time;
            row.Cells[4].Value = model.ModifitedDate;

            grdProductList.Rows.Add(row);
        }
    }
}