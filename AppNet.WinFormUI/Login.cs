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
using AppNet.Domain.Validations;

namespace AppNet.WinFormUI
{
    public partial class Login : Form
    {
        private readonly IUserService UserService;
        private readonly IServiceProvider sp;
        private readonly ILogService ls;
        private readonly INotificationsService n;
        public string Kullanıcı_Adı;
        public string Şifre;
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
            Kullanıcı_Adı = txtUserName.Text;
            Şifre = txtPassword.Text;
            try
            {
                Kullanıcı_Adı.NullOrEmpty(nameof(Kullanıcı_Adı));
                Şifre.NullOrEmpty(nameof(Şifre));
            
            try {
                
                i--;
            var list = (await UserService.GetAll()).ToList();
            if (i == 0)
            {
                DialogResult dialog = MessageBox.Show("3 hakkınızda kullandınız!", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ls.Add("3 defa yanlış şifre denemesi yapıldı", "Kritik Hata");
                notifyIcon1.ShowBalloonTip(1000, "Giriş Başarısız!", "Kullanıcınızı veya şifreniz yanlış kontrol ediniz. ", ToolTipIcon.Error);
                this.Close();
            }
            foreach (var item in list)
            {
                var userName = list.FirstOrDefault(u => u.UserName == txtUserName.Text);
                var password = list.FirstOrDefault(u => u.Password == txtPassword.Text);
                if (userName != null && password != null)
                {
                    notifyIcon1.ShowBalloonTip(1000, "Giriş Başarılı", "Hoşgeldiniz " + item.UserName, ToolTipIcon.Info);
                    ls.Add("Sisteme giriş yapıldı.", "Bilgilendirme");
                    var mainForm = sp.GetRequiredService<MainForm>();
                    mainForm.ShowDialog();
                    break;
                }
                else if (userName == null || password == null)
                {
                    DialogResult dialogResult = MessageBox.Show("Kullanıcı adınız veya şifreniz yanlış, lütfen doğru bilgilerinizi giriniz!", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    notifyIcon1.ShowBalloonTip(1000, "Giriş Başarısız!", "Kullanıcınızı veya şifreniz yanlış kontrol ediniz. ", ToolTipIcon.Error);
                    if (dialogResult == DialogResult.OK)
                    {
                        txtUserName.Text = "";
                        txtPassword.Text = "";

                        break;
                    }
                }
               }
            }
            catch
            {
                ls.Add("Kullanıcı giriş hatası", "Kritik Hata");
            }
            }
            catch (ArgumentNullException ex)
            {
                DialogResult dialogResult = MessageBox.Show($" {ex.ParamName} alanı boş bırakamazsınız!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ls.Add("Kullanıcı bilgileri null veya boş girildi.", "Kritik Hata");
            }

        }


        private void btnNewUser_Click(object sender, EventArgs e)
        {
            var Ad_Soyad = txtNewName.Text;
            var Kullanıcı_Adı = txtNewUserName.Text;
            var Şifre = txtNewPassword.Text;
            var Departman = txtNewDepartment.Text;
            try
            {
                Ad_Soyad.NullOrEmpty(nameof(Ad_Soyad));
                Kullanıcı_Adı.NullOrEmpty(nameof(Kullanıcı_Adı));
                Şifre.NullOrEmpty(nameof(Şifre));
                Departman.NullOrEmpty(nameof(Departman));
                UserService.Add(txtNewName.Text, txtNewUserName.Text, txtNewPassword.Text, txtNewDepartment.Text);
                DialogResult dialogResult = MessageBox.Show("Üye kaydınız başarıyla oluşturulmuştur. Şimdi kullanıcı adınız ve şifreniz ile giriş yapabilirsiniz.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch(ArgumentNullException ex)
            {
                DialogResult dialogResult = MessageBox.Show($" {ex.ParamName} alanı boş bırakamazsınız!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ls.Add("Yeni üye işleminde bilgiler null veya boş girildi.", "Kritik Hata");
            }
            }

        private void btnLoginNewPassword_Click(object sender, EventArgs e)
        {
            var mainForm = sp.GetRequiredService<NewPasswordForm>();
            mainForm.ShowDialog();
        }
    }
}
