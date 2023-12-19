namespace Bruchrechner
{
    public partial class Bruchrechner : Form
    {
        private int nenner1 { get; set; }
        private int nenner2 { get; set; }
        private int zaehler1 { get; set; }
        private int zaehler2 { get; set; }
        private Calculator result { get; set; }


        public Bruchrechner()
        {
            InitializeComponent();
        }

        // Die Methode wird beim laden des Forms aufgerufen
        // Es werden zwei Items auf Invisible gestellt
        // und die items für die Operation werden gesetzt
        private void Bruchrechner_Load(object sender, EventArgs e)
        {
            potenzLabel.Visible = false;
            textBoxPotenz.Visible = false;

            operations.Items.Clear();
            operations.Items.Add("Addition");
            operations.Items.Add("Subtraktion");
            operations.Items.Add("Multiplikation");
            operations.Items.Add("Division");
            operations.Items.Add("Potenzieren");
            operations.Items.Add("Wurzel ziehen");

        }

        // Beim drücken des Rechnen Buttons wird diese Methode ausgeführt
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Null Check für das Item der Operation
            if (operations.SelectedItem == null)
            {
                MessageBox.Show("Bitte wähle eine valide Operation aus!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedMode = operations.SelectedItem.ToString();
            int potenz;

            // verucht die zwei Text Boxen zu Int32 zu Convertieren
            try
            {
                nenner1 = Convert.ToInt32(textBoxNennerEins.Text);
                zaehler1 = Convert.ToInt32(textBoxZählerEins.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bitte geben Sie valide Werte ein!", "Fehler: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hier wird das erste mal gerechnet
            Calculator calculator1 = new Calculator(zaehler1, nenner1);

            // Hier wird das Wurzel Ziehen berechnet und in das result eingesetzt.
            if (selectedMode == "Wurzel ziehen")
            {
                result = Calculator.sqrt(calculator1);
                textBoxErgebnis.Text = result.ToString();
                return;
            }

            // Hier wird das Potenzieren berechnet und in das result eingesetzt.
            if (selectedMode == "Potenzieren")
            {
                // Es wird versucht die Potenz in Int32 zu Convertieren
                try
                {
                    potenz = Convert.ToInt32(textBoxPotenz.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bitte geben Sie valide Werte ein!", "Fehler: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                result = Calculator.Exponentiate(calculator1, potenz);
                textBoxErgebnis.Text = result.ToString();
                return;
            }

            // verucht die zwei Text Boxen zu Int32 zu Convertieren
            try
            {
                zaehler2 = Convert.ToInt32(textBoxZählerZwei.Text);
                nenner2 = Convert.ToInt32(textBoxNennerZwei.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bitte geben Sie valide Werte ein!", "Fehler: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Hier wird die zweite Rechnung gerechnet
            Calculator calculator2 = new Calculator(zaehler2, nenner2);

            // Switch case für die restlichen Operationen
            // das ergebnis wird dann in die result variable eingesetzt.
            switch (selectedMode)
            {
                case "Addition":
                    result = Calculator.Addition(calculator1, calculator2);
                    break;
                case "Subtraktion":
                    result = Calculator.Subtract(calculator1, calculator2);
                    break;
                case "Multiplikation":
                    result = Calculator.Multiply(calculator1, calculator2);
                    break;
                case "Division":
                    result = Calculator.Divide(calculator1, calculator2);
                    break;
                default:
                    MessageBox.Show("Bitte wähle eine valide Operation aus!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            // Die Ergebnis wird auf den Text des Results gesetzt
            textBoxErgebnis.Text = result.ToString();
        }

        // Beim Klicken der Ausgabe Box wird der Inhalt in das Clipboard kopiert.
        // Es wird auch eine windows Toast Notification gesendet
        private void textBoxAusgabe_TextClicked(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBoxErgebnis.Text);
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

        // Wenn man die Operationen wechseln werden nur noch bestimmte felder angezeigt.
        private void operations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (operations.Text == "Potenzieren")
            {
                zaehlerZweiLabel.Visible = false;
                textBoxZählerZwei.Visible = false;
                NennerZweiLabel.Visible = false;
                textBoxNennerZwei.Visible = false;

                textBoxPotenz.Visible = true;
                potenzLabel.Visible = true;
            }
            else if (operations.Text == "Wurzel ziehen")
            {
                zaehlerZweiLabel.Visible = false;
                textBoxZählerZwei.Visible = false;
                NennerZweiLabel.Visible = false;
                textBoxNennerZwei.Visible = false;

                textBoxPotenz.Visible = false;
                potenzLabel.Visible = false;
            }
            else
            {
                zaehlerZweiLabel.Visible = true;
                textBoxZählerZwei.Visible = true;
                NennerZweiLabel.Visible = true;
                textBoxNennerZwei.Visible = true;

                textBoxPotenz.Visible = false;
                potenzLabel.Visible = false;
            }
        }
    }
}