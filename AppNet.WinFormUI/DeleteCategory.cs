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
            var service = IOCContainer.Resolve<ICategoryService>();
            service.GetAll();
            if (cbbDeleteCategory.Text== "Kategori ID'sine Göre")
            {
                
            }
            else
            {
            
            foreach (var category in txtDeleteCategory.Text)
            {
                grdDeleteList.DataSource = category;
            }
            service.Remove(Convert.ToInt32(cbbDeleteCategory.SelectedValue));
            }
            
            
        }

        private void cbbDeleteCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
