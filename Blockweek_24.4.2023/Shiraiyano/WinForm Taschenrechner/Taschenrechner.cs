namespace WinForm_Taschenrechner
{
	public partial class Taschenrechner : Form
	{
		//Boolean Flags, um zu Überprüfen, ob zuletzt ein Operator oder eine Zahl gedrückt wurde.
		bool LastClickedIsNumber = true;
		bool LastClickedIsOperator;

		double Num1;
		double Num2;

		int PrecedencePrevOp;
		int PrecedenceCurOp;
		string LastOperator;

		private int get_Precedence(string Operator)
		{
			switch(Operator)
			{
				case "+":
				case "-":
					return 1;
				case "*":
				case "/":
					return 2;
				case "x^(y)":
					return 3;
				default:
					return -1;
			}
		}
		public Taschenrechner()
		{
			InitializeComponent();
		}

		private void OperatorIstGleich_Click(object sender, EventArgs e)
		{

		}

		private void AuthorsNote_Click(object sender, EventArgs e)
		{

		}

		private void Number_Click(object sender, EventArgs e)
		{
			Button Number = (Button)sender;

			if (LastClickedIsNumber)
			{
				OutputField.Text += Number.Text;
			}
			else if (LastClickedIsOperator)
			{
				OutputField.Text = OutputField.Text.Remove(0, OutputField.Text.Length);
				OutputField.Text += Number.Text;
			}

			LastClickedIsNumber = true;
			LastClickedIsOperator = false;
		}

		private void EingabeRückgängig_Click(object sender, EventArgs e)
		{
			switch (OutputField.Text.Length)
			{
				case 0:
					break;
				default:
					OutputField.Text = OutputField.Text.Substring(0, OutputField.Text.Length - 1);
					break;
			}
		}

		private void Operator_Click(object sender, EventArgs e)
		{
			Button Operator = (Button)sender;
			PrecedenceCurOp = get_Precedence(Operator.Text);

			if (LastClickedIsNumber)
			{
				if(PrecedenceCurOp < PrecedencePrevOp || PrecedenceCurOp == PrecedencePrevOp)
				{

				}

				PreviouslyEntered.Text += " " + OutputField.Text + " " + Operator.Text;
				LastOperator = Operator.Text;
			}
			else if (LastClickedIsOperator)
			{
				OutputField.Text = OutputField.Text.Substring(0, OutputField.Text.Length - LastOperator.Length) + Operator.Text;
				LastOperator = Operator.Text;
			}

			LastClickedIsNumber = false;
			LastClickedIsOperator = true;
		}

		private void LöschenCE_Click(object sender, EventArgs e)
		{
			if (OutputField.Text.Length == 0)
			{
				PreviouslyEntered.Text = PreviouslyEntered.Text.Remove(0, PreviouslyEntered.Text.Length);
			}
			OutputField.Text = OutputField.Text.Remove(0, OutputField.Text.Length);

		}
	}
}