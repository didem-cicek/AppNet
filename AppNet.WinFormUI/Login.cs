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
        private readonly ILogService ls;
        private readonly INotificationsService n;
        public Login(IUserService UserService, IServiceProvider sp, ILogService ls, INotificationsService n)
        {
            InitializeComponent();
            this.UserService = UserService;
            this.sp = sp;
            this.ls = ls;
            this.n = n;
            
        }
        private void Login_Load(object sender, EventArgs e)
        {
           
        }
        int i = 4;
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            i--;
            var list = (await UserService.GetAll()).ToList();
            if (i == 0)
            {
                DialogResult dialog = MessageBox.Show("3 hakkınızda kullandınız!", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ls.Add("3 defa yanlış şifre denemesi yapıldı", "Kritik Hata");
                this.Close();
            }
            foreach (var item in list)
            {
                var userName = list.FirstOrDefault(u => u.UserName == txtUserName.Text);
                var password = list.FirstOrDefault(u => u.Password == txtPassword.Text);
                if (userName!=null && password!=null)
                    {
                    n.Add("Hoşgeldiniz " + txtUserName.Text);
                    ls.Add("Sisteme giriş yapıldı.", "Bilgilenirme");
                    var mainForm = sp.GetRequiredService<MainForm>();
                    mainForm.ShowDialog();
                    break;
                    }
                    else if (userName == null && password == null)
                    {
                        DialogResult dialogResult = MessageBox.Show("Kullanıcı adınız veya şifreniz yanlış, lütfen doğru bilgilerinizi giriniz!", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.OK)
                        {
                            txtUserName.Text = "";
                            txtPassword.Text = "";
                            
                            break;
                        }
                    }else{
                        DialogResult dialog = MessageBox.Show("Bilinmeyen bir hata oluştu, sistem yöneticiniz ile iletişime geçiniz!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
               
            }
         }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            UserService.Add(txtNewName.Text, txtNewUserName.Text, txtNewPassword.Text, txtNewDepartment.Text);
            DialogResult dialogResult = MessageBox.Show("Üye kaydınız başarıyla oluşturulmuştur. Şimdi kullanıcı adınız ve şifreniz ile giriş yapabilirsiniz.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
