using AppNet.AppService;
using AppNet.Domain.Validations;
using AppNet.Infrastructer.Persistence;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;

namespace AppNet.WinFormUI
{
   
    public partial class AddCategory : Form
    {
        private readonly ICategoryService categoryService;
        public AddCategory(ICategoryService categoryService)
        {
            InitializeComponent();
            this.categoryService = categoryService;

        }

        private void AddCategory_Load(object sender, EventArgs e)
        {
            txtCategoryName.Text = "";
        }

        private async void btnAddCategory_Click(object sender, EventArgs e)
        { 
            var Kategori_Ad� = txtCategoryName.Text;
            try
            {
                Kategori_Ad�.NullOrEmpty(nameof(Kategori_Ad�));
                try
                {
                    var list = (await categoryService.GetAll()).ToList();
                    var find = list.FirstOrDefault(u => u.CategoryName.ToLower() == txtCategoryName.Text.ToLower());
                    if (find==null)
                    {
                        categoryService.Add(txtCategoryName.Text);
                        DialogResult dialogResult = MessageBox.Show("Kategoriniz ba�ar�yla eklenmi�tir. Bir kategori daha eklemek ister misiniz?", "Bilgilendirme Mesaj�", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dialogResult == DialogResult.Yes)
                        {
                            txtCategoryName.Text = "";
                        }
                        else
                        {
                            this.Close();
                        }
                        txtCategoryName.Text = "";
                    } else
                    {
                        DialogResult dialogResult = MessageBox.Show("Kategoriniz eklenemedi, girdi�iniz kategori zaten var!", "Uyar� Mesaj�", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    }
                }
                catch 
                {
                    DialogResult dialogResult = MessageBox.Show("Kategoriniz eklenemedi, l�tfen girdi�iniz de�erlerin do�ru oldu�una emin olunuz!", "Uyar� Mesaj�", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
            }
            catch (ArgumentNullException ex)
            {
                DialogResult dialogResult = MessageBox.Show($" {ex.ParamName} alan� bo� b�rakamazs�n�z!", "Uyar� Mesaj�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {
            txtCategoryName.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtCategoryName.Text);
            txtCategoryName.SelectionStart = txtCategoryName.Text.Length;
        }
    }
}