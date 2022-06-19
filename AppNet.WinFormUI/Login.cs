using System.Linq;
using AppNet.Domain.Entities;
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
using AppNet.AppServices;
using Microsoft.Extensions.DependencyInjection;

namespace AppNet.WinFormUI
{
    public partial class Login : Form
    {
        private readonly IUserService UserService;
        public Login(IUserService UserService)
        {
            InitializeComponent();
            this.UserService = UserService;
            
        }
        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            UserService.Add(txtNewName.Text, txtNewUserName.Text, txtNewPassword.Text, txtNewDepartment.Text);
            DialogResult dialogResult = MessageBox.Show("Üye kaydınız başarıyla oluşturulmuştur. Şimdi kullanıcı adınız ve şifreniz ile giriş yapabilirsiniz.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
