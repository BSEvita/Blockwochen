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
			radioB_Binär1 = new RadioButton();
			radioB_Oktal1 = new RadioButton();
			radioB_Dezimal1 = new RadioButton();
			radioB_Hexadez1 = new RadioButton();
			radioButton1 = new RadioButton();
			radioButton2 = new RadioButton();
			radioButton3 = new RadioButton();
			radioButton4 = new RadioButton();
			label_Zahlensys_Ergebnis = new Label();
			label_Ergebnis = new Label();
			Box_Ergebnis = new RichTextBox();
			label_Rechenoperation = new Label();
			radioB_Hexadez_Ergebnis = new RadioButton();
			radioB_Dezimal_Ergebnis = new RadioButton();
			radioB_Oktal_Ergebnis = new RadioButton();
			radioB_Binär_Ergebnis = new RadioButton();
			radioB_Div = new RadioButton();
			radioB_Mult = new RadioButton();
			radioB_Sub = new RadioButton();
			radioB_Add = new RadioButton();
			Hintergrund = new RichTextBox();
			label_Gewählt = new Label();
			richTextBox1 = new RichTextBox();
			richTextBox2 = new RichTextBox();
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
			// radioB_Binär1
			// 
			radioB_Binär1.AutoSize = true;
			radioB_Binär1.Location = new Point(27, 87);
			radioB_Binär1.Name = "radioB_Binär1";
			radioB_Binär1.Size = new Size(52, 19);
			radioB_Binär1.TabIndex = 1;
			radioB_Binär1.TabStop = true;
			radioB_Binär1.Text = "Binär";
			radioB_Binär1.UseVisualStyleBackColor = true;
			// 
			// radioB_Oktal1
			// 
			radioB_Oktal1.AutoSize = true;
			radioB_Oktal1.Location = new Point(85, 87);
			radioB_Oktal1.Name = "radioB_Oktal1";
			radioB_Oktal1.Size = new Size(53, 19);
			radioB_Oktal1.TabIndex = 2;
			radioB_Oktal1.TabStop = true;
			radioB_Oktal1.Text = "Oktal";
			radioB_Oktal1.UseVisualStyleBackColor = true;
			// 
			// radioB_Dezimal1
			// 
			radioB_Dezimal1.AutoSize = true;
			radioB_Dezimal1.Location = new Point(144, 87);
			radioB_Dezimal1.Name = "radioB_Dezimal1";
			radioB_Dezimal1.Size = new Size(67, 19);
			radioB_Dezimal1.TabIndex = 3;
			radioB_Dezimal1.TabStop = true;
			radioB_Dezimal1.Text = "Dezimal";
			radioB_Dezimal1.UseVisualStyleBackColor = true;
			// 
			// radioB_Hexadez1
			// 
			radioB_Hexadez1.AutoSize = true;
			radioB_Hexadez1.Location = new Point(217, 87);
			radioB_Hexadez1.Name = "radioB_Hexadez1";
			radioB_Hexadez1.Size = new Size(70, 19);
			radioB_Hexadez1.TabIndex = 4;
			radioB_Hexadez1.TabStop = true;
			radioB_Hexadez1.Text = "Hexadez";
			radioB_Hexadez1.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			radioButton1.AutoSize = true;
			radioButton1.Location = new Point(553, 87);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new Size(70, 19);
			radioButton1.TabIndex = 9;
			radioButton1.TabStop = true;
			radioButton1.Text = "Hexadez";
			radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			radioButton2.AutoSize = true;
			radioButton2.Location = new Point(480, 87);
			radioButton2.Name = "radioButton2";
			radioButton2.Size = new Size(67, 19);
			radioButton2.TabIndex = 8;
			radioButton2.TabStop = true;
			radioButton2.Text = "Dezimal";
			radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			radioButton3.AutoSize = true;
			radioButton3.Location = new Point(421, 87);
			radioButton3.Name = "radioButton3";
			radioButton3.Size = new Size(53, 19);
			radioButton3.TabIndex = 7;
			radioButton3.TabStop = true;
			radioButton3.Text = "Oktal";
			radioButton3.UseVisualStyleBackColor = true;
			// 
			// radioButton4
			// 
			radioButton4.AutoSize = true;
			radioButton4.Location = new Point(363, 87);
			radioButton4.Name = "radioButton4";
			radioButton4.Size = new Size(52, 19);
			radioButton4.TabIndex = 6;
			radioButton4.TabStop = true;
			radioButton4.Text = "Binär";
			radioButton4.UseVisualStyleBackColor = true;
			// 
			// label_Zahlensys_Ergebnis
			// 
			label_Zahlensys_Ergebnis.AutoSize = true;
			label_Zahlensys_Ergebnis.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			label_Zahlensys_Ergebnis.Location = new Point(33, 322);
			label_Zahlensys_Ergebnis.Name = "label_Zahlensys_Ergebnis";
			label_Zahlensys_Ergebnis.Size = new Size(131, 25);
			label_Zahlensys_Ergebnis.TabIndex = 12;
			label_Zahlensys_Ergebnis.Text = "Zahlensystem:";
			// 
			// label_Ergebnis
			// 
			label_Ergebnis.AutoSize = true;
			label_Ergebnis.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			label_Ergebnis.Location = new Point(8, 413);
			label_Ergebnis.Name = "label_Ergebnis";
			label_Ergebnis.Size = new Size(89, 25);
			label_Ergebnis.TabIndex = 13;
			label_Ergebnis.Text = "Ergebnis:";
			// 
			// Box_Ergebnis
			// 
			Box_Ergebnis.BackColor = SystemColors.Window;
			Box_Ergebnis.Location = new Point(103, 412);
			Box_Ergebnis.Name = "Box_Ergebnis";
			Box_Ergebnis.ReadOnly = true;
			Box_Ergebnis.Size = new Size(414, 26);
			Box_Ergebnis.TabIndex = 14;
			Box_Ergebnis.Text = "";
			// 
			// label_Rechenoperation
			// 
			label_Rechenoperation.AutoSize = true;
			label_Rechenoperation.BackColor = SystemColors.MenuHighlight;
			label_Rechenoperation.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			label_Rechenoperation.Location = new Point(33, 189);
			label_Rechenoperation.Name = "label_Rechenoperation";
			label_Rechenoperation.Size = new Size(159, 25);
			label_Rechenoperation.TabIndex = 15;
			label_Rechenoperation.Text = "Rechenoperation:";
			// 
			// radioB_Hexadez_Ergebnis
			// 
			radioB_Hexadez_Ergebnis.AutoSize = true;
			radioB_Hexadez_Ergebnis.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			radioB_Hexadez_Ergebnis.Location = new Point(170, 362);
			radioB_Hexadez_Ergebnis.Name = "radioB_Hexadez_Ergebnis";
			radioB_Hexadez_Ergebnis.Size = new Size(86, 25);
			radioB_Hexadez_Ergebnis.TabIndex = 17;
			radioB_Hexadez_Ergebnis.TabStop = true;
			radioB_Hexadez_Ergebnis.Text = "Hexadez";
			radioB_Hexadez_Ergebnis.UseVisualStyleBackColor = true;
			// 
			// radioB_Dezimal_Ergebnis
			// 
			radioB_Dezimal_Ergebnis.AutoSize = true;
			radioB_Dezimal_Ergebnis.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			radioB_Dezimal_Ergebnis.Location = new Point(170, 337);
			radioB_Dezimal_Ergebnis.Name = "radioB_Dezimal_Ergebnis";
			radioB_Dezimal_Ergebnis.Size = new Size(84, 25);
			radioB_Dezimal_Ergebnis.TabIndex = 16;
			radioB_Dezimal_Ergebnis.TabStop = true;
			radioB_Dezimal_Ergebnis.Text = "Dezimal";
			radioB_Dezimal_Ergebnis.UseVisualStyleBackColor = true;
			// 
			// radioB_Oktal_Ergebnis
			// 
			radioB_Oktal_Ergebnis.AutoSize = true;
			radioB_Oktal_Ergebnis.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			radioB_Oktal_Ergebnis.Location = new Point(170, 312);
			radioB_Oktal_Ergebnis.Name = "radioB_Oktal_Ergebnis";
			radioB_Oktal_Ergebnis.Size = new Size(65, 25);
			radioB_Oktal_Ergebnis.TabIndex = 15;
			radioB_Oktal_Ergebnis.TabStop = true;
			radioB_Oktal_Ergebnis.Text = "Oktal";
			radioB_Oktal_Ergebnis.UseVisualStyleBackColor = true;
			// 
			// radioB_Binär_Ergebnis
			// 
			radioB_Binär_Ergebnis.AutoSize = true;
			radioB_Binär_Ergebnis.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			radioB_Binär_Ergebnis.Location = new Point(170, 287);
			radioB_Binär_Ergebnis.Name = "radioB_Binär_Ergebnis";
			radioB_Binär_Ergebnis.Size = new Size(64, 25);
			radioB_Binär_Ergebnis.TabIndex = 14;
			radioB_Binär_Ergebnis.TabStop = true;
			radioB_Binär_Ergebnis.Text = "Binär";
			radioB_Binär_Ergebnis.UseVisualStyleBackColor = true;
			// 
			// radioB_Div
			// 
			radioB_Div.AutoSize = true;
			radioB_Div.BackColor = SystemColors.MenuHighlight;
			radioB_Div.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			radioB_Div.Location = new Point(201, 235);
			radioB_Div.Name = "radioB_Div";
			radioB_Div.Size = new Size(84, 25);
			radioB_Div.TabIndex = 13;
			radioB_Div.TabStop = true;
			radioB_Div.Text = "Division";
			radioB_Div.UseVisualStyleBackColor = false;
			// 
			// radioB_Mult
			// 
			radioB_Mult.AutoSize = true;
			radioB_Mult.BackColor = SystemColors.MenuHighlight;
			radioB_Mult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			radioB_Mult.Location = new Point(201, 208);
			radioB_Mult.Name = "radioB_Mult";
			radioB_Mult.Size = new Size(124, 25);
			radioB_Mult.TabIndex = 12;
			radioB_Mult.TabStop = true;
			radioB_Mult.Text = "Multiplikation";
			radioB_Mult.UseVisualStyleBackColor = false;
			// 
			// radioB_Sub
			// 
			radioB_Sub.AutoSize = true;
			radioB_Sub.BackColor = SystemColors.MenuHighlight;
			radioB_Sub.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			radioB_Sub.Location = new Point(201, 180);
			radioB_Sub.Name = "radioB_Sub";
			radioB_Sub.Size = new Size(109, 25);
			radioB_Sub.TabIndex = 11;
			radioB_Sub.TabStop = true;
			radioB_Sub.Text = "Subtraktion";
			radioB_Sub.UseVisualStyleBackColor = false;
			// 
			// radioB_Add
			// 
			radioB_Add.AutoSize = true;
			radioB_Add.BackColor = SystemColors.MenuHighlight;
			radioB_Add.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			radioB_Add.Location = new Point(201, 153);
			radioB_Add.Name = "radioB_Add";
			radioB_Add.Size = new Size(87, 25);
			radioB_Add.TabIndex = 10;
			radioB_Add.TabStop = true;
			radioB_Add.Text = "Addition";
			radioB_Add.UseVisualStyleBackColor = false;
			// 
			// Hintergrund
			// 
			Hintergrund.BackColor = SystemColors.MenuHighlight;
			Hintergrund.Location = new Point(27, 148);
			Hintergrund.Name = "Hintergrund";
			Hintergrund.Size = new Size(307, 114);
			Hintergrund.TabIndex = 24;
			Hintergrund.Text = "";
			// 
			// label_Gewählt
			// 
			label_Gewählt.AutoSize = true;
			label_Gewählt.BackColor = SystemColors.Control;
			label_Gewählt.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			label_Gewählt.Location = new Point(368, 189);
			label_Gewählt.Name = "label_Gewählt";
			label_Gewählt.Size = new Size(85, 25);
			label_Gewählt.TabIndex = 25;
			label_Gewählt.Text = "Gewählt:";
			// 
			// richTextBox1
			// 
			richTextBox1.BackColor = SystemColors.WindowFrame;
			richTextBox1.Location = new Point(459, 169);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new Size(64, 59);
			richTextBox1.TabIndex = 26;
			richTextBox1.Text = "";
			// 
			// richTextBox2
			// 
			richTextBox2.BackColor = SystemColors.Control;
			richTextBox2.Location = new Point(27, 273);
			richTextBox2.Name = "richTextBox2";
			richTextBox2.ReadOnly = true;
			richTextBox2.Size = new Size(307, 114);
			richTextBox2.TabIndex = 27;
			richTextBox2.Text = "";
			// 
			// Zahlensystemumrechner
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(638, 450);
			Controls.Add(richTextBox1);
			Controls.Add(label_Gewählt);
			Controls.Add(radioB_Div);
			Controls.Add(radioB_Mult);
			Controls.Add(radioB_Sub);
			Controls.Add(radioB_Add);
			Controls.Add(radioB_Hexadez_Ergebnis);
			Controls.Add(radioB_Dezimal_Ergebnis);
			Controls.Add(radioB_Oktal_Ergebnis);
			Controls.Add(radioB_Binär_Ergebnis);
			Controls.Add(label_Rechenoperation);
			Controls.Add(Box_Ergebnis);
			Controls.Add(label_Ergebnis);
			Controls.Add(label_Zahlensys_Ergebnis);
			Controls.Add(radioButton1);
			Controls.Add(radioButton2);
			Controls.Add(radioButton3);
			Controls.Add(radioButton4);
			Controls.Add(radioB_Hexadez1);
			Controls.Add(radioB_Dezimal1);
			Controls.Add(radioB_Oktal1);
			Controls.Add(radioB_Binär1);
			Controls.Add(label_Zahl2);
			Controls.Add(label_Zahl1);
			Controls.Add(Box_Zahl2);
			Controls.Add(Box_Zahl1);
			Controls.Add(Hintergrund);
			Controls.Add(richTextBox2);
			Name = "Zahlensystemumrechner";
			Text = "Zahlensystemumrechner";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private RichTextBox Box_Zahl1;
		private RichTextBox Box_Zahl2;
		private Label label_Zahl1;
		private Label label_Zahl2;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private RadioButton radioB_Binär1;
		private RadioButton radioB_Oktal1;
		private RadioButton radioB_Dezimal1;
		private RadioButton radioB_Hexadez1;
		private RadioButton radioButton1;
		private RadioButton radioButton2;
		private RadioButton radioButton3;
		private RadioButton radioButton4;
		private Label label_Zahlensys_Ergebnis;
		private Label label_Ergebnis;
		private RichTextBox Box_Ergebnis;
		private Label label_Rechenoperation;
		private RadioButton radioB_Hexadez_Ergebnis;
		private RadioButton radioB_Dezimal_Ergebnis;
		private RadioButton radioB_Oktal_Ergebnis;
		private RadioButton radioB_Binär_Ergebnis;
		private RadioButton radioB_Div;
		private RadioButton radioB_Mult;
		private RadioButton radioB_Sub;
		private RadioButton radioB_Add;
		private RichTextBox Hintergrund;
		private Label label_Gewählt;
		private RichTextBox richTextBox1;
		private RichTextBox richTextBox2;
	}
}