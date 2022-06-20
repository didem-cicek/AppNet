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
        private readonly IServiceProvider sp;
        public Login(IUserService UserService, IServiceProvider sp)
        {
            InitializeComponent();
            this.UserService = UserService;
            this.sp = sp;
            
        }
        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            var mainForm = sp.GetRequiredService<MainForm>();
            mainForm.ShowDialog();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            UserService.Add(txtNewName.Text, txtNewUserName.Text, txtNewPassword.Text, txtNewDepartment.Text);
            DialogResult dialogResult = MessageBox.Show("Üye kaydınız başarıyla oluşturulmuştur. Şimdi kullanıcı adınız ve şifreniz ile giriş yapabilirsiniz.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
