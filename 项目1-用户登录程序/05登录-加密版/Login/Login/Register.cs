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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() != txtPassword2.Text.Trim())
            {
                MessageBox.Show("两次密码输入不一致！");
                return;
            }
            Users u = new Users();
            string password;
            u.UserName = txtUser.Text.Trim();
            password= txtPassword.Text.Trim();

            byte[] buffer = Encoding.Default.GetBytes(password);
            MD5 md5 = MD5.Create();
            byte[] bufferNew = md5.ComputeHash(buffer); //使用MD5实例的ComputerHash()方法处理字节数组。
            string strNew = null;
            for (int i = 0; i < bufferNew.Length; i++)
            {
                strNew += bufferNew[i].ToString("x2");  //对bufferNew字节数组中的每个元素进行十六进制转换然后拼接成strNew字符串
            }
            u.Password = strNew;

            if (DBOption.readDB(u.UserName))
            {
                MessageBox.Show("当前用户已被注册！");
            }
            else
            {
                if (DBOption.writeDB(u))
                {
                    MessageBox.Show("注册成功！");
                    frmLogin l = new frmLogin();
                    l.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("注册失败！");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPassword.Text = "";
            txtPassword2.Text = "";
            txtUser.Focus();
        }
    }
}
