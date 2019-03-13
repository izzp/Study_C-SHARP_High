using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private string ToMD5(string input)
        {
            byte[] mingwen = Encoding.UTF8.GetBytes(input);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] miwen = md5.ComputeHash(mingwen);
            return BitConverter.ToString(miwen).Replace("-", "");
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            u.UserName = txtUser.Text.Trim();
            u.Password = ToMD5(txtPassword.Text.Trim());
            if (DBOption.readDB(u))
            {
                frmMain frmmain1 = new frmMain();
                frmmain1.Show();
                this.Hide();
            }
            else
                MessageBox.Show("用户名或密码错误！");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPassword.Text = "";
            txtUser.Focus();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
