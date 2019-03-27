using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCalculator
{
    public partial class Form1 : Form
    {
        string str, opp, opp1;
        double num1, num2, result;
        double m = 0;
        bool flag = false;//按过=后，防止数字拼接
        
        public Form1()
        {
            InitializeComponent();
        }

        private void number(object sender, EventArgs e)
        {
            if (flag)
            {
                txtOutput.Text = "0";
                flag = false;
            }
            Button b = (Button)sender;
            str = b.Text;
            if (txtOutput.Text == "0")
            {
                txtOutput.Text = str;
            }
            else
            {
                txtOutput.Text += str;
            }
        }

        private void operator1(object sender, EventArgs e)
        {
            if(opp !="" && opp1 == "")//用于连续计算，例1+2+3
            {
                btnEqual_Click(sender, e);
            }
            Button b = (Button)sender;
            num1 = double.Parse(txtOutput.Text);
            txtOutput.Text = "0";
            opp = b.Text;
            opp1 = "";

        }

        private void operator2(object sender, EventArgs e)
        {
            Button b=(Button)sender;
            double temp;
            temp = double.Parse(txtOutput.Text);
            switch(b.Text)
            {
                case "√": temp = Math.Sqrt(temp); break;
                case "%": temp /= 100; break;
                case "1/x": temp = 1 / temp; break;
                case "±": temp = -temp; break;
            }
            txtOutput.Text = "" + temp.ToString();
        }

        private void btnBackspace_Click(object sender, EventArgs e)//退格
        {
            if (txtOutput.Text != "0"&&txtOutput.Text.Length>0)
            {
                txtOutput.Text = txtOutput.Text.Substring(0, txtOutput.Text.Length - 1);
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            result = num1 = num2 = 0;
            opp = str = null;
            txtOutput.Text = "0";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text.IndexOf(".") == -1)
            {
                txtOutput.Text += ".";
            }
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            m = 0;
            label1.Text = null;
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            txtOutput.Text = m.ToString();
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            m = double.Parse(txtOutput.Text);
            label1.Visible = true;
            label1.Text = "M";
        }

        private void btnMAdd_Click(object sender, EventArgs e)
        {
            m += double.Parse(txtOutput.Text);
        }

        private void btnMSub_Click(object sender, EventArgs e)
        {
            m -= double.Parse(txtOutput.Text);
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEqual_Click(object sender, EventArgs e)//等号
        {

            if (opp1 != "=")
            {
                num2 = double.Parse(txtOutput.Text);
            }
            switch (opp)
            {
                case "+":
                    num1 += num2;
                    break;
                case "-":
                    num1 -= num2;
                    break;
                case "*":
                    num1 *= num2;
                    break;
                case "/":
                    if (num2 == 0) txtOutput.Text = "除数不能为零";
                    else num1 /= num2;
                    break;
            }
            txtOutput.Text = "" + num1.ToString();
            opp1 = "=";
            flag = true;
        }
    }
}
