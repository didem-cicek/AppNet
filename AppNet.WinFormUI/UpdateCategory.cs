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
            cbbCategorySearch.Items.Clear();
            cbbCategorySearch.Items.Add("Kategori ID'sine Göre");
            cbbCategorySearch.Items.Add("Kategori Adýna Göre");
            cbbCategorySearch.SelectedIndex = 0;
        }

        private async void btnUpdateSearch_Click(object sender, EventArgs e)
        {
            if (cbbCategorySearch.SelectedItem == "Kategori ID'sine Göre")
            {
                var list = (await cs.GetAll()).ToList();
                var gridList = (from q in list
                                where q.CategoryId == Convert.ToInt32(txtCategorySearch.Text)
                                select new
                                {
                                    KategoriID = q.CategoryId,
                                    KategoriAdý = q.CategoryName
                                }).ToList();
                grdUpdateCategory.DataSource = gridList;
                foreach (var i in gridList)
                {
                    txtUpdateCategory.Text = i.KategoriAdý;
                }

            }
            else if (cbbCategorySearch.SelectedItem == "Kategori Adýna Göre")
            {
                var list = (await cs.GetAll()).ToList();
                var gridList = (from q in list
                                where q.CategoryName == txtCategorySearch.Text
                                select new
                                {
                                    KategoriID = q.CategoryId,
                                    KategoriAdý = q.CategoryName
                                }).ToList();
                grdUpdateCategory.DataSource = gridList;
                foreach (var i in gridList)
                {
                    txtUpdateCategory.Text = i.KategoriAdý;
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Aradýðýnýz kategori bulunamamýþtýr!", "Bilgilendirme Mesajý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void cbbCategorySearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cs.Update(Convert.ToInt32(grdUpdateCategory.CurrentRow.Cells[0].Value), txtUpdateCategory.Text);
            DialogResult result = MessageBox.Show("Kategori baþarýyla güncellenmiþtir.", "Bilgilendirme Mesajý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cbbCategorySearch.Items.Clear();
            txtUpdateCategory.Text = "";
            txtCategorySearch.Text = "";
            grdUpdateCategory.DataSource = null;
            grdUpdateCategory.Refresh();
            this.Close();
        }
    }
}