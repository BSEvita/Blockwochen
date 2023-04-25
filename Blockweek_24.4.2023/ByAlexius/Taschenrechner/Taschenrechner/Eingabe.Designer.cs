namespace Taschenrechner
{
    partial class Eingabe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLabel = new Label();
            btnRechnen = new Button();
            firstNumberInput = new TextBox();
            secondNumberInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.Location = new Point(35, 28);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(195, 46);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Placeholder";
            titleLabel.Click += titleLabel_Click;
            // 
            // btnRechnen
            // 
            btnRechnen.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnRechnen.Location = new Point(81, 341);
            btnRechnen.Name = "btnRechnen";
            btnRechnen.Size = new Size(220, 73);
            btnRechnen.TabIndex = 1;
            btnRechnen.Text = "Rechnen";
            btnRechnen.UseVisualStyleBackColor = true;
            btnRechnen.Click += btnRechnen_Click;
            // 
            // firstNumberInput
            // 
            firstNumberInput.Location = new Point(41, 146);
            firstNumberInput.Name = "firstNumberInput";
            firstNumberInput.Size = new Size(305, 23);
            firstNumberInput.TabIndex = 2;
            firstNumberInput.TextChanged += firstNumberInput_TextChanged;
            // 
            // secondNumberInput
            // 
            secondNumberInput.Location = new Point(41, 244);
            secondNumberInput.Name = "secondNumberInput";
            secondNumberInput.Size = new Size(305, 23);
            secondNumberInput.TabIndex = 3;
            secondNumberInput.TextChanged += secondNumberInput_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(153, 115);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 4;
            label1.Text = "Erste Zahl";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(153, 213);
            label2.Name = "label2";
            label2.Size = new Size(111, 28);
            label2.TabIndex = 5;
            label2.Text = "Zweite Zahl";
            // 
            // Eingabe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 426);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(secondNumberInput);
            Controls.Add(firstNumberInput);
            Controls.Add(btnRechnen);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Eingabe";
            ShowInTaskbar = false;
            Text = "Eingabe";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Button btnRechnen;
        private TextBox firstNumberInput;
        private TextBox secondNumberInput;
        private Label label1;
        private Label label2;
    }
}