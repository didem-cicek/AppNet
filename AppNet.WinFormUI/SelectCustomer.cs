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
    public partial class SelectCustomer : Form
    {
        private readonly ICustomerService cs;
        private readonly IServiceProvider sp;
        public SelectCustomer(IServiceProvider sp, ICustomerService cs)
        {
            InitializeComponent();
            this.sp = sp;
            this.cs = cs;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SelectCustomer_Load(object sender, EventArgs e)
        {
            if (grdCustomer.Rows.Count == 0)
            {

                grdCustomer.Columns.Add("CustomerID", "Müşteri ID");
                grdCustomer.Columns.Add("CustomerName", "Müşteri Adı");
                grdCustomer.Columns.Add("Phone", "Telefon Numarası");
                LoadGridData();
            }
        }
        private async void LoadGridData()
        {
            var c = (await cs.GetAll()).ToList();
            var customerList = (from q in c
                                select new CustomerListView
                                {
                                    CustomerID = q.CustomerID,
                                    CustomerName = q.CustomerName,
                                    CustomerPhone = q.CustomerPhone,

                                }).ToList();
            foreach (var customer in customerList)
            {
                AddRowToGridCustomer(customer);
            }
        }
        private void AddRowToGridCustomer(CustomerListView model)
        {
            DataGridViewRow row = (DataGridViewRow)grdCustomer.Rows[0].Clone();
            row.Cells[0].Value = model.CustomerID;
            row.Cells[1].Value = model.CustomerName;
            row.Cells[2].Value = model.CustomerPhone;

            grdCustomer.Rows.Add(row);
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            grdCustomer.Rows.Clear();
            grdCustomer.Refresh();
            var customer = (await cs.GetAll()).ToList();
            var searchCustomer = (from q in customer
                                  where q.CustomerName.ToLower().Contains((txtSearch.Text).ToLower())
                                  orderby q.CustomerName ascending
                                  select new CustomerListView
                                  {
                                      CustomerID = q.CustomerID,
                                      CustomerName = q.CustomerName,
                                      CustomerPhone= q.CustomerPhone,

                                  }).ToList();

            foreach (var customerFind in searchCustomer)
            {

                AddRowToGridCustomer(customerFind);
            }
        }

        public void grdCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}