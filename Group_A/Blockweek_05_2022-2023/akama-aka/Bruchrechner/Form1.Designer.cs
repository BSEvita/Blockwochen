using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using static Bruchrechner.Rechner;

namespace Bruchrechner
{
    partial class Form1 : Form
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
            bruchTopFirst = new TextBox();
            bruchBottomFirst = new TextBox();
            btnPlus = new Button();
            btnMal = new Button();
            btnPot = new Button();
            btnMinus = new Button();
            btnDiv = new Button();
            btnWur = new Button();
            bruchBottomSecond = new TextBox();
            bruchTopSecond = new TextBox();
            textBox5 = new TextBox();
            bruchFinishTop = new TextBox();
            bruchFinishBottom = new TextBox();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // bruchTopFirst
            // 
            bruchTopFirst.Location = new Point(56, 50);
            bruchTopFirst.Name = "bruchTopFirst";
            bruchTopFirst.Size = new Size(100, 23);
            bruchTopFirst.TabIndex = 0;
            // 
            // bruchBottomFirst
            // 
            bruchBottomFirst.Location = new Point(56, 94);
            bruchBottomFirst.Name = "bruchBottomFirst";
            bruchBottomFirst.Size = new Size(100, 23);
            bruchBottomFirst.TabIndex = 1;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(216, 54);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(75, 23);
            btnPlus.TabIndex = 2;
            btnPlus.Tag = "opSelection";
            btnPlus.Text = "Plus";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMal
            // 
            btnMal.Location = new Point(216, 83);
            btnMal.Name = "btnMal";
            btnMal.Size = new Size(75, 23);
            btnMal.TabIndex = 3;
            btnMal.Tag = "opSelection";
            btnMal.Text = "Mal";
            btnMal.UseVisualStyleBackColor = true;
            btnMal.Click += btnMal_Click;
            // 
            // btnPot
            // 
            btnPot.Location = new Point(216, 112);
            btnPot.Name = "btnPot";
            btnPot.Size = new Size(75, 23);
            btnPot.TabIndex = 4;
            btnPot.Tag = "opSelection";
            btnPot.Text = "Potenz";
            btnPot.UseVisualStyleBackColor = true;
            btnPot.Click += btnPot_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(297, 54);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(75, 23);
            btnMinus.TabIndex = 5;
            btnMinus.Tag = "opSelection";
            btnMinus.Text = "Minus";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(297, 83);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(75, 23);
            btnDiv.TabIndex = 6;
            btnDiv.Tag = "opSelection";
            btnDiv.Text = "Dividiert";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnWur
            // 
            btnWur.Location = new Point(297, 112);
            btnWur.Name = "btnWur";
            btnWur.Size = new Size(75, 23);
            btnWur.TabIndex = 7;
            btnWur.Tag = "opSelection";
            btnWur.Text = "Wurzel";
            btnWur.UseVisualStyleBackColor = true;
            btnWur.Click += btnWur_Click;
            // 
            // bruchBottomSecond
            // 
            bruchBottomSecond.Location = new Point(403, 94);
            bruchBottomSecond.Name = "bruchBottomSecond";
            bruchBottomSecond.Size = new Size(100, 23);
            bruchBottomSecond.TabIndex = 9;
            // 
            // bruchTopSecond
            // 
            bruchTopSecond.Location = new Point(403, 50);
            bruchTopSecond.Name = "bruchTopSecond";
            bruchTopSecond.Size = new Size(100, 23);
            bruchTopSecond.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.White;
            textBox5.Location = new Point(529, 72);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(12, 23);
            textBox5.TabIndex = 10;
            textBox5.Text = "=";
            // 
            // bruchFinishTop
            // 
            bruchFinishTop.Location = new Point(622, 42);
            bruchFinishTop.Name = "bruchFinishTop";
            bruchFinishTop.Size = new Size(100, 23);
            bruchFinishTop.TabIndex = 11;
            // 
            // bruchFinishBottom
            // 
            bruchFinishBottom.Location = new Point(622, 94);
            bruchFinishBottom.Name = "bruchFinishBottom";
            bruchFinishBottom.Size = new Size(100, 23);
            bruchFinishBottom.TabIndex = 12;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(116, 172);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(329, 23);
            btnCalculate.TabIndex = 13;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculate);
            Controls.Add(bruchFinishBottom);
            Controls.Add(bruchFinishTop);
            Controls.Add(textBox5);
            Controls.Add(bruchBottomSecond);
            Controls.Add(bruchTopSecond);
            Controls.Add(btnWur);
            Controls.Add(btnDiv);
            Controls.Add(btnMinus);
            Controls.Add(btnPot);
            Controls.Add(btnMal);
            Controls.Add(btnPlus);
            Controls.Add(bruchBottomFirst);
            Controls.Add(bruchTopFirst);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox bruchTopFirst;
        private TextBox bruchBottomFirst;
        private Button btnPlus;
        private Button btnMal;
        private Button btnPot;
        private Button btnMinus;
        private Button btnDiv;
        private Button btnWur;
        private TextBox bruchBottomSecond;
        private TextBox bruchTopSecond;
        private TextBox textBox5;
        private TextBox bruchFinishTop;
        private TextBox bruchFinishBottom;
        private Button btnCalculate;

        private double firstResult;
        private double secondResult;
        private string op;
        public string Operation;
        public double bruchtTopFirstDouble;
    }
}