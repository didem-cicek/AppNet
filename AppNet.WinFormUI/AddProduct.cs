using AppNet.AppService;
using AppNet.Domain.Entities;
using AppNet.Domain.Validations;
using AppNet.Infrastructer.Persistence;
using System.Globalization;

namespace AppNet.WinFormUI
{
    public partial class AddProduct : Form
    {
        private readonly IServiceProvider sp;
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;
        public AddProduct(IProductService productService, ICategoryService categoryService, IServiceProvider sp)
        {
            InitializeComponent();
            this.productService = productService;
            this.categoryService = categoryService;
            this.sp = sp;
        }

        private async void AddProduct_Load(object sender, EventArgs e)
        {
            txtAddProduct.Text = "";
            txtAddDescription.Text = "";
            var list = (await categoryService.GetAll()).ToList();
            foreach (var item in list)
            {
                cbbAddCategory.DataSource = list;
                cbbAddCategory.DisplayMember = nameof(item.CategoryName);
                cbbAddCategory.ValueMember = nameof(item.CategoryId);
            }
        }

        private async void btnAddProduct_Click(object sender, EventArgs e)
        {
            var Ürün_Adý = txtAddProduct.Text;
            var Kategori_Adý = cbbAddCategory.Text;
            try
            {
                Kategori_Adý.NullOrEmpty(nameof(Kategori_Adý));
                Ürün_Adý.NullOrEmpty(nameof(Ürün_Adý));
                try
                {
                    var list = (await productService.GetAll()).ToList();
                    var find = list.FirstOrDefault(u => u.ProductName.ToLower() == txtAddProduct.Text.ToLower());
                    if (find == null)
                    {
                        productService.Add(Convert.ToInt32(cbbAddCategory.SelectedValue), txtAddProduct.Text, txtAddDescription.Text);
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
                        txtAddProduct.Text = "";
                        txtAddDescription.Text = "";
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Ürün eklenemedi, girdiðiniz ürün zaten var!", "Uyarý Mesajý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    DialogResult dialogResult = MessageBox.Show("Ürün eklenemedi, lütfen girdiðiniz deðerlerin doðru olduðuna emin olunuz!", "Uyarý Mesajý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
            }
            catch (ArgumentNullException ex)
            {
                DialogResult dialogResult = MessageBox.Show($" {ex.ParamName} alaný boþ býrakamazsýnýz!", "Uyarý Mesajý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            
        }

        private void txtAddProduct_TextChanged(object sender, EventArgs e)
        {
            txtAddProduct.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtAddProduct.Text);
            txtAddProduct.SelectionStart = txtAddProduct.Text.Length;
        }

        private void txtAddDescription_TextChanged(object sender, EventArgs e)
        {
            txtAddDescription.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtAddDescription.Text);
            txtAddDescription.SelectionStart = txtAddProduct.Text.Length;
        }
    }
}