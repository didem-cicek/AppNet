using AppNet.AppService;
using AppNet.Domain.Entities;
using AppNet.Infrastructer.Persistence;

namespace AppNet.WinFormUI
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            using (var context = new ErpDbContext())
            {
                var categories = context.Categories.ToList();
                cbbAddCategory.DataSource = categories;
                cbbAddCategory.DisplayMember = nameof(Category.CategoryName);
                cbbAddCategory.ValueMember = nameof(Category.CategoryId);

            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var service = IOCContainer.Resolve<IProductService>();
            service.Create(Convert.ToInt32(cbbAddCategory.SelectedValue),txtAddProduct.Text, txtAddDescription.Text);
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