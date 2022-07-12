using AppNet.AppService;

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
    }
}