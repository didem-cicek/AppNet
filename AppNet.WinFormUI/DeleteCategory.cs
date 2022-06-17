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
            int deletedProduct = 0;
            using (var context = new ErpDbContext())
            {
                if (cbbDeleteCategory.Text == "Kategori ID'sine Göre")
                {
                    var id = context.Products.FirstOrDefault(p => p.CategoryID == Convert.ToInt32(cbbDeleteCategory.Text));
                    deletedProduct = Convert.ToInt32(id);

                }
                else if (cbbDeleteCategory.Text == "Kategori Adına Göre")
                {
                    var name = context.Products.FirstOrDefault(p => p.Category.CategoryName == cbbDeleteCategory.Text);
                    deletedProduct = name.CategoryID;
                }
                else
                {
                    MessageBox.Show("Aradığınız kategori bulunamadı!", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                
                service.Remove(Convert.ToInt32(deletedProduct));

            }
        }

        private void cbbDeleteCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
