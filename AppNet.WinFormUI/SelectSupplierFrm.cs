using AppNet.AppService;
using AppNet.Infrastructer.Persistence.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppNet.WinFormUI
{
    public partial class SelectSupplierFrm : Form
    {
        private readonly ISupplierService ss;
        private readonly IServiceProvider sp;
        public SelectSupplierFrm(IServiceProvider sp, ISupplierService ss)
        {
            InitializeComponent();
            this.sp = sp;
            this.ss = ss;
        }

        private void SelectSupplierFrm_Load(object sender, EventArgs e)
        {
            if (grdSupplier.Rows.Count == 0)
            {

                grdSupplier.Columns.Add("SupplierID", "Tedarikçi ID");
                grdSupplier.Columns.Add("SupplierName", "Tedarikçi Adı");
                grdSupplier.Columns.Add("Phone", "Telefon Numarası");
                LoadGridData();
            }
        }
        private async void LoadGridData()
        {
            var s = (await ss.GetAll()).ToList();
            var customerList = (from q in s
                                select new SupplierListViewModel
                                {
                                    SupplierID = q.SupplierID,
                                    SupplierName = q.SupplierName,
                                    SupplierPhone = q.SupplierPhone,

                                }).ToList();
            foreach (var supplier in customerList)
            {
                AddRowToGridSupplier(supplier);
            }
        }
        private void AddRowToGridSupplier(SupplierListViewModel model)
        {
            DataGridViewRow row = (DataGridViewRow)grdSupplier.Rows[0].Clone();
            row.Cells[0].Value = model.SupplierID;
            row.Cells[1].Value = model.SupplierName;
            row.Cells[2].Value = model.SupplierPhone;

            grdSupplier.Rows.Add(row);
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            grdSupplier.Rows.Clear();
            grdSupplier.Refresh();
            var supplier = (await ss.GetAll()).ToList();
            var searchSupplier = (from q in supplier
                                  where q.SupplierName.ToLower().Contains((txtSearch.Text).ToLower())
                                  orderby q.SupplierName ascending
                                  select new SupplierListViewModel
                                  {
                                     SupplierID=q.SupplierID,
                                     SupplierName=q.SupplierName,
                                     SupplierPhone=q.SupplierPhone,

                                  }).ToList();

            foreach (var supplierFind in searchSupplier)
            {

                AddRowToGridSupplier(supplierFind);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
