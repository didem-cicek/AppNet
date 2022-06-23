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
            btnselectdel.Visible = false;
            cbbDeletedSearch.Items.Clear();
            cbbDeletedSearch.Items.Add("�r�n ID'sine G�re");
            cbbDeletedSearch.Items.Add("�r�n Ad�na G�re");
            cbbDeletedSearch.SelectedIndex = 0;
        }

        private async void btnDeleted_Click(object sender, EventArgs e)
        {
            var list = (await ps.GetAll()).ToList();
            if (cbbDeletedSearch.SelectedItem == "�r�n ID'sine G�re")
            {
                try { 
                var gridList = (from q in list
                                where q.ProductID == Convert.ToInt32(txtDeletedSearch.Text)
                                select new
                                {
                                    ID = q.ProductID,
                                    �r�nAd� = q.ProductName
                                }).ToList();
                grdDeletedList.DataSource = gridList;
                btnselectdel.Visible = true;
                }
                catch (Exception ex)
                {
                    DialogResult dialogResult = MessageBox.Show("Yazd���n�z arama kelimesinde sorun bulundu, l�tfen kontrol ediniz!", "Uyar� Mesaj�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else if (cbbDeletedSearch.SelectedItem == "�r�n Ad�na G�re")
            {
                try { 
                var gridList = (from q in list
                                where q.ProductName == txtDeletedSearch.Text
                                select new
                                {
                                    ID = q.ProductID,
                                    �r�nAd� = q.ProductName
                                }).ToList();
                grdDeletedList.DataSource = gridList;
                btnselectdel.Visible = true;
                }
                catch (Exception ex)
                {
                    DialogResult dialogResult = MessageBox.Show("Yazd���n�z arama kelimesinde sorun bulundu, l�tfen kontrol ediniz!", "Uyar� Mesaj�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Arad���n�z �r�n bulunamam��t�r!", "Uyar� Mesaj�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
    }
}