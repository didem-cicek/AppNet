using AppNet.AppService;
using AppNet.Infrastructer.Persistence.ViewModels;

namespace AppNet.WinFormUI
{
    public partial class DeleteProduct : Form
    {
        private readonly IServiceProvider sp;
        private readonly IProductService ps;
        private readonly ICategoryService cs;
        public DeleteProduct(IServiceProvider sp, IProductService ps, ICategoryService cs)
        {
            InitializeComponent();
            this.sp = sp;
            this.ps = ps;
            this.cs = cs;
        }

        private void DeleteProduct_Load(object sender, EventArgs e)
        {
           
        }

        private async void btnDeleted_Click(object sender, EventArgs e)
        {
            

           
        }


        
        private async void btnselectdel_Click(object sender, EventArgs e)
        {
            DialogResult question = MessageBox.Show("Bulunan �r�n� silmek istedi�inize emin misiniz?", "Uyar� Mesaj�", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (question == DialogResult.Yes)
            {
                ps.Remove(Convert.ToInt32(grdDeletedList.CurrentRow.Cells[0].Value));
                DialogResult result = MessageBox.Show("�r�n ba�ar�yla silinmi�tir.", "Bilgilendirme Mesaj�", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtDeletedSearch.Text = "";
            this.Close();
            grdDeletedList.DataSource = null;
            grdDeletedList.Refresh();
        }

        private async void txtDeletedSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var category = (await cs.GetAll()).ToList();
                var list = (await ps.GetAll()).ToList();
                var gridList = (from q in list
                                join c in category
                                on q.CategoryID equals c.CategoryId
                                where q.ProductName.ToLower().Contains((txtDeletedSearch.Text).ToLower())
                                orderby q.ProductName ascending
                                select new
                                {
                                    ID = q.ProductID,
                                    �r�nAd� = q.ProductName,
                                    KategoriAd� = c.CategoryName,
                                    Ac�klama = q.ProductDesriciption
                                }).ToList();
                grdDeletedList.DataSource = gridList;

            }
            catch
            {
                DialogResult dialogResult = MessageBox.Show("Arad���n�z �r�n bulunamam��t�r!", "Bilgilendirme Mesaj�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}