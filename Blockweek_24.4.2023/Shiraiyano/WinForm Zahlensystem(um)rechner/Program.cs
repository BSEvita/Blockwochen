namespace WinForm_Zahlensystem_um_rechner
{
	internal static class Program
	{
		[STAThread]
		static void Main()
		{
			ApplicationConfiguration.Initialize();
			Application.Run(new Zahlensystemumrechner());
		}
	}
}