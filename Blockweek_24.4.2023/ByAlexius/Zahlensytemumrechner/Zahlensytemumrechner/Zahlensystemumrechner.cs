namespace Zahlensytemumrechner
{
    public partial class Zahlensystemumrechner : Form
    {
        public Zahlensystemumrechner()
        {
            InitializeComponent();
        }

        // Die Methode wird beim laden des Forms aufgerufen
        // Es werden die items f�r die Operationen, etc. werden gesetzt
        private void Zahlensystemumrechner_Load(object sender, EventArgs e)
        {
            comboBoxZahlensystemNeu.Items.Clear();
            comboBoxZahlensystemNeu.Items.Add("Bin�r");
            comboBoxZahlensystemNeu.Items.Add("Oktal");
            comboBoxZahlensystemNeu.Items.Add("Dezimal");
            comboBoxZahlensystemNeu.Items.Add("Hexadezimal");

            comboBoxZahlensystemAlt.Items.Clear();
            comboBoxZahlensystemAlt.Items.Add("Bin�r");
            comboBoxZahlensystemAlt.Items.Add("Oktal");
            comboBoxZahlensystemAlt.Items.Add("Dezimal");
            comboBoxZahlensystemAlt.Items.Add("Hexadezimal");

            comboBoxAltesZahlensystem2.Items.Clear();
            comboBoxAltesZahlensystem2.Items.Add("Bin�r");
            comboBoxAltesZahlensystem2.Items.Add("Oktal");
            comboBoxAltesZahlensystem2.Items.Add("Dezimal");
            comboBoxAltesZahlensystem2.Items.Add("Hexadezimal");


            comboBoxRechenungsart.Items.Clear();
            comboBoxRechenungsart.Items.Add("Addition");
            comboBoxRechenungsart.Items.Add("Subtraction");
            comboBoxRechenungsart.Items.Add("Multiplikation");
            comboBoxRechenungsart.Items.Add("Division");
        }

        // Beim Textchange wird der Text gecentered
        private void textBoxAusgabe_TextChanged(object sender, EventArgs e)
        {
            textBoxAusgabe.SelectAll();
            textBoxAusgabe.SelectionAlignment = HorizontalAlignment.Center;
        }

        // Beim Klicken von rechnen wir die rechen operation gestartet
        private void btnCalculate_Click(object sender, EventArgs e)
        {

            // Die werden die Variablen angelegt
            int currentBase2;
            int currentBase;
            int newBase;

            // Hier werden variablen der Text aus den Text & Combo Boxen zugewiesen
            string newBaseText = comboBoxZahlensystemNeu.Text;
            string currentBaseText = comboBoxZahlensystemAlt.Text;
            string currentBaseText2 = comboBoxAltesZahlensystem2.Text;
            string input = textBoxEingabe.Text;
            string input2 = textBoxEingabe2.Text;
            string rechnungsart = comboBoxRechenungsart.Text;


            // Hier ein null / empty check
            if (input == null || input.Length == 0)
            {
                MessageBox.Show("Bitte geben Sie eine Zahl an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hier ein switch in welche Basis convertiert werden soll
            switch (newBaseText)
            {
                case "Bin�r":
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
                    MessageBox.Show("Bitte w�hlen Sie einen valide Base aus.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            // Hier ein switch f�r den ersten Text von welche Basis convertiert werden soll
            switch (currentBaseText)
            {
                case "Bin�r":
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
                    MessageBox.Show("Bitte w�hlen Sie einen valide Base aus.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            // Das ergebnis wird auf das ergebnis der Rechnungs gestetzt
            string ergebnis = Calculator.ConvertBases(input, currentBase, newBase);

            // Hier wird �berpr�ft ob eine zweite Zahl eingegeben wurde
            if (textBoxEingabe2.Text.Length > 0)
            {
                string ergebnis1 = Calculator.ConvertBases(input, currentBase, 10);

                string ergebnis2;

                int ergebnis2I;
                int ergebnis1I;

                // Hier ein switch f�r den zweiten Text von welche Basis convertiert werden soll
                switch (currentBaseText2)
                {
                    case "Bin�r":
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
                        MessageBox.Show("Bitte w�hlen Sie einen valide Base aus.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                // Ergebnis 2 wird wieder auf das ergebnis der rechnung gesetzt
                ergebnis2 = Calculator.ConvertBases(input2, currentBase2, 10);

                // Wenn das erbegnis gleich error ist wir das program gecancled
                if (ergebnis2 == "error")
                    return;

                // Es wird versucht zu Int32 zu converten
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

                // Hier ein switch f�r die Rechnungsart
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
                        MessageBox.Show("Bitte w�hlen Sie einen valide Rechnungsart aus.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

            }

            if (ergebnis == "error")
                return;

            // Das ergebnis wird in die ausgabe gesetzt
            textBoxAusgabe.Text = ergebnis;

            // der text wird zentriert
            textBoxAusgabe.SelectAll();
            textBoxAusgabe.SelectionAlignment = HorizontalAlignment.Center;
        }

        // Beim Klicken der Ausgabe Box wird der Inhalt in das Clipboard kopiert.
        // Es wird auch eine windows Toast Notification gesendet
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