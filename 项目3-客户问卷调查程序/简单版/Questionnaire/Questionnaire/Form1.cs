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
            string gender = "", impresses = "", services = "", satisfy="";//性别，印象，服务，满意度
            string[] serviceArray = new string[lstAnswer.SelectedItems.Count];
            string[] impressArray;
            int n=0;
            foreach (Control c in groupBox1.Controls)
            {
                if (((CheckBox)c).Checked)
                    n++;
            }
            impressArray = new string[n];

            if (rbtnAnswer1.Checked)
                gender = rbtnAnswer1.Text;
            if (rbtnAnswer2.Checked)
                gender = rbtnAnswer2.Text;
            int i = 0;
            if (chkAnswer1.Checked)
                impressArray[i++] = chkAnswer1.Text;
            if (chkAnswer2.Checked)
                impressArray[i++] = chkAnswer2.Text;
            if (chkAnswer3.Checked)
                impressArray[i++] = chkAnswer3.Text;
            if (chkAnswer4.Checked)
                impressArray[i++] = chkAnswer4.Text;
            impresses = string.Join("、", impressArray);

            for (i = 0; i < lstAnswer.SelectedItems.Count;i++ )
            {
                serviceArray[i] += lstAnswer.SelectedItems[i].ToString();
            }
            services = string.Join("、", serviceArray);
            satisfy = cboAnwer.Text;
            if (txtName.Text == "")
            {
                MessageBox.Show("请输入姓名");
            }
            else
            {
                MessageBox.Show("客户姓名：" + txtName.Text.Trim() + "\n性别："+gender + "\n印象是：" + impresses + "\n需要提供的服务是：" + services + "\n客户最满意：" + satisfy, "问卷调查结果");
            }

        }
    }
}
