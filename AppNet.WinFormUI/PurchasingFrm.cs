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
    public partial class PurchasingFrm : Form
    {
        public PurchasingFrm()
        {
            InitializeComponent();
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            AddStock addStockFrm = new AddStock();
            addStockFrm.ShowDialog();
        }

        private void btnUpdatedStock_Click(object sender, EventArgs e)
        {
            UpdateStock updateStockFrm = new UpdateStock();
            updateStockFrm.ShowDialog();
        }

        private void btnDeletedStock_Click(object sender, EventArgs e)
        {
            DeleteStock deleteStockFrm = new DeleteStock();
            deleteStockFrm.ShowDialog();
        }

        private void PurchasingFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
