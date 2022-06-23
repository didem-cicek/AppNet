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
            cbbDeleteCategory.Items.Clear();
            cbbDeleteCategory.Items.Add("Kategori ID'sine Göre");
            cbbDeleteCategory.Items.Add("Kategori Adına Göre");
            cbbDeleteCategory.SelectedIndex = 0;
        }

        private async void btnDeletedCategory_Click(object sender, EventArgs e)
        {
            var list = (await cs.GetAll()).ToList();
            if (cbbDeleteCategory.SelectedItem == "Kategori ID'sine Göre")
            {
                try
                {
                    var gridList = (from q in list
                                where q.CategoryId == Convert.ToInt32(txtDeleteCategory.Text)
                                select new
                                {
                                    ID = q.CategoryId,
                                    KategoriAdı = q.CategoryName
                                }).ToList();
                    grdDeleteList.DataSource = gridList;
                }catch (Exception ex)
                {
                    DialogResult dialogResult = MessageBox.Show("Yazdığınız arama kelimesinde sorun bulundu, lütfen kontrol ediniz!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                

            }
            else if (cbbDeleteCategory.SelectedItem == "Kategori Adına Göre")
            {
                try
                {
                    var gridList = (from q in list
                                    where q.CategoryName == txtDeleteCategory.Text
                                    select new
                                    {
                                        ID = q.CategoryId,
                                        KategoriAdı = q.CategoryName
                                    }).ToList();
                    grdDeleteList.DataSource = gridList;
                }
                catch (Exception ex)
                {
                    DialogResult dialogResult = MessageBox.Show("Yazdığınız arama kelimesinde sorun bulundu, lütfen kontrol ediniz!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Aradığınız kategori bulunamamıştır!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        
    }

    }
