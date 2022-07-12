using AppNet.AppServices;
using AppNet.Domain.Validations;
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
    public partial class NewPasswordForm : Form
    {
        private readonly IUserService UserService;
        private readonly IServiceProvider sp;
        private readonly ILogService ls;
        public string Kullanıcı_Adı;
        public string Şifre;
        public NewPasswordForm(IUserService UserService, IServiceProvider sp, ILogService ls)
        {
            InitializeComponent();
            this.sp = sp;
            this.ls = ls;
            this.UserService = UserService;
        }

        private async void btnPassword_Click(object sender, EventArgs e)
        {
            Kullanıcı_Adı = txtUserName.Text;
            Şifre = txtNewPassword.Text;
            try
            {
                Kullanıcı_Adı.NullOrEmpty(nameof(Kullanıcı_Adı));
                Şifre.NullOrEmpty(nameof(Şifre));
            
            try { 
            var list = (await UserService.GetAll()).ToList();
            foreach (var item in list)
            {
                if (item.UserName == txtUserName.Text)
                {
                    UserService.Update(item.UserID, item.Name, item.UserName, txtNewPassword.Text, item.UserAuthorization);
                    DialogResult dialogResult = MessageBox.Show("Şifreniz değiştirilmiştir.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Aradığınız kullanıcı adı bulunamamıştır!", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }}
            catch (Exception ex){
            
            }
            }
            catch (ArgumentNullException ex)
            {
                DialogResult dialogResult = MessageBox.Show($" {ex.ParamName} alanı boş bırakamazsınız!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ls.Add("Şifre değişikliği işleminde bilgiler null veya boş girildi.", "Kritik Hata");
            }

            this.Close();
        }

        private async void NewPasswordForm_Load(object sender, EventArgs e)
        {
            
        }
            
    }
}
