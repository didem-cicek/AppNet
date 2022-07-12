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
            var �r�n_Ad� = txtAddProduct.Text;
            var Kategori_Ad� = cbbAddCategory.Text;
            try
            {
                Kategori_Ad�.NullOrEmpty(nameof(Kategori_Ad�));
                �r�n_Ad�.NullOrEmpty(nameof(�r�n_Ad�));
                try
                {
                    var list = (await productService.GetAll()).ToList();
                    var find = list.FirstOrDefault(u => u.ProductName.ToLower() == txtAddProduct.Text.ToLower());
                    if (find == null)
                    {
                        productService.Add(Convert.ToInt32(cbbAddCategory.SelectedValue), txtAddProduct.Text, txtAddDescription.Text);
                        DialogResult dialogResult = MessageBox.Show("�r�n�n�z ba�ar�yla eklenmi�tir. Bir �r�n daha eklemek ister misiniz?", "Bilgilendirme Mesaj�", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
                        DialogResult dialogResult = MessageBox.Show("�r�n eklenemedi, girdi�iniz �r�n zaten var!", "Uyar� Mesaj�", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    DialogResult dialogResult = MessageBox.Show("�r�n eklenemedi, l�tfen girdi�iniz de�erlerin do�ru oldu�una emin olunuz!", "Uyar� Mesaj�", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
            }
            catch (ArgumentNullException ex)
            {
                DialogResult dialogResult = MessageBox.Show($" {ex.ParamName} alan� bo� b�rakamazs�n�z!", "Uyar� Mesaj�", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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