using System.Numerics;

namespace WinForm_Taschenrechner
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
			Application.Run(new Taschenrechner());
		}
	}
	// Klasse beherbergt die Methoden zum Ausführen der Rechenoperationen, die in der Klasse "Taschenrechner" aufgerufen werden.
	// Einige Methoden verwenden im Return-Statement Methoden der "Math" Klasse, die komplexere Rechnungen mit dem Datentyp "double" ermöglicht.
	class Calculator
	{
		public static double Add(double a, double b)
		{
			return a + b;
		}

		public static double Subtract(double a, double b)
		{
			return a - b;
		}

		public static double Multiply(double a, double b)
		{
			return a * b;
		}

		public static double Divide(double a, double b)
		{
			if (b == 0)
			{
				throw new DivideByZeroException("Division by zero is not allowed.");
			}
			return a / b;
		}

		public static double Power(double a, double b)
		{
			return Math.Pow(a, b);
		}

		public static double Root(double a)
		{
			if (a < 0)
			{
				throw new ArgumentOutOfRangeException("Square root of negative number is not allowed.");
			}
			return Math.Sqrt(a);
		}

		public static double Log10(double a)
		{
			if (a <= 0)
			{
				throw new ArgumentOutOfRangeException("Logarithm of non-positive number is not allowed.");
			}
			return Math.Log10(a);
		}

		public static double Log(double a, double b)
		{
			if (a <= 0 || b <= 0)
			{
				throw new ArgumentOutOfRangeException("Logarithm of non-positive number is not allowed.");
			}
			return Math.Log(a, b);
		}

		// Faktoriell besitzt keine .Math-Methode, weshalb hier die Faktorielle durch einen for-Loop realisiert wird.
		// Fakultäten im ursprünglichen Sinne sind für negative oder nichtganze Zahlen nicht definiert.
		//
		// Bei negativer Zahl => Fehler, bei nichtganzer Zahl => Cast in Integer.
		public static double Factorial(double n)
		{
			if (n < 0)
			{
				throw new ArgumentOutOfRangeException("Factorial of negative number is not allowed.");
			}
			int intN = (int)n;
			BigInteger result = 1;
			for (int i = 2; i <= intN; i++)
			{
				result *= i;
			}
			return double.Parse(result.ToString());
		}

		// Zu Sin/Cos/Tan: Eingabe durch User geschieht in Grad. C# braucht Radianten.
		// Eingabe wird daher in Radianten konvertiert.
		public static double Sin(double a)
		{
			return Math.Sin(a * (Math.PI / 180));
		}

		public static double Cos(double a)
		{
			return Math.Cos(a * (Math.PI / 180));
		}

		public static double Tan(double a)
		{
			return Math.Tan(a * (Math.PI / 180));
		}
	}
}
