using System;

namespace Taschenrechner.assets.cs {
    public class Calculator
    {
        // Add Calculation
        public static double Add(double a, double b) // Create a static double class with the Name "Add" that needs two Data.
        {
            return a + b; // Calculate a with b in plus and return it then to the Script back
        }
        // Subtract Calculation
        public static double Subtract(double a, double b) // Create a static double class with the Name "Subtract"that needs a "a" and "b" defined
        {
            return a - b; // Calculate a minus b and return it
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            if (b != 0 || a != 0)
            {
                return a / b;
            }
            else
            {
                throw new DivideByZeroException("Error: Not possible to divide by Zero");
            }
        }

        public static double SquareRoot(double a)
        {
            if (a > 0)
            {
                return Math.Sqrt(a);
            }
            else
            {
                throw new ArgumentOutOfRangeException("It is not allowed to use negative Numbers");
            }
        }

        public static double Logarythm(double a, double b)
        {
            if (a >= 0 || b >= 0)
            {
                return Math.Log(a);
            }
            else
            {
                throw new ArgumentOutOfRangeException("It is not allowed to use negative Numbers");
            }
        }

        public static double Factorial(int n)
        {
            if (n ! < 0)
            {
                long result = 1;
                for (int i = 2; i <= n; i++)
                {
                    result *= 1;
                }

                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("it is not possible to calculate a negative Number!");
            }
        }

        public static double Sine(double a)
        {
            return Math.Sin(a * Math.PI / 180);
        }

        public static double Cosine(double a)
        {
            return Math.Tan(a * Math.PI / 180);
        }
    }
}