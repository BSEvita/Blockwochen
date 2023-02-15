using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bruchrechner
{
    public class Program
    {
        public static string last_Result = "";

        static void Main()
        {
            bool repeat = true;
            char operation;
            bool first_Round = true;
            do
            {
                Console.Clear();
                Console.Write("Geben Sie an, welche Rechenoperation durchgeführt werden soll: \n\n" +
                "* [+] für Addition \n" +
                "* [-] für Subtraktion \n" +
                "* [*] für Multiplikation \n" +
                "* [/] für Division \n" +
                "* [p] für Potenzieren \n" +
                "* [r] für Wurzel ziehen \n" +
                "Eingabe: ");

                try
                {
                    operation = Convert.ToChar(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.Clear();
                    continue;
                }

                switch (operation)
                {
                    case '+':
                        caseAddition();
                        break;
                    case '-':
                        caseSubtraktion();
                        break;
                    case '*':
                        caseMultiplikation();
                        break;
                    case '/':
                        caseDivision();
                        break;
                    case 'p':
                        casePotenzieren();
                        break;
                    case 'r':
                        caseWurzelZiehen();
                        break;
                    default:
                        Console.Clear();
                        continue;
                }

                if (first_Round != true)
                    Console.WriteLine("Ergebnis der letzten Berechnung: " + last_Result);
                else
                    first_Round = false;

                Console.WriteLine("Möchten Sie den Vorgang wiederholen? \n");
                Console.WriteLine(" [y] Ja");
                Console.WriteLine(" [n] Nein \n");

                char inputChar = Convert.ToChar(Console.ReadLine().ToLower());

                switch (inputChar)
                {
                    case 'y':
                        Console.Clear();
                        break;

                    case 'n':
                        repeat = false;
                        Console.Clear();
                        break;

                    default:
                        Console.Clear();
                        Thread.Sleep(1000);
                        Console.WriteLine("Ungültige Eingabe, Programm wird erneut ausgeführt!\n");
                        Console.Clear();
                        break;
                }
            }
            while (repeat == true);
        }

        public static void caseAddition()
        {
            Console.Clear();
            Console.Write("Geben Sie den ersten Zähler an: ");
            double input = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.Write("Geben Sie den ersten Nenner an: ");
            double input2 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.Write("Geben Sie den zweiten Zähler an: ");
            double input3 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.Write("Geben Sie den zweiten Nenner an: ");
            double input4 = Convert.ToDouble(Console.ReadLine());

            Bruch a = new Bruch(input, input2);
            Bruch b = new Bruch(input3, input4);

            Bruch result = a.Addieren(b);

            double zaehler = result.get_zaehler();
            double nenner = result.get_nenner();

            Console.WriteLine($"Der Zähler ist {zaehler} und der Nenner {nenner}.");
            last_Result = $"{zaehler}/{nenner}";
        }

        public static void caseSubtraktion()
        {
            Console.Clear();
            Console.Write("Geben Sie den ersten Zähler an: ");
            double input = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.Write("Geben Sie den ersten Nenner an: ");
            double input2 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.Write("Geben Sie den zweiten Zähler an: ");
            double input3 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.Write("Geben Sie den zweiten Nenner an: ");
            double input4 = Convert.ToDouble(Console.ReadLine());

            Bruch a = new Bruch(input, input2);
            Bruch b = new Bruch(input3, input4);

            Bruch result = a.Subtrahieren(b);

            double zaehler = result.get_zaehler();
            double nenner = result.get_nenner();

            Console.WriteLine($"Der Zähler ist {zaehler} und der Nenner {nenner}.");
            last_Result = $"{zaehler}/{nenner}";
        }

        public static void caseMultiplikation()
        {
            Console.Clear();
            Console.Write("Geben Sie den ersten Zähler an: ");
            double input = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.Write("Geben Sie den ersten Nenner an: ");
            double input2 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.Write("Geben Sie den zweiten Zähler an: ");
            double input3 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.Write("Geben Sie den zweiten Nenner an: ");
            double input4 = Convert.ToDouble(Console.ReadLine());

            Bruch a = new Bruch(input, input2);
            Bruch b = new Bruch(input3, input4);

            Bruch result = a.Multiplizieren(b);

            double zaehler = result.get_zaehler();
            double nenner = result.get_nenner();

            Console.WriteLine($"Der Zähler ist {zaehler} und der Nenner {nenner}.");
            last_Result = $"{zaehler}/{nenner}";
        }

        public static void caseDivision()
        {
            Console.Clear();
            Console.Write("Geben Sie den ersten Zähler an: ");
            double input = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.Write("Geben Sie den ersten Nenner an: ");
            double input2 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.Write("Geben Sie den zweiten Zähler an: ");
            double input3 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.Write("Geben Sie den zweiten Nenner an: ");
            double input4 = Convert.ToDouble(Console.ReadLine());

            Bruch a = new Bruch(input, input2);
            Bruch b = new Bruch(input3, input4);

            Bruch result = a.Dividieren(b);

            double zaehler = result.get_zaehler();
            double nenner = result.get_nenner();

            Console.WriteLine($"Der Zähler ist {zaehler} und der Nenner {nenner}.");
            last_Result = $"{zaehler}/{nenner}";
        }

        public static void casePotenzieren()
        {
            Console.Clear();
            Console.Write("Geben Sie den ersten Zähler an: ");
            double input = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.Write("Geben Sie den ersten Nenner an: ");
            double input2 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.Write("Geben Sie die Exponente an: ");
            double input3 = Convert.ToDouble(Console.ReadLine());

            Bruch a = new Bruch(input, input2);

            double result = a.Potenzieren(input3);

            Console.WriteLine($"Der Bruch {a.get_zaehler()} / {a.get_nenner()} und die Exponente {input3} ergeben das Ergebnis {result}.");
            last_Result = $"{result}";
        }

        public static void caseWurzelZiehen()
        {
            Console.Clear();
            Console.Write("Geben Sie den ersten Zähler an: ");
            double input = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.Write("Geben Sie den ersten Nenner an: ");
            double input2 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.Write("Geben Sie den zweiten Zähler an: ");
            double input3 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.Write("Geben Sie den zweiten Nenner an: ");
            double input4 = Convert.ToDouble(Console.ReadLine());

            Bruch a = new Bruch(input, input2);
            Bruch b = new Bruch(input3, input4);

            double r = Math.Pow(a.get_zaehler() / a.get_nenner(), 1 / (b.get_zaehler() / b.get_nenner()));

            Console.WriteLine($"Das Ergebnis des Wurzel ziehens ist {r}");
            last_Result = $"{r}";
        }

    }

    class Bruch
    {
        private double z, n;

        public Bruch(double zaehler, double nenner)
        {
            z = zaehler; n = nenner;
        }

        public double get_zaehler()
        {
            return z;
        }

        public void set_zaehler(double value)
        {
            z = value;
        }

        public double get_nenner()
        {
            return n;
        }

        public void set_nenner(double value)
        {
            n = value;
        }

        public Bruch Addieren(Bruch other)
        {
            return new Bruch(z * other.n + other.z * n, n * other.n);
        }

        public Bruch Subtrahieren(Bruch other)
        {
            return new Bruch(z * other.n - other.z * n, n * other.n);
        }

        public Bruch Multiplizieren(Bruch other)
        {
            return new Bruch(z * other.z, n * other.n);
        }

        public Bruch Dividieren(Bruch other)
        {
            return new Bruch(z * other.n, n * other.z);
        }

        public double Potenzieren(double exponent)
        {
            return Math.Pow(z / n, exponent);
        }
    }
}