using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Bruchrechner
{
    internal class Bruchrechnung
    {
        private double Zaehler1;
        private double Nenner1;
 
        private double Zaehler2;
        private double Nenner2;
 
        private double Ergebnis;
        private char Operation;
 
        public void Rechnung(char operation)
        {
            switch (operation)
            {
                case '+':
                    set_Ergebnis(get_Zaehler1()/get_Nenner1() + get_Zaehler2()/get_Nenner2());
                    Console.WriteLine("Das Ergebnis der Addition ist: " + get_Ergebnis());
                    break;
                case '-':
                    set_Ergebnis(get_Zaehler1() / get_Nenner1() - get_Zaehler2() / get_Nenner2());
                    Console.WriteLine("Das Ergebnis der Subtraktion ist: " + get_Ergebnis());
                    break;
                case '*':
                    set_Ergebnis((get_Zaehler1() / get_Nenner1()) * (get_Zaehler2() / get_Nenner2()));
                    Console.WriteLine("Das Ergebnis der Multiplikation ist: " + get_Ergebnis());
                    break;
                case '/':
                    set_Ergebnis((get_Zaehler1() / get_Nenner1()) / (get_Zaehler2() / get_Nenner2()));
                    Console.WriteLine("Das Ergebnis der Division ist: " + get_Ergebnis());
                    break;
                case 'p':
                    set_Ergebnis(Math.Pow(get_Zaehler1() / get_Nenner1(), get_Zaehler2() / get_Nenner2()));
                    Console.WriteLine("Das Ergebnis der Potenzierung ist: " + get_Ergebnis());
                    break;
                case 'r':
                    set_Ergebnis(Math.Pow(get_Zaehler1() / get_Nenner1(), 1 / (get_Zaehler2() / get_Nenner2())));
                    Console.WriteLine("Das Ergebnis der Potenzierung ist: " + get_Ergebnis());
                    break;
                default:
                    Console.Clear();
                    break;
            }
        }
 
        public double get_Zaehler1()
        {   set_Zaehler1();
            return Zaehler1;    }
        public void set_Zaehler1()
        {   Console.Write("Geben Sie den ersten Zähler an (Kommazahlen mit Beistrich trennen): ");
            double zaehler = Convert.ToDouble(Console.ReadLine());
            Zaehler1 = zaehler; }
 
        public double get_Nenner1()
        {   set_Nenner1();
            return Nenner1;     }
        public void set_Nenner1()
        {   Console.Write("Geben Sie den ersten Nenner an (Kommazahlen mit Beistrich trennen): ");
            double nenner = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Nenner1 = nenner;   }
 
        public double get_Zaehler2()
        {
            set_Zaehler2();
            return Zaehler2;
        }
        public void set_Zaehler2()
        {   Console.Write("Geben Sie den zweiten Zähler an (Kommazahlen mit Beistrich trennen): ");
            double zaehler = Convert.ToDouble(Console.ReadLine());
            Zaehler2 = zaehler; }
 
        public double get_Nenner2()
        {   set_Nenner2();
            return Nenner2;     }
        public void set_Nenner2()
        {   Console.Write("Geben Sie den zweiten Nenner an (Kommazahlen mit Beistrich trennen): ");
            double nenner = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Nenner2 = nenner;   }
 
        public double get_Ergebnis()
        {   return Ergebnis;    }
        public void set_Ergebnis(double Rechnung)
        {   Ergebnis = Rechnung;}
 
        public char get_Operation()
        {
            set_Operation();
            return Operation;   }
        public void set_Operation()
        {   Console.Write("Geben Sie an, welche Rechenoperation durchgeführt werden soll: \n\n" +
                "* [+] für Addition \n" +
                "* [-] für Subtraktion \n" +
                "* [*] für Multiplikation \n" +
                "* [/] für Division \n" +
                "* [p] für Potenzieren \n" +
                "* [r] für Wurzel ziehen \n\n" +
                "Eingabe: ");
 
            char operation = Convert.ToChar(Console.ReadLine());
 
            Operation = operation;}
    }
}