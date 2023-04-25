using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Calculator
{
    public class Taschenrechner
    {
        static void Main()
        {
            bool Wiederholen = true; //Wird zum wiederholen des Programms verwendet.
            double last_Result = 0;
            do
            {
                Calculations Calculator = new Calculations();

                Calculator.set_operation(); //Fragt Nutzer nach Operator

                Calculator.Equate(Calculator.get_operation());

                Console.WriteLine(Calculator.get_Result());
                Console.WriteLine("Ergebnis der letzten Berechnung: " + last_Result); //Gibt bei der ersten Ausführung 0 aus, weil mit 0 initialisiert.

                last_Result = Calculator.get_Result();

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

    class Calculations
    {
        public char Operation;

        private double FirstNumber;
        private double SecondNumber;
        private double Result;

        //Da mit Doubles operiert wird, wird für das meiste die Math Library verwendet.
        //Fakultät hat keine Methode in der Math Library, und muss daher selbst definiert werden.
        public double Factorial(double FirstNumber)
        {
            double Factorial = FirstNumber;                 // Beispiel: FirstNumber = 6
            for (double i = Factorial - 1; i > 0; i--)      // 6*5 (30) => 30*4 (120) =>
            {                                               // 120*3 (360) => 360*2 (720) =>
                FirstNumber *= i;                           // 720*1 (720 == Ergebnis)
            }
            return FirstNumber;
        }

        public void Equate(char Operation)
        {
            switch (Operation)
            {
                case '+':
                    set_Result(get_FirstNumber() + get_SecondNumber()); break;
                case '-':
                    set_Result(get_FirstNumber() - get_SecondNumber()); break;
                case '*':
                    set_Result(get_FirstNumber() * get_SecondNumber()); break;
                case '/':
                    set_Result(get_FirstNumber() / get_SecondNumber()); break;
                case 'p':
                    set_Result(Math.Pow(get_FirstNumber(), get_SecondNumber())); break;
                case 'r':
                    set_Result(Math.Pow(get_FirstNumber(), 1.0 / get_SecondNumber())); break;
                case 'l':
                    set_Result(Math.Log(get_FirstNumber(), get_SecondNumber())); break;
                case '!':
                    set_Result(Factorial(get_FirstNumber())); break;
                case 's':
                    set_Result(Math.Sin(get_FirstNumber() * Math.PI / 180)); break;
                case 'c':
                    set_Result(Math.Cos(get_FirstNumber() * Math.PI / 180)); break;
                case 't':
                    set_Result(Math.Tan(get_FirstNumber() * Math.PI / 180)); break;
            }
        }

        public char get_operation()
        { return Operation; }
        public void set_operation()
        {
            Console.Write("Geben Sie an, welche Rechenoperation durchgeführt werden soll: \n\n" +
                "[+] für Addition \n" +
                "[-] für Subtraktion \n" +
                "[*] für Multiplikation \n" +
                "[/] für Division \n" +
                "[p] für Potenzieren \n" +
                "[r] für Wurzel ziehen \n" +
                "[l] für Logarithmus \n" +
                "[!] für Fakultät \n" +
                "[s] für Sinus \n" +
                "[c] für Cosinus \n" +
                "[t] für Tangens \n\n" +
                "Auswahl: ");
            char operation = Convert.ToChar(Console.ReadLine());
            Operation = operation;
        }

        public double get_FirstNumber()
        {
            set_FirstNumber();
            return FirstNumber;
        }
        public void set_FirstNumber()
        {
            Console.Write("Geben Sie die erste Zahl an: ");
            double input = Convert.ToDouble(Console.ReadLine());
            FirstNumber = input;
        }

        public double get_SecondNumber()
        {
            set_SecondNumber();
            return SecondNumber;
        }
        public void set_SecondNumber()
        {
            Console.Write("Geben Sie die zweite Zahl an: ");
            double input = Convert.ToDouble(Console.ReadLine());
            SecondNumber = input;
        }

        public double get_Result()
        { return Result; }
        public void set_Result(double result)
        { Result = result; }
    }
}
