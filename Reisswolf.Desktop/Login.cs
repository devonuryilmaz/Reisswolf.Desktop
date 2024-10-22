using MetroFramework.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Reisswolf.Desktop
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginUser();
        }

        private void LoginUser()
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return;

            var user = Core.database.Users.FirstOrDefault(x => x.UserName == username && x.Password == password);
            if (user != null)
            {
                Core.ActiveUser = user;

                Program.ValidLogin = true;
                this.Hide();

                var df = new Dashboard();
                df.Show();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Kullanıcı adı veya şifre yanlış. \nLütfen giriş bilgilerini kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void chckBtnTogglePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBtnTogglePassword.Checked)
            {
                chckBtnTogglePassword.Text = "Şifreyi Gizle";
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                chckBtnTogglePassword.Text = "Şifreyi Göster";
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        //private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        LoginUser();
        //        e.SuppressKeyPress = true;
        //    }

        //}

        //private void txtUsername_KeyUp(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        LoginUser();
        //        e.SuppressKeyPress = true;

        //    }
        //}

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LoginUser();
                e.Handled = true;

            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LoginUser();
                e.Handled = true;

            }
        }
    }
}
