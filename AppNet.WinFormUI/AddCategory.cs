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
            try { 
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
            }
            catch
            {
                DialogResult dialogResult = MessageBox.Show("Kategoriniz eklenemedi, l�tfen girdi�iniz de�erlerin do�ru oldu�una emin olunuz!", "Uyar� Mesaj�", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }
    }
}