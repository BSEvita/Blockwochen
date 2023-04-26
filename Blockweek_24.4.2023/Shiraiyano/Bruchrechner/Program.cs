namespace Bruchrechner
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			ApplicationConfiguration.Initialize();
			Application.Run(new Bruchrechner_Fenster());
		}

	}

	public class Bruch
	{
		//Felder für Zähler und Nenner
		public int Zähler { get; set; }
		public int Nenner { get; set; }

		public Bruch(int zähler, int nenner)
		{
			int ggt = GGT(zähler, nenner);
			Zähler = zähler / ggt;
			Nenner = nenner / ggt;
		}

		//Rechenlogik Addition
		public static Bruch Addition(Bruch f1, Bruch f2)
		{
			int zähler = f1.Zähler * f2.Nenner + f2.Zähler * f1.Nenner;
			int nenner = f1.Nenner * f2.Nenner;
			return new Bruch(zähler, nenner);
		}

		//Rechenlogik Subtraktion
		public static Bruch Subtraktion(Bruch f1, Bruch f2)
		{
			int zähler = f1.Zähler * f2.Nenner - f2.Zähler * f1.Nenner;
			int nenner = f1.Nenner * f2.Nenner;
			return new Bruch(zähler, nenner);
		}

		//Rechenlogik Multiplikation
		public static Bruch Multiplikation(Bruch f1, Bruch f2)
		{
			int zähler = f1.Zähler * f2.Zähler;
			int nenner = f1.Nenner * f2.Nenner;
			return new Bruch(zähler, nenner);
		}

		//Rechenlogik Division
		public static Bruch Division(Bruch f1, Bruch f2)
		{
			int zähler = f1.Zähler * f2.Nenner;
			int nenner = f1.Nenner * f2.Zähler;
			return new Bruch(zähler, nenner);
		}

		//Rechenlogik Potenzieren
		public static Bruch Potenzieren(Bruch f, int n)
		{
			int zähler = (int)Math.Pow(f.Zähler, n);
			int nenner = (int)Math.Pow(f.Nenner, n);
			return new Bruch(zähler, nenner);
		}

		//Rechenlogik Wurzel
		public static Bruch Wurzel(Bruch f)
		{
			int zähler = (int)Math.Sqrt(f.Zähler);
			int nenner = (int)Math.Sqrt(f.Nenner);
			return new Bruch(zähler, nenner);
		}

		//Überladung der ToString Methode. Notwendig, um richtigen Output zu bekommen
		public override string ToString()
		{
			if (Nenner == 1)
				return Zähler.ToString();
			else
				return "Zähler: " + Zähler + " | Nenner: " + Nenner;
		}
		
		//Berechnung des größten gemeinsamen Teilers
		int GGT(int a, int b)
		{
			if (b == 0)
			{
				return a;
			}
			else
			{
				return GGT(b, a % b);
			}
		}
	}
}

