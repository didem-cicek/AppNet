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
        public CustomerFrm()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomerFrm = new AddCustomer();
            addCustomerFrm.ShowDialog();
        }

        private void btnUpdatedCustomer_Click(object sender, EventArgs e)
        {
            UpdateCustomer updateCustomerFrm = new UpdateCustomer();
            updateCustomerFrm.ShowDialog();
        }

        private void btnDeletedCustomer_Click(object sender, EventArgs e)
        {
            DeleteCustomer deleteCustomerFrm = new DeleteCustomer();
            deleteCustomerFrm.ShowDialog();
        }
    }
}
