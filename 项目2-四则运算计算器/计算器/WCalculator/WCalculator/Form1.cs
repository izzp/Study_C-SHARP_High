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
        public Form1()
        {
            InitializeComponent();
        }
        string str, opp, opp1;
        double num1, num2, result;
        private void number(object sender, EventArgs e)//数字0~9
        {
            Button b = (Button)(sender);//实例化按钮对象
            str = b.Text; ;
            if (txtOutput.Text == "0")//是否按下0
            {
                txtOutput.Text = str;
            }
            else
            {
                txtOutput.Text = txtOutput.Text + str;
            }
        }
        private void operator1(object sender, EventArgs e)//符号"+ - * / ="
        {
            Button b = (Button)(sender);//实例化按钮对象
            if (b.Text == "+")//是否按下加号
            {
                num1 = double.Parse(txtOutput.Text);
                txtOutput.Text = "";
                opp = "+";
                opp1 = "";
            }
            else if (b.Text == "-")//是否按下减号
            {
                num1 = double.Parse(txtOutput.Text);
                txtOutput.Text = "";
                opp = "-";
                opp1 = "";
            }
            else if (b.Text == "*")//是否按下乘号
            {
                num1 = double.Parse(txtOutput.Text);
                txtOutput.Text = "";
                opp = "*";
                opp1 = "";
            }
            else if (b.Text == "/")//是否按下除号
            {
                num1 = double.Parse(txtOutput.Text);
                txtOutput.Text = "";
                opp = "/";
                opp1 = "";
            }
            else if (b.Text == "=")//是否按下等号
            {
                if (opp1 != "=")
                {
                    num2 = double.Parse(txtOutput.Text);
                }
                if (opp == "+")
                {
                    num1 = num1 + num2;
                    txtOutput.Text = "" + num1.ToString();
                }
                if (opp == "-")
                {
                    num1 = num1 - num2;
                    txtOutput.Text = "" + num1.ToString();
                }
                if (opp == "*")
                {
                    num1 = num1 * num2;
                    txtOutput.Text = "" + num1.ToString();
                }
                if (opp == "/")
                {
                    if (num2 == 0)//判断num2是否为0
                    {
                        txtOutput.Text = "除数不能为零！";
                    }
                    else
                    {
                        num1 = num1 / num2;
                        txtOutput.Text = "" + num1.ToString();
                    }
                }
                opp1 = "=";
            }
        }
        private void operator2(object sender, EventArgs e)//操作符"退格<--  CE  C  sqrt  %  1/x  +/-  . "
        {
            Button b = (Button)(sender);//实例化按钮对象
            if (b.Text == ".")//是否按下.
            {
                str = txtOutput.Text;
                int index = str.IndexOf(".");
                if (index == -1)
                {
                    txtOutput.Text = str + ".";
                }
            }
            else if (b.Text == "<---")//是否按下退格符
            {
                if (txtOutput.Text != "")
                {
                    str = txtOutput.Text;
                    str = str.Substring(0, str.Length - 1);
                    txtOutput.Text = str;
                }
            }
            else if (b.Text == "CE")//是否按下"CE"
            {
                txtOutput.Text = "0";
            }
            else if (b.Text == "C")//是否按下"C"
            {
                result = num1 = num2 = 0;
                str = null;
                opp = null;
                txtOutput.Text = "0";
            }
            else if (b.Text == "√")//是否按下"√"
            {
                if (num1 == -1)
                {
                    txtOutput.Text = "错误，不可开根号！";
                }
                num1 = double.Parse(txtOutput.Text);
                result = Math.Sqrt(num1);
                txtOutput.Text = result.ToString();
            }
            else if (b.Text == "1/x")//是否按下"1/x"
            {
                num1 = double.Parse(txtOutput.Text);
                result = 1 / num1;
                txtOutput.Text = result.ToString();
            }
            else if (b.Text == "%")//是否按下"%"
            {
                num1 = double.Parse(txtOutput.Text);
                result = num1 / 100;
                txtOutput.Text = result.ToString();
            }
            opp1 = "";
        }
    }
}
