namespace WinForm_Zahlensystem_um_rechner
{
    partial class Zahlensystemumrechner
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Box_Zahl1 = new RichTextBox();
            Box_Zahl2 = new RichTextBox();
            label_Zahl1 = new Label();
            label_Zahl2 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            RB_Binär1 = new RadioButton();
            RB_Oktal1 = new RadioButton();
            RB_Dezimal1 = new RadioButton();
            RB_Hexadez1 = new RadioButton();
            RB_Hexadez2 = new RadioButton();
            RB_Dezimal2 = new RadioButton();
            RB_Oktal2 = new RadioButton();
            RB_Binär2 = new RadioButton();
            label_Zahlensys_Ergebnis = new Label();
            label_Ergebnis = new Label();
            Box_Ergebnis = new RichTextBox();
            label_Rechenoperation = new Label();
            RB_E_Hexadez = new RadioButton();
            RB_E_Dezimal = new RadioButton();
            RB_E_Oktal = new RadioButton();
            RB_E_Binär = new RadioButton();
            RB_Div = new RadioButton();
            RB_Mult = new RadioButton();
            RB_Sub = new RadioButton();
            RB_Add = new RadioButton();
            B_Berechnen = new Button();
            panel_RB1 = new Panel();
            panel_RB2 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel_RB1.SuspendLayout();
            panel_RB2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Box_Zahl1
            // 
            Box_Zahl1.Location = new Point(27, 55);
            Box_Zahl1.Name = "Box_Zahl1";
            Box_Zahl1.Size = new Size(248, 26);
            Box_Zahl1.TabIndex = 0;
            Box_Zahl1.Text = "";
            // 
            // Box_Zahl2
            // 
            Box_Zahl2.Location = new Point(362, 55);
            Box_Zahl2.Name = "Box_Zahl2";
            Box_Zahl2.Size = new Size(248, 26);
            Box_Zahl2.TabIndex = 5;
            Box_Zahl2.Text = "";
            // 
            // label_Zahl1
            // 
            label_Zahl1.AutoSize = true;
            label_Zahl1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_Zahl1.Location = new Point(123, 27);
            label_Zahl1.Name = "label_Zahl1";
            label_Zahl1.Size = new Size(64, 25);
            label_Zahl1.TabIndex = 2;
            label_Zahl1.Text = "Zahl 1";
            // 
            // label_Zahl2
            // 
            label_Zahl2.AutoSize = true;
            label_Zahl2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_Zahl2.Location = new Point(453, 27);
            label_Zahl2.Name = "label_Zahl2";
            label_Zahl2.Size = new Size(64, 25);
            label_Zahl2.TabIndex = 3;
            label_Zahl2.Text = "Zahl 2";
            // 
            // RB_Binär1
            // 
            RB_Binär1.AutoSize = true;
            RB_Binär1.Location = new Point(3, 5);
            RB_Binär1.Name = "RB_Binär1";
            RB_Binär1.Size = new Size(52, 19);
            RB_Binär1.TabIndex = 1;
            RB_Binär1.TabStop = true;
            RB_Binär1.Text = "Binär";
            RB_Binär1.UseVisualStyleBackColor = true;
            RB_Binär1.Click += Zahlensystem1_Click;
            // 
            // RB_Oktal1
            // 
            RB_Oktal1.AutoSize = true;
            RB_Oktal1.Location = new Point(61, 5);
            RB_Oktal1.Name = "RB_Oktal1";
            RB_Oktal1.Size = new Size(53, 19);
            RB_Oktal1.TabIndex = 2;
            RB_Oktal1.TabStop = true;
            RB_Oktal1.Text = "Oktal";
            RB_Oktal1.UseVisualStyleBackColor = true;
            RB_Oktal1.Click += Zahlensystem1_Click;
            // 
            // RB_Dezimal1
            // 
            RB_Dezimal1.AutoSize = true;
            RB_Dezimal1.Location = new Point(120, 5);
            RB_Dezimal1.Name = "RB_Dezimal1";
            RB_Dezimal1.Size = new Size(67, 19);
            RB_Dezimal1.TabIndex = 3;
            RB_Dezimal1.TabStop = true;
            RB_Dezimal1.Text = "Dezimal";
            RB_Dezimal1.UseVisualStyleBackColor = true;
            RB_Dezimal1.Click += Zahlensystem1_Click;
            // 
            // RB_Hexadez1
            // 
            RB_Hexadez1.AutoSize = true;
            RB_Hexadez1.Location = new Point(193, 5);
            RB_Hexadez1.Name = "RB_Hexadez1";
            RB_Hexadez1.Size = new Size(70, 19);
            RB_Hexadez1.TabIndex = 4;
            RB_Hexadez1.TabStop = true;
            RB_Hexadez1.Text = "Hexadez";
            RB_Hexadez1.UseVisualStyleBackColor = true;
            RB_Hexadez1.Click += Zahlensystem1_Click;
            // 
            // RB_Hexadez2
            // 
            RB_Hexadez2.AutoSize = true;
            RB_Hexadez2.Location = new Point(198, 5);
            RB_Hexadez2.Name = "RB_Hexadez2";
            RB_Hexadez2.Size = new Size(70, 19);
            RB_Hexadez2.TabIndex = 9;
            RB_Hexadez2.TabStop = true;
            RB_Hexadez2.Text = "Hexadez";
            RB_Hexadez2.UseVisualStyleBackColor = true;
            RB_Hexadez2.Click += Zahlensystem2_Click;
            // 
            // RB_Dezimal2
            // 
            RB_Dezimal2.AutoSize = true;
            RB_Dezimal2.Location = new Point(121, 5);
            RB_Dezimal2.Name = "RB_Dezimal2";
            RB_Dezimal2.Size = new Size(67, 19);
            RB_Dezimal2.TabIndex = 8;
            RB_Dezimal2.TabStop = true;
            RB_Dezimal2.Text = "Dezimal";
            RB_Dezimal2.UseVisualStyleBackColor = true;
            RB_Dezimal2.Click += Zahlensystem2_Click;
            // 
            // RB_Oktal2
            // 
            RB_Oktal2.AutoSize = true;
            RB_Oktal2.Location = new Point(61, 5);
            RB_Oktal2.Name = "RB_Oktal2";
            RB_Oktal2.Size = new Size(53, 19);
            RB_Oktal2.TabIndex = 7;
            RB_Oktal2.TabStop = true;
            RB_Oktal2.Text = "Oktal";
            RB_Oktal2.UseVisualStyleBackColor = true;
            RB_Oktal2.Click += Zahlensystem2_Click;
            // 
            // RB_Binär2
            // 
            RB_Binär2.AutoSize = true;
            RB_Binär2.Location = new Point(3, 5);
            RB_Binär2.Name = "RB_Binär2";
            RB_Binär2.Size = new Size(52, 19);
            RB_Binär2.TabIndex = 6;
            RB_Binär2.TabStop = true;
            RB_Binär2.Text = "Binär";
            RB_Binär2.UseVisualStyleBackColor = true;
            RB_Binär2.Click += Zahlensystem2_Click;
            // 
            // label_Zahlensys_Ergebnis
            // 
            label_Zahlensys_Ergebnis.AutoSize = true;
            label_Zahlensys_Ergebnis.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_Zahlensys_Ergebnis.Location = new Point(38, 258);
            label_Zahlensys_Ergebnis.Name = "label_Zahlensys_Ergebnis";
            label_Zahlensys_Ergebnis.Size = new Size(131, 25);
            label_Zahlensys_Ergebnis.TabIndex = 12;
            label_Zahlensys_Ergebnis.Text = "Zahlensystem:";
            // 
            // label_Ergebnis
            // 
            label_Ergebnis.AutoSize = true;
            label_Ergebnis.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_Ergebnis.Location = new Point(8, 398);
            label_Ergebnis.Name = "label_Ergebnis";
            label_Ergebnis.Size = new Size(89, 25);
            label_Ergebnis.TabIndex = 13;
            label_Ergebnis.Text = "Ergebnis:";
            // 
            // Box_Ergebnis
            // 
            Box_Ergebnis.BackColor = SystemColors.Window;
            Box_Ergebnis.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Box_Ergebnis.Location = new Point(103, 382);
            Box_Ergebnis.Name = "Box_Ergebnis";
            Box_Ergebnis.ReadOnly = true;
            Box_Ergebnis.Size = new Size(414, 56);
            Box_Ergebnis.TabIndex = 14;
            Box_Ergebnis.Text = "";
            // 
            // label_Rechenoperation
            // 
            label_Rechenoperation.AutoSize = true;
            label_Rechenoperation.BackColor = SystemColors.Control;
            label_Rechenoperation.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_Rechenoperation.Location = new Point(9, 176);
            label_Rechenoperation.Name = "label_Rechenoperation";
            label_Rechenoperation.Size = new Size(159, 25);
            label_Rechenoperation.TabIndex = 15;
            label_Rechenoperation.Text = "Rechenoperation:";
            // 
            // RB_E_Hexadez
            // 
            RB_E_Hexadez.AutoSize = true;
            RB_E_Hexadez.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RB_E_Hexadez.Location = new Point(244, 9);
            RB_E_Hexadez.Name = "RB_E_Hexadez";
            RB_E_Hexadez.Size = new Size(86, 25);
            RB_E_Hexadez.TabIndex = 17;
            RB_E_Hexadez.TabStop = true;
            RB_E_Hexadez.Text = "Hexadez";
            RB_E_Hexadez.UseVisualStyleBackColor = true;
            RB_E_Hexadez.Click += Zahlensystem_E_Click;
            // 
            // RB_E_Dezimal
            // 
            RB_E_Dezimal.AutoSize = true;
            RB_E_Dezimal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RB_E_Dezimal.Location = new Point(153, 9);
            RB_E_Dezimal.Name = "RB_E_Dezimal";
            RB_E_Dezimal.Size = new Size(84, 25);
            RB_E_Dezimal.TabIndex = 16;
            RB_E_Dezimal.TabStop = true;
            RB_E_Dezimal.Text = "Dezimal";
            RB_E_Dezimal.UseVisualStyleBackColor = true;
            RB_E_Dezimal.Click += Zahlensystem_E_Click;
            // 
            // RB_E_Oktal
            // 
            RB_E_Oktal.AutoSize = true;
            RB_E_Oktal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RB_E_Oktal.Location = new Point(79, 9);
            RB_E_Oktal.Name = "RB_E_Oktal";
            RB_E_Oktal.Size = new Size(65, 25);
            RB_E_Oktal.TabIndex = 15;
            RB_E_Oktal.TabStop = true;
            RB_E_Oktal.Text = "Oktal";
            RB_E_Oktal.UseVisualStyleBackColor = true;
            RB_E_Oktal.Click += Zahlensystem_E_Click;
            // 
            // RB_E_Binär
            // 
            RB_E_Binär.AutoSize = true;
            RB_E_Binär.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RB_E_Binär.Location = new Point(9, 9);
            RB_E_Binär.Name = "RB_E_Binär";
            RB_E_Binär.Size = new Size(64, 25);
            RB_E_Binär.TabIndex = 14;
            RB_E_Binär.TabStop = true;
            RB_E_Binär.Text = "Binär";
            RB_E_Binär.UseVisualStyleBackColor = true;
            RB_E_Binär.Click += Zahlensystem_E_Click;
            // 
            // RB_Div
            // 
            RB_Div.AutoSize = true;
            RB_Div.BackColor = SystemColors.Control;
            RB_Div.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RB_Div.Location = new Point(349, 9);
            RB_Div.Name = "RB_Div";
            RB_Div.Size = new Size(84, 25);
            RB_Div.TabIndex = 13;
            RB_Div.TabStop = true;
            RB_Div.Text = "Division";
            RB_Div.UseVisualStyleBackColor = false;
            RB_Div.Click += Operation_Click;
            // 
            // RB_Mult
            // 
            RB_Mult.AutoSize = true;
            RB_Mult.BackColor = SystemColors.Control;
            RB_Mult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RB_Mult.Location = new Point(219, 9);
            RB_Mult.Name = "RB_Mult";
            RB_Mult.Size = new Size(124, 25);
            RB_Mult.TabIndex = 12;
            RB_Mult.TabStop = true;
            RB_Mult.Text = "Multiplikation";
            RB_Mult.UseVisualStyleBackColor = false;
            RB_Mult.Click += Operation_Click;
            // 
            // RB_Sub
            // 
            RB_Sub.AutoSize = true;
            RB_Sub.BackColor = SystemColors.Control;
            RB_Sub.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RB_Sub.Location = new Point(104, 8);
            RB_Sub.Name = "RB_Sub";
            RB_Sub.Size = new Size(109, 25);
            RB_Sub.TabIndex = 11;
            RB_Sub.TabStop = true;
            RB_Sub.Text = "Subtraktion";
            RB_Sub.UseVisualStyleBackColor = false;
            RB_Sub.Click += Operation_Click;
            // 
            // RB_Add
            // 
            RB_Add.AutoSize = true;
            RB_Add.BackColor = SystemColors.Control;
            RB_Add.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RB_Add.Location = new Point(11, 8);
            RB_Add.Name = "RB_Add";
            RB_Add.Size = new Size(87, 25);
            RB_Add.TabIndex = 10;
            RB_Add.TabStop = true;
            RB_Add.Text = "Addition";
            RB_Add.UseVisualStyleBackColor = false;
            RB_Add.Click += Operation_Click;
            // 
            // B_Berechnen
            // 
            B_Berechnen.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            B_Berechnen.Location = new Point(217, 328);
            B_Berechnen.Name = "B_Berechnen";
            B_Berechnen.Size = new Size(168, 37);
            B_Berechnen.TabIndex = 18;
            B_Berechnen.Text = "Jetzt Berechnen!";
            B_Berechnen.UseVisualStyleBackColor = true;
            B_Berechnen.Click += B_Berechnen_Click;
            // 
            // panel_RB1
            // 
            panel_RB1.Controls.Add(RB_Binär1);
            panel_RB1.Controls.Add(RB_Oktal1);
            panel_RB1.Controls.Add(RB_Dezimal1);
            panel_RB1.Controls.Add(RB_Hexadez1);
            panel_RB1.Location = new Point(12, 87);
            panel_RB1.Name = "panel_RB1";
            panel_RB1.Size = new Size(284, 29);
            panel_RB1.TabIndex = 20;
            panel_RB1.Paint += panel_RB1_Paint;
            // 
            // panel_RB2
            // 
            panel_RB2.Controls.Add(RB_Binär2);
            panel_RB2.Controls.Add(RB_Oktal2);
            panel_RB2.Controls.Add(RB_Dezimal2);
            panel_RB2.Controls.Add(RB_Hexadez2);
            panel_RB2.Location = new Point(342, 87);
            panel_RB2.Name = "panel_RB2";
            panel_RB2.Size = new Size(284, 29);
            panel_RB2.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.Controls.Add(RB_Add);
            panel1.Controls.Add(RB_Div);
            panel1.Controls.Add(RB_Sub);
            panel1.Controls.Add(RB_Mult);
            panel1.Location = new Point(174, 168);
            panel1.Name = "panel1";
            panel1.Size = new Size(457, 42);
            panel1.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.Controls.Add(RB_E_Binär);
            panel2.Controls.Add(RB_E_Oktal);
            panel2.Controls.Add(RB_E_Hexadez);
            panel2.Controls.Add(RB_E_Dezimal);
            panel2.Location = new Point(173, 250);
            panel2.Name = "panel2";
            panel2.Size = new Size(340, 42);
            panel2.TabIndex = 23;
            // 
            // Zahlensystemumrechner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 450);
            Controls.Add(B_Berechnen);
            Controls.Add(label_Rechenoperation);
            Controls.Add(Box_Ergebnis);
            Controls.Add(label_Ergebnis);
            Controls.Add(label_Zahlensys_Ergebnis);
            Controls.Add(label_Zahl2);
            Controls.Add(label_Zahl1);
            Controls.Add(Box_Zahl2);
            Controls.Add(Box_Zahl1);
            Controls.Add(panel_RB1);
            Controls.Add(panel_RB2);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Zahlensystemumrechner";
            Text = "Zahlensystemumrechner";
            Click += Zahlensystem_E_Click;
            panel_RB1.ResumeLayout(false);
            panel_RB1.PerformLayout();
            panel_RB2.ResumeLayout(false);
            panel_RB2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox Box_Zahl1;
        private RichTextBox Box_Zahl2;
        private Label label_Zahl1;
        private Label label_Zahl2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RadioButton RB_Binär1;
        private RadioButton RB_Oktal1;
        private RadioButton RB_Dezimal1;
        private RadioButton RB_Hexadez1;
        private RadioButton RB_Hexadez2;
        private RadioButton RB_Dezimal2;
        private RadioButton RB_Oktal2;
        private RadioButton RB_Binär2;
        private Label label_Zahlensys_Ergebnis;
        private Label label_Ergebnis;
        private RichTextBox Box_Ergebnis;
        private Label label_Rechenoperation;
        private RadioButton RB_E_Hexadez;
        private RadioButton RB_E_Dezimal;
        private RadioButton RB_E_Oktal;
        private RadioButton RB_E_Binär;
        private RadioButton RB_Div;
        private RadioButton RB_Mult;
        private RadioButton RB_Sub;
        private RadioButton RB_Add;
        private Button B_Berechnen;
        private Panel panel_RB1;
        private Panel panel_RB2;
        private Panel panel1;
        private Panel panel2;
    }
}