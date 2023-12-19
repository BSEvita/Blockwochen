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
            this.number1 = new System.Windows.Forms.TextBox();
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.inputHexadecimalRadioButton = new System.Windows.Forms.RadioButton();
            this.inputDecimalRadioButton = new System.Windows.Forms.RadioButton();
            this.inputOctalRadioButton = new System.Windows.Forms.RadioButton();
            this.inputBinaryRadioButton = new System.Windows.Forms.RadioButton();
            this.outputGroupBox = new System.Windows.Forms.GroupBox();
            this.outputHexadecimalRadioButton = new System.Windows.Forms.RadioButton();
            this.outputDecimalRadioButton = new System.Windows.Forms.RadioButton();
            this.outputOctalRadioButton = new System.Windows.Forms.RadioButton();
            this.outputBinaryRadioButton = new System.Windows.Forms.RadioButton();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.inputGroupBox.SuspendLayout();
            this.outputGroupBox.SuspendLayout();
            this.SuspendLayout();
            //
            // number1Label
            //
            this.number1Label.AutoSize = true;
            this.number1Label.Text = "Number:";
            this.number1Label.Location = new System.Drawing.Point(12, 11);
            this.number1Label.Size = new System.Drawing.Size(54, 15);
            //
            // number1
            //
            this.number1.Location = new System.Drawing.Point(15, 28);
            this.number1.Size = new System.Drawing.Size(374, 23);
            this.number1.TabIndex = 1;
            this.number1.TextChanged += new System.EventHandler(StuffChanged);
            //
            // inputGroupBox
            //
            this.inputGroupBox.Controls.Add(this.inputHexadecimalRadioButton);
            this.inputGroupBox.Controls.Add(this.inputDecimalRadioButton);
            this.inputGroupBox.Controls.Add(this.inputOctalRadioButton);
            this.inputGroupBox.Controls.Add(this.inputBinaryRadioButton);
            this.inputGroupBox.Text = "Input in:";
            this.inputGroupBox.Location = new System.Drawing.Point(11, 59);
            this.inputGroupBox.Size = new System.Drawing.Size(374, 54);
            this.inputGroupBox.TabIndex = 8;
            //
            // inputHexadecimalRadioButton
            //
            this.inputHexadecimalRadioButton.CheckedChanged += new System.EventHandler(StuffChanged);
            this.inputHexadecimalRadioButton.AutoSize = true;
            this.inputHexadecimalRadioButton.Text = "Hexadecimal";
            this.inputHexadecimalRadioButton.Location = new System.Drawing.Point(285, 22);
            this.inputHexadecimalRadioButton.Size = new System.Drawing.Size(94, 19);
            this.inputHexadecimalRadioButton.TabIndex = 3;
            //
            // inputDecimalRadioButton
            //
            this.inputDecimalRadioButton.CheckedChanged += new System.EventHandler(StuffChanged);
            this.inputDecimalRadioButton.Checked = true;
            this.inputDecimalRadioButton.TabStop = true;
            this.inputDecimalRadioButton.AutoSize = true;
            this.inputDecimalRadioButton.Text = "Decimal";
            this.inputDecimalRadioButton.Location = new System.Drawing.Point(211, 22);
            this.inputDecimalRadioButton.Size = new System.Drawing.Size(68, 19);
            this.inputDecimalRadioButton.TabIndex = 2;
            //
            // inputOctalRadioButton
            //
            this.inputOctalRadioButton.CheckedChanged += new System.EventHandler(StuffChanged);
            this.inputOctalRadioButton.TabStop = true;
            this.inputOctalRadioButton.AutoSize = true;
            this.inputOctalRadioButton.Text = "Octal";
            this.inputOctalRadioButton.Location = new System.Drawing.Point(144, 22);
            this.inputOctalRadioButton.Size = new System.Drawing.Size(53, 19);
            this.inputOctalRadioButton.TabIndex = 1;
            //
            // inputBinaryRadioButton
            //
            this.inputBinaryRadioButton.CheckedChanged += new System.EventHandler(StuffChanged);
            this.inputBinaryRadioButton.TabStop = true;
            this.inputBinaryRadioButton.AutoSize = true;
            this.inputBinaryRadioButton.Text = "Binary";
            this.inputBinaryRadioButton.Location = new System.Drawing.Point(74, 22);
            this.inputBinaryRadioButton.Size = new System.Drawing.Size(58, 19);
            this.inputBinaryRadioButton.TabIndex = 6;
            //
            // outputGroupBox
            //
            this.outputGroupBox.Controls.Add(this.outputHexadecimalRadioButton);
            this.outputGroupBox.Controls.Add(this.outputDecimalRadioButton);
            this.outputGroupBox.Controls.Add(this.outputOctalRadioButton);
            this.outputGroupBox.Controls.Add(this.outputBinaryRadioButton);
            this.outputGroupBox.Text = "Output in:";
            this.outputGroupBox.Location = new System.Drawing.Point(11, 121);
            this.outputGroupBox.Size = new System.Drawing.Size(374, 54);
            this.outputGroupBox.TabIndex = 5;
            //
            // outputHexadecimalRadioButton
            //
            this.outputHexadecimalRadioButton.CheckedChanged += new System.EventHandler(StuffChanged);
            this.outputHexadecimalRadioButton.AutoSize = true;
            this.outputHexadecimalRadioButton.Text = "Hexadecimal";
            this.outputHexadecimalRadioButton.Location = new System.Drawing.Point(285, 22);
            this.outputHexadecimalRadioButton.Size = new System.Drawing.Size(94, 19);
            this.outputHexadecimalRadioButton.TabIndex = 3;
            //
            // outputDecimalRadioButton
            //
            this.outputDecimalRadioButton.CheckedChanged += new System.EventHandler(StuffChanged);
            this.outputDecimalRadioButton.Checked = true;
            this.outputDecimalRadioButton.TabStop = true;
            this.outputDecimalRadioButton.AutoSize = true;
            this.outputDecimalRadioButton.Text = "Decimal";
            this.outputDecimalRadioButton.Location = new System.Drawing.Point(211, 22);
            this.outputDecimalRadioButton.Size = new System.Drawing.Size(68, 19);
            this.outputDecimalRadioButton.TabIndex = 2;
            //
            // outputOctalRadioButton
            //
            this.outputOctalRadioButton.CheckedChanged += new System.EventHandler(StuffChanged);
            this.outputOctalRadioButton.TabStop = true;
            this.outputOctalRadioButton.AutoSize = true;
            this.outputOctalRadioButton.Text = "Octal";
            this.outputOctalRadioButton.Location = new System.Drawing.Point(144, 22);
            this.outputOctalRadioButton.Size = new System.Drawing.Size(53, 19);
            this.outputOctalRadioButton.TabIndex = 1;
            //
            // outputBinaryRadioButton
            //
            this.outputBinaryRadioButton.CheckedChanged += new System.EventHandler(StuffChanged);
            this.outputBinaryRadioButton.TabStop = true;
            this.outputBinaryRadioButton.AutoSize = true;
            this.outputBinaryRadioButton.Text = "Binary";
            this.outputBinaryRadioButton.Location = new System.Drawing.Point(74, 22);
            this.outputBinaryRadioButton.Size = new System.Drawing.Size(58, 19);
            this.outputBinaryRadioButton.TabIndex = 11;
            //
            // resultLabel
            //
            this.resultLabel.AutoSize = true;
            this.resultLabel.Text = "Result:";
            this.resultLabel.Location = new System.Drawing.Point(12, 182);
            this.resultLabel.Size = new System.Drawing.Size(42, 15);
            this.resultLabel.TabIndex = 6;
            //
            // resultTextBox
            //
            this.resultTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Location = new System.Drawing.Point(15, 200);
            this.resultTextBox.Size = new System.Drawing.Size(374, 23);
            this.resultTextBox.TabIndex = 7;
            //
            // form
            //
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Size = new System.Drawing.Size(420, 280);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zahlen System Umrechner";
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.number1Label);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.inputGroupBox);
            this.Controls.Add(this.outputGroupBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.resultTextBox);
            this.inputGroupBox.ResumeLayout(false);
            this.outputGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label number1Label;
        private System.Windows.Forms.TextBox number1;
        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.RadioButton inputHexadecimalRadioButton;
        private System.Windows.Forms.RadioButton inputDecimalRadioButton;
        private System.Windows.Forms.RadioButton inputOctalRadioButton;
        private System.Windows.Forms.RadioButton inputBinaryRadioButton;
        private System.Windows.Forms.GroupBox outputGroupBox;
        private System.Windows.Forms.RadioButton outputHexadecimalRadioButton;
        private System.Windows.Forms.RadioButton outputDecimalRadioButton;
        private System.Windows.Forms.RadioButton outputOctalRadioButton;
        private System.Windows.Forms.RadioButton outputBinaryRadioButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}