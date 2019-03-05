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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            string password;
            u.UserName = txtUser.Text.Trim();
            password = txtPassword.Text.Trim();
            byte[] buffer = Encoding.Default.GetBytes(password);
            MD5 md5 = MD5.Create(); 
            byte[] bufferNew=md5.ComputeHash(buffer); //使用MD5实例的ComputerHash()方法处理字节数组。
            string strNew=null;
            for(int i=0;i<bufferNew.Length;i++)
            {
            strNew+=bufferNew[i].ToString("x2");  //对bufferNew字节数组中的每个元素进行十六进制转换然后拼接成strNew字符串
            }
            u.Password = strNew;
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
