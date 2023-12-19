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

        private void StuffChanged(object sender, EventArgs e)
        {
            CalculateResult();
        }

        private void CalculateResult()
        {
            if (outputBinaryRadioButton.Checked || outputOctalRadioButton.Checked || outputDecimalRadioButton.Checked || outputHexadecimalRadioButton.Checked)
            {
                ConvertAndDisplayResult(() =>
                {
                    var result = NumberConverter.Convert(number1.Text, GetInputBaseValue(), GetOutputBaseValue());
                    return result;
                });
            }
            else
            {
                resultTextBox.Text = string.Empty;
            }
        }

        private int GetInputBaseValue()
        {
            if (inputBinaryRadioButton.Checked)
            {
                return 2;
            }
            else if (inputOctalRadioButton.Checked)
            {
                return 8;
            }
            else if (inputDecimalRadioButton.Checked)
            {
                return 10;
            }
            else if (inputHexadecimalRadioButton.Checked)
            {
                return 16;
            }
            else
            {
                throw new InvalidOperationException("Invalid number system.");
            }
        }

        private int GetOutputBaseValue()
        {
            if (outputBinaryRadioButton.Checked)
            {
                return 2;
            }
            else if (outputOctalRadioButton.Checked)
            {
                return 8;
            }
            else if (outputDecimalRadioButton.Checked)
            {
                return 10;
            }
            else if (outputHexadecimalRadioButton.Checked)
            {
                return 16;
            }
            else
            {
                throw new InvalidOperationException("Invalid number system.");
            }
        }

        private void ConvertAndDisplayResult(Func<string> conversion)
        {
            try
            {
                var result = conversion();
                resultTextBox.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}