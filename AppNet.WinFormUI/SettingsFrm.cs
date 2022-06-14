using AppNet.AppServices;
using AppNet.Infrastructer.Persistence;
using Microsoft.EntityFrameworkCore;
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
    public partial class SettingsFrm : Form
    {
        public SettingsFrm()
        {
            InitializeComponent();
        }

        private void SettingsFrm_Load(object sender, EventArgs e)
        {

        }

        private void txtAddDatabasePassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddDataBaseUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddDatabaseName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddDatabase_Click(object sender, EventArgs e)
        {
            var filePath = "AppNet-Domain-Entities-DataBase" + ".txt";
            if(!File.Exists(filePath)){
            var service = IOCContainer.Resolve<IDatabaseService>();
             service.Create(Convert.ToInt32(1), txtAddDatabaseName.Text, txtAddDataBaseUser.Text, txtAddPassword.Text);
            MessageBox.Show("Veri Loglandı.");
            ErpDbContext database = new ErpDbContext();
            database.dbName = txtAddDatabaseName.Text;
            database.userName = txtAddDataBaseUser.Text;
            database.userPassword = txtAddPassword.Text;
            database.Database.EnsureCreated();
            database.Database.Migrate();
            MessageBox.Show("Database Oluşturuldu! İlk giriş için YENİ KAYIT alanından sisteme kayıt olunuz.","Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Login login = new Login();
            login.ShowDialog();
            }
            else
            {
                MessageBox.Show("Zaten Oluşturduğunuz Bir Database Var!");
            }
            this.Close();

        }
    }
}
