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

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            cbbUpdateProduct.Items.Clear();
            cbbUpdateProduct.Items.Add("�r�n ID'sine G�re");
            cbbUpdateProduct.Items.Add("�r�n Ad�na G�re");
            cbbUpdateProduct.SelectedIndex = 0;
        }

        private async void btnUpdateSearch_Click(object sender, EventArgs e)
        {
            var category = (await cs.GetAll()).ToList();
            var list = (await ps.GetAll()).ToList();
            foreach (var item in category)
            {
                cbbUpdatedCategory.Items.Add(item.CategoryName);
            }
            if (cbbUpdateProduct.SelectedItem == "�r�n ID'sine G�re")
            {
                var gridList = (from q in list
                                join c in category
                                on q.CategoryID equals c.CategoryId
                                where q.ProductID == Convert.ToInt32(txtUpdateProductSearch.Text)
                                select new
                                {
                                    ID = q.ProductID,
                                    �r�nAd� = q.ProductName,
                                    KategoriAd� = c.CategoryName,
                                    Ac�klama = q.ProductDesriciption
                                }).ToList();
                grdUpdateProductList.DataSource = gridList;
                foreach (var i in gridList)
                {
                    cbbUpdatedCategory.SelectedItem = i.KategoriAd�;
                    updatedProductName.Text = i.�r�nAd�;
                    txtUpdatedDescription.Text = i.Ac�klama;
                }
            }
            else if (cbbUpdateProduct.SelectedItem == "�r�n Ad�na G�re")
            {
                var gridList = (from q in list
                                join c in category
                                on q.CategoryID equals c.CategoryId
                                where q.ProductName == txtUpdateProductSearch.Text
                                select new
                                {
                                    ID = q.ProductID,
                                    �r�nAd� = q.ProductName,
                                    KategoriAd� = c.CategoryName,
                                    KategoriID = c.CategoryId,
                                    Ac�klama = q.ProductDesriciption
                                }).ToList();
                grdUpdateProductList.DataSource = gridList;
                foreach (var i in gridList)
                {
                    //cbbUpdatedCategory.SelectedItem = i.KategoriAd�;
                    //cbbUpdatedCategory.SelectedIndex = i.KategoriID;
                    updatedProductName.Text = i.�r�nAd�;
                    txtUpdatedDescription.Text = i.Ac�klama;
                }
            } else
            {
                DialogResult dialogResult = MessageBox.Show("Arad���n�z �r�n bulunamam��t�r!", "Bilgilendirme Mesaj�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                          
        }

        private void btnUpdatedProduct_Click(object sender, EventArgs e)
        {
            ps.Update(Convert.ToInt32(grdUpdateProductList.CurrentRow.Cells[0].Value), updatedProductName.Text, Convert.ToInt32(cbbUpdatedCategory.SelectedValue), txtUpdatedDescription.Text);
            DialogResult result = MessageBox.Show("�r�n ba�ar�yla g�ncellenmi�tir.", "Bilgilendirme Mesaj�", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cbbUpdatedCategory.Items.Clear();
            updatedProductName.Text = "";
            txtUpdatedDescription.Text = "";
            grdUpdateProductList.DataSource = null;
            grdUpdateProductList.Refresh();
            this.Close();
        }
    }
}

