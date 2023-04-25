using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    public class Calculations
    {
        // Hier werden Variablen Initsialisiert
        public char Operation;

        public double FirstNumber {  get; set; }
        public double SecondNumber { get; set; }
        public double Result { get; set; }

        // Die Rechnung für Additionen
        public static double Addition(double FirstNumber, double SecondNumber)
        {
            return FirstNumber + SecondNumber;
        }

        // Die Rechnung für Subtraktionen
        public static double Subtraction(double FirstNumber, double SecondNumber)
        {
            return FirstNumber - SecondNumber;
        }

        // Die Rechnung für Multiplikationen
        public static double Multiplikation(double FirstNumber, double SecondNumber)
        {
            return FirstNumber * SecondNumber;
        }

        // Die Rechnung für Divisionen
        public static double Division(double FirstNumber, double SecondNumber)
        {
            return FirstNumber / SecondNumber;
        }

        // Die Rechnung für das Potenzieren
        public static double Potenzieren(double FirstNumber, double SecondNumber)
        {
            return Math.Pow(FirstNumber, SecondNumber);
        }

        // Die Rechnung für den Logarithmus 
        public static double Logarithmus(double FirstNumber)
        {
            return Math.Log10(FirstNumber);
        }

        // Die Rechnung für das Factoral
        public static double Factorial(double FirstNumber)
        {
            double Factorial = FirstNumber;
            for (double i = Factorial - 1; i > 0; i--)
            {
                FirstNumber *= i;
            }
            return FirstNumber;
        }

        // Die Rechnung für den Sinus
        public static double Sinus(double FirstNumber)
        {
            return Math.Sin(FirstNumber * Math.PI / 180);
        }

        // Die Rechnung für den Cosinus
        public static double Cosinus(double FirstNumber)
        {
            return Math.Cos(FirstNumber * Math.PI / 180);
        }

        // Die Rechnung für den Tanges
        public static double Tangens(double FirstNumber)
        {
            return Math.Tan(FirstNumber * Math.PI / 180);
        }

        // Die Rechnung für die Quadratwurzel
        public static double Squareroot(double FirstNumber)
        {
            return Math.Sqrt(FirstNumber);
        }

        // Die Rechnung für das Quadrat
        public static double Quadrat(double FirstNumber)
        {
            return Math.Pow(FirstNumber, 2);
        }

        // Die Rechnung für den Kehrwert
        public static double Kehrwert(double FirstNumber)
        {
            return (1.0 / FirstNumber);
        }

        // Diese Methode wird aufgerufen wenn man Rechnen möchte.
        // Es wird der Operator und zwei nummern übergeben.
        // Sollte nur eine benötigt werden hat die zweiten den wert 0.0
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
                case 'l':
                    Result = Logarithmus(FirstNumber);
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
                case 'w':
                    Result = Squareroot(FirstNumber);
                    break;
                case 'q':
                    Result = Quadrat(FirstNumber);
                    break;
                case 'k':
                    Result = Kehrwert(FirstNumber);
                    break;
                default:
                    break;
            }
        }
    }
}