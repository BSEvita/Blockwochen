using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_Taschenrechner
{
	public class Calculations
	{
		public string Operation;

		public double FirstNumber { get; set; }
		public double SecondNumber { get; set; }
		public double Result { get; set; }

		public static double Addition(double FirstNumber, double SecondNumber)
		{
			return FirstNumber + SecondNumber;
		}

		public static double Subtraction(double FirstNumber, double SecondNumber)
		{
			return FirstNumber - SecondNumber;
		}

		public static double Multiplikation(double FirstNumber, double SecondNumber)
		{
			return FirstNumber * SecondNumber;
		}

		public static double Division(double FirstNumber, double SecondNumber)
		{
			return FirstNumber / SecondNumber;
		}

		public static double Potenzieren(double FirstNumber, double SecondNumber)
		{
			return Math.Pow(FirstNumber, SecondNumber);
		}

		public static double WurzelZiehen(double FirstNumber, double SecondNumber)
		{
			return Math.Pow(FirstNumber, 1.0 / SecondNumber);
		}

		public static double Logarithmus(double FirstNumber, double SecondNumber)
		{
			return Math.Log(FirstNumber, SecondNumber);
		}

		public static double Factorial(double FirstNumber)
		{
			double Factorial = FirstNumber;
			for (double i = Factorial - 1; i > 0; i--)
			{
				FirstNumber *= i;
			}
			return FirstNumber;
		}

		public static double Sinus(double FirstNumber)
		{
			return Math.Sin(FirstNumber * Math.PI / 180);
		}

		public static double Cosinus(double FirstNumber)
		{
			return Math.Cos(FirstNumber * Math.PI / 180);
		}

		public static double Tangens(double FirstNumber)
		{
			return Math.Tan(FirstNumber * Math.PI / 180);
		}

		public void Equate(string Operation, double number1, double number2)
		{

			FirstNumber = number1;
			SecondNumber = number2;

			switch (Operation)
			{
				case "+":
					Result = Addition(FirstNumber, SecondNumber);
					break;
				case "-":
					Result = Subtraction(FirstNumber, SecondNumber);
					break;
				case "*":
					Result = Multiplikation(FirstNumber, SecondNumber);
					break;
				case "/":
					Result = Division(FirstNumber, SecondNumber);
					break;
				case "x^y":
					Result = Potenzieren(FirstNumber, SecondNumber);
					break;
				case "(x)√y":
					Result = WurzelZiehen(FirstNumber, SecondNumber);
					break;
				case "log_x(y)":
					Result = Logarithmus(FirstNumber, SecondNumber);
					break;
				case "!":
					Result = Factorial(FirstNumber);
					break;
				case "Sin":
					Result = Sinus(FirstNumber);
					break;
				case "Cos":
					Result = Cosinus(FirstNumber);
					break;
				case "Tan":
					Result = Tangens(FirstNumber);
					break;
				default:
					break;
			}
		}
	}
}
