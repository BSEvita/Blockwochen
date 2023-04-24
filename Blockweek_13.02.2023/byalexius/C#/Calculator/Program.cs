using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*using Taschenrechner;*/

namespace Calculator
{
    public class Calculators
    {
        static void Main()
        {
            bool Wiederholen = true;
            double last_Result = 0;
            bool first_Round = true;
            do
            {
  /*              try
                {
                    CalculatorTests.Tests();
                } catch (Exception ex) 
                {
                    throw new Exception(ex.Message);
                }
*/
                Calculations Calculator = new Calculations();

                Calculator.setOperation();

                Calculator.Equate(Calculator.getOperation());

                Console.WriteLine(Calculator.getResult());
                if (first_Round != true)
                    Console.WriteLine("Ergebnis der letzten Berechnung: " + last_Result);
                else
                    first_Round = false;

                last_Result = Calculator.getResult();

                Console.WriteLine("Möchten Sie den Vorgang wiederholen? \n");
                Console.WriteLine(" [y] Ja");
                Console.WriteLine(" [n] Nein \n");

                char inputChar = Convert.ToChar(Console.ReadLine().ToLower());

                switch (inputChar)
                {
                    case 'j':
                        Console.Clear();
                        break;

                    case 'n':
                        Wiederholen = false;
                        Console.Clear();
                        break;

                        default:
                        Console.Clear();
                        Thread.Sleep(1000);
                        Console.WriteLine("Ungültige Eingabe, Programm wird erneut ausgeführt!\n");
                        Console.Clear();
                        break;
                }
            } while (Wiederholen == true);

            
        }
    }

    public class Calculations
    {
        public char Operation;

        private double FirstNumber;
        private double SecondNumber;
        private double Result;

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
            return Math.Sin(FirstNumber);
        }

        public static double Cosinus(double FirstNumber)
        {
            return Math.Cos(FirstNumber);
        }

        public static double Tangens(double FirstNumber)
        {
            return Math.Tan(FirstNumber);
        }

        public void Equate(char Operation)
        {
            switch (Operation)
            {
                case '+':
                    setFirstNumber();
                    setSecondNumber();
                    setResult(Addition(getFirstNumber(), getSecondNumber()));
                    break;
                case '-':
                    setFirstNumber();
                    setSecondNumber();
                    setResult(Subtraction(getFirstNumber(), getSecondNumber()));
                    break;
                case '*':
                    setFirstNumber();
                    setSecondNumber();
                    setResult(Multiplikation(getFirstNumber(), getSecondNumber()));
                    break;
                case '/':
                    setFirstNumber();
                    setSecondNumber();
                    setResult(Division(getFirstNumber(), getSecondNumber()));
                    break;
                case 'p':
                    setFirstNumber();
                    setSecondNumber();
                    setResult(Potenzieren(getFirstNumber(), getSecondNumber()));
                    break;
                case 'r':
                    setFirstNumber();
                    setSecondNumber();
                    setResult(WurzelZiehen(getFirstNumber(), getSecondNumber()));
                    break;
                case 'l':
                    setFirstNumber();
                    setSecondNumber();
                    setResult(Logarithmus(getFirstNumber(), getSecondNumber()));
                    break;
                case '!':
                    setFirstNumber();
                    setResult(Factorial(getFirstNumber()));
                    break;
                case 's':
                    setFirstNumber();
                    setResult(Sinus(getFirstNumber()));
                    break;
                case 'c':
                    setFirstNumber();
                    setResult(Cosinus(getFirstNumber()));
                    break;
                case 't':
                    setFirstNumber();
                    setResult(Tangens(getFirstNumber()));
                    break;
                default:
                    Equate(Operation);
                    break;
            }
        }

        public char getOperation()
        { return Operation; }
        public void setOperation()
        {
            Console.Write("Geben Sie an, welche Rechenoperation durchgeführt werden soll: \n\n" +
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
                "Eingabe: ");
            char operation = Convert.ToChar(Console.ReadLine());
            Operation = operation;
        }

        public double getFirstNumber()
        { return FirstNumber; }
        public void setFirstNumber()
        {
            Console.Write("Geben Sie die erste Zahl an: ");
            double input = Convert.ToDouble(Console.ReadLine());
            FirstNumber = input;
        }

        public double getSecondNumber()
        { return SecondNumber; }
        public void setSecondNumber()
        {
            Console.Write("Geben Sie die zweite Zahl an: ");
            double input = Convert.ToDouble(Console.ReadLine());
            SecondNumber = input;
        }

        public double getResult()
        { return Result; }
        public void setResult(double result)
        { Result = result; }
    }
}