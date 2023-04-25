using System.Numerics;

/* 
 * ANMERKUNG DES AUTHORS (Shiraiyano): 
 * 
 * Dieser Code wurde mit Unterstützung meiner Kollegen realisiert, deren Code mir das 
 * notwendige Verständnis gaben, um diese Aufgabe abzuschließen.
 * 
 * Der Goßteil meiner anfänglich geplanten und getesteten Features wurden nicht implementiert, z.B eine komplexe Eingabe mit mehreren Zahlen und Rechenoperatoren, 
 * die dafür benötigte Logik zum erkennen und resolven der Operator-Rangfolge, oder eine komplexe Logik zum handlen verschiedener Eingaben (Abgekürzt: Wann darf welche 
 * Eingabe Wie gemacht werden.) mittels boolean Flags - einzige Überbleibsel sind die Flags "Vorzeichen Negativ" und ein rudimentäres "KommaVorhanden".
 * 
 * Grund für die Entfernung der Features und Flags war die immer größer werdende Übersättigung des Codes - nach jedem Click folgte ein
 * Check mit ein oder zwei if-Abfragen, gefolgt von Abfragen von ein bis vier Flags, die allesamt wieder resettet werden mussten, oder auch nicht!
 * 
 * Plötzlich mussten dann also in jedem switch-case Statement Flags beachtet werden, und ab dem Zeitpunkt entschied ich mich für eine Refactoring.
 */

namespace WinForm_Taschenrechner
{
	public partial class Taschenrechner : Form
	{
		// number1 ist die erste eingegeben Zahl, number2 die (wenn notwendige) Zweite.
		private double number1 = 0;
		private double number2 = 0;

		// Mithilfe des im String gespeicherten Operators wird die richtige Rechenoperation aus der Klasse "Calculator ausgewählt.
		private string operation = "";

		// Übriggebliebene Flags, durch die das Vorhandensen von Vorzeichen und Komma überprüft werden - kann durch
		// Refactoring u.U. (also mit ziemlicher Sicherheit) wegfallen.
		bool VorzeichenNegativ = false;
		bool KommaVorhanden = false;

		public Taschenrechner()
		{
			InitializeComponent();
		}

		// Selbsterklärend (Hoffentlich). Ein Click-Event für alle Zahlen.
		private void Number_Click(object sender, EventArgs e)
		{
			Button Number = (Button)sender;
			InputField.Text += Number.Text;

		}

		// Ermöglicht die Eingabe eines negativen Vorzeichens. Ist eines vorhanden, wir dieses gelöscht
		private void VorzeichenSwitch_Click(object sender, EventArgs e)
		{
			if (InputField.Text.Length > 0 && !VorzeichenNegativ)
			{
				InputField.Text = "-" + InputField.Text;
				VorzeichenNegativ = true;
			}
			else
			{
				InputField.Text = InputField.Text.TrimStart('-');
				VorzeichenNegativ = false;
			}
		}

		// Ermöglicht die Eingabe eines Kommas. Ist eines vorhanden, wird dieses gelöscht
		private void KommaClick(object sender, EventArgs e)
		{
			if (InputField.Text.Length > 0 && !KommaVorhanden)
			{
				InputField.Text += ",";
				KommaVorhanden = true;
			}
			else
			{
				InputField.Text = InputField.Text.TrimEnd(',');
				KommaVorhanden = false;
			}
		}

		// Bei Klick wird die erste Zahl an number1 assigned, anschließend wird Operator an "operation" string assigned.
		// Danach wird die erste Zahl mit dem Operator an die eine Textbox übergeben, um die Übersicht zu wahren.
		private void Operator_Click(object sender, EventArgs e)
		{
			try
			{
				Button Operator = (Button)sender;
				number1 = double.Parse(InputField.Text);
				operation = Operator.Text;
				PreviousEntries.Text += InputField.Text + " " + Operator.Text;
				InputField.Text = "";
				KommaVorhanden = false;
				bool VorzeichenNegativ = false;
			}
			catch
			{
				MessageBox.Show("Error: Operatoreingabe ist hier nicht zulässig!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				InputField.Text = "";
				return;
			}
		}

		// Setzt das Ergebnis auf Null. Wenn zweite Zahl vorhanden, wird diese für Berechnung herangezogen.
		// Mittels switch statements wird die richtige Rechenoperation ausgewählt.
		private void IstGleich_Click(object sender, EventArgs e)
		{
			double result = 0;

			if (InputField.Text.Length > 0)
			{
				number2 = double.Parse(InputField.Text);
				PreviousEntries.Text += " " + InputField.Text;
			}

			try
			{
				switch (operation)
				{
					case "+":
						result = Calculator.Add(number1, number2);
						break;
					case "-":
						result = Calculator.Subtract(number1, number2);
						break;
					case "×":
						result = Calculator.Multiply(number1, number2);
						break;
					case "÷":
						try
						{
							result = Calculator.Divide(number1, number2);
						}
						catch (DivideByZeroException ex)
						{
							MessageBox.Show(ex.Message, "Division durch Null (0) nicht möglich!", MessageBoxButtons.OK, MessageBoxIcon.Error);
							InputField.Text = "";
							return;
						}
						break;
					case "x^y":
						result = Calculator.Power(number1, number2);
						break;
					case "x√y":
						result = Calculator.Root(number1);
						break;
					// Wenn zweite Zahl vorhanden, wird ein Log zur Basis number2 erstellt, ansonsten Log zur Basis 10
					case "log_(x)y":
						if (number2 != 0)
						{
							result = Calculator.Log(number1, number2);
						}
						else
						{
							result = Calculator.Log10(number1);
						}
						break;
					case "!":
						result = Calculator.Factorial(number1);
						break;
					case "Sin":
						result = Calculator.Sin(number1);
						break;
					case "Cos":
						result = Calculator.Cos(number1);
						break;
					case "Tan":
						result = Calculator.Tan(number1);
						break;
				}
				Ergebnis.Text = result.ToString();
				PreviousEntries.Text = "";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Auflösung nicht möglich!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				InputField.Text = "";
				return;
			}
		}

		// Löscht die zuletzt eingegebene Ziffer
		private void EingabeRückgängig_Click(object sender, EventArgs e)
		{
			switch (InputField.Text.Length)
			{
				case 0:
					break;
				default:
					InputField.Text = InputField.Text.Remove(InputField.Text.Length - 1, 1);
					break;
			}
		}

		//Funktioniert hier als komplette Löschfunktion.
		//Ursprünglich hätte die Eingabe gelöscht werden sollen, dann die
		//Zwischenübersicht, dann das Endergebnis. Aufgrund Implementierungsschwierigkeiten wird
		//auf eine vereinfachte Variante zurückgegriffen.
		private void LöschenCE_Click(object sender, EventArgs e)
		{
			InputField.Text = "";
			PreviousEntries.Text = "";

			number1 = 0;
			number2 = 0;
		}
	}
}