namespace Taschenrechner
{
    public partial class Default : Form
    {
        private Calculations calculations = new Calculations();
        private char lastOperation;
        private double firstnumber;
        private double secondnumber;

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

        private void btnKlammerSchliesen_Click(object sender, EventArgs e)
        {
            outputField.Text += ")";
        }

        private void btnKlammerOeffnen_Click(object sender, EventArgs e)
        {
            outputField.Text += "(";
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            outputField.Text += ".";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            OnOperation('+');
        }

        private bool checkLastOperation()
        {
            if (lastOperation != null)
                return true;
            else
                return false;
        }

        private void OnOperation(char op)
        {
            outputField.Text += " " + op + "\n";

            string firstLine = outputField.Lines[0];

            outputField.Select(outputField.GetFirstCharIndexFromLine(0), firstLine.Length);
            outputField.SelectionColor = Color.Gray;
        }
    }
}