using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questionnaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string gender = "";
            string impression = "客户对业务员印象:";//储存印象
            string service = "客户需要：";
            if (rbtnAnswer1.Checked == true)
            {
                gender = "客户性别:" + rbtnAnswer1.Text;
            }
            if (rbtnAnswer2.Checked == true)
            {
                gender = "客户性别:" + rbtnAnswer2.Text;
            }
            if(chkAnswer1.Checked==true)
            {
                impression = impression + chkAnswer1.Text;
            }
            if (chkAnswer2.Checked == true)
            {
                impression = impression + chkAnswer2.Text;
            }
            if (chkAnswer3.Checked == true)
            {
                impression = impression + chkAnswer1.Text;
            }
            if (chkAnswer4.Checked == true)
            {
                impression = impression + chkAnswer4.Text;
            }
            for (int i = 0; i < lstAnswer.SelectedItems.Count;i++ )
            {
                service += lstAnswer.SelectedItems[i].ToString();
            }

            if (txtName.Text == "")
            {
                MessageBox.Show("请输入姓名");
            }
            else
            {
                MessageBox.Show("客户姓名：" + txtName.Text.Trim() + "\r\n" + gender + "\r\n" + impression + "\r\n" + service + "\r\n" + "客户最满意：" + cboAnwer.Text, "问卷调查结果");
            }

        }
    }
}
