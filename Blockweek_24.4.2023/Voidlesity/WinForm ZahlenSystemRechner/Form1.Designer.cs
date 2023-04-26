namespace ZahlenSystemRechner
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

        #region
        private void InitializeComponent()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.number1Label = new System.Windows.Forms.Label();
            this.number2Label = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.number1 = new System.Windows.Forms.TextBox();
            this.number2 = new System.Windows.Forms.TextBox();
            this.binaryRadioButton = new System.Windows.Forms.RadioButton();
            this.octalRadioButton = new System.Windows.Forms.RadioButton();
            this.decimalRadioButton = new System.Windows.Forms.RadioButton();
            this.hexadecimalRadioButton = new System.Windows.Forms.RadioButton();
            this.inputNumberSystemLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // number1Label
            //
            this.number1Label.AutoSize = true;
            this.number1Label.Text = "Number 1";
            this.number1Label.Location = new System.Drawing.Point(12, 19);
            this.number1Label.Size = new System.Drawing.Size(60, 15);
            //
            // number2Label
            //
            this.number2Label.AutoSize = true;
            this.number2Label.Text = "Number 2";
            this.number2Label.Location = new System.Drawing.Point(12, 51);
            this.number2Label.Size = new System.Drawing.Size(60, 15);
            this.number2Label.TabIndex = 1;
            //
            // resultLabel
            //
            this.resultLabel.AutoSize = true;
            this.resultLabel.Text = "Result:";
            this.resultLabel.Location = new System.Drawing.Point(12, 119);
            this.resultLabel.Size = new System.Drawing.Size(42, 15);
            this.resultLabel.TabIndex = 2;
            //
            // number1
            //
            this.number1.Location = new System.Drawing.Point(80, 16);
            this.number1.TabIndex = 6;
            //
            // number2
            //
            this.number2.Location = new System.Drawing.Point(80, 48);
            this.number2.TabIndex = 7;
            //
            // binaryRadioButton
            //
            this.binaryRadioButton.AutoSize = true;
            this.binaryRadioButton.Text = "Binary";
            this.binaryRadioButton.Location = new System.Drawing.Point(74, 85);
            this.binaryRadioButton.Size = new System.Drawing.Size(58, 19);
            this.binaryRadioButton.TabIndex = 12;
            //
            // octalRadioButton
            //
            this.octalRadioButton.AutoSize = true;
            this.octalRadioButton.Text = "Octal";
            this.octalRadioButton.Location = new System.Drawing.Point(144, 85);
            this.octalRadioButton.Size = new System.Drawing.Size(53, 19);
            this.octalRadioButton.TabIndex = 13;
            //
            // decimalRadioButton
            //
            this.decimalRadioButton.AutoSize = true;
            this.decimalRadioButton.Text = "Decimal";
            this.decimalRadioButton.Location = new System.Drawing.Point(211, 85);
            this.decimalRadioButton.Size = new System.Drawing.Size(68, 19);
            this.decimalRadioButton.TabIndex = 14;
            //
            // hexadecimalRadioButton
            //
            this.hexadecimalRadioButton.Checked = true;
            this.hexadecimalRadioButton.TabStop = true;
            this.hexadecimalRadioButton.AutoSize = true;
            this.hexadecimalRadioButton.Text = "Hexadecimal";
            this.hexadecimalRadioButton.Location = new System.Drawing.Point(295, 85);
            this.hexadecimalRadioButton.Size = new System.Drawing.Size(94, 19);
            this.hexadecimalRadioButton.TabIndex = 15;
            //
            // inputNumberSystemLabel
            //
            this.inputNumberSystemLabel.AutoSize = true;
            this.inputNumberSystemLabel.Text = "Input in:";
            this.inputNumberSystemLabel.Location = new System.Drawing.Point(12, 87);
            this.inputNumberSystemLabel.Size = new System.Drawing.Size(51, 15);
            this.inputNumberSystemLabel.TabIndex = 16;
            //
            // addButton
            //
            this.addButton.Text = "Add";
            this.addButton.Location = new System.Drawing.Point(307, 13);
            this.addButton.Size = new System.Drawing.Size(100, 30);
            this.addButton.TabIndex = 18;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            //
            // subtractButton
            //
            this.subtractButton.Text = "Subtract";
            this.subtractButton.Location = new System.Drawing.Point(203, 13);
            this.subtractButton.Size = new System.Drawing.Size(100, 30);
            this.subtractButton.TabIndex = 19;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            //
            // multiplyButton
            //
            this.multiplyButton.Text = "Multiply";
            this.multiplyButton.Location = new System.Drawing.Point(203, 45);
            this.multiplyButton.Size = new System.Drawing.Size(100, 30);
            this.multiplyButton.TabIndex = 20;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            //
            // divideButton
            //
            this.divideButton.Text = "Divide";
            this.divideButton.Location = new System.Drawing.Point(307, 45);
            this.divideButton.Size = new System.Drawing.Size(100, 30);
            this.divideButton.TabIndex = 21;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            //
            // resultTextBox
            //
            this.resultTextBox.Location = new System.Drawing.Point(64, 116);
            this.resultTextBox.Size = new System.Drawing.Size(340, 23);
            this.resultTextBox.TabIndex = 22;
            this.resultTextBox.ReadOnly = true;
            //
            // form
            //
            this.Size = new System.Drawing.Size(435, 188);
            this.Text = "Zahlen System Rechner";
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.number1Label);
            this.Controls.Add(this.number2Label);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.binaryRadioButton);
            this.Controls.Add(this.octalRadioButton);
            this.Controls.Add(this.decimalRadioButton);
            this.Controls.Add(this.hexadecimalRadioButton);
            this.Controls.Add(this.inputNumberSystemLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.resultTextBox);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label number1Label;
        private System.Windows.Forms.Label number2Label;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox number1;
        private System.Windows.Forms.TextBox number2;
        private System.Windows.Forms.RadioButton binaryRadioButton;
        private System.Windows.Forms.RadioButton octalRadioButton;
        private System.Windows.Forms.RadioButton decimalRadioButton;
        private System.Windows.Forms.RadioButton hexadecimalRadioButton;
        private System.Windows.Forms.Label inputNumberSystemLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}