using System.Buffers;

namespace Bruchrechner
{
	public partial class Bruchrechner_Fenster : Form
	{ 
		// Felder zum Übernehmen der Zähler- und Nenner- Strings
		private int Zähler1_Num { get; set; }
		private int Nenner1_Num { get; set; }
		private int Zähler2_Num { get; set; }
		private int Nenner2_Num { get; set; }

		Bruch Ergebnis { get; set; }

		public Bruchrechner_Fenster()
		{
			InitializeComponent();
		}

		private void OnOperationClick(object sender, EventArgs e)
		{
			Button Operator = (Button)sender;

			Operation_Display.Text = Operator.Text;

			if (Operation_Display.Text == "√x")
			{
				Zähler2.Visible = false;
				Nenner2.Visible = false;

				Potenz.Visible = false;
				label_Exponent.Visible = false;

				label_Bruch2.Visible = false;
			}

			if (Operation_Display.Text == "x^y")
			{
				Zähler2.Visible = false;
				Nenner2.Visible = false;

				Potenz.Visible = true;
				label_Exponent.Visible = true;

				label_Bruch2.Visible = false;
			}

			// Da der Zweite Bruch trotz Auswahl des "√x" Strings nicht verschwindet, wird er hier explizit berücksichtigt
			if (Operation_Display.Text != "x^y" && Operation_Display.Text != "√x")
			{
				Zähler2.Visible = true;
				Nenner2.Visible = true;

				label_Bruch2.Visible = true;

				Potenz.Visible = false;
				label_Exponent.Visible = false;
			}
		}

		//Bei Drücken des Ist Gleich Buttons wird die Rechen-Logik aufgerufen
		private void BTN_EQUAL_Click(object sender, EventArgs e)
		{
			//Prüft, ob Operator ausgewählt wurde
			if (Operation_Display.Text == "")
			{
				MessageBox.Show("Bitte wähle einen Operator aus!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			//Übergabe des ersten Zähler und Nenners. Wirft Fehler, wenn Input keine ganze Zahl ist
			try
			{
				Zähler1_Num = Convert.ToInt32(Zähler1.Text);
				Nenner1_Num = Convert.ToInt32(Nenner1.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("In den Feldern für Zähler und Nenner dürfen nur Ganze Zahlen verwendet werden!",
				"Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Bruch Bruch_1 = new Bruch(Zähler1_Num, Nenner1_Num);

			//Für Wurzel und Potenz wird nur ein Bruch benötigt
			if (Operation_Display.Text == "√x")
			{
				//Berechnung
				Ergebnis = Bruch.Wurzel(Bruch_1);
				ErgebnisBox.Text = Ergebnis.ToString();
				return;
			}

			if (Operation_Display.Text == "x^y")
			{
				int Exponent;

				//Wirft Fehler, wenn Input keine ganze Zahl ist
				try
				{
					Exponent = Convert.ToInt32(Potenz.Text);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Bitte geben Sie einen Exponenten an!",
					"Fehler: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				//Berechnung
				Ergebnis = Bruch.Potenzieren(Bruch_1, Exponent);
				ErgebnisBox.Text = Ergebnis.ToString();
				return;
			}

			//Wirft Fehler, wenn Input keine ganze Zahl ist
			try
			{
				Zähler2_Num = Convert.ToInt32(Zähler2.Text);
				Nenner2_Num = Convert.ToInt32(Nenner2.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Zähler und Nenner des zweiten Bruchs müssen befüllt sein!",
				"Fehler: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Bruch Bruch_2 = new Bruch(Zähler2_Num, Nenner2_Num);

			//Je nach ausgewähltem Operator wird eine andere Rechen Methode ausgewählt.
			//Wirft Fehler, wenn Operator_Display.Text kein gültiger Operator ist (sollte garnicht passieren können)
			switch (Operation_Display.Text)
			{
				case "+":
					Ergebnis = Bruch.Addition(Bruch_1, Bruch_2);
					break;
				case "-":
					Ergebnis = Bruch.Subtraktion(Bruch_1, Bruch_2);
					break;
				case "×":
					Ergebnis = Bruch.Multiplikation(Bruch_1, Bruch_2);
					break;
				case "÷":
					Ergebnis = Bruch.Division(Bruch_1, Bruch_2);
					break;
				default:
					MessageBox.Show("Bitte wähle eine valide Operation aus!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
			}
			//Ergebnis wird als String an gleichnamige Textbox übergeben
			ErgebnisBox.Text = Ergebnis.ToString();
		}
	}
}