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
			Operation = new RichTextBox();
			BT_ADD = new Button();
			BT_SUB = new Button();
			BT_MULT = new Button();
			BT_DIV = new Button();
			BT_POT = new Button();
			BT_ROOT = new Button();
			SuspendLayout();
			// 
			// Zähler1
			// 
			Zähler1.Location = new Point(37, 63);
			Zähler1.Name = "Zähler1";
			Zähler1.Size = new Size(243, 43);
			Zähler1.TabIndex = 0;
			Zähler1.Text = "";
			// 
			// Nenner1
			// 
			Nenner1.Location = new Point(37, 156);
			Nenner1.Name = "Nenner1";
			Nenner1.Size = new Size(243, 43);
			Nenner1.TabIndex = 1;
			Nenner1.Text = "";
			// 
			// Zähler2
			// 
			Zähler2.Location = new Point(443, 63);
			Zähler2.Name = "Zähler2";
			Zähler2.Size = new Size(243, 43);
			Zähler2.TabIndex = 2;
			Zähler2.Text = "";
			// 
			// Nenner2
			// 
			Nenner2.Location = new Point(443, 156);
			Nenner2.Name = "Nenner2";
			Nenner2.Size = new Size(243, 43);
			Nenner2.TabIndex = 3;
			Nenner2.Text = "";
			Nenner2.TextChanged += Nenner2_TextChanged;
			// 
			// Operation
			// 
			Operation.BackColor = SystemColors.ControlDark;
			Operation.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			Operation.Location = new Point(307, 101);
			Operation.Name = "Operation";
			Operation.ReadOnly = true;
			Operation.Size = new Size(115, 54);
			Operation.TabIndex = 4;
			Operation.Text = "";
			Operation.TextChanged += Operation_TextChanged;
			// 
			// BT_ADD
			// 
			BT_ADD.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			BT_ADD.Location = new Point(37, 254);
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
			BT_SUB.Location = new Point(143, 254);
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
			BT_MULT.Location = new Point(244, 254);
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
			BT_DIV.Location = new Point(347, 254);
			BT_DIV.Name = "BT_DIV";
			BT_DIV.Size = new Size(75, 46);
			BT_DIV.TabIndex = 8;
			BT_DIV.Text = "÷";
			BT_DIV.UseVisualStyleBackColor = true;
			BT_DIV.Click += OnOperationClick;
			// 
			// BT_POT
			// 
			BT_POT.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			BT_POT.Location = new Point(443, 254);
			BT_POT.Name = "BT_POT";
			BT_POT.Size = new Size(84, 46);
			BT_POT.TabIndex = 9;
			BT_POT.Text = "x^(y)";
			BT_POT.UseVisualStyleBackColor = true;
			BT_POT.Click += OnOperationClick;
			// 
			// BT_ROOT
			// 
			BT_ROOT.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			BT_ROOT.Location = new Point(551, 254);
			BT_ROOT.Name = "BT_ROOT";
			BT_ROOT.Size = new Size(85, 46);
			BT_ROOT.TabIndex = 10;
			BT_ROOT.Text = "(x)√y";
			BT_ROOT.UseVisualStyleBackColor = true;
			BT_ROOT.Click += OnOperationClick;
			// 
			// Bruchrechner_Fenster
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(BT_ROOT);
			Controls.Add(BT_POT);
			Controls.Add(BT_DIV);
			Controls.Add(BT_MULT);
			Controls.Add(BT_SUB);
			Controls.Add(BT_ADD);
			Controls.Add(Operation);
			Controls.Add(Nenner2);
			Controls.Add(Zähler2);
			Controls.Add(Nenner1);
			Controls.Add(Zähler1);
			Name = "Bruchrechner_Fenster";
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion

		private RichTextBox Zähler1;
		private RichTextBox Nenner1;
		private RichTextBox Zähler2;
		private RichTextBox Nenner2;
		private RichTextBox Operation;
		private Button BT_ADD;
		private Button BT_SUB;
		private Button BT_MULT;
		private Button BT_DIV;
		private Button BT_POT;
		private Button BT_ROOT;
	}
}