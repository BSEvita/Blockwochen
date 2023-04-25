namespace Taschenrechner
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonPower = new System.Windows.Forms.Button();
            this.buttonRoot = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonFactorial = new System.Windows.Forms.Button();
            this.buttonSin = new System.Windows.Forms.Button();
            this.buttonCos = new System.Windows.Forms.Button();
            this.buttonTan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // textBoxInput
            //
            this.textBoxInput.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxInput.ReadOnly = true;
            this.textBoxInput.Location = new System.Drawing.Point(12, 12);
            this.textBoxInput.Size = new System.Drawing.Size(344, 23);
            //
            // button0
            //
            this.button0.Text = "0";
            this.button0.Location = new System.Drawing.Point(82, 294);
            this.button0.Size = new System.Drawing.Size(65, 50);
            this.button0.TabIndex = 10;
            this.button0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button0.Click += new System.EventHandler(this.buttonNumber_Click);
            //
            // button1
            //
            this.button1.Text = "1";
            this.button1.Location = new System.Drawing.Point(12, 238);
            this.button1.Size = new System.Drawing.Size(65, 50);
            this.button1.TabIndex = 1;
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button1.Click += new System.EventHandler(this.buttonNumber_Click);
            //
            // button2
            //
            this.button2.Text = "2";
            this.button2.Location = new System.Drawing.Point(82, 238);
            this.button2.Size = new System.Drawing.Size(65, 50);
            this.button2.TabIndex = 2;
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button2.Click += new System.EventHandler(this.buttonNumber_Click);
            //
            // button3
            //
            this.button3.Text = "3";
            this.button3.Location = new System.Drawing.Point(152, 238);
            this.button3.Size = new System.Drawing.Size(65, 50);
            this.button3.TabIndex = 3;
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button3.Click += new System.EventHandler(this.buttonNumber_Click);
            //
            // button4
            //
            this.button4.Text = "4";
            this.button4.Location = new System.Drawing.Point(12, 182);
            this.button4.Size = new System.Drawing.Size(65, 50);
            this.button4.TabIndex = 4;
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button4.Click += new System.EventHandler(this.buttonNumber_Click);
            //
            // button5
            //
            this.button5.Text = "5";
            this.button5.Location = new System.Drawing.Point(82, 182);
            this.button5.Size = new System.Drawing.Size(65, 50);
            this.button5.TabIndex = 5;
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button5.Click += new System.EventHandler(this.buttonNumber_Click);
            //
            // button6
            //
            this.button6.Text = "6";
            this.button6.Location = new System.Drawing.Point(152, 182);
            this.button6.Size = new System.Drawing.Size(65, 50);
            this.button6.TabIndex = 6;
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button6.Click += new System.EventHandler(this.buttonNumber_Click);
            //
            // button7
            //
            this.button7.Text = "7";
            this.button7.Location = new System.Drawing.Point(12, 126);
            this.button7.Size = new System.Drawing.Size(65, 50);
            this.button7.TabIndex = 7;
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button7.Click += new System.EventHandler(this.buttonNumber_Click);
            //
            // button8
            //
            this.button8.Text = "8";
            this.button8.Location = new System.Drawing.Point(82, 126);
            this.button8.Size = new System.Drawing.Size(65, 50);
            this.button8.TabIndex = 8;
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button8.Click += new System.EventHandler(this.buttonNumber_Click);
            //
            // button9
            //
            this.button9.Text = "9";
            this.button9.Location = new System.Drawing.Point(152, 126);
            this.button9.Size = new System.Drawing.Size(65, 50);
            this.button9.TabIndex = 9;
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button9.Click += new System.EventHandler(this.buttonNumber_Click);
            //
            // buttonAdd
            //
            this.buttonAdd.Text = "+";
            this.buttonAdd.Location = new System.Drawing.Point(222, 238);
            this.buttonAdd.Size = new System.Drawing.Size(65, 50);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonAdd.Click += new System.EventHandler(this.buttonOperation_Click);
            //
            // buttonSubtract
            //
            this.buttonSubtract.Text = "-";
            this.buttonSubtract.Location = new System.Drawing.Point(222, 182);
            this.buttonSubtract.Size = new System.Drawing.Size(65, 50);
            this.buttonSubtract.TabIndex = 12;
            this.buttonSubtract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonSubtract.Click += new System.EventHandler(this.buttonOperation_Click);
            //
            // buttonMultiply
            //
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.Location = new System.Drawing.Point(222, 126);
            this.buttonMultiply.Size = new System.Drawing.Size(65, 50);
            this.buttonMultiply.TabIndex = 13;
            this.buttonMultiply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonMultiply.Click += new System.EventHandler(this.buttonOperation_Click);
            //
            // buttonDivide
            //
            this.buttonDivide.Text = "/";
            this.buttonDivide.Location = new System.Drawing.Point(222, 70);
            this.buttonDivide.Size = new System.Drawing.Size(65, 50);
            this.buttonDivide.TabIndex = 14;
            this.buttonDivide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonDivide.Click += new System.EventHandler(this.buttonOperation_Click);
            //
            // buttonEquals
            //
            this.buttonEquals.Text = "=";
            this.buttonEquals.Location = new System.Drawing.Point(222, 294);
            this.buttonEquals.Size = new System.Drawing.Size(65, 50);
            this.buttonEquals.TabIndex = 15;
            this.buttonEquals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            //
            // buttonClear
            //
            this.buttonClear.Text = "C";
            this.buttonClear.Location = new System.Drawing.Point(12, 70);
            this.buttonClear.Size = new System.Drawing.Size(65, 50);
            this.buttonClear.TabIndex = 17;
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            //
            // buttonPower
            //
            this.buttonPower.Text = "x²";
            this.buttonPower.Location = new System.Drawing.Point(152, 70);
            this.buttonPower.Size = new System.Drawing.Size(65, 50);
            this.buttonPower.TabIndex = 18;
            this.buttonPower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonPower.Click += new System.EventHandler(this.buttonOperation_Click);
            //
            // buttonRoot
            //
            this.buttonRoot.Text = "√";
            this.buttonRoot.Location = new System.Drawing.Point(12, 294);
            this.buttonRoot.Size = new System.Drawing.Size(65, 50);
            this.buttonRoot.TabIndex = 19;
            this.buttonRoot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonRoot.Click += new System.EventHandler(this.buttonOperation_Click);
            //
            // buttonLog
            //
            this.buttonLog.Text = "log";
            this.buttonLog.Location = new System.Drawing.Point(152, 294);
            this.buttonLog.Size = new System.Drawing.Size(65, 50);
            this.buttonLog.TabIndex = 21;
            this.buttonLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonLog.Click += new System.EventHandler(this.buttonOperation_Click);
            //
            // buttonFactorial
            //
            this.buttonFactorial.Text = "!";
            this.buttonFactorial.Location = new System.Drawing.Point(82, 70);
            this.buttonFactorial.Size = new System.Drawing.Size(65, 50);
            this.buttonFactorial.TabIndex = 22;
            this.buttonFactorial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonFactorial.Click += new System.EventHandler(this.buttonOperation_Click);
            //
            // buttonSin
            //
            this.buttonSin.Text = "sin";
            this.buttonSin.Location = new System.Drawing.Point(292, 70);
            this.buttonSin.Size = new System.Drawing.Size(65, 50);
            this.buttonSin.TabIndex = 23;
            this.buttonSin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonSin.Click += new System.EventHandler(this.buttonOperation_Click);
            //
            // buttonCos
            //
            this.buttonCos.Text = "cos";
            this.buttonCos.Location = new System.Drawing.Point(292, 126);
            this.buttonCos.Size = new System.Drawing.Size(65, 50);
            this.buttonCos.TabIndex = 24;
            this.buttonCos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonCos.Click += new System.EventHandler(this.buttonOperation_Click);
            //
            // buttonTan
            //
            this.buttonTan.Text = "tan";
            this.buttonTan.Location = new System.Drawing.Point(292, 182);
            this.buttonTan.Size = new System.Drawing.Size(65, 50);
            this.buttonTan.TabIndex = 25;
            this.buttonTan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonTan.Click += new System.EventHandler(this.buttonOperation_Click);
            //
            // form
            //
            this.Size = new System.Drawing.Size(400, 411);
            this.Text = "Calculator";
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonPower);
            this.Controls.Add(this.buttonRoot);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.buttonFactorial);
            this.Controls.Add(this.buttonSin);
            this.Controls.Add(this.buttonCos);
            this.Controls.Add(this.buttonTan);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonPower;
        private System.Windows.Forms.Button buttonRoot;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Button buttonFactorial;
        private System.Windows.Forms.Button buttonSin;
        private System.Windows.Forms.Button buttonCos;
        private System.Windows.Forms.Button buttonTan;
    }
}