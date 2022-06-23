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
            cbbCategorySearch.Items.Add("Kategori ID'sine G�re");
            cbbCategorySearch.Items.Add("Kategori Ad�na G�re");
            cbbCategorySearch.SelectedIndex = 0;
        }

        private async void btnUpdateSearch_Click(object sender, EventArgs e)
        {
            if (cbbCategorySearch.SelectedItem == "Kategori ID'sine G�re")
            {
                var list = (await cs.GetAll()).ToList();
                var gridList = (from q in list
                                where q.CategoryId == Convert.ToInt32(txtCategorySearch.Text)
                                select new
                                {
                                    KategoriID = q.CategoryId,
                                    KategoriAd� = q.CategoryName
                                }).ToList();
                grdUpdateCategory.DataSource = gridList;
                foreach (var i in gridList)
                {
                    txtUpdateCategory.Text = i.KategoriAd�;
                }

            }
            else if (cbbCategorySearch.SelectedItem == "Kategori Ad�na G�re")
            {
                var list = (await cs.GetAll()).ToList();
                var gridList = (from q in list
                                where q.CategoryName == txtCategorySearch.Text
                                select new
                                {
                                    KategoriID = q.CategoryId,
                                    KategoriAd� = q.CategoryName
                                }).ToList();
                grdUpdateCategory.DataSource = gridList;
                foreach (var i in gridList)
                {
                    txtUpdateCategory.Text = i.KategoriAd�;
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Arad���n�z kategori bulunamam��t�r!", "Bilgilendirme Mesaj�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void cbbCategorySearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cs.Update(Convert.ToInt32(grdUpdateCategory.CurrentRow.Cells[0].Value), txtUpdateCategory.Text);
            DialogResult result = MessageBox.Show("Kategori ba�ar�yla g�ncellenmi�tir.", "Bilgilendirme Mesaj�", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cbbCategorySearch.Items.Clear();
            txtUpdateCategory.Text = "";
            txtCategorySearch.Text = "";
            grdUpdateCategory.DataSource = null;
            grdUpdateCategory.Refresh();
            this.Close();
        }
    }
}