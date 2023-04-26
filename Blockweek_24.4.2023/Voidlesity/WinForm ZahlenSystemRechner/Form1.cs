using System;
using System.Windows.Forms;

namespace ZahlenSystemRechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ConvertAndDisplayResult(() =>
            {
                var result = NumberConverter.Add(number1.Text, number2.Text, GetBaseValue());
                return result.ToString();
            });
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            ConvertAndDisplayResult(() =>
            {
                var result = NumberConverter.Subtract(number1.Text, number2.Text, GetBaseValue());
                return result.ToString();
            });
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            ConvertAndDisplayResult(() =>
            {
                var result = NumberConverter.Multiply(number1.Text, number2.Text, GetBaseValue());
                return result.ToString();
            });
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            ConvertAndDisplayResult(() =>
            {
                var result = NumberConverter.Divide(number1.Text, number2.Text, GetBaseValue());
                return result.ToString();
            });
        }

        private int GetBaseValue()
        {
            if (binaryRadioButton.Checked)
            {
                return 2;
            }
            else if (octalRadioButton.Checked)
            {
                return 8;
            }
            else if (decimalRadioButton.Checked)
            {
                return 10;
            }
            else if (hexadecimalRadioButton.Checked)
            {
                return 16;
            }
            else
            {
                throw new InvalidOperationException("Invalid number system.");
            }
        }

        private void ConvertAndDisplayResult(Func<string> calculation)
        {
            try
            {
                var result = calculation();
                resultTextBox.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}