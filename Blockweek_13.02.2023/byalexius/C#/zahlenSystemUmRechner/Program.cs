using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahlensystemrechner
{
    public class Zahlensystemumrechner
    {
        static void Main(string[] args)
        {
            bool repeat;
            Converter number1 = new Converter();
            Converter number2 = new Converter();
            Converter answer = new Converter();
            string Endergebnis;
            do
            {
                repeat = true;
                Console.WriteLine(" * Bitte gib die Basis der ersten Zahl an:\n * [2] Binär\n * [8] Oktal\n * [10] Dezimal\n * [16] Hexadezimal\n");
                number1.checkAndSetBasis();
                number1.setAndCheckWert();
                number1.setDezimalform(number1.ConvertBase(number1.getWert(), number1.getBasis()));

                Console.WriteLine(" * Bitte gib die Basis der zweiten Zahl an:\n * [2] Binär\n * [8] Oktal\n * [10] Dezimal\n * [16] Hexadezimal\n");
                number2.checkAndSetBasis();
                number2.setAndCheckWert();
                number2.setDezimalform(number2.ConvertBase(number2.getWert(), number2.getBasis()));

                Console.WriteLine("Welche Basis soll das Ergebnis haben?\n * [2] Binär\n * [8] Oktal\n * [10] Dezimal\n * [16] Hexadezimal\n");
                answer.checkAndSetBasis();
                Console.WriteLine("Gib eine Rechenoperation an, die ausgeführt werden soll.\n");
                answer.setAndCheckOperation();

                // Hier wird entschieden welcher rechen Operator verwendet werden soll
                switch (answer.getOperation())
                {
                    case "+":
                        answer.setDezimalform(number1.getDezimalform() + number2.getDezimalform());
                        break;

                    case "-":
                        answer.setDezimalform(number1.getDezimalform() - number2.getDezimalform());
                        break;

                    case "*":
                        answer.setDezimalform(number1.getDezimalform() * number2.getDezimalform());
                        break;

                    case "/":
                        answer.setDezimalform(number1.getDezimalform() / number2.getDezimalform());
                        break;
                }
                Endergebnis = Convert.ToString(answer.getDezimalform(), answer.getBasis());
                Console.WriteLine("Das Ergebnis ist: " + Endergebnis);

                Console.WriteLine("\nMöchten Sie den Vorgang wiederholen? \n");
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
            } while (repeat == true);
        }
    }

    class Converter
    {
        // Initsialisierung der Variablen
        private string Wert;
        private int Basis;
        private int Dezimalform;
        private string Operation;

        // Wandelt den Wert mit der basis um
        public int ConvertBase(string Wert, int Basis)
        {
            int ConvWert = Convert.ToInt32(Wert, Basis);
            return ConvWert;
        }

        // Die Methode für die Addition
        public int Addition(int Zahl1, int Zahl2)
        { 
            return Zahl1 + Zahl2; 
        }

        // Die Methode für die Subtraktion
        public int Subtraktion(int Zahl1, int Zahl2)
        { 
            return Zahl1 - Zahl2; 
        }

        // Die Methode für die Multiplikation
        public int Multiplikation(int Zahl1, int Zahl2)
        {
            return Zahl1 * Zahl2;
        }

        // Die Methode für die Division
        public int Division(int Zahl1, int Zahl2)
        {
            return Zahl1 / Zahl2;
        }

        // Die Methode für das Setzen und überprüfen des Wertes
        public void setAndCheckWert()
        {
            bool CorrectNumFormat = false;
            do
            {
                Console.Write("Gib deine Zahl ein, die umgewandelt werden soll: ");
                string NewWert = Console.ReadLine();
                Console.WriteLine();

                //Using LINQ to check if Number wants to use letters when its not a hex
                if (getBasis() < 16 && NewWert.All(Char.IsDigit) != true)
                {
                    Console.WriteLine("Nur Hexadezimalzahlen (Basis 16) dürfen Zahlen enthalten! \n");
                    Console.WriteLine("Drücke [Enter], um die Zahl erneut einzugeben!\n");
                    Console.ReadLine();
                }
                //Using LINQ to check for invalid Hexadecimal input (only 0 - 9, A - F)
                else if (getBasis() == 16 && NewWert.All("0123456789abcdefABCDEF".Contains) != true)
                {
                    Console.WriteLine("Hexadezimalzahlen dürfen nur Ziffern und Buchstaben von A bis F enthalten! \n");
                    Console.WriteLine("Drücke [Enter], um die Hexadezimalzahl erneut einzugeben!\n");
                    Console.ReadLine();
                }
                else
                {
                    CorrectNumFormat = true;
                    Wert = NewWert;
                    Console.WriteLine();
                }
            } while (CorrectNumFormat == false);
        }

        // Die Methode für das Setzen und überprüfen der Basis
        public void checkAndSetBasis()
        {
            bool CorrectBase = false;
            do
            {
                Console.Write("Eingabe: ");
                int NewBasis = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (NewBasis != 2 && NewBasis != 8 && NewBasis != 10 && NewBasis != 16)
                {

                    Console.WriteLine("Die Basis muss 2, 8, 10 oder 16 sein!\n");
                    Console.WriteLine("Drücke [Enter], um die Basis erneut einzugeben!\n");
                    Console.ReadLine();
                }
                else
                {
                    CorrectBase = true;
                    Basis = NewBasis;
                    Console.WriteLine();
                }
            } while (CorrectBase == false);
        }

        // Die Methode für das Setzen und überprüfen der Operation
        public void setAndCheckOperation()
        {
            bool CorrectOperator = false;
            do
            {
                Console.Write("Operationen ( +, -, *, / ): ");
                string NewOperator = Console.ReadLine();
                Console.WriteLine();

                if (NewOperator.All("+-*/".Contains) != true)
                {
                    Console.WriteLine("Die einzigen erlaubten Operationen sind [ +, -, *, / ] !\n");
                    Console.WriteLine("Drücke [Enter], um die Rechenoperation erneut einzugeben!\n");
                    Console.ReadLine();
                }
                else if (NewOperator.Length > 1)
                {
                    Console.WriteLine("Es darf maximal ein Rechenzeichen verwendet werden!\n");
                    Console.WriteLine("Drücke [Enter], um die Rechenoperation erneut einzugeben!\n");
                    Console.ReadLine();
                }
                else
                {
                    CorrectOperator = true;
                    Operation = NewOperator;
                    Console.WriteLine();
                }

            } while (CorrectOperator == false);
        }

        // Getter und Setter

        public int getBasis()
        {
            return Basis;
        }
        public int getDezimalform()
        {
            return Dezimalform;
        }
        public void setDezimalform(int dezimalform)
        { 
            Dezimalform = dezimalform;
        }
        public string getOperation()
        { 
            return Operation;
        }
        public string getWert()
        {
            return Wert;
        }
    }
}
