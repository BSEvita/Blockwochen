using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Taschenrechner
{
    public partial class Default : Form
    {
        private Calculations calculations = new Calculations();
        private double firstnumber;
        private double secondnumber;
        private bool isSecondNumber = false;
        private char lastOperator;

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (outputField.Text.Length == 0)
                return;

            outputField.Text = outputField.Text.Remove(outputField.Text.Length - 1, 1);
        }

        private void outputField_TextChanged(object sender, EventArgs e)
        {
            outputField.SelectionStart = outputField.Text.Length;
            outputField.ScrollToCaret();
        }

        private void firstCalculationBox_TextChanged(object sender, EventArgs e)
        {
            firstCalculationBox.SelectionStart = firstCalculationBox.Text.Length;
            firstCalculationBox.ScrollToCaret();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            outputField.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            outputField.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            outputField.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            outputField.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            outputField.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            outputField.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            outputField.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            outputField.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            outputField.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            outputField.Text += "9";
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            outputField.Text += ",";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            outputField.Clear();
            firstCalculationBox.Clear();
            ergebnisBox.Clear();
            firstnumber = new double();
            secondnumber = new double();
        }

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

        private async void OnOperation(char op)
        {
            string Line;

            Calculations calculations = new Calculations();

            if (op == 'p')
            {
                Eingabe eingabe = new Eingabe();
                eingabe.Show();

                while (!dataReceived)
                {
                    if (eingabe.IsDisposed)
                        return;
                    await Task.Delay(25);
                }
                eingabe.Hide();

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
                Line = outputField.Lines[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bitte geben Sie Zahlen ein.", "Fehler: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (op)
            {
                case 'w':
                    {
                        double number = Convert.ToDouble(Line);
                        outputField.Clear();
                        ergebnisBox.Clear();
                        firstCalculationBox.Clear();

                        outputField.Text += "√(" + number + ")";

                        firstCalculationBox.Text += "√(" + number + ")";

                        calculations.Equate(op, number, 0.0);

                        outputField.Clear();
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

            if (isSecondNumber)
            {
                outputField.Clear();
                isSecondNumber = false;
                secondnumber = Convert.ToDouble(Line);

                if (firstCalculationBox.Text.Length < 0)
                    firstCalculationBox.Text += secondnumber + " " + op;
                else if (op == '=')
                {
                    firstCalculationBox.Text += " " + secondnumber;
                    op = lastOperator;
                }
                else
                    firstCalculationBox.Text += " " + secondnumber + " " + op;
                calculations.Equate(op, firstnumber, secondnumber);

                outputField.Clear();
                ergebnisBox.Clear();

                ergebnisBox.Text += calculations.Result;
            }
            else
            {

                firstCalculationBox.Clear();
                isSecondNumber = true;
                secondnumber = new double();
                firstnumber = Convert.ToDouble(Line);
                outputField.Clear();

                if (firstCalculationBox.Text.Length < 0)
                    firstCalculationBox.Text += firstnumber + " " + op;
                else
                    firstCalculationBox.Text += " " + firstnumber + " " + op;

                lastOperator = op;
            }
        }

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

        private void ergebnisBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            OnOperation('!');
        }
    }
}