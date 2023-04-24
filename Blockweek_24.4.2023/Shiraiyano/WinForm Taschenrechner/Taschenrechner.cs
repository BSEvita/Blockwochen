using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinForm_Taschenrechner
{
    public partial class Taschenrechner : Form
    {
        //Boolean Flags, um zu Überprüfen, ob zuletzt ein Operator oder eine Zahl gedrückt wurde.
        bool LastClickedIsNumber = true;
        bool LastClickedKomma = false;
        bool LastClickedIsOperator;

        double Eingabe;

        double Zwischensumme; //selbsterklärend
        double Endsumme;      //selbsterklärend

        int PrecedencePrevOp;
        int PrecedenceCurOp;

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

            if (LastClickedIsNumber || OutputField.Text.Length == 0)
            {
                OutputField.Text += Number.Text;
            }
            else if (LastClickedIsOperator && OutputField.Text.Length > 0)
            {
                OutputField.Text = OutputField.Text.Remove(0, OutputField.Text.Length);
                OutputField.Text += Number.Text;
            }

            LastClickedIsNumber = true;
            LastClickedIsOperator = false;
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
    }
}