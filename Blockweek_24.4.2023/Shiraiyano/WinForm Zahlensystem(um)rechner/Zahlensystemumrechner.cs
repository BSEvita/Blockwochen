namespace WinForm_Zahlensystem_um_rechner
{
    public partial class Zahlensystemumrechner : Form
    {
        //Zahlensystem Basis für Zahl 1, Zahl 2 und Ergebnis
        int Num1_Base { get; set; }
        int Num2_Base { get; set; }
        int Result_Base { get; set; }

        //Wird für Auswahl der Rechenmethode benötigt
        char Operator { get; set; }

        public Zahlensystemumrechner()
        {
            InitializeComponent();
        }

        private void Zahlensystem1_Click(object sender, EventArgs e)
        {
            if (RB_Binär1.Checked)
                Num1_Base = 2;

            if (RB_Oktal1.Checked)
                Num1_Base = 8;

            if (RB_Dezimal1.Checked)
                Num1_Base = 10;

            if (RB_Hexadez1.Checked)
                Num1_Base = 16;

        }

        private void Zahlensystem2_Click(object sender, EventArgs e)
        {
            if (RB_Binär2.Checked)
                Num2_Base = 2;

            if (RB_Oktal2.Checked)
                Num2_Base = 8;

            if (RB_Dezimal2.Checked)
                Num2_Base = 10;

            if (RB_Hexadez2.Checked)
                Num2_Base = 16;

        }

        private void Zahlensystem_E_Click(object sender, EventArgs e)
        {
            if (RB_E_Binär.Checked)
                Result_Base = 2;

            if (RB_E_Oktal.Checked)
                Result_Base = 8;

            if (RB_E_Dezimal.Checked)
                Result_Base = 10;

            if (RB_E_Hexadez.Checked)
                Result_Base = 16;

        }

        private void Operation_Click(object sender, EventArgs e)
        {
            if (RB_Add.Checked)
                Operator = '+';

            if (RB_Sub.Checked)
                Operator = '-';

            if (RB_Mult.Checked)
                Operator = '*';

            if (RB_Div.Checked)
                Operator = '/';

        }

        private void B_Berechnen_Click(object sender, EventArgs e)
        {

            string input1 = Box_Zahl1.Text;
            string input2 = Box_Zahl2.Text;

            string Base10_Zahl1_string;
            string Base10_Zahl2_string;

            int Base10_Zahl1_integer;
            int Base10_Zahl2_integer;

            string Converted_Final_Result_String;

            if (input1 == null || input1.Length == 0 || input2 == null || input2.Length == 0)
            {
                MessageBox.Show("Zahl 1 und Zahl 2 müssen beide befüllt sein!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Base10_Zahl1_string = BaseConverter.ConvertBases(input1, Num1_Base, 10);

            Base10_Zahl2_string = BaseConverter.ConvertBases(input2, Num2_Base, 10);

            try
            {
                Base10_Zahl1_integer = Convert.ToInt32(Base10_Zahl1_string);

                Base10_Zahl2_integer = Convert.ToInt32(Base10_Zahl2_string);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bitte geben Sie valide Zahlen ein!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (Operator)
            {
                case '+':
                    Converted_Final_Result_String = BaseConverter.ConvertBases((Base10_Zahl1_integer + Base10_Zahl2_integer).ToString(), 10, Result_Base);
                    break;

                case '-':
                    Converted_Final_Result_String = BaseConverter.ConvertBases((Base10_Zahl1_integer - Base10_Zahl2_integer).ToString(), 10, Result_Base);
                    break;

                case '*':
                    Converted_Final_Result_String = BaseConverter.ConvertBases((Base10_Zahl1_integer * Base10_Zahl2_integer).ToString(), 10, Result_Base);
                    break;

                case '/':
                    Converted_Final_Result_String = BaseConverter.ConvertBases((Base10_Zahl1_integer / Base10_Zahl2_integer).ToString(), 10, Result_Base);
                    break;

                default:
                    MessageBox.Show("Bitte wählen Sie einen valide Rechnungsart aus!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            Box_Ergebnis.Text = Converted_Final_Result_String;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel_RB1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}