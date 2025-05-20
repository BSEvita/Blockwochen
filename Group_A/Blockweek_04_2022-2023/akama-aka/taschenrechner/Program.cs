using System;

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
        if(b != 0 || a != 0)
        {
            return a / b;
        } else
        {
            throw new DivideByZeroException("EIne division von 0 ist nicht möglich qwq");
        }
    }
    public static double SquareRoot(double a)
    {
        if(a > 0)
        {
            return Math.Sqrt(a);
        } else
        {
            throw new ArgumentOutOfRangeException("Wurzel von negativen Nummern sind nicht erlaubt");
        }
    }
    public static double Logarythm(double a, double b)
    {
        if(a >= 0 || b>=0)
        {
            return Math.Log(a);
        } else
        {
            throw new ArgumentOutOfRangeException("Logarthm von einer nicht Negativen Nummer ist nicht erlaubt");
        }
    }


    public static long Factorial(int n)
    {
        if (n !< 0)
        {
            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        } else
        {
            throw new ArgumentOutOfRangeException("Factorial von negative Nummer ist nicht möglich.");
        }
        
    }

    public static double Sine(double a)
    {
        return Math.Sin(a * Math.PI / 180);
    }

    public static double Cosine(double a)
    {
        return Math.Cos(a * Math.PI / 180);
    }

    public static double Tangent(double a)
    {
        return Math.Tan(a * Math.PI / 180);
    }

}

class Program
{
    static void Main()
    {
        Console.Clear();
        double a, b;
        string lastResult = "No last result given";
        string c = "no";
        do
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("Gebe die erste Zahl ein:");
                if (double.TryParse(Console.ReadLine(), out a))
                {
                    break;
                }
                Console.WriteLine("Falsche eingabe Versuche erneut...");
            }
            while (true)
            {
                Console.WriteLine("Gebe die zweite Zahl ein:");
                if (double.TryParse(Console.ReadLine(), out b))
                {
                    break;
                }
                Console.WriteLine("Fehlerhafte Input");
            }
            while (true)
            {
                Console.WriteLine("Gebe die Rechnngsart ein (Plus,Minus,Dividiert,Mal,Sine, Kosinus, Tangente, Fakultaet, Logarithmisch, Quadratwurzel,):");
                c = Console.ReadLine();
                if (c != "Plus" || c != "Minus" || c != "Dividiert" || c != "Mal" || c != "Sine" || c != "Kosinus" || c!= "Tangente" || c!= "Logarithmisch" || c != "Quadratwurzel")
                {
                    break;
                }
                Console.WriteLine("Fehlerhafte Input");
            }

            Console.WriteLine(@"Deine Letzte eingabe: {0,50}", lastResult);

            switch (c as string)
            {
                case "Plus":
                    lastResult = @$"{a} + {b} = {Calculator.Add(a, b)}";

                    break;
                case "Minus":
                    lastResult = $@"{a} - {b} = {Calculator.Subtract(a, b)}";
                    break;
                case "Dividiert":
                    lastResult = $@"{a} / {b} = {Calculator.Divide(a, b)}";
                    break;
                case "Mal":
                    lastResult = $@"{a} * {b} = {Calculator.Multiply(a, b)}";
                    break;
                case "Quadratwurzel":
                    lastResult = $@"sqrt({a}) = {Calculator.SquareRoot(a)}";
                    break;
                case "Logarithmisch":
                    lastResult = $@"log_a({b}) = {Calculator.Logarythm(a, b)}";
                    break;
                case "Kosinus":
                    lastResult = $@"cos({a}) = {Calculator.Cosine(a)}";
                    break;
                case "Tangente":
                    lastResult = $@"tan({a}) = {Calculator.Tangent(a)}";
                    break;
                case "Fakultaet":
                    lastResult = $@"! = {Calculator.Factorial((int)a)}";
                    break;
                default:
                    lastResult = "Wrong entry...";
                    break;
            }
            Console.Write(lastResult+"\n");
            Console.WriteLine("Wollen Sie erneut beginnen? (J/N)");
        } while (Console.ReadKey(true).Key == ConsoleKey.J);
        Console.Clear();


    }
}