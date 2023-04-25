using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinForm_Taschenrechner
{
	public partial class Taschenrechner : Form
	{
		//Objekt der Rechner-Logik Klasse
		private Calculations calculations = new Calculations();

		string NumberString;



		//Boolean Flags, um zu Überprüfen, ob zuletzt ein Operator oder eine Zahl gedrückt wurde.
		bool LastClickedIsNumber = true;
		bool LastClickedKomma = false;
		bool LastClickedIsTransf = false;
		bool LastClickedIsOperator;


		//Neuer Operator ersetzt bei Eingabe den vorherigen. Alter Operator wird zum Entfernen in Anzeige benötigt.
		string LastOperator;

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

			OutputField.Text += Number.Text;

			NumberString += Number.Text;

			LastClickedIsNumber = true;
			LastClickedIsOperator = false;
			LastClickedIsTransf = false;
		}

		private void SymbolKomma_Click(object sender, EventArgs e)
		{
			Button Komma = (Button)sender;
			if (LastClickedIsNumber && OutputField.Text.Length > 0 && LastClickedKomma == false)
			{
				OutputField.Text += Komma.Text;
				LastClickedKomma = true;
			}
		}

		private void Operator_Click(object sender, EventArgs e)
		{
			Button Operator = (Button)sender;

			if (LastClickedIsNumber && OutputField.Text.Length > 0)
			{
				AllPreviouslyEntered.Text += " " + OutputField.Text + " " + Operator.Text;
			}
			else if (LastClickedIsOperator && AllPreviouslyEntered.Text.Length > 0)
			{
				AllPreviouslyEntered.Text = AllPreviouslyEntered.Text.Substring(0, AllPreviouslyEntered.Text.Length - LastOperator.Length) + Operator.Text;
			}
			else if (LastClickedIsTransf)
				AllPreviouslyEntered.Text += " " + Operator.Text;

			OutputField.Text = OutputField.Text.Remove(0, OutputField.Text.Length);

			NumberString = "";

			LastOperator = Operator.Text;

			LastClickedIsNumber = false;
			LastClickedIsOperator = true;
			LastClickedKomma = false;
		}

		private void EingabeRückgängig_Click(object sender, EventArgs e)
		{
			switch (OutputField.Text.Length)
			{
				case 0:
					break;
				default:
					OutputField.Text = OutputField.Text.Remove(OutputField.Text.Length - 1, 1);
					break;
			}
		}

		private void LöschenCE_Click(object sender, EventArgs e)
		{
			if (OutputField.Text.Length == 0)
			{
				AllPreviouslyEntered.Text = AllPreviouslyEntered.Text.Remove(0, AllPreviouslyEntered.Text.Length);
			}
			OutputField.Text = OutputField.Text.Remove(0, OutputField.Text.Length);

		}

		private void OutputField_TextChanged(object sender, EventArgs e)
		{

		}

		private void NumberTransformationClick(object sender, EventArgs e)
		{
			Button NumberTransform = (Button)sender;

			if (LastClickedIsNumber && OutputField.Text.Length > 0)
			{
				switch (NumberTransform.Text)
				{
					case "Sin":
						AllPreviouslyEntered.Text += " Sin(" + NumberString + ")";
						break;
					case "Cos":
						AllPreviouslyEntered.Text += " Cos(" + NumberString + ")";
						break;
					case "Tan":
						AllPreviouslyEntered.Text += " Tan(" + NumberString + ")";
						break;
					case "x^y":
						OutputField.Text += " ^ ";
						break;
				}

				OutputField.Text = OutputField.Text.Remove(0, OutputField.Text.Length);

				LastClickedIsTransf = true;
				LastClickedIsNumber = false;
				LastClickedIsOperator = false;
			}
		}
	}
}