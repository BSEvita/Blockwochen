using System;
using System.Windows.Forms;

namespace BruchRechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Fraction fraction1 = new Fraction(int.Parse(num1Box.Text), int.Parse(den1Box.Text));
                Fraction result;

                if (operationBox.SelectedItem.ToString() == "sqrt")
                {
                    result = Fraction.Sqrt(fraction1);
                }
                else
                {
                    Fraction fraction2 = new Fraction(int.Parse(num2Box.Text), int.Parse(den2Box.Text));
                    switch (operationBox.SelectedItem.ToString())
                    {
                        case "+":
                            result = fraction1 + fraction2;
                            break;
                        case "-":
                            result = fraction1 - fraction2;
                            break;
                        case "*":
                            result = fraction1 * fraction2;
                            break;
                        case "/":
                            result = fraction1 / fraction2;
                            break;
                        case "x²":
                            result = fraction1 ^ int.Parse(num2Box.Text);
                            break;
                        default:
                            result = new Fraction(0, 0);
                            break;
                    }
                }

                resultBox.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}