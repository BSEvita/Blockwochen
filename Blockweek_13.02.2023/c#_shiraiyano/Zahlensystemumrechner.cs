using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Zahlensystemumrechner
{
    public class Zahlensystemumrechner
    {
        static void Main(string[] args)
        {
            Converter Zahl1 = new Converter();
            Converter Zahl2 = new Converter();
            Converter Ergebnis = new Converter();

            string Zwischenergebnis = "";

            Console.Write("Gib die Basis der ersten Zahl an (2, 8, 10, 16). \n");
            Zahl1.setAndCheckBasis();
            Zahl1.setAndCheckWert();

            Console.WriteLine("Gib die Basis der zweiten Zahl an (2, 8, 10, 16). \n");
            Zahl2.setAndCheckBasis();
            Zahl2.setAndCheckWert();

            Console.WriteLine("Welche Basis soll das Ergebnis haben?\n");
            Ergebnis.setAndCheckBasis();
            Console.WriteLine("Gib eine Rechenoperation an, die ausgeführt werden soll.\n");
            Ergebnis.setAndCheckOperation();

            switch(Ergebnis.getOperation())
            {
                case "+":
                  
                    break;

                case "-":
                   
                    break;

                case "*":
                    
                    break;

                case "/":
                    
                    break;

            }

            Console.WriteLine(Ergebnis.BaseConvert(Zwischenergebnis,Ergebnis.getBasis()));
        }
    }

    internal class Converter
    {
        private string Wert;
        private int Basis;
        private string Operation;

        public string BaseConvert(string Wert, int Basis)
        {
            string ConvWert = Convert.ToInt32(Wert, Basis).ToString();
            return ConvWert;
        }

        public int Addition(int Zahl1, int Zahl2)
        { return Zahl1 + Zahl2; }

        public int Subtraktion(int Zahl1, int Zahl2)
        { return Zahl1 - Zahl2; }

        public int Multiplikation(int Zahl1, int Zahl2)
        { return Zahl1 * Zahl2; }

        public int Division(int Zahl1, int Zahl2)
        { return Zahl1 / Zahl2; }

        public string getWert()
        { return Wert; }
        public void setAndCheckWert()
        {
            bool CorrectNumFormat = false;
            do
            {
                Console.Write("Gib deine Zahl ein, die umgewandelt werden soll: ");
                string NewWert = Console.ReadLine();
                Console.WriteLine();

                if (getBasis() < 16 && NewWert.All(Char.IsDigit) != true)
                {
                    Console.WriteLine("Nur Hexadezimalzahlen (Basis 16) dürfen Zahlen enthalten! \n");
                    Console.WriteLine("Drücke [Enter], um die Zahl erneut einzugeben!\n");
                    Console.ReadLine();
                }
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
            }while (CorrectNumFormat == false);
        }

        public int getBasis()
        { return Basis; }
        public void setAndCheckBasis()
        {
            bool CorrectBase = false;
            do
            {
                Console.Write("Basis (2, 8, 10, 16): ");
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

        public string getOperation()
        { return Operation; }
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
    }

}
