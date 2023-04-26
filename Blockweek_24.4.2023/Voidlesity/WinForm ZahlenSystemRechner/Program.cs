namespace ZahlenSystemRechner
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class NumberConverter
    {
        public static int BinaryToDecimal(string binary)
        {
            int decimalNumber = 0;
            int baseValue = 1;
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                if (binary[i] == '1')
                {
                    decimalNumber += baseValue;
                }
                baseValue *= 2;
            }
            return decimalNumber;
        }
        public static string DecimalToBinary(int decimalNumber)
        {
            string binary = "";
            while (decimalNumber > 0)
            {
                binary = (decimalNumber % 2) + binary;
                decimalNumber /= 2;
            }
            return binary;
        }

        public static int OctalToDecimal(string octal)
        {
            int decimalNumber = 0;
            int baseValue = 1;
            for (int i = octal.Length - 1; i >= 0; i--)
            {
                decimalNumber += (octal[i] - '0') * baseValue;
                baseValue *= 8;
            }
            return decimalNumber;
        }

        public static string DecimalToOctal(int decimalNumber)
        {
            string octal = "";
            while (decimalNumber > 0)
            {
                octal = (decimalNumber % 8) + octal;
                decimalNumber /= 8;
            }
            return octal;
        }

        public static int HexadecimalToDecimal(string hexadecimal)
        {
            int decimalNumber = 0;
            int baseValue = 1;
            for (int i = hexadecimal.Length - 1; i >= 0; i--)
            {
                if (hexadecimal[i] >= '0' && hexadecimal[i] <= '9')
                {
                    decimalNumber += (hexadecimal[i] - '0') * baseValue;
                }
                else if (hexadecimal[i] >= 'A' && hexadecimal[i] <= 'F')
                {
                    decimalNumber += (hexadecimal[i] - 'A' + 10) * baseValue;
                }
                baseValue *= 16;
            }
            return decimalNumber;
        }

        public static string DecimalToHexadecimal(int decimalNumber)
        {
            string hexadecimal = "";
            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % 16;
                if (remainder < 10)
                {
                    hexadecimal = remainder + hexadecimal;
                }
                else
                {
                    hexadecimal = (char)('A' + remainder - 10) + hexadecimal;
                }
                decimalNumber /= 16;
            }
            return hexadecimal;
        }

        public static string Add(string number1, string number2, int baseValue)
        {
            int sign1 = 1, sign2 = 1;
            if (number1.StartsWith("-"))
            {
                sign1 = -1;
                number1 = number1.Substring(1);
            }
            if (number2.StartsWith("-"))
            {
                sign2 = -1;
                number2 = number2.Substring(1);
            }
            int result = sign1 * ConvertToDecimal(number1, baseValue) + sign2 * ConvertToDecimal(number2, baseValue);
            string resultString = ConvertFromDecimal(Math.Abs(result), baseValue);
            if (result < 0)
            {
                resultString = "-" + resultString;
            }
            return resultString;
        }

        public static string Subtract(string number1, string number2, int baseValue)
        {
            int result = ConvertToDecimal(number1, baseValue) - ConvertToDecimal(number2, baseValue);
            string resultString = ConvertFromDecimal(Math.Abs(result), baseValue);
            if (result < 0)
            {
                resultString = "-" + resultString;
            }
            return resultString;
        }

        public static string Multiply(string number1, string number2, int baseValue)
        {
            int sign1 = 1, sign2 = 1;
            if (number1.StartsWith("-"))
            {
                sign1 = -1;
                number1 = number1.Substring(1);
            }
            if (number2.StartsWith("-"))
            {
                sign2 = -1;
                number2 = number2.Substring(1);
            }
            int result = sign1 * sign2 * ConvertToDecimal(number1, baseValue) * ConvertToDecimal(number2, baseValue);
            string resultString = ConvertFromDecimal(Math.Abs(result), baseValue);
            if (result < 0)
            {
                resultString = "-" + resultString;
            }
            return resultString;
        }

        public static string Divide(string number1, string number2, int baseValue)
        {
            int sign1 = 1, sign2 = 1;
            if (number1.StartsWith("-"))
            {
                sign1 = -1;
                number1 = number1.Substring(1);
            }
            if (number2.StartsWith("-"))
            {
                sign2 = -1;
                number2 = number2.Substring(1);
            }
            int result = sign1 * sign2 * ConvertToDecimal(number1, baseValue) / ConvertToDecimal(number2, baseValue);
            string resultString = ConvertFromDecimal(Math.Abs(result), baseValue);
            if (result < 0)
            {
                resultString = "-" + resultString;
            }
            return resultString;
        }

        private static int ConvertToDecimal(string number, int baseValue)
        {
            int decimalNumber = 0;
            int basePower = 1;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                int digitValue = (number[i] >= '0' && number[i] <= '9') ? (number[i] - '0') : (number[i] - 'A' + 10);
                decimalNumber += digitValue * basePower;
                basePower *= baseValue;
            }
            return decimalNumber;
        }

        private static string ConvertFromDecimal(int decimalNumber, int baseValue)
        {
            string number = "";
            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % baseValue;
                if (remainder < 10)
                {
                    number = remainder + number;
                }
                else
                {
                    number = (char)('A' + remainder - 10) + number;
                }
                decimalNumber /= baseValue;
            }
            return number;
        }
    }
}
