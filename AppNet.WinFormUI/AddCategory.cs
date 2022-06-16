using AppNet.AppService;
using AppNet.Infrastructer.Persistence;

namespace AppNet.WinFormUI
{
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            var service = IOCContainer.Resolve<ICategoryService>();
            service.Create(txtCategoryName.Text);
            DialogResult dialogResult = MessageBox.Show("Kategoriniz baþarýyla eklenmiþtir. Bir kategori daha eklemek ister misiniz?", "Bilgilendirme Mesajý", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                txtCategoryID.Text = "";
                txtCategoryName.Text = "";
            }
            else
            {
                this.Close();
            }
        }
    }
}