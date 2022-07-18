using AppNet.AppService;
using AppNet.Infrastructer.Persistence.ViewModels;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class CustomerFrm : Form
    {
        private readonly ICustomerService cs;
        private readonly ISalesService ss;
        private readonly IServiceProvider sp;
        public decimal Debt = 0;
        public decimal Receivable = 0;
        public CustomerFrm(IServiceProvider sp, ICustomerService cs, ISalesService ss)
        {
            InitializeComponent();
            this.sp = sp;
            this.cs = cs;
            this.ss = ss;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<AddCustomer>();
            frm.ShowDialog();
            grdCustomerList.Rows.Clear();
            LoadGridData();
        }

        private void btnUpdatedCustomer_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<UpdateCustomer>();
            frm.ShowDialog();
            grdCustomerList.Rows.Clear();
            LoadGridData();
        }

        private void btnDeletedCustomer_Click(object sender, EventArgs e)
        {
            var frm = sp.GetRequiredService<DeleteCustomer>();
            frm.ShowDialog();
            grdCustomerList.Rows.Clear();
            LoadGridData();
        }

        private void CustomerFrm_Load(object sender, EventArgs e)
        {
            if (grdCustomerList.Rows.Count == 0)
            {
                grdCustomerList.Columns.Add("CustomerID", "Müşteri ID");
                grdCustomerList.Columns.Add("CustomerName", "Müşteri Adı");
                grdCustomerList.Columns.Add("CustomerPhone", "Telefon Numarası");
                grdCustomerList.Columns.Add("CustomerEmail", "E-Posta Adresi");
                grdCustomerList.Columns.Add("CustomerAddress", "Fatura Adresi");
                grdCustomerList.Columns.Add("CustomerShippingAddress", "Sevk Adresi");
                grdCustomerList.Columns.Add("CustomerTaxNumber", "Vergi Numarası");
                grdCustomerList.Columns.Add("CustomerTaxOffice", "Vergi Dairesi");
                grdCustomerList.Columns.Add("CustomerDesription", "Açıklama");
                grdCustomerList.Columns.Add("CustomerDebt", "Borç");
                grdCustomerList.Columns.Add("CustomerReceivable", "Alacak");
                grdCustomerList.Columns.Add("CustomerDate", "Ekleme Tarihi");
                grdCustomerList.Columns.Add("CustomerModifitedDate", "Düzenleme Tarihi");
                LoadGridData();
                grdCustomerList.Columns[0].Visible = false;
            }
        }
        private async void LoadGridData()
        {
            grdCustomerList.Rows.Clear();
            grdCustomerList.Refresh();
            var customer = (await cs.GetAll()).ToList();
            var sales = (await ss.GetAll()).ToList();
            var salesData = from p in customer
                            join s in sales
                            on p.CustomerID equals s.CustomerID
                            select new
                            {
                                CustomerID = p.CustomerID,
                                CustomerName = p.CustomerName,
                                CustomerPhone = p.CustomerPhone,
                                CustomerEmail = p.CustomerEmail,
                                CustomerAddress = p.CustomerAddress,
                                CustomerShippingAddress = p.CustomerShippingAddress,
                                CustomerTaxNumber = p.CustomerTaxNumber,
                                CustomerTaxOffice = p.CustomerTaxOffice,
                                CustomerDesription = p.CustomerDesription,
                                Sales = s.SalePrice,
                                Status = s.SaleStatus,
                                CustomerDate = p.CustomerDate,
                                CustomerModifitedDate = p.CustomerModifitedDate,
                            };

            var data = from p in customer
                       select new CustomerViewModel
                       {
                           CustomerID = p.CustomerID,
                           CustomerName = p.CustomerName,
                           CustomerPhone = p.CustomerPhone,
                           CustomerEmail = p.CustomerEmail,
                           CustomerAddress = p.CustomerAddress,
                           CustomerShippingAddress = p.CustomerShippingAddress,
                           CustomerTaxNumber = p.CustomerTaxNumber,
                           CustomerTaxOffice = p.CustomerTaxOffice,
                           CustomerDesription = p.CustomerDesription,
                           CustomerDebt = 0,
                           CustomerReceivable = 0,
                           CustomerDate = p.CustomerDate,
                           CustomerModifitedDate = p.CustomerModifitedDate,
                       };
            foreach (var item in data)
            {
                AddRowToGrid(item);
            }
        }
        private async void Data()
        {
            var customer = (await cs.GetAll()).ToList();
            var sales = (await ss.GetAll()).ToList();
            var salesData = from p in customer
                            join s in sales
                            on p.CustomerID equals s.CustomerID
                            select new
                            {
                                CustomerID = p.CustomerID,
                                CustomerName = p.CustomerName,
                                CustomerPhone = p.CustomerPhone,
                                CustomerEmail = p.CustomerEmail,
                                CustomerAddress = p.CustomerAddress,
                                CustomerShippingAddress = p.CustomerShippingAddress,
                                CustomerTaxNumber = p.CustomerTaxNumber,
                                CustomerTaxOffice = p.CustomerTaxOffice,
                                CustomerDesription = p.CustomerDesription,
                                Sales = s.SalePrice,
                                Status = s.SaleStatus,
                                CustomerDate = p.CustomerDate,
                                CustomerModifitedDate = p.CustomerModifitedDate,
                            };
            foreach (var item in salesData)
            {
                if (grdCustomerList.CurrentRow.Cells[1].Value.ToString().ToLower() == item.CustomerName.ToLower())
                {

                }
            }
        }
        private void AddRowToGrid(CustomerViewModel model)
        {
            DataGridViewRow row = (DataGridViewRow)grdCustomerList.Rows[0].Clone();
            row.Cells[0].Value = model.CustomerID;
            row.Cells[1].Value = model.CustomerName;
            row.Cells[2].Value = model.CustomerPhone;
            row.Cells[3].Value = model.CustomerEmail;
            row.Cells[4].Value = model.CustomerAddress;
            row.Cells[5].Value = model.CustomerShippingAddress;
            row.Cells[6].Value = model.CustomerTaxNumber;
            row.Cells[7].Value = model.CustomerTaxOffice;
            row.Cells[8].Value = model.CustomerDesription;
            row.Cells[9].Value = model.CustomerDebt;
            row.Cells[10].Value = model.CustomerReceivable;
            row.Cells[11].Value = model.CustomerDate;
            row.Cells[12].Value = model.CustomerModifitedDate;


            grdCustomerList.Rows.Add(row);
        }

        private void grdCustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void txtCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            grdCustomerList.Rows.Clear();
            grdCustomerList.Refresh();
            var customer = (await cs.GetAll()).ToList();
            var find = (from p in customer
                                 where p.CustomerName.ToLower().Contains((txtCustomerSearch.Text).ToLower())
                                 orderby p.CustomerName ascending
                                 select new CustomerViewModel
                                 {
                                     CustomerID = p.CustomerID,
                                     CustomerName = p.CustomerName,
                                     CustomerPhone = p.CustomerPhone,
                                     CustomerEmail = p.CustomerEmail,
                                     CustomerAddress = p.CustomerAddress,
                                     CustomerShippingAddress = p.CustomerShippingAddress,
                                     CustomerTaxNumber = p.CustomerTaxNumber,
                                     CustomerTaxOffice = p.CustomerTaxOffice,
                                     CustomerDesription = p.CustomerDesription,
                                     CustomerDebt = p.Sales == null ? 0 : p.Sales.Sum(s => s.SalePrice),
                                     CustomerReceivable = p.Sales == null ? 0 : p.Sales.Sum(s => s.SalePrice),
                                     CustomerDate = p.CustomerDate,
                                     CustomerModifitedDate = p.CustomerModifitedDate,

                                 }).ToList();

            foreach (var f in find)
            {

                AddRowToGrid(f);
            }
        }
    }
}
