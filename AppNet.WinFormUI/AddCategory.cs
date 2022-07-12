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
            var Kategori_Adý = txtCategoryName.Text;
            try
            {
                Kategori_Adý.NullOrEmpty(nameof(Kategori_Adý));
                try
                {
                    var list = (await categoryService.GetAll()).ToList();
                    var find = list.FirstOrDefault(u => u.CategoryName.ToLower() == txtCategoryName.Text.ToLower());
                    if (find==null)
                    {
                        categoryService.Add(txtCategoryName.Text);
                        DialogResult dialogResult = MessageBox.Show("Kategoriniz baþarýyla eklenmiþtir. Bir kategori daha eklemek ister misiniz?", "Bilgilendirme Mesajý", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
                        DialogResult dialogResult = MessageBox.Show("Kategoriniz eklenemedi, girdiðiniz kategori zaten var!", "Uyarý Mesajý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    }
                }
                catch 
                {
                    DialogResult dialogResult = MessageBox.Show("Kategoriniz eklenemedi, lütfen girdiðiniz deðerlerin doðru olduðuna emin olunuz!", "Uyarý Mesajý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
            }
            catch (ArgumentNullException ex)
            {
                DialogResult dialogResult = MessageBox.Show($" {ex.ParamName} alaný boþ býrakamazsýnýz!", "Uyarý Mesajý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {
            txtCategoryName.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtCategoryName.Text);
            txtCategoryName.SelectionStart = txtCategoryName.Text.Length;
        }
    }
}