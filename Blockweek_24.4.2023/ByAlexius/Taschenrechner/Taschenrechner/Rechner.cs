using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Taschenrechner
{
    public partial class Default : Form
    {
        // Inistialization der Variablen
        private Calculations calculations = new Calculations();
        private double firstnumber;
        private double secondnumber;
        private bool isSecondNumber = false;
        private char lastOperator;

        // Globale Variablen
        public static string Title { get; set; }
        public static double receivedNumberOne { get; set; }
        public static double receivedNumberTwo { get; set; }
        public static bool dataReceived { get; set; }

        public Default()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnEquals.BackColor = Color.DeepSkyBlue;
            Title = "Bitte Zahlen Eingeben";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            OnOperation('=');
        }

        // Code für den Delete button
        // Löscht ein Zeichen
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (outputField.Text.Length == 0)
                return;

            outputField.Text = outputField.Text.Remove(outputField.Text.Length - 1, 1);
        }

        // Auto Scroll für das Große Feld
        private void outputField_TextChanged(object sender, EventArgs e)
        {
            outputField.SelectionStart = outputField.Text.Length;
            outputField.ScrollToCaret();
        }

        // Auto Scroll für die Ausgabe der Rechnung
        private void firstCalculationBox_TextChanged(object sender, EventArgs e)
        {
            firstCalculationBox.SelectionStart = firstCalculationBox.Text.Length;
            firstCalculationBox.ScrollToCaret();
        }

        // Fügt eine Zahl um OutputField hinzu
        private void btn0_Click(object sender, EventArgs e)
        {
            outputField.Text += "0";
        }

        // Fügt eine Zahl um OutputField hinzu
        private void btn1_Click(object sender, EventArgs e)
        {
            outputField.Text += "1";
        }

        // Fügt eine Zahl um OutputField hinzu
        private void btn2_Click(object sender, EventArgs e)
        {
            outputField.Text += "2";
        }

        // Fügt eine Zahl um OutputField hinzu
        private void btn3_Click(object sender, EventArgs e)
        {
            outputField.Text += "3";
        }

        // Fügt eine Zahl um OutputField hinzu
        private void btn4_Click(object sender, EventArgs e)
        {
            outputField.Text += "4";
        }

        // Fügt eine Zahl um OutputField hinzu
        private void btn5_Click(object sender, EventArgs e)
        {
            outputField.Text += "5";
        }

        // Fügt eine Zahl um OutputField hinzu
        private void btn6_Click(object sender, EventArgs e)
        {
            outputField.Text += "6";
        }

        // Fügt eine Zahl um OutputField hinzu
        private void btn7_Click(object sender, EventArgs e)
        {
            outputField.Text += "7";
        }

        // Fügt eine Zahl um OutputField hinzu
        private void btn8_Click(object sender, EventArgs e)
        {
            outputField.Text += "8";
        }

        // Fügt eine Zahl um OutputField hinzu
        private void btn9_Click(object sender, EventArgs e)
        {
            outputField.Text += "9";
        }

        // Fügt ein Komma um OutputField hinzu
        private void btnComma_Click(object sender, EventArgs e)
        {
            outputField.Text += ",";
        }

        // Löscht alle Felder und setzt fistnumber und secondnumber zurück
        private void btnC_Click(object sender, EventArgs e)
        {
            outputField.Clear();
            firstCalculationBox.Clear();
            ergebnisBox.Clear();
            firstnumber = new double();
            secondnumber = new double();
        }

        // Löscht nur das OutputField und entweder die secondnumber oder die firstnumber zurück
        private void bntCE_Click(object sender, EventArgs e)
        {
            outputField.Clear();

            if (isSecondNumber)
            {
                secondnumber = new double();
            }
            else
            {
                firstnumber = new double();
            }
        }

        // Die methode handelt alle aufgerufenen Operationen
        private async void OnOperation(char op)
        {
            string Line;

            // Neue instanz der Klasse Calculations
            Calculations calculations = new Calculations();

            // Das Potenzieren wir vor allen anderen gehandelt weil Sie keine eigentragenen wert in dem OutputField braucht.
            if (op == 'p')
            {
                // Neues forms window öffnen
                Eingabe eingabe = new Eingabe();
                eingabe.ShowDialog();

                // while loop bis im anderen Fenster auf den "Rechnen" button gedrückt wird.
                while (!dataReceived)
                {
                    if (eingabe.IsDisposed)
                        return;
                    // Ein Delay, ich weiß nicht mehr ganz warum aber ich glaub irgendwas wegen der Performance
                    await Task.Delay(25);
                }
                // forms window schliesen
                eingabe.Hide();

                // Hier wird gerechnet und die Texte in die Felder eingefügt.
                double firstNumber = receivedNumberOne;
                double lastNumber = receivedNumberTwo;
                outputField.Clear();
                ergebnisBox.Clear();
                firstCalculationBox.Clear();
                outputField.Text += firstNumber + " ^ " + lastNumber;
                firstCalculationBox.Text += firstNumber + " ^ " + lastNumber;

                calculations.Equate(op, firstNumber, lastNumber);

                outputField.Clear();
                ergebnisBox.Text += calculations.Result;

                receivedNumberOne = new double();
                receivedNumberTwo = new double();
                dataReceived = false;

                return;
            }

            try
            {
                // Hier wird die erste Zahl auf dem OutputField geholt.
                Line = outputField.Lines[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bitte geben Sie eine Rechnung ein.", "Fehler: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hier noch ein switch case weil ich manche funktionen anders Handel muss als die Normal wie zbs. Dividieren, etc.
            // Der code ist nur beim ersten Case dokumentiert weil er überal gleich ist
            switch (op)
            {
                case 'w':
                    {
                        // Hier wird die nummer convertiert.
                        double number = Convert.ToDouble(Line);
                        // Die Felder werden geCleared
                        outputField.Clear();
                        ergebnisBox.Clear();
                        firstCalculationBox.Clear();

                        // Es wird die Rechnung in die Felder eingetragen
                        outputField.Text += "√(" + number + ")";

                        firstCalculationBox.Text += "√(" + number + ")";

                        // Das Ergebnis wird errechnet
                        calculations.Equate(op, number, 0.0);

                        outputField.Clear();

                        // Das Ergebnis wird eingetragen
                        ergebnisBox.Text += calculations.Result;
                        return;
                    }

                case 'q':
                    {
                        double number = Convert.ToDouble(Line);
                        outputField.Clear();
                        ergebnisBox.Clear();
                        firstCalculationBox.Clear();

                        outputField.Text += "sqr(" + number + ")";

                        firstCalculationBox.Text += "sqr(" + number + ")";

                        calculations.Equate(op, number, 0.0);

                        outputField.Clear();
                        ergebnisBox.Text += calculations.Result;
                        return;
                    }

                case 'l':
                    {
                        double number = Convert.ToDouble(Line);
                        outputField.Clear();
                        ergebnisBox.Clear();
                        firstCalculationBox.Clear();
                        outputField.Text += "log(" + number + ")";

                        firstCalculationBox.Text += "log(" + number + ")";

                        calculations.Equate(op, number, 0.0);

                        outputField.Clear();
                        ergebnisBox.Text += calculations.Result;
                        return;
                    }

                case 's':
                    {
                        double number = Convert.ToDouble(Line);
                        outputField.Clear();
                        ergebnisBox.Clear();
                        firstCalculationBox.Clear();
                        outputField.Text += "sin₀(" + number + ")";

                        firstCalculationBox.Text += "sin₀(" + number + ")";

                        calculations.Equate(op, number, 0.0);

                        outputField.Clear();
                        ergebnisBox.Text += calculations.Result;
                        return;
                    }

                case 'c':
                    {
                        double number = Convert.ToDouble(Line);
                        outputField.Clear();
                        ergebnisBox.Clear();
                        firstCalculationBox.Clear();
                        outputField.Text += "cos₀(" + number + ")";

                        firstCalculationBox.Text += "cos₀(" + number + ")";

                        calculations.Equate(op, number, 0.0);

                        outputField.Clear();
                        ergebnisBox.Text += calculations.Result;
                        return;
                    }

                case 't':
                    {
                        double number = Convert.ToDouble(Line);
                        outputField.Clear();
                        ergebnisBox.Clear();
                        firstCalculationBox.Clear();
                        outputField.Text += "tan₀(" + number + ")";

                        firstCalculationBox.Text += "tan₀(" + number + ")";

                        calculations.Equate(op, number, 0.0);

                        outputField.Clear();
                        ergebnisBox.Text += calculations.Result;
                        return;
                    }

                case '!':
                    {
                        double number = Convert.ToDouble(Line);
                        outputField.Clear();
                        ergebnisBox.Clear();
                        firstCalculationBox.Clear();
                        outputField.Text += "fact(" + number + ")";

                        firstCalculationBox.Text += "fact(" + number + ")";

                        calculations.Equate(op, number, 0.0);

                        outputField.Clear();
                        ergebnisBox.Text += calculations.Result;
                        return;
                    }

                case 'k':
                    {
                        double number = Convert.ToDouble(Line);
                        outputField.Clear();
                        ergebnisBox.Clear();
                        firstCalculationBox.Clear();
                        outputField.Text += "1/(" + number + ")";

                        firstCalculationBox.Text += "1/(" + number + ")";

                        calculations.Equate(op, number, 0.0);

                        outputField.Clear();
                        ergebnisBox.Text += calculations.Result;
                        return;
                    }
            }

            // Hier ist das Handling für Plus, Minus, Dividiert, Mal und alle anderen die kein Spezielles handling brauchen.

            if (isSecondNumber)
            {
                outputField.Clear();
                isSecondNumber = false;

                // Die nummer wird convertiert.
                secondnumber = Convert.ToDouble(Line);

                // Hier wird geschaut ob am ende der Operator angehängt wird oder nicht
                if (firstCalculationBox.Text.Length < 0)
                    firstCalculationBox.Text += secondnumber + " " + op;
                else if (op == '=')
                {
                    firstCalculationBox.Text += " " + secondnumber;
                    op = lastOperator;
                }
                else
                    firstCalculationBox.Text += " " + secondnumber + " " + op;

                // Hier wird gerechnet
                calculations.Equate(op, firstnumber, secondnumber);

                outputField.Clear();
                ergebnisBox.Clear();

                // Das Ergebnis wird gesetzt.
                ergebnisBox.Text += calculations.Result;
            }
            else
            {

                firstCalculationBox.Clear();
                isSecondNumber = true;
                secondnumber = new double();
                // Die nummer wird convertiert.
                firstnumber = Convert.ToDouble(Line);
                outputField.Clear();

                if (firstCalculationBox.Text.Length < 0)
                    firstCalculationBox.Text += firstnumber + " " + op;
                else
                    firstCalculationBox.Text += " " + firstnumber + " " + op;

                // lastOperator wird gesetzt (Ich weiß nicht mehr für was der Verwendet wird.)
                lastOperator = op;
            }
        }

        /*
         * Hier sind jetzt die OnButton Click methoden.
         * Sie rufen alle die OnOperation Methode mit dem dazugehörigen Operator auf.
         */

        private void btnPlus_Click(object sender, EventArgs e)
        {
            OnOperation('+');
        }

        private void btnDividieren_Click(object sender, EventArgs e)
        {
            OnOperation('/');
        }

        private void btnMulitplizieren_Click(object sender, EventArgs e)
        {
            OnOperation('*');
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            OnOperation('-');
        }

        private void btnPot2_Click(object sender, EventArgs e)
        {
            OnOperation('p');
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            OnOperation('t');
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            OnOperation('c');
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            OnOperation('s');
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            OnOperation('l');
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OnOperation('n');
        }

        private void btnKehrwert_Click(object sender, EventArgs e)
        {
            OnOperation('k');
        }

        private void btnQuadrat_Click(object sender, EventArgs e)
        {
            OnOperation('q');
        }

        private void btnWurzel_Click(object sender, EventArgs e)
        {
            OnOperation('w');
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            OnOperation('!');
        }
    }
}