using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    public class Calculation
    {
        public char Character;
        public double Value;
    }

    public class HistoryDictionary : Dictionary<int, Calculation> 
    {
        public void add(int key, char operation, double value)
        {
            Calculation cal = new Calculation();
            cal.Character = operation;
            cal.Value = value;
            this.Add(key, cal);
        }
    }

    public class Calculations
    {
        public char Operation;

        private double FirstNumber {  get; set; }
        private double SecondNumber { get; set; }
        private double Result { get; set; }

        private HistoryDictionary history = new HistoryDictionary();

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

        public void Equate(char Operation, double number1, double number2)
        {

            FirstNumber = number1;
            SecondNumber = number2;

            switch (Operation)
            {
                case '+':
                    Result = Addition(FirstNumber, SecondNumber);
                    break;
                case '-':
                    Result = Subtraction(FirstNumber, SecondNumber);
                    break;
                case '*':
                    Result = Multiplikation(FirstNumber, SecondNumber);
                    break;
                case '/':
                    Result = Division(FirstNumber, SecondNumber);
                    break;
                case 'p':
                    Result = Potenzieren(FirstNumber, SecondNumber);
                    break;
                case 'r':
                    Result = WurzelZiehen(FirstNumber, SecondNumber);
                    break;
                case 'l':
                    Result = Logarithmus(FirstNumber, SecondNumber);
                    break;
                case '!':
                    Result = Factorial(FirstNumber);
                    break;
                case 's':
                    Result = Sinus(FirstNumber);
                    break;
                case 'c':
                    Result = Cosinus(FirstNumber);
                    break;
                case 't':
                    Result = Tangens(FirstNumber);
                    break;
                default:
                    break;
            }
        }
    }
}

/**
                "* [+] für Addition \n" +
                "* [-] für Subtraktion \n" +
                "* [*] für Multiplikation \n" +
                "* [/] für Division \n" +
                "* [p] für Potenzieren \n" +
                "* [r] für Wurzel ziehen \n" +
                "* [l] für Logarithmus \n" +
                "* [!] für Fakultät \n" +
                "* [s] für Sinus \n" +
                "* [c] für Cosinus \n" +
                "* [t] für Tangens \n\n" +
**/
