using AppNet.AppService;
using AppNet.Domain.Validations;
using System.Globalization;

namespace AppNet.WinFormUI
{
    public partial class UpdateSupplier : Form
    {
        private readonly ISupplierService ss;
        public UpdateSupplier(ISupplierService ss)
        {
            InitializeComponent();
            this.ss = ss;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void btnUpdatedSupplier_Click(object sender, EventArgs e)
        {
            var Tedarik�i_Ad� = txtUpdateSupplierName.Text;
            var Telefon_Numaras� = txtUpdateSupplierPhoneNumber.Text;
            var Adres = txtUpdateSupplierAddress.Text;
            var Vergi_Numaras� = txtTaxNo.Text;
            var Vergi_Dairesi = txtTaxOffice.Text;

            try {
                Tedarik�i_Ad�.NullOrEmpty(nameof(Tedarik�i_Ad�));
                Telefon_Numaras�.NullOrEmpty(nameof(Telefon_Numaras�));
                Adres.NullOrEmpty(nameof(Adres));
                Vergi_Numaras�.NullOrEmpty(nameof(Vergi_Numaras�));
                Vergi_Dairesi.NullOrEmpty(nameof(Vergi_Dairesi));

                try { 
                ss.Update(Convert.ToInt32(grdSupplierList.CurrentRow.Cells[0].Value), txtUpdateSupplierName.Text, txtUpdateSupplierPhoneNumber.Text, txtUpdateSupplierAddress.Text, Convert.ToInt32(txtTaxNo.Text), txtTaxOffice.Text);
                DialogResult result = MessageBox.Show("Tedarik�i ba�ar�yla g�ncellenmi�tir.", "Bilgilendirme Mesaj�", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUpdateSupplierName.Text = "";
                txtUpdateSupplierPhoneNumber.Text = "";
                txtUpdateSupplierAddress.Text = "";
                txtTaxOffice.Text = "";
                txtTaxNo.Text = "";
                grdSupplierList.DataSource = null;
                grdSupplierList.Refresh();
                this.Close();
                }
                catch
                {
                    DialogResult dialogResult = MessageBox.Show("Bilinmeyen bir hata olu�tu, g�ncelleme i�leminiz ba�ar�z!", "Uyar� Mesaj�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (ArgumentNullException ex)
            {
                DialogResult dialogResult = MessageBox.Show($" {ex.ParamName} alan� bo� b�rakamazs�n�z!", "Uyar� Mesaj�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateSupplier_Load(object sender, EventArgs e)
        {
            
        }
        private async void btnSearchUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private async void txtUpdateSupplierSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var suppliers = (await ss.GetAll()).ToList();
                var gridList = (from q in suppliers
                                where q.SupplierName.ToLower().Contains((txtUpdateSupplierSearch.Text).ToLower())
                                orderby q.SupplierName ascending
                                select new
                                {
                                    ID = q.SupplierID,
                                    Tedarik�iAd� = q.SupplierName,
                                    Telefon = q.SupplierPhone,
                                    Adres = q.SupplierAddress,
                                    VergiNumaras� = q.SupplierTaxNumber,
                                    VergiDairesi = q.SupplierTaxName
                                }).ToList();
                grdSupplierList.DataSource = gridList;

            }
            catch
            {
                DialogResult dialogResult = MessageBox.Show("Arad���n�z tedarik�i bulunamam��t�r!", "Bilgilendirme Mesaj�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void grdSupplierList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUpdateSupplierName.Text = grdSupplierList.CurrentRow.Cells[1].Value.ToString();
            txtUpdateSupplierPhoneNumber.Text = grdSupplierList.CurrentRow.Cells[2].Value.ToString();
            txtUpdateSupplierAddress.Text = grdSupplierList.CurrentRow.Cells[3].Value.ToString();
            txtTaxOffice.Text = grdSupplierList.CurrentRow.Cells[5].Value.ToString();
            txtTaxNo.Text = grdSupplierList.CurrentRow.Cells[4].Value.ToString();
        }

        private void txtUpdateSupplierName_TextChanged(object sender, EventArgs e)
        {
            txtUpdateSupplierName.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtUpdateSupplierName.Text);
            txtUpdateSupplierName.SelectionStart = txtUpdateSupplierName.Text.Length;
        }

        private void txtUpdateSupplierPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUpdateSupplierAddress_TextChanged(object sender, EventArgs e)
        {
            txtUpdateSupplierAddress.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtUpdateSupplierAddress.Text);
            txtUpdateSupplierAddress.SelectionStart = txtUpdateSupplierAddress.Text.Length;
        }

        private void txtTaxNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTaxOffice_TextChanged(object sender, EventArgs e)
        {
            txtTaxOffice.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtTaxOffice.Text);
            txtTaxOffice.SelectionStart = txtTaxOffice.Text.Length;
        }

        private void txtUpdateSupplierPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTaxNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}