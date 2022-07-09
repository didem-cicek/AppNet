using AppNet.AppService;

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
            cs.Update(Convert.ToInt32(grdUpdateCategory.CurrentRow.Cells[0].Value), txtUpdateCategory.Text);
            DialogResult result = MessageBox.Show("Kategori baþarýyla güncellenmiþtir.", "Bilgilendirme Mesajý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtUpdateCategory.Text = "";
            txtCategorySearch.Text = "";
            grdUpdateCategory.DataSource = null;
            grdUpdateCategory.Refresh();
            this.Close();
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
                                    CategoryID = q.CategoryId,
                                    CategoryName = q.CategoryName,
                                }).ToList();
                grdUpdateCategory.DataSource = gridList;

            }
            catch
            {
                DialogResult dialogResult = MessageBox.Show("Aradýðýnýz ürün bulunamamýþtýr!", "Bilgilendirme Mesajý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}