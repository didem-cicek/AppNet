using AppNet.AppService;
using AppNet.Infrastructer.Persistence;
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
    public partial class DeleteCategory : Form
    {
        public DeleteCategory()
        {
            InitializeComponent();
        }

        private void DeleteCategory_Load(object sender, EventArgs e)
        {

        }

        private void DeleteCategory_Load_1(object sender, EventArgs e)
        {
            
            cbbDeleteCategory.Items.Add("Kategori ID'sine Göre");
            cbbDeleteCategory.Items.Add("Kategori Adına Göre");
            cbbDeleteCategory.SelectedIndex = 0;
        }

        private void btnDeletedCategory_Click(object sender, EventArgs e)
        {
           
        }

        private void cbbDeleteCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
