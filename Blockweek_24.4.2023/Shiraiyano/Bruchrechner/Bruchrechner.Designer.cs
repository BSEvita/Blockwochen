namespace Bruchrechner
{
	partial class Bruchrechner_Fenster
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
			Zähler1 = new RichTextBox();
			Nenner1 = new RichTextBox();
			Zähler2 = new RichTextBox();
			Nenner2 = new RichTextBox();
			Operation_Display = new RichTextBox();
			BT_ADD = new Button();
			BT_SUB = new Button();
			BT_MULT = new Button();
			BT_DIV = new Button();
			BT_POT = new Button();
			BT_ROOT = new Button();
			BTN_EQUAL = new Button();
			Potenz = new RichTextBox();
			ErgebnisBox = new RichTextBox();
			label_Ergebnis = new Label();
			label_Bruch1 = new Label();
			label_Bruch2 = new Label();
			label_Exponent = new Label();
			SuspendLayout();
			// 
			// Zähler1
			// 
			Zähler1.Location = new Point(75, 58);
			Zähler1.Name = "Zähler1";
			Zähler1.Size = new Size(243, 27);
			Zähler1.TabIndex = 0;
			Zähler1.Text = "";
			// 
			// Nenner1
			// 
			Nenner1.Location = new Point(75, 111);
			Nenner1.Name = "Nenner1";
			Nenner1.Size = new Size(243, 27);
			Nenner1.TabIndex = 1;
			Nenner1.Text = "";
			// 
			// Zähler2
			// 
			Zähler2.Location = new Point(481, 58);
			Zähler2.Name = "Zähler2";
			Zähler2.Size = new Size(243, 27);
			Zähler2.TabIndex = 2;
			Zähler2.Text = "";
			// 
			// Nenner2
			// 
			Nenner2.Location = new Point(481, 111);
			Nenner2.Name = "Nenner2";
			Nenner2.Size = new Size(243, 27);
			Nenner2.TabIndex = 3;
			Nenner2.Text = "";
			// 
			// Operation_Display
			// 
			Operation_Display.BackColor = SystemColors.ControlDark;
			Operation_Display.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			Operation_Display.Location = new Point(362, 73);
			Operation_Display.Name = "Operation_Display";
			Operation_Display.ReadOnly = true;
			Operation_Display.Size = new Size(75, 46);
			Operation_Display.TabIndex = 4;
			Operation_Display.Text = "";
			// 
			// BT_ADD
			// 
			BT_ADD.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			BT_ADD.Location = new Point(50, 245);
			BT_ADD.Name = "BT_ADD";
			BT_ADD.Size = new Size(75, 46);
			BT_ADD.TabIndex = 5;
			BT_ADD.Text = "+";
			BT_ADD.UseVisualStyleBackColor = true;
			BT_ADD.Click += OnOperationClick;
			// 
			// BT_SUB
			// 
			BT_SUB.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			BT_SUB.Location = new Point(131, 245);
			BT_SUB.Name = "BT_SUB";
			BT_SUB.Size = new Size(75, 46);
			BT_SUB.TabIndex = 6;
			BT_SUB.Text = "-";
			BT_SUB.UseVisualStyleBackColor = true;
			BT_SUB.Click += OnOperationClick;
			// 
			// BT_MULT
			// 
			BT_MULT.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			BT_MULT.Location = new Point(212, 245);
			BT_MULT.Name = "BT_MULT";
			BT_MULT.Size = new Size(75, 46);
			BT_MULT.TabIndex = 7;
			BT_MULT.Text = "×";
			BT_MULT.UseVisualStyleBackColor = true;
			BT_MULT.Click += OnOperationClick;
			// 
			// BT_DIV
			// 
			BT_DIV.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			BT_DIV.Location = new Point(50, 297);
			BT_DIV.Name = "BT_DIV";
			BT_DIV.Size = new Size(75, 46);
			BT_DIV.TabIndex = 8;
			BT_DIV.Text = "÷";
			BT_DIV.UseVisualStyleBackColor = true;
			BT_DIV.Click += OnOperationClick;
			// 
			// BT_POT
			// 
			BT_POT.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			BT_POT.Location = new Point(131, 297);
			BT_POT.Name = "BT_POT";
			BT_POT.Size = new Size(75, 46);
			BT_POT.TabIndex = 9;
			BT_POT.Text = "x^y";
			BT_POT.UseVisualStyleBackColor = true;
			BT_POT.Click += OnOperationClick;
			// 
			// BT_ROOT
			// 
			BT_ROOT.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			BT_ROOT.Location = new Point(212, 297);
			BT_ROOT.Name = "BT_ROOT";
			BT_ROOT.Size = new Size(75, 46);
			BT_ROOT.TabIndex = 10;
			BT_ROOT.Text = "√x";
			BT_ROOT.UseVisualStyleBackColor = true;
			BT_ROOT.Click += OnOperationClick;
			// 
			// BTN_EQUAL
			// 
			BTN_EQUAL.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			BTN_EQUAL.Location = new Point(362, 266);
			BTN_EQUAL.Name = "BTN_EQUAL";
			BTN_EQUAL.Size = new Size(75, 46);
			BTN_EQUAL.TabIndex = 11;
			BTN_EQUAL.Text = "=";
			BTN_EQUAL.UseVisualStyleBackColor = true;
			BTN_EQUAL.Click += BTN_EQUAL_Click;
			// 
			// Potenz
			// 
			Potenz.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			Potenz.Location = new Point(512, 9);
			Potenz.Name = "Potenz";
			Potenz.Size = new Size(212, 42);
			Potenz.TabIndex = 12;
			Potenz.Text = "";
			Potenz.Visible = false;
			// 
			// ErgebnisBox
			// 
			ErgebnisBox.Location = new Point(481, 276);
			ErgebnisBox.Name = "ErgebnisBox";
			ErgebnisBox.ReadOnly = true;
			ErgebnisBox.Size = new Size(243, 27);
			ErgebnisBox.TabIndex = 13;
			ErgebnisBox.Text = "";
			// 
			// label_Ergebnis
			// 
			label_Ergebnis.AutoSize = true;
			label_Ergebnis.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			label_Ergebnis.Location = new Point(541, 201);
			label_Ergebnis.Name = "label_Ergebnis";
			label_Ergebnis.Size = new Size(119, 37);
			label_Ergebnis.TabIndex = 15;
			label_Ergebnis.Text = "Ergebnis";
			// 
			// label_Bruch1
			// 
			label_Bruch1.AutoSize = true;
			label_Bruch1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			label_Bruch1.Location = new Point(141, 12);
			label_Bruch1.Name = "label_Bruch1";
			label_Bruch1.Size = new Size(105, 37);
			label_Bruch1.TabIndex = 16;
			label_Bruch1.Text = "Bruch 1";
			// 
			// label_Bruch2
			// 
			label_Bruch2.AutoSize = true;
			label_Bruch2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			label_Bruch2.Location = new Point(555, 12);
			label_Bruch2.Name = "label_Bruch2";
			label_Bruch2.Size = new Size(105, 37);
			label_Bruch2.TabIndex = 17;
			label_Bruch2.Text = "Bruch 2";
			// 
			// label_Exponent
			// 
			label_Exponent.AutoSize = true;
			label_Exponent.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label_Exponent.Location = new Point(440, 21);
			label_Exponent.Name = "label_Exponent";
			label_Exponent.Size = new Size(66, 19);
			label_Exponent.TabIndex = 18;
			label_Exponent.Text = "Exponent";
			label_Exponent.Visible = false;
			// 
			// Bruchrechner_Fenster
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(810, 514);
			Controls.Add(label_Exponent);
			Controls.Add(label_Bruch2);
			Controls.Add(label_Bruch1);
			Controls.Add(label_Ergebnis);
			Controls.Add(ErgebnisBox);
			Controls.Add(Potenz);
			Controls.Add(BTN_EQUAL);
			Controls.Add(BT_ROOT);
			Controls.Add(BT_POT);
			Controls.Add(BT_DIV);
			Controls.Add(BT_MULT);
			Controls.Add(BT_SUB);
			Controls.Add(BT_ADD);
			Controls.Add(Operation_Display);
			Controls.Add(Nenner2);
			Controls.Add(Zähler2);
			Controls.Add(Nenner1);
			Controls.Add(Zähler1);
			Name = "Bruchrechner_Fenster";
			Text = "Bruchrechner";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private RichTextBox Zähler1;
		private RichTextBox Nenner1;
		private RichTextBox Zähler2;
		private RichTextBox Nenner2;
		private RichTextBox Operation_Display;
		private Button BT_ADD;
		private Button BT_SUB;
		private Button BT_MULT;
		private Button BT_DIV;
		private Button BT_POT;
		private Button BT_ROOT;
		private Button BTN_EQUAL;
		private RichTextBox Potenz;
		private RichTextBox ErgebnisBox;
		private Label label_Ergebnis;
		private Label label_Bruch1;
		private Label label_Bruch2;
		private Label label_Exponent;
	}
}