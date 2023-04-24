using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace Taschenrechner
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
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return a / b;
        }

        public static double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public static double Root(double a)
        {
            if (a < 0)
            {
                throw new ArgumentOutOfRangeException("Square root of negative number is not allowed.");
            }
            return Math.Sqrt(a);
        }

        public static double Log10(double a)
        {
            if (a <= 0)
            {
                throw new ArgumentOutOfRangeException("Logarithm of non-positive number is not allowed.");
            }
            return Math.Log10(a);
        }

        public static double Log(double a, double b)
        {
            if (a <= 0 || b <= 0)
            {
                throw new ArgumentOutOfRangeException("Logarithm of non-positive number is not allowed.");
            }
            return Math.Log(a, b);
        }

        public static double Factorial(double n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException("Factorial of negative number is not allowed.");
            }
            int intN = (int)n;
            BigInteger result = 1;
            for (int i = 2; i <= intN; i++)
            {
                result *= i;
            }
            return double.Parse(result.ToString());
        }

        public static double Sin(double a)
        {
            return Math.Sin(a * (Math.PI / 180));
        }

        public static double Cos(double a)
        {
            return Math.Cos(a * (Math.PI / 180));
        }

        public static double Tan(double a)
        {
            return Math.Tan(a * (Math.PI / 180));
        }
    }
}