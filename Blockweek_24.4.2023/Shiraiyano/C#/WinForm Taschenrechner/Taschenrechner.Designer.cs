namespace WinForm_Taschenrechner
{
	partial class Taschenrechner
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Taschenrechner));
			label1 = new Label();
			contextMenuStrip1 = new ContextMenuStrip(components);
			Zahl1 = new Button();
			Zahl2 = new Button();
			Zahl6 = new Button();
			Zahl4 = new Button();
			Zahl5 = new Button();
			Zahl3 = new Button();
			Zahl7 = new Button();
			Zahl8 = new Button();
			Zahl9 = new Button();
			Zahl0 = new Button();
			OutputField = new RichTextBox();
			OperatorPotenz = new Button();
			LöschenCE = new Button();
			OperatorQuadrat = new Button();
			OperatorKehrwert = new Button();
			OperatorQuadratwurzel = new Button();
			OperatorDivision = new Button();
			OperatorMultiplikation = new Button();
			OperatorSubtraktion = new Button();
			OperatorAddition = new Button();
			SymbolKomma = new Button();
			OperatorIstGleich = new Button();
			EingabeRückgängig = new Button();
			OperatorLog = new Button();
			OperatorFakultät = new Button();
			OperatorSin = new Button();
			OperatorCos = new Button();
			OperatorTan = new Button();
			AuthorsNote = new Label();
			PreviouslyEntered = new RichTextBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(12, 87);
			label1.Name = "label1";
			label1.Size = new Size(84, 25);
			label1.TabIndex = 0;
			label1.Text = "Eingabe:";
			// 
			// contextMenuStrip1
			// 
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.Size = new Size(61, 4);
			// 
			// Zahl1
			// 
			Zahl1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			Zahl1.Location = new Point(89, 387);
			Zahl1.Name = "Zahl1";
			Zahl1.Size = new Size(69, 54);
			Zahl1.TabIndex = 3;
			Zahl1.Text = "1";
			Zahl1.UseVisualStyleBackColor = true;
			Zahl1.Click += Number_Click;
			// 
			// Zahl2
			// 
			Zahl2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			Zahl2.Location = new Point(164, 387);
			Zahl2.Name = "Zahl2";
			Zahl2.Size = new Size(69, 54);
			Zahl2.TabIndex = 4;
			Zahl2.Text = "2";
			Zahl2.UseVisualStyleBackColor = true;
			Zahl2.Click += Number_Click;
			// 
			// Zahl6
			// 
			Zahl6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			Zahl6.Location = new Point(239, 327);
			Zahl6.Name = "Zahl6";
			Zahl6.Size = new Size(69, 54);
			Zahl6.TabIndex = 5;
			Zahl6.Text = "6";
			Zahl6.UseVisualStyleBackColor = true;
			Zahl6.Click += Number_Click;
			// 
			// Zahl4
			// 
			Zahl4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			Zahl4.Location = new Point(89, 327);
			Zahl4.Name = "Zahl4";
			Zahl4.Size = new Size(69, 54);
			Zahl4.TabIndex = 6;
			Zahl4.Text = "4";
			Zahl4.UseVisualStyleBackColor = true;
			Zahl4.Click += Number_Click;
			// 
			// Zahl5
			// 
			Zahl5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			Zahl5.Location = new Point(164, 327);
			Zahl5.Name = "Zahl5";
			Zahl5.Size = new Size(69, 54);
			Zahl5.TabIndex = 7;
			Zahl5.Text = "5";
			Zahl5.UseVisualStyleBackColor = true;
			Zahl5.Click += Number_Click;
			// 
			// Zahl3
			// 
			Zahl3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			Zahl3.Location = new Point(239, 387);
			Zahl3.Name = "Zahl3";
			Zahl3.Size = new Size(69, 54);
			Zahl3.TabIndex = 8;
			Zahl3.Text = "3";
			Zahl3.UseVisualStyleBackColor = true;
			Zahl3.Click += Number_Click;
			// 
			// Zahl7
			// 
			Zahl7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			Zahl7.Location = new Point(89, 267);
			Zahl7.Name = "Zahl7";
			Zahl7.Size = new Size(69, 54);
			Zahl7.TabIndex = 9;
			Zahl7.Text = "7";
			Zahl7.UseVisualStyleBackColor = true;
			Zahl7.Click += Number_Click;
			// 
			// Zahl8
			// 
			Zahl8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			Zahl8.Location = new Point(164, 267);
			Zahl8.Name = "Zahl8";
			Zahl8.Size = new Size(69, 54);
			Zahl8.TabIndex = 10;
			Zahl8.Text = "8";
			Zahl8.UseVisualStyleBackColor = true;
			Zahl8.Click += Number_Click;
			// 
			// Zahl9
			// 
			Zahl9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			Zahl9.Location = new Point(239, 267);
			Zahl9.Name = "Zahl9";
			Zahl9.Size = new Size(69, 54);
			Zahl9.TabIndex = 11;
			Zahl9.Text = "9";
			Zahl9.UseVisualStyleBackColor = true;
			Zahl9.Click += Number_Click;
			// 
			// Zahl0
			// 
			Zahl0.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			Zahl0.Location = new Point(164, 447);
			Zahl0.Name = "Zahl0";
			Zahl0.Size = new Size(69, 54);
			Zahl0.TabIndex = 12;
			Zahl0.Text = "0";
			Zahl0.UseVisualStyleBackColor = true;
			Zahl0.Click += Number_Click;
			// 
			// OutputField
			// 
			OutputField.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
			OutputField.Location = new Point(108, 68);
			OutputField.Name = "OutputField";
			OutputField.Size = new Size(275, 61);
			OutputField.TabIndex = 13;
			OutputField.Text = "";
			// 
			// OperatorPotenz
			// 
			OperatorPotenz.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			OperatorPotenz.Location = new Point(14, 447);
			OperatorPotenz.Name = "OperatorPotenz";
			OperatorPotenz.Size = new Size(69, 54);
			OperatorPotenz.TabIndex = 14;
			OperatorPotenz.Text = "x^(y)";
			OperatorPotenz.UseVisualStyleBackColor = true;
			// 
			// LöschenCE
			// 
			LöschenCE.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			LöschenCE.Location = new Point(239, 147);
			LöschenCE.Name = "LöschenCE";
			LöschenCE.Size = new Size(69, 54);
			LöschenCE.TabIndex = 15;
			LöschenCE.Text = "CE";
			LöschenCE.UseVisualStyleBackColor = true;
			LöschenCE.Click += LöschenCE_Click;
			// 
			// OperatorQuadrat
			// 
			OperatorQuadrat.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			OperatorQuadrat.Location = new Point(14, 327);
			OperatorQuadrat.Name = "OperatorQuadrat";
			OperatorQuadrat.Size = new Size(69, 54);
			OperatorQuadrat.TabIndex = 16;
			OperatorQuadrat.Text = "x²";
			OperatorQuadrat.UseVisualStyleBackColor = true;
			OperatorQuadrat.Click += Operator_Click;
			// 
			// OperatorKehrwert
			// 
			OperatorKehrwert.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			OperatorKehrwert.Location = new Point(14, 267);
			OperatorKehrwert.Name = "OperatorKehrwert";
			OperatorKehrwert.Size = new Size(69, 54);
			OperatorKehrwert.TabIndex = 17;
			OperatorKehrwert.Text = "1/x";
			OperatorKehrwert.UseVisualStyleBackColor = true;
			// 
			// OperatorQuadratwurzel
			// 
			OperatorQuadratwurzel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			OperatorQuadratwurzel.Location = new Point(14, 387);
			OperatorQuadratwurzel.Name = "OperatorQuadratwurzel";
			OperatorQuadratwurzel.Size = new Size(69, 54);
			OperatorQuadratwurzel.TabIndex = 18;
			OperatorQuadratwurzel.Text = "(y)√x";
			OperatorQuadratwurzel.UseVisualStyleBackColor = true;
			// 
			// OperatorDivision
			// 
			OperatorDivision.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			OperatorDivision.Location = new Point(314, 207);
			OperatorDivision.Name = "OperatorDivision";
			OperatorDivision.Size = new Size(69, 54);
			OperatorDivision.TabIndex = 19;
			OperatorDivision.Text = "÷";
			OperatorDivision.UseVisualStyleBackColor = true;
			OperatorDivision.Click += Operator_Click;
			// 
			// OperatorMultiplikation
			// 
			OperatorMultiplikation.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			OperatorMultiplikation.Location = new Point(314, 267);
			OperatorMultiplikation.Name = "OperatorMultiplikation";
			OperatorMultiplikation.Size = new Size(69, 54);
			OperatorMultiplikation.TabIndex = 20;
			OperatorMultiplikation.Text = "×";
			OperatorMultiplikation.UseVisualStyleBackColor = true;
			OperatorMultiplikation.Click += Operator_Click;
			// 
			// OperatorSubtraktion
			// 
			OperatorSubtraktion.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			OperatorSubtraktion.Location = new Point(314, 327);
			OperatorSubtraktion.Name = "OperatorSubtraktion";
			OperatorSubtraktion.Size = new Size(69, 54);
			OperatorSubtraktion.TabIndex = 21;
			OperatorSubtraktion.Text = "-";
			OperatorSubtraktion.UseVisualStyleBackColor = true;
			OperatorSubtraktion.Click += Operator_Click;
			// 
			// OperatorAddition
			// 
			OperatorAddition.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			OperatorAddition.Location = new Point(314, 387);
			OperatorAddition.Name = "OperatorAddition";
			OperatorAddition.Size = new Size(69, 54);
			OperatorAddition.TabIndex = 22;
			OperatorAddition.Text = "+";
			OperatorAddition.UseVisualStyleBackColor = true;
			OperatorAddition.Click += Operator_Click;
			// 
			// SymbolKomma
			// 
			SymbolKomma.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			SymbolKomma.Location = new Point(239, 447);
			SymbolKomma.Name = "SymbolKomma";
			SymbolKomma.Size = new Size(69, 54);
			SymbolKomma.TabIndex = 23;
			SymbolKomma.Text = ",";
			SymbolKomma.UseVisualStyleBackColor = true;
			// 
			// OperatorIstGleich
			// 
			OperatorIstGleich.BackColor = SystemColors.Highlight;
			OperatorIstGleich.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			OperatorIstGleich.Location = new Point(314, 447);
			OperatorIstGleich.Name = "OperatorIstGleich";
			OperatorIstGleich.Size = new Size(69, 54);
			OperatorIstGleich.TabIndex = 24;
			OperatorIstGleich.Text = "=";
			OperatorIstGleich.UseVisualStyleBackColor = false;
			OperatorIstGleich.Click += OperatorIstGleich_Click;
			// 
			// EingabeRückgängig
			// 
			EingabeRückgängig.BackColor = SystemColors.ControlDark;
			EingabeRückgängig.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			EingabeRückgängig.Location = new Point(314, 147);
			EingabeRückgängig.Name = "EingabeRückgängig";
			EingabeRückgängig.Size = new Size(69, 54);
			EingabeRückgängig.TabIndex = 26;
			EingabeRückgängig.Text = "←";
			EingabeRückgängig.UseVisualStyleBackColor = false;
			EingabeRückgängig.Click += EingabeRückgängig_Click;
			// 
			// OperatorLog
			// 
			OperatorLog.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			OperatorLog.Location = new Point(89, 447);
			OperatorLog.Name = "OperatorLog";
			OperatorLog.Size = new Size(69, 54);
			OperatorLog.TabIndex = 27;
			OperatorLog.Text = "log";
			OperatorLog.UseVisualStyleBackColor = true;
			OperatorLog.Click += Operator_Click;
			// 
			// OperatorFakultät
			// 
			OperatorFakultät.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			OperatorFakultät.Location = new Point(239, 207);
			OperatorFakultät.Name = "OperatorFakultät";
			OperatorFakultät.Size = new Size(69, 54);
			OperatorFakultät.TabIndex = 28;
			OperatorFakultät.Text = "!";
			OperatorFakultät.UseVisualStyleBackColor = true;
			// 
			// OperatorSin
			// 
			OperatorSin.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			OperatorSin.Location = new Point(14, 207);
			OperatorSin.Name = "OperatorSin";
			OperatorSin.Size = new Size(69, 54);
			OperatorSin.TabIndex = 29;
			OperatorSin.Text = "Sin";
			OperatorSin.UseVisualStyleBackColor = true;
			OperatorSin.Click += Operator_Click;
			// 
			// OperatorCos
			// 
			OperatorCos.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			OperatorCos.Location = new Point(89, 207);
			OperatorCos.Name = "OperatorCos";
			OperatorCos.Size = new Size(69, 54);
			OperatorCos.TabIndex = 30;
			OperatorCos.Text = "Cos";
			OperatorCos.UseVisualStyleBackColor = true;
			OperatorCos.Click += Operator_Click;
			// 
			// OperatorTan
			// 
			OperatorTan.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			OperatorTan.Location = new Point(164, 207);
			OperatorTan.Name = "OperatorTan";
			OperatorTan.Size = new Size(69, 54);
			OperatorTan.TabIndex = 31;
			OperatorTan.Text = "Tan";
			OperatorTan.UseVisualStyleBackColor = true;
			OperatorTan.Click += Operator_Click;
			// 
			// AuthorsNote
			// 
			AuthorsNote.AutoSize = true;
			AuthorsNote.BorderStyle = BorderStyle.FixedSingle;
			AuthorsNote.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			AuthorsNote.Location = new Point(14, 156);
			AuthorsNote.Name = "AuthorsNote";
			AuthorsNote.Size = new Size(143, 32);
			AuthorsNote.TabIndex = 33;
			AuthorsNote.Text = "Taschenrechner made by \r\nShiraiyano\r\n";
			AuthorsNote.Click += AuthorsNote_Click;
			// 
			// PreviouslyEntered
			// 
			PreviouslyEntered.BackColor = SystemColors.InactiveCaption;
			PreviouslyEntered.Location = new Point(14, 12);
			PreviouslyEntered.Name = "PreviouslyEntered";
			PreviouslyEntered.ReadOnly = true;
			PreviouslyEntered.Size = new Size(369, 50);
			PreviouslyEntered.TabIndex = 34;
			PreviouslyEntered.Text = "";
			// 
			// Taschenrechner
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(395, 513);
			Controls.Add(PreviouslyEntered);
			Controls.Add(AuthorsNote);
			Controls.Add(OperatorTan);
			Controls.Add(OperatorCos);
			Controls.Add(OperatorSin);
			Controls.Add(OperatorFakultät);
			Controls.Add(OperatorLog);
			Controls.Add(EingabeRückgängig);
			Controls.Add(OperatorIstGleich);
			Controls.Add(SymbolKomma);
			Controls.Add(OperatorAddition);
			Controls.Add(OperatorSubtraktion);
			Controls.Add(OperatorMultiplikation);
			Controls.Add(OperatorDivision);
			Controls.Add(OperatorQuadratwurzel);
			Controls.Add(OperatorKehrwert);
			Controls.Add(OperatorQuadrat);
			Controls.Add(LöschenCE);
			Controls.Add(OperatorPotenz);
			Controls.Add(OutputField);
			Controls.Add(Zahl0);
			Controls.Add(Zahl9);
			Controls.Add(Zahl8);
			Controls.Add(Zahl7);
			Controls.Add(Zahl3);
			Controls.Add(Zahl5);
			Controls.Add(Zahl4);
			Controls.Add(Zahl6);
			Controls.Add(Zahl2);
			Controls.Add(Zahl1);
			Controls.Add(label1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "Taschenrechner";
			Text = "Taschenerchner";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox textBox1;
		private ContextMenuStrip contextMenuStrip1;
		private Button Zahl7;
		private Button Zahl8;
		private Button Zahl1;
		private Button Zahl2;
		private Button Zahl6;
		private Button Zahl4;
		private Button Zahl5;
		private Button Zahl3;
		private Button button5;
		private Button button6;
		private Button Zahl9;
		private Button Zahl0;
		private RichTextBox OutputField;
		private Button OperatorPotenz;
		private Button LöschenCE;
		private Button OperatorQuadrat;
		private Button OperatorKehrwert;
		private Button OperatorQuadratwurzel;
		private Button OperatorDivision;
		private Button OperatorMultiplikation;
		private Button OperatorSubtraktion;
		private Button OperatorAddition;
		private Button SymbolKomma;
		private Button OperatorIstGleich;
		private Button EingabeRückgängig;
		private Button OperatorLog;
		private Button OperatorFakultät;
		private Button OperatorSin;
		private Button OperatorCos;
		private Button OperatorTan;
		private Label AuthorsNote;
		private RichTextBox PreviouslyEntered;
	}
}