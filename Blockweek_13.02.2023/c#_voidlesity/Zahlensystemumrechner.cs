using System;

class NumberConverter
{
    private int decimalValue;
    
    public NumberConverter(int decimalValue)
    {
        this.decimalValue = decimalValue;
    }

    public static NumberConverter FromBinary(string binaryValue)
    {
        int decimalValue = Convert.ToInt32(binaryValue, 2);
        return new NumberConverter(decimalValue);
    }

    public static NumberConverter FromOctal(string octalValue)
    {
        int decimalValue = Convert.ToInt32(octalValue, 8);
        return new NumberConverter(decimalValue);
    }

    public static NumberConverter FromDecimal(int decimalValue)
    {
        return new NumberConverter(decimalValue);
    }

    public static NumberConverter FromHexadecimal(string hexadecimalValue)
    {
        int decimalValue = Convert.ToInt32(hexadecimalValue, 16);
        return new NumberConverter(decimalValue);
    }

    public string ToBinary()
    {
        return Convert.ToString(decimalValue, 2);
    }

    public string ToOctal()
    {
        return Convert.ToString(decimalValue, 8);
    }

    public int ToDecimal()
    {
        return decimalValue;
    }

    public string ToHexadecimal()
    {
        return Convert.ToString(decimalValue, 16);
    }

    public static NumberConverter operator +(NumberConverter a, NumberConverter b)
    {
        int sum = a.decimalValue + b.decimalValue;
        return new NumberConverter(sum);
    }

    public static NumberConverter operator -(NumberConverter a, NumberConverter b)
    {
        int difference = a.decimalValue - b.decimalValue;
        return new NumberConverter(difference);
    }

    public static NumberConverter operator *(NumberConverter a, NumberConverter b)
    {
        int product = a.decimalValue * b.decimalValue;
        return new NumberConverter(product);
    }

    public static NumberConverter operator /(NumberConverter a, NumberConverter b)
    {
        int quotient = a.decimalValue / b.decimalValue;
        return new NumberConverter(quotient);
    }
}

class Program
{
    static void Main()
    {
        Console.Clear();
Console.Write(@"
  ____     _    _          ___         _             ___        _                 
 |_  /__ _| |_ | |___ _ _ / __|_  _ __| |_ ___ _ __ | _ \___ __| |_  _ _  ___ _ _ 
  / // _` | ' \| / -_) ' \\__ \ || (_-<  _/ -_) '  \|   / -_) _| ' \| ' \/ -_) '_|
 /___\__,_|_||_|_\___|_||_|___/\_, /__/\__\___|_|_|_|_|_\___\__|_||_|_||_\___|_|  
                               |__/                                               
----------------------------------------------------------------------------------
");
        Console.ReadLine();
        do {
            Console.Clear();
            Console.WriteLine("Geben Sie die Basis der Zahlen ein (2, 8, 10, 16):");
            int baseValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Geben Sie die erste Zahl ein:");
            string value1 = Console.ReadLine();

            Console.WriteLine("Geben Sie die zweite Zahl ein:");
            string value2 = Console.ReadLine();

            NumberConverter number1, number2;

            switch (baseValue)
            {
                case 2:
                    number1 = NumberConverter.FromBinary(value1);
                    number2 = NumberConverter.FromBinary(value2);
                    break;
                case 8:
                    number1 = NumberConverter.FromOctal(value1);
                    number2 = NumberConverter.FromOctal(value2);
                    break;
                case 10:
                    number1 = NumberConverter.FromDecimal(Convert.ToInt32(value1));
                    number2 = NumberConverter.FromDecimal(Convert.ToInt32(value2));
                    break;
                case 16:
                    number1 = NumberConverter.FromHexadecimal(value1);
                    number2 = NumberConverter.FromHexadecimal(value2);
                    break;
                default:
                    Console.WriteLine("Ungültige Basis.");
                    return;
            }

            Console.WriteLine("Welche Rechenoperation möchten Sie durchführen (+, -, *, /):");
            string operation = Console.ReadLine();

            NumberConverter result;

            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
                default:
                    Console.WriteLine("Ungültige Rechenoperation.");
                    return;
            }

            Console.Clear();
            Console.WriteLine("Ergebnis: " + result.ToDecimal());
            Console.WriteLine("Ergebnis in Binär: " + result.ToBinary());
            Console.WriteLine("Ergebnis in Oktal: " + result.ToOctal());
            Console.WriteLine("Ergebnis in Hexadezimal: " + result.ToHexadecimal());

        //ask for Restart
Console.Write(@"
--------------------------------------

Press Y to run the program again, or any other key to exit: ");
        } while (Console.ReadKey(true).Key == ConsoleKey.Y);
        Console.Clear();
    }
}