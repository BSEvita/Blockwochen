namespace Bruchrechner
{
	public partial class Bruchrechner_Fenster : Form
	{
		public Bruchrechner_Fenster()
		{
			InitializeComponent();
		}

		private void Nenner2_TextChanged(object sender, EventArgs e)
		{

		}

		private void OnOperationClick(object sender, EventArgs e)
		{
			Button Operator = (Button)sender;

			Operation.Text = Operator.Text;
		}

		private void Operation_TextChanged(object sender, EventArgs e)
		{

		}
	}
}