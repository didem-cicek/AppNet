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

namespace AppNet.WinFormUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            

        }
        
      

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MainForm mainFrm = new MainForm();
            mainFrm.ShowDialog();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = txtNewName.Text.ToString();
            user.UserName = txtNewUserName.Text.ToString();
            user.Password = txtNewPassword.Text.ToString();
            user.UserAuthorization = txtNewDepartment.Text.ToString();
            
            using (var context = new ErpDbContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
                MessageBox.Show("Kaydınızı başarıyla oluşturdunuz. Bu bilgiler ile giriş yapınız.");
            }

        }
    }
}
