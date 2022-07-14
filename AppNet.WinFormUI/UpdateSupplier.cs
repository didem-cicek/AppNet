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
            var Tedarikçi_Adý = txtUpdateSupplierName.Text;
            var Telefon_Numarasý = txtUpdateSupplierPhoneNumber.Text;
            var Adres = txtUpdateSupplierAddress.Text;
            var Vergi_Numarasý = txtTaxNo.Text;
            var Vergi_Dairesi = txtTaxOffice.Text;

            try {
                Tedarikçi_Adý.NullOrEmpty(nameof(Tedarikçi_Adý));
                Telefon_Numarasý.NullOrEmpty(nameof(Telefon_Numarasý));
                Adres.NullOrEmpty(nameof(Adres));
                Vergi_Numarasý.NullOrEmpty(nameof(Vergi_Numarasý));
                Vergi_Dairesi.NullOrEmpty(nameof(Vergi_Dairesi));

                try { 
                ss.Update(Convert.ToInt32(grdSupplierList.CurrentRow.Cells[0].Value), txtUpdateSupplierName.Text, txtUpdateSupplierPhoneNumber.Text, txtUpdateSupplierAddress.Text, Convert.ToInt32(txtTaxNo.Text), txtTaxOffice.Text);
                DialogResult result = MessageBox.Show("Tedarikçi baþarýyla güncellenmiþtir.", "Bilgilendirme Mesajý", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    DialogResult dialogResult = MessageBox.Show("Bilinmeyen bir hata oluþtu, güncelleme iþleminiz baþarýz!", "Uyarý Mesajý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (ArgumentNullException ex)
            {
                DialogResult dialogResult = MessageBox.Show($" {ex.ParamName} alaný boþ býrakamazsýnýz!", "Uyarý Mesajý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                                    TedarikçiAdý = q.SupplierName,
                                    Telefon = q.SupplierPhone,
                                    Adres = q.SupplierAddress,
                                    VergiNumarasý = q.SupplierTaxNumber,
                                    VergiDairesi = q.SupplierTaxName
                                }).ToList();
                grdSupplierList.DataSource = gridList;

            }
            catch
            {
                DialogResult dialogResult = MessageBox.Show("Aradýðýnýz tedarikçi bulunamamýþtýr!", "Bilgilendirme Mesajý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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