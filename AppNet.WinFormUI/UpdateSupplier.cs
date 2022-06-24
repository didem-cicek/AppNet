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
            ss.Update(Convert.ToInt32(grdSupplierList.CurrentRow.Cells[0].Value), txtUpdateSupplierName.Text, txtUpdateSupplierPhoneNumber.Text, txtUpdateSupplierAddress.Text, txtShippingAdress.Text);
            DialogResult result = MessageBox.Show("Tedarikçi baþarýyla güncellenmiþtir.", "Bilgilendirme Mesajý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtUpdateSupplierName.Text = "";
            txtUpdateSupplierPhoneNumber.Text = "";
            txtUpdateSupplierAddress.Text = "";
            txtShippingAdress.Text = "";
            grdSupplierList.DataSource = null;
            grdSupplierList.Refresh();
            this.Close();
        }

        private void UpdateSupplier_Load(object sender, EventArgs e)
        {
            cbbUpdateSupplierSearch.Items.Clear();
            cbbUpdateSupplierSearch.Items.Add("Tedarikçi ID'sine Göre");
            cbbUpdateSupplierSearch.Items.Add("Tedarikçi Adýna Göre");
            cbbUpdateSupplierSearch.SelectedIndex = 0;
        }
        private async void btnSearchUpdate_Click(object sender, EventArgs e)
        {
            var suppliers = (await ss.GetAll()).ToList();
            if (cbbUpdateSupplierSearch.SelectedItem == "Tedarikçi ID'sine Göre")
            {
                try
                {
                    var gridList = (from q in suppliers
                                    where q.SupplierID == Convert.ToInt32(txtUpdateSupplierSearch.Text)
                                    select new
                                    {
                                        ID = q.SupplierID,
                                        TedarikçiAdý = q.SupplierName,
                                        Telefon = q.SupplierPhone,
                                        Adres = q.SupplierAddress,
                                        SevkAdresi=q.SupplierShippingAddress,
                                    }).ToList();
                    grdSupplierList.DataSource = gridList;
                    foreach (var i in gridList)
                    {
                        txtUpdateSupplierName.Text = i.TedarikçiAdý;
                        txtUpdateSupplierPhoneNumber.Text = i.Telefon;
                        txtUpdateSupplierAddress.Text = i.Adres;
                        txtUpdateSupplierAddress.Text = i.SevkAdresi;
                    }
                }
                catch
                {
                    DialogResult dialogResult = MessageBox.Show("Yazdýðýnýz arama kelimesinde sorun bulundu, lütfen kontrol ediniz!", "Uyarý Mesajý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else if (cbbUpdateSupplierSearch.SelectedItem == "Tedarikçi Adýna Göre")
            {
                try
                {
                    var gridList = (from q in suppliers
                                    where q.SupplierName == txtUpdateSupplierName.Text
                                    select new
                                    {
                                        ID = q.SupplierID,
                                        TedarikçiAdý = q.SupplierName,
                                        Telefon = q.SupplierPhone,
                                        Adres = q.SupplierAddress,
                                        SevkAdresi = q.SupplierShippingAddress
                                    }).ToList();
                    grdSupplierList.DataSource = gridList;
                    foreach (var i in gridList)
                    {
                        txtUpdateSupplierName.Text = i.TedarikçiAdý;
                        txtUpdateSupplierPhoneNumber.Text = i.Telefon;
                        txtUpdateSupplierAddress.Text = i.Adres;
                        txtUpdateSupplierAddress.Text = i.SevkAdresi;
                    }
                }
                catch
                {
                    DialogResult dialogResult = MessageBox.Show("Yazdýðýnýz arama kelimesinde sorun bulundu, lütfen kontrol ediniz!", "Uyarý Mesajý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Aradýðýnýz tedarikçi bulunamamýþtýr!", "Uyarý Mesajý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}