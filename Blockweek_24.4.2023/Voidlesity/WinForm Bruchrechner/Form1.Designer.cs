namespace BruchRechner
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.num1Box = new System.Windows.Forms.TextBox();
            this.den1Box = new System.Windows.Forms.TextBox();
            this.num2Box = new System.Windows.Forms.TextBox();
            this.den2Box = new System.Windows.Forms.TextBox();
            this.operationBox = new System.Windows.Forms.ComboBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // num1Box
            // 
            this.num1Box.Location = new System.Drawing.Point(51, 32);
            this.num1Box.Name = "num1Box";
            this.num1Box.Size = new System.Drawing.Size(100, 20);
            this.num1Box.TabIndex = 0;
            // 
            // den1Box
            // 
            this.den1Box.Location = new System.Drawing.Point(51, 58);
            this.den1Box.Name = "den1Box";
            this.den1Box.Size = new System.Drawing.Size(100, 20);
            this.den1Box.TabIndex = 1;
            // 
            // num2Box
            // 
            this.num2Box.Location = new System.Drawing.Point(51, 97);
            this.num2Box.Name = "num2Box";
            this.num2Box.Size = new System.Drawing.Size(100, 20);
            this.num2Box.TabIndex = 2;
            // 
            // den2Box
            // 
            this.den2Box.Location = new System.Drawing.Point(51, 123);
            this.den2Box.Name = "den2Box";
            this.den2Box.Size = new System.Drawing.Size(100, 20);
            this.den2Box.TabIndex = 3;
            // 
            // operationBox
            // 
            this.operationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operationBox.FormattingEnabled = true;
            this.operationBox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "x²",
            "sqrt"});
            this.operationBox.Location = new System.Drawing.Point(51, 170);
            this.operationBox.Name = "operationBox";
            this.operationBox.Size = new System.Drawing.Size(100, 21);
            this.operationBox.TabIndex = 4;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(51, 208);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 23);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            //
            // resultBox
            //
            this.resultBox.Location = new System.Drawing.Point(51, 254);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(100, 20);
            this.resultBox.TabIndex = 6;
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Num:";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Den1:";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Num:";
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Den2:";
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Op:";
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 306);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.operationBox);
            this.Controls.Add(this.den2Box);
            this.Controls.Add(this.num2Box);
            this.Controls.Add(this.den1Box);
            this.Controls.Add(this.num1Box);
            this.Name = "Form1";
            this.Text = "BruchRechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num1Box;
        private System.Windows.Forms.TextBox den1Box;
        private System.Windows.Forms.TextBox num2Box;
        private System.Windows.Forms.TextBox den2Box;
        private System.Windows.Forms.ComboBox operationBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}