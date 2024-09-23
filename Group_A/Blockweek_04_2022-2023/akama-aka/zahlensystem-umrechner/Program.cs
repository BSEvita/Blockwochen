class Converter
{
    private int value;

    public Converter(int value)
    {
        this.value = value;
    }
    
    public static Converter FromBinary(string binaryValue)
    {
        int value = Convert.ToInt32(binaryValue, 2);
        return new Converter(value);
    }
    
    public static Converter FromOctal(string octalValue)
    {
        int value = Convert.ToInt32(octalValue, 8);
        return new Converter(value);
    }
    
    public static Converter FromDecimal(int decimalValue)
    {
        return new Converter(decimalValue);
    }

    public static Converter FromHexadecimal(string hexadecimalValue)
    {
        int value = Convert.ToInt32(hexadecimalValue, 16);
        return new Converter(value);
    }
    
    public string ToBinary()
    {
        return Convert.ToString(value, 2);
    }
    
    public string ToOctal()
    {
        return Convert.ToString(value, 8);
    }
    
    public int ToDecimal()
    {
        return value;
    }
    
    public string ToHexadecimal()
    {
        return Convert.ToString(value, 16);
    }
    
    public static Converter operator +(Converter a, Converter b)
    {
        int sum = a.value + b.value;
        return new Converter(sum);
    }
    
    public static Converter operator -(Converter a, Converter b)
    {
        int difference = a.value - b.value;
        return new Converter(difference);
    }
    
    public static Converter operator *(Converter a, Converter b)
    {
        int product = a.value * b.value;
        return new Converter(product);
    }
    
    public static Converter operator /(Converter a, Converter b)
    {
        int quotient = a.value / b.value;
        return new Converter(quotient);
    }
    
    public static Converter operator %(Converter a, Converter b)
    {
        int remainder = a.value % b.value;
        return new Converter(remainder);
    }
}

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Please enter the base of the number you want to convert:");
        string baseInput = Console.ReadLine();
        Console.WriteLine("Please enter the first number:");
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the second number:");
        int secondNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the operation you want to perform:");
        string operation = Console.ReadLine();
        Converter firstConverter = null;
        Converter secondConverter = null;
        switch (baseInput)
        {
            case "binary":
                firstConverter = Converter.FromBinary(firstNumber.ToString());
                secondConverter = Converter.FromBinary(secondNumber.ToString());
                break;
            case "octal":
                firstConverter = Converter.FromOctal(firstNumber.ToString());
                secondConverter = Converter.FromOctal(secondNumber.ToString());
                break;
            case "decimal":
                firstConverter = Converter.FromDecimal(firstNumber);
                secondConverter = Converter.FromDecimal(secondNumber);
                break;
            case "hexadecimal":
                firstConverter = Converter.FromHexadecimal(firstNumber.ToString());
                secondConverter = Converter.FromHexadecimal(secondNumber.ToString());
                break;
            default:
                Console.WriteLine("Invalid input!");
                return;
        }
        Converter result = null;
        
        switch (operation)
        {
            case "+":
                result = firstConverter + secondConverter;
                break;
            case "-":
                result = firstConverter - secondConverter;
                break;
            case "*":
                result = firstConverter * secondConverter;
                break;
            case "/":
                result = firstConverter / secondConverter;
                break;
            case "%":
                result = firstConverter % secondConverter;
                break;
            default:
                Console.WriteLine("Invalid input!");
                return;
        }
        
        Console.WriteLine("The result is:");
        Console.WriteLine(result.ToBinary());
        Console.WriteLine(result.ToOctal());
        Console.WriteLine(result.ToDecimal());
        Console.WriteLine(result.ToHexadecimal());
    }
}