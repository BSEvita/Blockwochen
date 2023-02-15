using System;

class NumberConverter
{
    private int _value;
    private int _base;

    public NumberConverter(int value, int numBase)
    {
        _value = value;
        _base = numBase;
    }

    public int Value
    {
        get { return _value; }
    }

    public int Base
    {
        get { return _base; }
    }

    public static NumberConverter operator +(NumberConverter a, NumberConverter b)
    {
        if (a._base != b._base)
        {
            throw new Exception("Numbers must be in the same base to perform arithmetic operations.");
        }

        return new NumberConverter(a._value + b._value, a._base);
    }

    public static NumberConverter operator -(NumberConverter a, NumberConverter b)
    {
        if (a._base != b._base)
        {
            throw new Exception("Numbers must be in the same base to perform arithmetic operations.");
        }

        return new NumberConverter(a._value - b._value, a._base);
    }

    public static NumberConverter operator *(NumberConverter a, NumberConverter b)
    {
        if (a._base != b._base)
        {
            throw new Exception("Numbers must be in the same base to perform arithmetic operations.");
        }

        return new NumberConverter(a._value * b._value, a._base);
    }

    public static NumberConverter operator /(NumberConverter a, NumberConverter b)
    {
        if (a._base != b._base)
        {
            throw new Exception("Numbers must be in the same base to perform arithmetic operations.");
        }

        return new NumberConverter(a._value / b._value, a._base);
    }

    public NumberConverter ToBinary()
    {
        return new NumberConverter(Convert.ToInt32(Convert.ToString(_value, 2), 2), 2);
    }

    public NumberConverter ToOctal()
    {
        return new NumberConverter(Convert.ToInt32(Convert.ToString(_value, 8), 8), 8);
    }

    public NumberConverter ToDecimal()
    {
        return new NumberConverter(Convert.ToInt32(Convert.ToString(_value, 10), 10), 10);
    }

    public NumberConverter ToHexadecimal()
    {
        return new NumberConverter(Convert.ToInt32(Convert.ToString(_value, 16), 16), 16);
    }
}

class Program
{
    static void Main(string[] args)
    {
Console.Write(@"
  ____     _    _          ___         _             ___        _                 
 |_  /__ _| |_ | |___ _ _ / __|_  _ __| |_ ___ _ __ | _ \___ __| |_  _ _  ___ _ _ 
  / // _` | ' \| / -_) ' \\__ \ || (_-<  _/ -_) '  \|   / -_) _| ' \| ' \/ -_) '_|
 /___\__,_|_||_|_\___|_||_|___/\_, /__/\__\___|_|_|_|_|_\___\__|_||_|_||_\___|_|  
                               |__/                                               
----------------------------------------------------------------------------
");
Console.ReadLine();
        do
        {
            Console.Clear();
            Console.WriteLine("Enter the first number: ");
            int value1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int value2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the base of the numbers (2, 8, 10, or 16): ");
            int numBase = int.Parse(Console.ReadLine());

            NumberConverter a = new NumberConverter(value1, numBase);
            NumberConverter b = new NumberConverter(value2, numBase);

Console.WriteLine(@"
Welche Rechenoperation möchtest du ausführen?:
1. [+]
2. [-]
3. [*]
4. [/]
--------------------------------------");
            string operation = Console.ReadLine();

            NumberConverter result = new NumberConverter(0, numBase);
            switch (operation)
            {
                case "1":
                    result = a + b;
                    break;
                case "2":
                    result = a - b;
                    break;
                case "3":
                    result = a * b;
                    break;
                case "4":
                    result = a / b;
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    break;
            }

            Console.Clear();
            Console.WriteLine("Result: " + result.Value);
//ask for Restart
Console.Write(@"
--------------------------------------

Press Y to run the program again, or any other key to exit: ");
        } while (Console.ReadKey(true).Key == ConsoleKey.Y);
        Console.Clear();
    }
}