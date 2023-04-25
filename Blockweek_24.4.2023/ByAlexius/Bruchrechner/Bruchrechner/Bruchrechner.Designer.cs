namespace Bruchrechner
{
    partial class Bruchrechner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bruchrechner));
            btnCalculate = new Button();
            textBoxZählerEins = new TextBox();
            textBoxZählerZwei = new TextBox();
            label1 = new Label();
            zaehlerZweiLabel = new Label();
            textBoxErgebnis = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxNennerEins = new TextBox();
            NennerZweiLabel = new Label();
            textBoxNennerZwei = new TextBox();
            operations = new ComboBox();
            label6 = new Label();
            potenzLabel = new Label();
            textBoxPotenz = new TextBox();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalculate.Location = new Point(150, 368);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(118, 59);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Rechnen";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // textBoxZählerEins
            // 
            textBoxZählerEins.Location = new Point(40, 215);
            textBoxZählerEins.Name = "textBoxZählerEins";
            textBoxZählerEins.Size = new Size(144, 23);
            textBoxZählerEins.TabIndex = 1;
            // 
            // textBoxZählerZwei
            // 
            textBoxZählerZwei.Location = new Point(234, 215);
            textBoxZählerZwei.Name = "textBoxZählerZwei";
            textBoxZählerZwei.Size = new Size(144, 23);
            textBoxZählerZwei.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(77, 189);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 3;
            label1.Text = "Zähler 1";
            // 
            // zaehlerZweiLabel
            // 
            zaehlerZweiLabel.AutoSize = true;
            zaehlerZweiLabel.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            zaehlerZweiLabel.Location = new Point(276, 189);
            zaehlerZweiLabel.Name = "zaehlerZweiLabel";
            zaehlerZweiLabel.Size = new Size(75, 25);
            zaehlerZweiLabel.TabIndex = 4;
            zaehlerZweiLabel.Text = "Zähler 2";
            // 
            // textBoxErgebnis
            // 
            textBoxErgebnis.Location = new Point(117, 59);
            textBoxErgebnis.Multiline = true;
            textBoxErgebnis.Name = "textBoxErgebnis";
            textBoxErgebnis.ReadOnly = true;
            textBoxErgebnis.Size = new Size(181, 40);
            textBoxErgebnis.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(171, 28);
            label3.Name = "label3";
            label3.Size = new Size(88, 28);
            label3.TabIndex = 6;
            label3.Text = "Ausgabe";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(77, 264);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 8;
            label4.Text = "Nenner 1";
            // 
            // textBoxNennerEins
            // 
            textBoxNennerEins.Location = new Point(40, 290);
            textBoxNennerEins.Name = "textBoxNennerEins";
            textBoxNennerEins.Size = new Size(144, 23);
            textBoxNennerEins.TabIndex = 7;
            // 
            // NennerZweiLabel
            // 
            NennerZweiLabel.AutoSize = true;
            NennerZweiLabel.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            NennerZweiLabel.Location = new Point(276, 262);
            NennerZweiLabel.Name = "NennerZweiLabel";
            NennerZweiLabel.Size = new Size(84, 25);
            NennerZweiLabel.TabIndex = 10;
            NennerZweiLabel.Text = "Nenner 2";
            NennerZweiLabel.Click += label5_Click;
            // 
            // textBoxNennerZwei
            // 
            textBoxNennerZwei.Location = new Point(234, 290);
            textBoxNennerZwei.Name = "textBoxNennerZwei";
            textBoxNennerZwei.Size = new Size(144, 23);
            textBoxNennerZwei.TabIndex = 9;
            textBoxNennerZwei.TextChanged += textBox2_TextChanged;
            // 
            // operations
            // 
            operations.FormattingEnabled = true;
            operations.Location = new Point(100, 140);
            operations.Name = "operations";
            operations.Size = new Size(223, 23);
            operations.TabIndex = 11;
            operations.SelectedIndexChanged += operations_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(167, 112);
            label6.Name = "label6";
            label6.Size = new Size(92, 25);
            label6.TabIndex = 12;
            label6.Text = "Operation";
            // 
            // potenzLabel
            // 
            potenzLabel.AutoSize = true;
            potenzLabel.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            potenzLabel.Location = new Point(276, 226);
            potenzLabel.Name = "potenzLabel";
            potenzLabel.Size = new Size(65, 25);
            potenzLabel.TabIndex = 14;
            potenzLabel.Text = "Potenz";
            // 
            // textBoxPotenz
            // 
            textBoxPotenz.Location = new Point(234, 254);
            textBoxPotenz.Name = "textBoxPotenz";
            textBoxPotenz.Size = new Size(144, 23);
            textBoxPotenz.TabIndex = 13;
            // 
            // Bruchrechner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 450);
            Controls.Add(potenzLabel);
            Controls.Add(textBoxPotenz);
            Controls.Add(label6);
            Controls.Add(operations);
            Controls.Add(NennerZweiLabel);
            Controls.Add(textBoxNennerZwei);
            Controls.Add(label4);
            Controls.Add(textBoxNennerEins);
            Controls.Add(label3);
            Controls.Add(textBoxErgebnis);
            Controls.Add(zaehlerZweiLabel);
            Controls.Add(label1);
            Controls.Add(textBoxZählerZwei);
            Controls.Add(textBoxZählerEins);
            Controls.Add(btnCalculate);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Bruchrechner";
            Text = "Bruchrechner";
            Load += Bruchrechner_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private TextBox textBoxZählerEins;
        private TextBox textBoxZählerZwei;
        private Label label1;
        private Label zaehlerZweiLabel;
        private TextBox textBoxErgebnis;
        private Label label3;
        private Label label4;
        private TextBox textBoxNennerEins;
        private Label NennerZweiLabel;
        private TextBox textBoxNennerZwei;
        private ComboBox operations;
        private Label label6;
        private Label potenzLabel;
        private TextBox textBoxPotenz;
    }
}