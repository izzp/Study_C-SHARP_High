namespace WCalculator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnMC = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMAdd = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.btnMSub = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnInverse = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("宋体", 25F);
            this.txtOutput.Location = new System.Drawing.Point(13, 29);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(222, 50);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.Text = "0";
            this.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // btnMC
            // 
            this.btnMC.Location = new System.Drawing.Point(13, 85);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(38, 28);
            this.btnMC.TabIndex = 1;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = true;
            this.btnMC.Click += new System.EventHandler(this.btnMC_Click);
            // 
            // btnMR
            // 
            this.btnMR.Location = new System.Drawing.Point(57, 85);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(40, 28);
            this.btnMR.TabIndex = 2;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = true;
            this.btnMR.Click += new System.EventHandler(this.btnMR_Click);
            // 
            // btnMAdd
            // 
            this.btnMAdd.Location = new System.Drawing.Point(149, 85);
            this.btnMAdd.Name = "btnMAdd";
            this.btnMAdd.Size = new System.Drawing.Size(40, 28);
            this.btnMAdd.TabIndex = 4;
            this.btnMAdd.Text = "M+";
            this.btnMAdd.UseVisualStyleBackColor = true;
            this.btnMAdd.Click += new System.EventHandler(this.btnMAdd_Click);
            // 
            // btnMS
            // 
            this.btnMS.Location = new System.Drawing.Point(103, 85);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(40, 28);
            this.btnMS.TabIndex = 3;
            this.btnMS.Text = "MS";
            this.btnMS.UseVisualStyleBackColor = true;
            this.btnMS.Click += new System.EventHandler(this.btnMS_Click);
            // 
            // btnMSub
            // 
            this.btnMSub.Location = new System.Drawing.Point(195, 85);
            this.btnMSub.Name = "btnMSub";
            this.btnMSub.Size = new System.Drawing.Size(40, 28);
            this.btnMSub.TabIndex = 5;
            this.btnMSub.Text = "M-";
            this.btnMSub.UseVisualStyleBackColor = true;
            this.btnMSub.Click += new System.EventHandler(this.btnMSub_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Location = new System.Drawing.Point(195, 117);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(40, 28);
            this.btnSqrt.TabIndex = 10;
            this.btnSqrt.Text = "√";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.operator2);
            // 
            // btnSign
            // 
            this.btnSign.Location = new System.Drawing.Point(149, 117);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(40, 28);
            this.btnSign.TabIndex = 9;
            this.btnSign.Text = "±";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.operator2);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(103, 117);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(40, 28);
            this.btnC.TabIndex = 8;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCE
            // 
            this.btnCE.Location = new System.Drawing.Point(57, 117);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(40, 28);
            this.btnCE.TabIndex = 7;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnBackspace
            // 
            this.btnBackspace.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBackspace.Location = new System.Drawing.Point(13, 117);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(38, 28);
            this.btnBackspace.TabIndex = 6;
            this.btnBackspace.Text = "←";
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnPercent
            // 
            this.btnPercent.Location = new System.Drawing.Point(195, 150);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(40, 28);
            this.btnPercent.TabIndex = 15;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = true;
            this.btnPercent.Click += new System.EventHandler(this.operator2);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(149, 150);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(40, 28);
            this.btnDiv.TabIndex = 14;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.operator1);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(103, 150);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(40, 28);
            this.btn9.TabIndex = 13;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.number);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(57, 150);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(40, 28);
            this.btn8.TabIndex = 12;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.number);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(13, 150);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(38, 28);
            this.btn7.TabIndex = 11;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.number);
            // 
            // btnInverse
            // 
            this.btnInverse.Location = new System.Drawing.Point(195, 183);
            this.btnInverse.Name = "btnInverse";
            this.btnInverse.Size = new System.Drawing.Size(40, 28);
            this.btnInverse.TabIndex = 20;
            this.btnInverse.Text = "1/x";
            this.btnInverse.UseVisualStyleBackColor = true;
            this.btnInverse.Click += new System.EventHandler(this.operator2);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(149, 183);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(40, 28);
            this.btnMul.TabIndex = 19;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.operator1);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(103, 183);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(40, 28);
            this.btn6.TabIndex = 18;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.number);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(57, 183);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(40, 28);
            this.btn5.TabIndex = 17;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.number);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(13, 183);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(38, 28);
            this.btn4.TabIndex = 16;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.number);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(149, 215);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(40, 27);
            this.btnSub.TabIndex = 24;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.operator1);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(103, 215);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(40, 27);
            this.btn3.TabIndex = 23;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.number);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(57, 215);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(40, 27);
            this.btn2.TabIndex = 22;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.number);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(13, 214);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(38, 28);
            this.btn1.TabIndex = 21;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.number);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(149, 244);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 29);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.operator1);
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(103, 244);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(40, 29);
            this.btnDot.TabIndex = 27;
            this.btnDot.Text = "▪";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(13, 245);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(86, 28);
            this.btn0.TabIndex = 25;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.number);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(195, 215);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(40, 58);
            this.btnEqual.TabIndex = 29;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(250, 25);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.查看ToolStripMenuItem.Text = "查看";
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(223, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 31;
            this.label1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 284);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnInverse);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.btnMSub);
            this.Controls.Add(this.btnMAdd);
            this.Controls.Add(this.btnMS);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnMC);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "计算器";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnMAdd;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Button btnMSub;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnInverse;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

