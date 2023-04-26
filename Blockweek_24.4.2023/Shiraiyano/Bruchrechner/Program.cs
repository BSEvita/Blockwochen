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
		//Felder f�r Z�hler und Nenner
		public int Z�hler { get; set; }
		public int Nenner { get; set; }

		public Bruch(int z�hler, int nenner)
		{
			int ggt = GGT(z�hler, nenner);
			Z�hler = z�hler / ggt;
			Nenner = nenner / ggt;
		}

		//Rechenlogik Addition
		public static Bruch Addition(Bruch f1, Bruch f2)
		{
			int z�hler = f1.Z�hler * f2.Nenner + f2.Z�hler * f1.Nenner;
			int nenner = f1.Nenner * f2.Nenner;
			return new Bruch(z�hler, nenner);
		}

		//Rechenlogik Subtraktion
		public static Bruch Subtraktion(Bruch f1, Bruch f2)
		{
			int z�hler = f1.Z�hler * f2.Nenner - f2.Z�hler * f1.Nenner;
			int nenner = f1.Nenner * f2.Nenner;
			return new Bruch(z�hler, nenner);
		}

		//Rechenlogik Multiplikation
		public static Bruch Multiplikation(Bruch f1, Bruch f2)
		{
			int z�hler = f1.Z�hler * f2.Z�hler;
			int nenner = f1.Nenner * f2.Nenner;
			return new Bruch(z�hler, nenner);
		}

		//Rechenlogik Division
		public static Bruch Division(Bruch f1, Bruch f2)
		{
			int z�hler = f1.Z�hler * f2.Nenner;
			int nenner = f1.Nenner * f2.Z�hler;
			return new Bruch(z�hler, nenner);
		}

		//Rechenlogik Potenzieren
		public static Bruch Potenzieren(Bruch f, int n)
		{
			int z�hler = (int)Math.Pow(f.Z�hler, n);
			int nenner = (int)Math.Pow(f.Nenner, n);
			return new Bruch(z�hler, nenner);
		}

		//Rechenlogik Wurzel
		public static Bruch Wurzel(Bruch f)
		{
			int z�hler = (int)Math.Sqrt(f.Z�hler);
			int nenner = (int)Math.Sqrt(f.Nenner);
			return new Bruch(z�hler, nenner);
		}

		//�berladung der ToString Methode. Notwendig, um richtigen Output zu bekommen
		public override string ToString()
		{
			if (Nenner == 1)
				return Z�hler.ToString();
			else
				return "Z�hler: " + Z�hler + " | Nenner: " + Nenner;
		}
		
		//Berechnung des gr��ten gemeinsamen Teilers
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

