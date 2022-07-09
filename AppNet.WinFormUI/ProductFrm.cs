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

        private async void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            grdProductList.Rows.Clear();
            grdProductList.Refresh();
            var p = (await productService.GetAll()).ToList();
            var c = (await categoryService.GetAll()).ToList();
            var searchProduct = (from q in p
                                 join s in c
                                 on q.CategoryID equals s.CategoryId
                                 where q.ProductName.ToLower().Contains((txtProductSearch.Text).ToLower())
                                 orderby q.ProductName ascending
                                 select new ProductViewModel
                                 {
                                     ProductId = q.ProductID,
                                     ProductName = q.ProductName,
                                     CategorName = s.CategoryName,
                                     Description = q.ProductDesriciption,
                                     Time = q.ProductDate,
                                     ModifitedDate = q.ProductModifitedDate

                                 }).ToList();

            foreach (var product in searchProduct)
            {

                AddRowToGrid(product);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<AddProduct>();
            frm.ShowDialog();
            grdProductList.Rows.Clear();
            LoadGridData();

        }

        private void btnUpdatedProduct_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<UpdateProduct>();
            frm.ShowDialog();
            grdProductList.Rows.Clear();
            LoadGridData();

        }

        private void btnDeletedProduct_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<DeleteProduct>();
            frm.ShowDialog();
            grdProductList.Rows.Clear();
            LoadGridData();

        }

        private void btnAddCategory_Click_1(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<AddCategory>();
            frm.ShowDialog();
            grdProductList.Rows.Clear();
            LoadGridData();

        }

        private void btnUpdatedCategory_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<UpdateCategory>();
            frm.ShowDialog();
            grdProductList.Rows.Clear();
            LoadGridData();

        }

        private void btnDeletedCategory_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<DeleteCategory>();
            frm.ShowDialog();
            grdProductList.Rows.Clear();
            LoadGridData();

        }

        private void grdProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductFrm_Load(object sender, EventArgs e)
        {
            txtProductSearch.Text = "";
            grdProductList.Rows.Clear();
            grdProductList.Refresh();
            if (grdProductList.Rows.Count == 0)
            {
                grdProductList.Rows.Clear();
                grdProductList.Columns.Add("Product ID", "Ürün ID");
                grdProductList.Columns.Add("ProductName", "Ürün Adý");
                grdProductList.Columns.Add("CategoryName", "Kategori Adý");
                grdProductList.Columns.Add("ProductDesriciption", "Ürün Açýklamasý");
                grdProductList.Columns.Add("ProductDate", "Eklenme Tarihi");
                grdProductList.Columns.Add("ModifitedDate", "Düzenlenme Tarihi");
                LoadGridData();
                grdProductList.Columns[0].Visible = false;
            }
        }
        private async void LoadGridData()
        {
            var product = (await productService.GetAll()).ToList();
            var category = (await categoryService.GetAll()).ToList();
            var data = from p in product
                       join c in category
                       on p.CategoryID equals c.CategoryId
                       orderby p.ProductID descending
                       select new ProductViewModel
                       {
                           ProductId = p.ProductID,
                           ProductName = p.ProductName,
                           CategorName = c.CategoryName,
                           Description = p.ProductDesriciption,
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
            row.Cells[3].Value = model.Description;
            row.Cells[4].Value = model.Time;
            row.Cells[5].Value = model.ModifitedDate;

            grdProductList.Rows.Add(row);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}