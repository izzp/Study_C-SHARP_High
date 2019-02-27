using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin" && txtPassword.Text == "admin")
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
    }
}
