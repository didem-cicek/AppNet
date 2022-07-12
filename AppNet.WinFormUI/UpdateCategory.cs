using AppNet.AppService;
using AppNet.Domain.Validations;

namespace AppNet.WinFormUI
{
    public partial class UpdateCategory : Form
    {
        private readonly IServiceProvider sp;
        private readonly ICategoryService cs;
        public UpdateCategory(IServiceProvider sp, ICategoryService cs)
        {
            InitializeComponent();
            this.sp = sp;
            this.cs = cs;
        }

        private void UpdateCategory_Load(object sender, EventArgs e)
        {
           
        }

        private async void btnUpdateSearch_Click(object sender, EventArgs e)
        {
            
           
            
        }

        private void cbbCategorySearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var Kategori_Adý = txtUpdateCategory.Text;
            try {
                Kategori_Adý.NullOrEmpty(nameof(Kategori_Adý));
                try { 
            cs.Update(Convert.ToInt32(grdUpdateCategory.CurrentRow.Cells[0].Value), txtUpdateCategory.Text);
            DialogResult result = MessageBox.Show("Kategori baþarýyla güncellenmiþtir.", "Bilgilendirme Mesajý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtUpdateCategory.Text = "";
            txtCategorySearch.Text = "";
            grdUpdateCategory.DataSource = null;
            grdUpdateCategory.Refresh();
            this.Close();}
                catch (Exception ex)
                {
                    DialogResult dialogResult = MessageBox.Show($" {ex.Message} iþlem baþarýsýz!", "Uyarý Mesajý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentNullException ex)
            {
                DialogResult dialogResult = MessageBox.Show($" {ex.ParamName} alaný boþ býrakamazsýnýz!", "Uyarý Mesajý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void txtCategorySearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var category = (await cs.GetAll()).ToList();
                var gridList = (from q in category
                                where q.CategoryName.ToLower().Contains((txtCategorySearch.Text).ToLower())
                                orderby q.CategoryName ascending
                                select new
                                {
                                    KategoriID = q.CategoryId,
                                    KategoriAdý = q.CategoryName,
                                }).ToList();
                grdUpdateCategory.DataSource = gridList;

            }
            catch
            {
                DialogResult dialogResult = MessageBox.Show("Aradýðýnýz ürün bulunamamýþtýr!", "Bilgilendirme Mesajý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void grdUpdateCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUpdateCategory.Text = grdUpdateCategory.CurrentRow.Cells[1].Value.ToString();
        }
    }
}