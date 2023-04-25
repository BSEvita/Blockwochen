using System.Diagnostics.Eventing.Reader;

namespace Taschenrechner
{
    public partial class Default : Form
    {
        private Calculations calculations = new Calculations();
        private double firstnumber;
        private double secondnumber;
        private bool isSecondNumber = false;
        private double lastAnswer;
        private char lastOperator;

        public Default()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnEquals.BackColor = Color.DeepSkyBlue;
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

        public String getRechnerValue()
        {
            return outputField.Text;
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
            outputField.Text += ".";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            outputField.Clear();
            firstCalculationBox.Clear();
            ergebnisBox.Clear();
            firstnumber = new double();
            secondnumber = new double();
            lastAnswer = new double();
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

        private void OnOperation(char op)
        {
            string Line;

            Calculations calculations = new Calculations();

            try
            {
                Line = outputField.Lines[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            if (lastAnswer != 0.0)
            {
                double answer = Convert.ToDouble(Line.Replace(".", ","));

                calculations.Equate(op, lastAnswer, answer);

                outputField.Clear();

                ergebnisBox.Clear();

                ergebnisBox.Text += calculations.Result;
                lastAnswer = calculations.Result;
            }

            if (isSecondNumber)
            {
                outputField.Clear();
                isSecondNumber = false;
                secondnumber = Convert.ToDouble(Line.Replace(".", ","));

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
                lastAnswer = calculations.Result;
            }
            else
            {
                if (lastOperator != null)
                {
                    firstCalculationBox.Clear();
                    lastOperator = new char();
                }

                isSecondNumber = true;
                secondnumber = new double();
                firstnumber = Convert.ToDouble(Line.Replace(".", ","));
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
            OnOperation('2');
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

        private void btnPot_Click(object sender, EventArgs e)
        {
            OnOperation('p');
        }

        private void btnWurzel_Click(object sender, EventArgs e)
        {
            OnOperation('w');
        }

        private void ergebnisBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}