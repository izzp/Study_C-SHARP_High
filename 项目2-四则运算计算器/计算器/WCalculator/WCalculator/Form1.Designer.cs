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
            this.btnEqu = new System.Windows.Forms.Button();
            this.btnDian = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btn百分号 = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btnAC = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnReciprocal = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEqu
            // 
            this.btnEqu.Location = new System.Drawing.Point(221, 185);
            this.btnEqu.Margin = new System.Windows.Forms.Padding(2);
            this.btnEqu.Name = "btnEqu";
            this.btnEqu.Size = new System.Drawing.Size(46, 57);
            this.btnEqu.TabIndex = 40;
            this.btnEqu.Text = "=";
            this.btnEqu.UseVisualStyleBackColor = true;
            this.btnEqu.Click += new System.EventHandler(this.operator1);
            // 
            // btnDian
            // 
            this.btnDian.Location = new System.Drawing.Point(121, 216);
            this.btnDian.Margin = new System.Windows.Forms.Padding(2);
            this.btnDian.Name = "btnDian";
            this.btnDian.Size = new System.Drawing.Size(46, 26);
            this.btnDian.TabIndex = 56;
            this.btnDian.Text = ".";
            this.btnDian.UseVisualStyleBackColor = true;
            this.btnDian.Click += new System.EventHandler(this.operator2);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(21, 216);
            this.btn0.Margin = new System.Windows.Forms.Padding(2);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(95, 26);
            this.btn0.TabIndex = 55;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.number);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(171, 216);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(46, 26);
            this.btnPlus.TabIndex = 54;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.operator1);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(121, 185);
            this.btn3.Margin = new System.Windows.Forms.Padding(2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(46, 26);
            this.btn3.TabIndex = 53;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.AutoSizeChanged += new System.EventHandler(this.number);
            this.btn3.Click += new System.EventHandler(this.number);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(71, 185);
            this.btn2.Margin = new System.Windows.Forms.Padding(2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(46, 26);
            this.btn2.TabIndex = 52;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.AutoSizeChanged += new System.EventHandler(this.number);
            this.btn2.Click += new System.EventHandler(this.number);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(20, 185);
            this.btn1.Margin = new System.Windows.Forms.Padding(2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(46, 26);
            this.btn1.TabIndex = 51;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.AutoSizeChanged += new System.EventHandler(this.number);
            this.btn1.Click += new System.EventHandler(this.number);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(171, 185);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(46, 26);
            this.btnMinus.TabIndex = 50;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.operator1);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(121, 154);
            this.btn6.Margin = new System.Windows.Forms.Padding(2);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(46, 26);
            this.btn6.TabIndex = 57;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.number);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(71, 154);
            this.btn5.Margin = new System.Windows.Forms.Padding(2);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(46, 26);
            this.btn5.TabIndex = 49;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.number);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(20, 154);
            this.btn4.Margin = new System.Windows.Forms.Padding(2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(46, 26);
            this.btn4.TabIndex = 47;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.number);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(171, 154);
            this.btnMul.Margin = new System.Windows.Forms.Padding(2);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(46, 26);
            this.btnMul.TabIndex = 46;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.operator1);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(121, 123);
            this.btn9.Margin = new System.Windows.Forms.Padding(2);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(46, 26);
            this.btn9.TabIndex = 45;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.number);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(71, 123);
            this.btn8.Margin = new System.Windows.Forms.Padding(2);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(46, 26);
            this.btn8.TabIndex = 44;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.number);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(20, 123);
            this.btn7.Margin = new System.Windows.Forms.Padding(2);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(46, 26);
            this.btn7.TabIndex = 43;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.number);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(171, 123);
            this.btnDiv.Margin = new System.Windows.Forms.Padding(2);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(46, 26);
            this.btnDiv.TabIndex = 42;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.operator1);
            // 
            // btn百分号
            // 
            this.btn百分号.Location = new System.Drawing.Point(220, 123);
            this.btn百分号.Margin = new System.Windows.Forms.Padding(2);
            this.btn百分号.Name = "btn百分号";
            this.btn百分号.Size = new System.Drawing.Size(46, 26);
            this.btn百分号.TabIndex = 41;
            this.btn百分号.Text = "%";
            this.btn百分号.UseVisualStyleBackColor = true;
            this.btn百分号.Click += new System.EventHandler(this.operator2);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(171, 91);
            this.btn.Margin = new System.Windows.Forms.Padding(2);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(46, 26);
            this.btn.TabIndex = 48;
            this.btn.Text = "±";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.operator2);
            // 
            // btnAC
            // 
            this.btnAC.Location = new System.Drawing.Point(20, 91);
            this.btnAC.Margin = new System.Windows.Forms.Padding(2);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(46, 26);
            this.btnAC.TabIndex = 58;
            this.btnAC.Text = "<---";
            this.btnAC.UseVisualStyleBackColor = true;
            this.btnAC.Click += new System.EventHandler(this.operator2);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(21, 21);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(2);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(245, 51);
            this.txtOutput.TabIndex = 59;
            // 
            // btnReciprocal
            // 
            this.btnReciprocal.Location = new System.Drawing.Point(220, 154);
            this.btnReciprocal.Margin = new System.Windows.Forms.Padding(2);
            this.btnReciprocal.Name = "btnReciprocal";
            this.btnReciprocal.Size = new System.Drawing.Size(46, 26);
            this.btnReciprocal.TabIndex = 40;
            this.btnReciprocal.Text = "1/x";
            this.btnReciprocal.UseVisualStyleBackColor = true;
            this.btnReciprocal.Click += new System.EventHandler(this.operator2);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Location = new System.Drawing.Point(220, 91);
            this.btnSqrt.Margin = new System.Windows.Forms.Padding(2);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(46, 26);
            this.btnSqrt.TabIndex = 40;
            this.btnSqrt.Text = "√";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.operator2);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(121, 91);
            this.btnC.Margin = new System.Windows.Forms.Padding(2);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(46, 26);
            this.btnC.TabIndex = 40;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.operator2);
            // 
            // btnCE
            // 
            this.btnCE.Location = new System.Drawing.Point(71, 91);
            this.btnCE.Margin = new System.Windows.Forms.Padding(2);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(46, 26);
            this.btnCE.TabIndex = 40;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.operator2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 262);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnReciprocal);
            this.Controls.Add(this.btnEqu);
            this.Controls.Add(this.btnDian);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btn百分号);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnAC);
            this.Name = "Form1";
            this.Text = "这是个计算器";
            this.Click += new System.EventHandler(this.operator2);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEqu;
        private System.Windows.Forms.Button btnDian;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btn百分号;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnAC;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnReciprocal;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
    }
}

