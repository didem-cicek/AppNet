using AppNet.AppService;
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
    public partial class DeleteCustomer : Form
    {
        private readonly ICustomerService cs;
        public DeleteCustomer(ICustomerService cs)
        {
            InitializeComponent();
            this.cs = cs;
        }

        private async void btnDeleted_Click(object sender, EventArgs e)
        {
        }

        private void DeleteCustomer_Load(object sender, EventArgs e)
        {
           
        }

        private void btncustomerDelete_Click(object sender, EventArgs e)
        {
            DialogResult question = MessageBox.Show("Bulunan müşteriyi silmek istediğinize emin misiniz?", "Bilgilendirme Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (question == DialogResult.Yes)
            {
                cs.Remove(Convert.ToInt32(grdDeleteCustomerList.CurrentRow.Cells[0].Value));
                DialogResult result = MessageBox.Show("Müşteri başarıyla silinmiştir.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtDeleteCustomerSearch.Text = "";
            this.Close();
            grdDeleteCustomerList.DataSource = null;
            grdDeleteCustomerList.Refresh();
        }

        private async void txtDeleteCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var customer = (await cs.GetAll()).ToList();
                var find = (from q in customer
                                where q.CustomerName.ToLower().Contains((txtDeleteCustomerSearch.Text).ToLower())
                                orderby q.CustomerName ascending
                                select new
                                {
                                    CustomerID = q.CustomerID,
                                    CustomerName = q.CustomerName,
                                }).ToList();
                grdDeleteCustomerList.DataSource = find;

            }
            catch
            {
                DialogResult dialogResult = MessageBox.Show("Aradığınız ürün bulunamamıştır!", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
