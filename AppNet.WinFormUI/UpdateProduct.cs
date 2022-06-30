using AppNet.AppService;

namespace AppNet.WinFormUI
{
    public partial class UpdateProduct : Form
    {
        private readonly IServiceProvider sp;
        private readonly IProductService ps;
        private readonly ICategoryService cs;
        public UpdateProduct(IServiceProvider sp, IProductService ps, ICategoryService cs)
        {
            InitializeComponent();
            this.sp = sp;
            this.ps = ps;
            this.cs = cs;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private async void UpdateProduct_Load(object sender, EventArgs e)
        {
            var category = (await cs.GetAll()).ToList();
            foreach (var item in category)
            {
                cbbUpdatedCategory.DataSource = category;
                cbbUpdatedCategory.DisplayMember = nameof(item.CategoryName);
                cbbUpdatedCategory.ValueMember = nameof(item.CategoryId);
                
            }
        }

        private void btnUpdatedProduct_Click(object sender, EventArgs e)
        {
            
        }

        private async void txtUpdateProductSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var category = (await cs.GetAll()).ToList();
                var list = (await ps.GetAll()).ToList();
                var gridList = (from q in list
                                join c in category
                                on q.CategoryID equals c.CategoryId
                                where q.ProductName.ToLower().Contains((txtUpdateProductSearch.Text).ToLower())
                                orderby q.ProductName ascending
                                select new
                                {
                                    ID = q.ProductID,
                                    �r�nAd� = q.ProductName,
                                    KategoriAd� = c.CategoryName,
                                    Ac�klama = q.ProductDesriciption
                                }).ToList();
                grdUpdateProductList.DataSource = gridList;
                
            }
            catch
            {
                DialogResult dialogResult = MessageBox.Show("Arad���n�z �r�n bulunamam��t�r!", "Bilgilendirme Mesaj�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnUpdateSearch_Click(object sender, EventArgs e)
        {
            try
            {
            ps.Update(Convert.ToInt32(grdUpdateProductList.CurrentRow.Cells[0].Value), updatedProductName.Text, Convert.ToInt32(cbbUpdatedCategory.SelectedValue), txtUpdatedDescription.Text);
            DialogResult result = MessageBox.Show("�r�n ba�ar�yla g�ncellenmi�tir.", "Bilgilendirme Mesaj�", MessageBoxButtons.OK, MessageBoxIcon.Information);
            updatedProductName.Text = "";
            txtUpdatedDescription.Text = "";
            grdUpdateProductList.DataSource = null;
            grdUpdateProductList.Refresh();
            this.Close();}
            catch
            {

            }
        }

        private void grdUpdateProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            updatedProductName.Text = grdUpdateProductList.CurrentRow.Cells[1].Value.ToString();
            cbbUpdatedCategory.Text = grdUpdateProductList.CurrentRow.Cells[2].Value.ToString();
            txtUpdatedDescription.Text = grdUpdateProductList.CurrentRow.Cells[3].Value.ToString();
        }
    }

}