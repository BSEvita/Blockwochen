namespace Zahlensytemumrechner
{
    public partial class Zahlensystemumrechner : Form
    {
        public Zahlensystemumrechner()
        {
            InitializeComponent();
        }

        private void Zahlensystemumrechner_Load(object sender, EventArgs e)
        {
            comboBoxZahlensystemNeu.Items.Clear();
            comboBoxZahlensystemNeu.Items.Add("Binär");
            comboBoxZahlensystemNeu.Items.Add("Oktal");
            comboBoxZahlensystemNeu.Items.Add("Dezimal");
            comboBoxZahlensystemNeu.Items.Add("Hexadezimal");

            comboBoxZahlensystemAlt.Items.Clear();
            comboBoxZahlensystemAlt.Items.Add("Binär");
            comboBoxZahlensystemAlt.Items.Add("Oktal");
            comboBoxZahlensystemAlt.Items.Add("Dezimal");
            comboBoxZahlensystemAlt.Items.Add("Hexadezimal");

            comboBoxAltesZahlensystem2.Items.Clear();
            comboBoxAltesZahlensystem2.Items.Add("Binär");
            comboBoxAltesZahlensystem2.Items.Add("Oktal");
            comboBoxAltesZahlensystem2.Items.Add("Dezimal");
            comboBoxAltesZahlensystem2.Items.Add("Hexadezimal");


            comboBoxRechenungsart.Items.Clear();
            comboBoxRechenungsart.Items.Add("Addition");
            comboBoxRechenungsart.Items.Add("Subtraction");
            comboBoxRechenungsart.Items.Add("Multiplikation");
            comboBoxRechenungsart.Items.Add("Division");
        }

        private void textBoxAusgabe_TextChanged(object sender, EventArgs e)
        {
            textBoxAusgabe.SelectAll();
            textBoxAusgabe.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int currentBase2;
            int currentBase;
            int newBase;

            char calcType;

            string newBaseText = comboBoxZahlensystemNeu.Text;
            string currentBaseText = comboBoxZahlensystemAlt.Text;
            string currentBaseText2 = comboBoxAltesZahlensystem2.Text;
            string input = textBoxEingabe.Text;
            string input2 = textBoxEingabe2.Text;
            string rechnungsart = comboBoxRechenungsart.Text;

            if (input == null || input.Length == 0)
            {
                MessageBox.Show("Bitte geben Sie eine Zahl an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (newBaseText)
            {
                case "Binär":
                    newBase = 2;
                    break;
                case "Oktal":
                    newBase = 8;
                    break;
                case "Dezimal":
                    newBase = 10;
                    break;
                case "Hexadezimal":
                    newBase = 16;
                    break;
                default:
                    MessageBox.Show("Bitte wählen Sie einen valide Base aus.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            switch (currentBaseText)
            {
                case "Binär":
                    currentBase = 2;
                    break;
                case "Oktal":
                    currentBase = 8;
                    break;
                case "Dezimal":
                    currentBase = 10;
                    break;
                case "Hexadezimal":
                    currentBase = 16;
                    break;
                default:
                    MessageBox.Show("Bitte wählen Sie einen valide Base aus.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            string ergebnis = Calculator.ConvertBases(input, currentBase, newBase);

            if (textBoxEingabe2.Text.Length > 0)
            {
                string ergebnis1 = Calculator.ConvertBases(input, currentBase, 10);

                string ergebnis2;

                int ergebnis2I;
                int ergebnis1I;

                switch (currentBaseText2)
                {
                    case "Binär":
                        currentBase2 = 2;
                        break;
                    case "Oktal":
                        currentBase2 = 8;
                        break;
                    case "Dezimal":
                        currentBase2 = 10;
                        break;
                    case "Hexadezimal":
                        currentBase2 = 16;
                        break;
                    default:
                        MessageBox.Show("Bitte wählen Sie einen valide Base aus.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }
                ergebnis2 = Calculator.ConvertBases(input2, currentBase2, 10);

                if (ergebnis2 == "error")
                    return;

                try
                {
                    ergebnis1I = Convert.ToInt32(ergebnis1);
                    ergebnis2I = Convert.ToInt32(ergebnis2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bitte geben Sie valide zahlen ein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                switch (rechnungsart)
                {
                    case "Addition":
                        ergebnis = Calculator.ConvertBases((ergebnis1I + ergebnis2I).ToString(), 10, newBase);
                        break;
                    case "Subtraction":
                        ergebnis = Calculator.ConvertBases((ergebnis1I - ergebnis2I).ToString(), 10, newBase);
                        break;
                    case "Multiplikation":
                        ergebnis = Calculator.ConvertBases((ergebnis1I * ergebnis2I).ToString(), 10, newBase);
                        break;
                    case "Division":
                        ergebnis = Calculator.ConvertBases((ergebnis1I / ergebnis2I).ToString(), 10, newBase);
                        break;
                    default:
                        MessageBox.Show("Bitte wählen Sie einen valide Rechnungsart aus.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

            }

            if (ergebnis == "error")
                return;

            textBoxAusgabe.Text = ergebnis;

            textBoxAusgabe.SelectAll();
            textBoxAusgabe.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void textBoxAusgabe_Clicked(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBoxAusgabe.Text);
            }
            catch (Exception ex)
            {
                return;
            }

            notifyIcon.Icon = new System.Drawing.Icon(Path.GetFullPath("symbol.ico"));
            notifyIcon.Text = "Copied the output to your Clipboard";
            notifyIcon.Visible = true;
            notifyIcon.BalloonTipTitle = "Information";
            notifyIcon.BalloonTipText = "Das Ergebnis wurde in ihr Clipboard kopiert.";
            notifyIcon.ShowBalloonTip(100);
        }
    }
}