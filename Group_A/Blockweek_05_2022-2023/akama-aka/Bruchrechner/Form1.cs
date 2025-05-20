namespace Bruchrechner
{
    public partial class Form1 : Form
    {
        
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double bruchTopFirstDouble = Convert.ToDouble(bruchTopFirst.Text);
            double bruchBottomFirstDouble = Convert.ToDouble(bruchBottomFirst.Text);
            double bruchTopSecondDouble = Convert.ToDouble(bruchTopSecond.Text);
            double bruchBottomSecondDouble = Convert.ToDouble(bruchBottomSecond.Text);

            /*            if (!double.TryParse(bruchTopFirst.Text, out bruchTopFirstDouble) ||
                            !double.TryParse(bruchBottomFirst.Text, out bruchBottomFirstDouble) ||
                            !double.TryParse(bruchTopSecond.Text, out bruchTopSecondDouble) ||
                            !double.TryParse(bruchBottomSecond.Text, out bruchBottomSecondDouble))
                        {
                            MessageBox.Show("Bitte geben Sie gültige Zahlen ein.");
                            return;
                        }*/

            Rechner bruch1 = new Rechner(bruchTopFirstDouble, bruchBottomFirstDouble);
            Rechner bruch2 = new Rechner(bruchTopSecondDouble, bruchBottomSecondDouble);

            switch (op)
            {
                case "+":
                    bruch1 = Rechner.Addition(bruch1, bruch2);
                    break;
                case "-":
                    bruch1 = Rechner.Subtraktion(bruch1, bruch2);
                    break;
                case "*":
                    bruch1 = Rechner.Multiplikation(bruch1, bruch2);
                    break;
                case "/":
                    bruch1 = Rechner.Division(bruch1, bruch2);
                    break;
                case "^":
                    bruch1 = Rechner.Potenzieren(bruch1, int.Parse(textBox5.Text));
                    break;
                case "Wurzel":
                    bruch1 = Rechner.Wurzel(bruch1);
                    break;
                default:
                    MessageBox.Show("Bitte wählen Sie eine Rechenoperation aus.");
                    return;
            }

            bruchFinishTop.Text = bruch1.Zaehler.ToString();
            bruchFinishBottom.Text = bruch1.Nenner.ToString();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            op = "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            op = "-";
        }

        private void btnMal_Click(object sender, EventArgs e)
        {
            op = "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            op = "/";
        }

        private void btnPot_Click(object sender, EventArgs e)
        {
            op = "^";
        }

        private void btnWur_Click(object sender, EventArgs e)
        {
            op = "Wurzel";
        }
    }
}