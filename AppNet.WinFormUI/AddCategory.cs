using AppNet.AppService;
using AppNet.Infrastructer.Persistence;
using Microsoft.Extensions.DependencyInjection;

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
            
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
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
        }
    }
}