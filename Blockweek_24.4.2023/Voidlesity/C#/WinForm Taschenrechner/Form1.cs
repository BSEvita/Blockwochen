using System;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Form1 : Form
    {
        private double number1 = 0;
        private double number2 = 0;
        private string operation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNumber_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBoxInput.Text += button.Text;
        }

        private void buttonOperation_Click(object sender, EventArgs e)
        {
            try
            {
                Button button = (Button)sender;
                number1 = double.Parse(textBoxInput.Text);
                operation = button.Text;
                textBoxInput.Text = "";
            }
            catch
            {
                MessageBox.Show("Error: Syntax error." , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxInput.Text = "";
                return;
            }
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            double result = 0;

            if (!string.IsNullOrEmpty(textBoxInput.Text))
            {
                number2 = double.Parse(textBoxInput.Text);
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
                    case "*":
                        result = Calculator.Multiply(number1, number2);
                        break;
                    case "/":
                        try
                        {
                            result = Calculator.Divide(number1, number2);
                        }
                        catch (DivideByZeroException ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxInput.Text = "";
                            return;
                        }
                        break;
                    case "x²":
                        result = Calculator.Power(number1, number2);
                        break;
                    case "√":
                        result = Calculator.Root(number1);
                        break;
                    case "log":
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
                    case "sin":
                        result = Calculator.Sin(number1);
                        break;
                    case "cos":
                        result = Calculator.Cos(number1);
                        break;
                    case "tan":
                        result = Calculator.Tan(number1);
                        break;
                }
                textBoxInput.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxInput.Text = "";
                return;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = "";
            number1 = 0;
            number2 = 0;
        }
    }
}