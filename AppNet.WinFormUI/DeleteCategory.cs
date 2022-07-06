using AppNet.AppService;
using AppNet.Infrastructer.Persistence;
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
    public partial class DeleteCategory : Form
    {
        private readonly ICategoryService cs;
        public DeleteCategory(ICategoryService cs)
        {
            InitializeComponent();
            this.cs = cs;
        }

        private void DeleteCategory_Load(object sender, EventArgs e)
        {

        }

        private void DeleteCategory_Load_1(object sender, EventArgs e)
        {
            if (grdDeleteList.Rows.Count == 0)
            {

                grdDeleteList.Columns.Add("CategoryID", "Kategori ID");
                grdDeleteList.Columns.Add("CategoryName", "Kategori Adı");
                LoadGridData();
            }
        }
        private async void LoadGridData()
        {
            var c = (await cs.GetAll()).ToList();
            var list = (from q in c
                                select new CategoryList
                                {
                                    CategoryID = q.CategoryId,
                                    CategoryName = q.CategoryName,

                                }).ToList();
            foreach (var find in list)
            {
                AddRowToGrid(find);
            }
        }
        private void AddRowToGrid(CategoryList model)
        {
            DataGridViewRow row = (DataGridViewRow)grdDeleteList.Rows[0].Clone();
            row.Cells[0].Value = model.CategoryID;
            row.Cells[1].Value = model.CategoryName;

            grdDeleteList.Rows.Add(row);
        }
        private async void btnDeletedCategory_Click(object sender, EventArgs e)
        {
            
        }
        private void btnSearchDelete_Click(object sender, EventArgs e)
        {
            DialogResult question = MessageBox.Show("Bulunan kategoriyi silmek istediğinize emin misiniz?", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (question == DialogResult.Yes)
            {
                cs.Remove(Convert.ToInt32(grdDeleteList.CurrentRow.Cells[0].Value));
                DialogResult result = MessageBox.Show("Kategori başarıyla silinmiştir.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtDeleteCategory.Text = "";
            this.Close();
            grdDeleteList.DataSource = null;
            grdDeleteList.Refresh();
        }

        private async void txtDeleteCategory_TextChanged(object sender, EventArgs e)
        {
            grdDeleteList.Rows.Clear();
            grdDeleteList.Refresh();
            var customer = (await cs.GetAll()).ToList();
            var search = (from q in customer
                          where q.CategoryName.ToLower().Contains((txtDeleteCategory.Text).ToLower())
                                  orderby q.CategoryName ascending
                                  select new CategoryList
                                  {
                                      CategoryID= q.CategoryId,
                                      CategoryName = q.CategoryName,

                                  }).ToList();

            foreach (var find in search)
            {

                AddRowToGrid(find);
            }
        }
    }

    }
