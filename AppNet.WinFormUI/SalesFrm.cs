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
    public partial class SalesFrm : Form
    {
        public SalesFrm()
        {
            InitializeComponent();
        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            AddSale addSaleFrm = new AddSale();
            addSaleFrm.ShowDialog();
        }

        private void btnUpdateSale_Click(object sender, EventArgs e)
        {
            UpdateSale updateSaleFrm = new UpdateSale();
            updateSaleFrm.ShowDialog();
        }

        private void btnDeleteSale_Click(object sender, EventArgs e)
        {
            DeleteSale deleteSaleFrm = new DeleteSale();
            deleteSaleFrm.ShowDialog();
        }
    }
}
