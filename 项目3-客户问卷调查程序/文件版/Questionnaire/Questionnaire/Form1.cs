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
            Customers cs = new Customers();
            cs.Name = txtName.Text;
            if (rbtnAnswer1.Checked)
                cs.Gender = rbtnAnswer1.Text;
            if (rbtnAnswer2.Checked)
                cs.Gender = rbtnAnswer2.Text;
            if (chkAnswer1.Checked)
                cs.Impression += chkAnswer1.Text + " ";
            if (chkAnswer2.Checked)
                cs.Impression += chkAnswer2.Text + " ";
            if (chkAnswer3.Checked)
                cs.Impression += chkAnswer3.Text + " ";
            if (chkAnswer4.Checked)
                cs.Impression += chkAnswer4.Text + " ";
            cs.Satisfaction = cboAnwer.Text;
            for (int i = 0; i < lstAnswer.SelectedItems.Count; i++)
            {
                cs.Service += lstAnswer.SelectedItems[i].ToString() + " ";
            }
            if (txtOperate.Writer(cs))
                MessageBox.Show("保存成功！");
            else
                MessageBox.Show("保存失败！");
        }
    }
}
