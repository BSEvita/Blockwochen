using System;

class Calculator {
    public static double Add(double a, double b) {
        return a + b;
    }

    public static double Subtract(double a, double b) {
        return a - b;
    }

    public static double Multiply(double a, double b) {
        return a * b;
    }

    public static double Divide(double a, double b) {
        if (b == 0) {
            throw new DivideByZeroException("Division by zero is not allowed.");
        }
        return a / b;
    }

    public static double Power(double a, double b) {
        return Math.Pow(a, b);
    }

    public static double SquareRoot(double a) {
        if (a < 0) {
            throw new ArgumentOutOfRangeException("Square root of negative number is not allowed.");
        }
        return Math.Sqrt(a);
    }

    public static double Logarithm(double a, double b) {
        if (a <= 0 || b <= 0) {
            throw new ArgumentOutOfRangeException("Logarithm of non-positive number is not allowed.");
        }
        return Math.Log(a, b);
    }

    public static long Factorial(int n) {
        if (n < 0) {
            throw new ArgumentOutOfRangeException("Factorial of negative number is not allowed.");
        }
        long result = 1;
        for (int i = 2; i <= n; i++) {
            result *= i;
        }
        return result;
    }

    public static double Sine(double a) {
        return Math.Sin(a * Math.PI / 180);
    }

    public static double Cosine(double a) {
        return Math.Cos(a * Math.PI / 180);
    }

    public static double Tangent(double a) {
        return Math.Tan(a * Math.PI / 180);
    }
}

class Program {
    static void Main()
{

//start supper Cool Calculator
Console.Clear();
Console.WriteLine(@"
   ______      __           __      __                          
  / ____/___ _/ /______  __/ /___ _/ /_____  _____     __    __ 
 / /   / __ `/ / ___/ / / / / __ `/ __/ __ \/ ___/  __/ /___/ /_
/ /___/ /_/ / / /__/ /_/ / / /_/ / /_/ /_/ / /     /_  __/_  __/
\____/\__,_/_/\___/\__,_/_/\__,_/\__/\____/_/       /_/   /_/   
");
Console.ReadLine();

//create Cool Last Result Variable
string lastResult = @"    _  __       __            __    ___               ____ 
   / |/ /__    / /  ___ ____ / /_  / _ \___ ___ __ __/ / /_
  /    / _ \  / /__/ _ `(_-</ __/ / , _/ -_|_-</ // / / __/
 /_/|_/\___/ /____/\_,_/___/\__/ /_/|_|\__/___/\_,_/_/\__/ 
 ";

//loop that shid
    do {
        Console.Clear();
        double a, b;
        while (true) {
            Console.Write("Enter the first number: ");
            if (double.TryParse(Console.ReadLine(), out a)) {
                break;
            }
            Console.WriteLine("Invalid input. Please enter a number.");
        }

        while (true) {
            Console.Write("Enter the second number: ");
            if (double.TryParse(Console.ReadLine(), out b)) {
                break;
            }
            Console.WriteLine("Invalid input. Please enter a number.");
        }

Console.Write(@"
  _            _     ___             _ _   
 | |   __ _ __| |_  | _ \___ ____  _| | |_ 
 | |__/ _` (_-<  _| |   / -_|_-< || | |  _|
 |____\__,_/__/\__| |_|_\___/__/\_,_|_|\__|
 --------------------------------------

");
        Console.Write(lastResult);

Console.WriteLine(@"
--------------------------------------
   ___ _   _ ___ ___ ___ _  _ _____ 
  / __| | | | _ \ _ \ __| \| |_   _|
 | (__| |_| |   /   / _|| .` | | |  
  \___|\___/|_|_\_|_\___|_|\_| |_|  

--------------------------------------
");

//replace old Last Result
lastResult = @$"    {a} + {b} = {Calculator.Add(a, b)}
    {a} - {b} = {Calculator.Subtract(a, b)}
    {a} * {b} = {Calculator.Multiply(a, b)}
    {a} / {b} = {Calculator.Divide(a, b)}
    {a} ^ {b} = {Calculator.Power(a, b)}
    sqrt({a}) = {Calculator.SquareRoot(a)}
    log_a({b}) = {Calculator.Logarithm(a, b)}
    ! = {Calculator.Factorial((int)a)}
    sin({a}) = {Calculator.Sine(a)}
    cos({a}) = {Calculator.Cosine(a)}
    tan({a}) = {Calculator.Tangent(a)}
    ";

//Print the current Results
Console.Write(lastResult);

//ask for Restart
Console.Write(@"
--------------------------------------

Press Y to run the program again, or any other key to exit: ");
    } while (Console.ReadKey(true).Key == ConsoleKey.Y);
    Console.Clear();
}
}