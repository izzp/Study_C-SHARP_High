﻿using System;
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
            u.UserName = txtUser.Text.Trim();
            u.Password = txtPassword.Text.Trim();
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
