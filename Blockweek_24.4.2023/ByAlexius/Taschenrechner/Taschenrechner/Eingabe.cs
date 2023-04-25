using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Eingabe : Form
    {
        public Eingabe()
        {
            InitializeComponent();

            titleLabel.Text = Default.Title;
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnRechnen_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumberInput.Text);
            double secondNumber = Convert.ToDouble(secondNumberInput.Text);

            Default.receivedNumberOne = firstNumber;
            Default.receivedNumberTwo = secondNumber;
            Default.dataReceived = true;
        }

        private void firstNumberInput_TextChanged(object sender, EventArgs e)
        {
            if (!IsDigit(firstNumberInput.Text))
            {
                firstNumberInput.Text.Remove(firstNumberInput.Text.Length - 1);
            }
        }

        private void secondNumberInput_TextChanged(object sender, EventArgs e)
        {

        }

        private bool IsDigit(string s)
        {
            if (s == null || s == " ")
                return false;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ',' || s[i] == '-')
                    continue;

                if ((s[i] ^ '0') > 9)
                    return false;
            }

            return true;
        }
    }
}
