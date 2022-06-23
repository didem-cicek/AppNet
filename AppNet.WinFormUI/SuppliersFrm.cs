using AppNet.AppService;
using AppNet.Infrastructer.Persistence.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace AppNet.WinFormUI
{
    public partial class SuppliersFrm : Form
    {
        private readonly IServiceProvider sp;
        private readonly ISupplierService ss;
        private readonly IStockService sts;
        public SuppliersFrm(IServiceProvider sp, ISupplierService ss, IStockService sts)
        {
            InitializeComponent();
            this.sp = sp;
            this.ss = ss;
            this.sts = sts;
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<AddSupplier>();
            frm.ShowDialog();
            grdSupplierList.Rows.Clear();
            LoadGridData();
        }

        private void btnUpdatedSupplier_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<UpdateSupplier>();
            frm.ShowDialog();
            grdSupplierList.Rows.Clear();
            LoadGridData();
        }

        private void SuppliersFrm_Load(object sender, EventArgs e)
        {
            grdSupplierList.Rows.Clear();
            grdSupplierList.Columns.Add("SupplierID", "Tedarikçi ID");
            grdSupplierList.Columns.Add("SupplierName", "Tedarikçi Adý");
            grdSupplierList.Columns.Add("SupplierPhone", "Telefon");
            grdSupplierList.Columns.Add("SupplierAddress", "Adres");
            grdSupplierList.Columns.Add("SupplierShippingAddress", "Sevk Adresi");
            grdSupplierList.Columns.Add("SupplierDebt", "Borç");
            grdSupplierList.Columns.Add("SupplierReceivable", "Alacak");
            grdSupplierList.Columns.Add("Date", "Kayýt Tarihi");
            grdSupplierList.Columns.Add("ModifiedDate", "Son Düzenleme");
            LoadGridData();
            grdSupplierList.Columns[0].Visible = false;
        }
        private async void LoadGridData()
        {
            var supplier = (await ss.GetAll()).ToList();
            var stok = (await sts.GetAll()).ToList();
            var data = from p in supplier
                       join c in stok
                       on p.SupplierID equals c.SupplierID
                       select new SupplierViewModel
                       {
                           SupplierID = p.SupplierID,
                           SupplierName = p.SupplierName,
                           SupplierPhone = p.SupplierPhone,
                           SupplierAddress = p.SupplierAddress,
                           SupplierShippingAddress = p.SupplierShippingAddress,
                           SupplierDebt = c.StockTotalPrice - c.StockPiece,
                           SupplierReceivable = c.StockTotalPrice,
                           Date = p.SupplierDate,
                           ModifiedDate =p.SupplierModifitedDate
                       };
            foreach (var item in data)
            {
                AddRowToGrid(item);
            }
        }
        private void AddRowToGrid(SupplierViewModel model)
        {
            DataGridViewRow row = (DataGridViewRow)grdSupplierList.Rows[0].Clone();
            row.Cells[0].Value = model.SupplierID;
            row.Cells[1].Value = model.SupplierName;
            row.Cells[2].Value = model.SupplierPhone;
            row.Cells[3].Value = model.SupplierAddress;
            row.Cells[4].Value = model.SupplierShippingAddress;
            row.Cells[5].Value = model.SupplierDebt;
            row.Cells[6].Value = model.SupplierReceivable;
            row.Cells[7].Value = model.Date;
            row.Cells[8].Value = model.ModifiedDate;

            grdSupplierList.Rows.Add(row);
        }
        private void btnDeletedSupplier_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<DeleteSupplier>();
            frm.ShowDialog();
            grdSupplierList.Rows.Clear();
            LoadGridData();
        }
    }
}