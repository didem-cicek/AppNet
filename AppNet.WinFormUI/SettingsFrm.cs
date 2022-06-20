using AppNet.AppService;
using AppNet.AppServices;
using AppNet.Infrastructer.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
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
        private readonly IDatabaseService databaseService;
        private readonly ErpDbContext db;
        private readonly IServiceProvider sp;
        private readonly ServiceCollection services;
        public SettingsFrm(IDatabaseService databaseService, ErpDbContext db, IServiceProvider sp)
        {
            InitializeComponent();
            this.databaseService = databaseService;
            this.db = db;
            this.sp = sp;

        }


        private void SettingsFrm_Load(object sender, EventArgs e)
        {
            var settings = DbSettings.Load();

            if (settings != null)
            {
                var frm = sp.GetRequiredService<Login>();
                frm.ShowDialog();


                //txtServer.Text = settings.Server;
                //txtAddDatabaseName.Text = settings.Database;
                //txtAddDataBaseUser.Text = settings.Username;
                //txtAddPassword.Text = settings.Password;
            }
            else
            {
                
            }
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
            DbSettings dbsettings = new DbSettings();
            dbsettings.Server = txtServer.Text;
            dbsettings.Database = txtAddDatabaseName.Text;
            dbsettings.Username = txtAddDataBaseUser.Text;
            dbsettings.Password = txtAddPassword.Text;
            dbsettings.Save();
            services.RegisterPersistenceService();
            db.Database.EnsureCreated();
            db.Database.Migrate();
            databaseService.Add(txtAddDatabaseName.Text, txtAddDataBaseUser.Text, txtAddPassword.Text);

            MessageBox.Show("Database Oluşturuldu! İlk giriş için YENİ KAYIT alanından sisteme kayıt olunuz.","Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var frm = sp.GetRequiredService<Login>();
            frm.ShowDialog();


            this.Close();

        }
    }
}
