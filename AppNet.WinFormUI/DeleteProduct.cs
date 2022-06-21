using AppNet.AppService;
using AppNet.Infrastructer.Persistence.ViewModels;

namespace AppNet.WinFormUI
{
    public partial class DeleteProduct : Form
    {
        private readonly IServiceProvider sp;
        private readonly IProductService ps;
        public DeleteProduct(IServiceProvider sp, IProductService ps)
        {
            InitializeComponent();
            this.sp = sp;
            this.ps = ps;
        }

        private void DeleteProduct_Load(object sender, EventArgs e)
        {
            cbbDeletedSearch.Items.Add("�r�n ID'sine G�re");
            cbbDeletedSearch.Items.Add("�r�n Ad�na G�re");
            cbbDeletedSearch.SelectedIndex = 0;
        }

        private async void btnDeleted_Click(object sender, EventArgs e)
        {
            if (cbbDeletedSearch.SelectedItem == "�r�n ID'sine G�re")
            {
                var list = (await ps.GetAll()).ToList();
                foreach (var item in list)
                {
                    if (item.ProductID == Convert.ToInt32(txtDeletedSearch.Text))
                    {

                        var gridList = (from q in list
                                        where q.ProductID == Convert.ToInt32(txtDeletedSearch.Text)
                                        select new
                                        {
                                            ID = q.ProductID,
                                            �r�nAd� = q.ProductName
                                        }).ToList();
                        grdDeletedList.DataSource = gridList;
                        if (gridList.Count == 0) { 
                            DialogResult dialogResult = MessageBox.Show("Arad���n�z �r�n bulunamam��t�r!", "Bilgilendirme Mesaj�", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                        break;}

                    }
                }

            }
            else if (cbbDeletedSearch.SelectedItem == "�r�n Ad�na G�re")
            {
                var list = (await ps.GetAll()).ToList();
                foreach (var item in list)
                {
                    if (item.ProductName == txtDeletedSearch.Text)
                    {
                        var gridList = (from q in list
                                        where q.ProductName == txtDeletedSearch.Text
                                        select new
                                        {
                                            ID = q.ProductID,
                                            �r�nAd� = q.ProductName
                                        }).ToList();
                        grdDeletedList.DataSource = gridList;
                        if (gridList.Count == 0)
                        {
                            DialogResult dialogResult = MessageBox.Show("Arad���n�z �r�n bulunamam��t�r!", "Bilgilendirme Mesaj�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                    }
                }
            }
            else
            {
                DialogResult error = MessageBox.Show("Bilinmeyen bir hata olu�tu!", "Bilgilendirme Mesaj�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (grdDeletedList.DataSource != null)
            {
                DialogResult question = MessageBox.Show("Bulunan �r�n� silmek istedi�inize emin misiniz?", "Bilgilendirme Mesaj�", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (question == DialogResult.Yes)
                {
                    ps.Remove(Convert.ToInt32(grdDeletedList.CurrentRow.Cells[0].Value));
                    DialogResult result = MessageBox.Show("�r�n ba�ar�yla silinmi�tir.", "Bilgilendirme Mesaj�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                txtDeletedSearch.Text = "";
                this.Close();
            }
            

        }


        private void cbbDeletedSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}