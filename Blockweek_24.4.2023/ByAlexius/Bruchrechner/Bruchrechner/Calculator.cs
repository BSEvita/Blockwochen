using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Bruchrechner
{
    public class Calculator
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Calculator(int i, int i2)
        {
            int devisor = CalculateGCD(i, i2);
            Numerator = i / devisor;
            Denominator = i2 / devisor;
        }

        public static Calculator Addition(Calculator c1, Calculator c2)
        {
            int numerator = c1.Numerator * c2.Denominator + c2.Numerator * c1.Denominator;
            int denominator = c1.Denominator * c2.Denominator;
            return new Calculator(numerator, denominator);
        }

        public static Calculator Subtract(Calculator c1, Calculator c2)
        {
            int numerator = c1.Numerator * c2.Denominator - c2.Numerator * c1.Denominator;
            int denominator = c1.Denominator * c2.Denominator;
            return new Calculator(numerator, denominator);
        }

        public static Calculator Multiply(Calculator c1, Calculator c2)
        {
            int numerator = c1.Numerator * c2.Numerator;
            int denominator = c1.Denominator * c2.Denominator;
            return new Calculator(numerator, denominator);
        }

        public static Calculator Divide(Calculator c1, Calculator c2)
        {
            int numerator = c1.Numerator * c2.Denominator;
            int denominator = c1.Denominator * c2.Numerator;
            return new Calculator(numerator, denominator);
        }

        public static Calculator Exponentiate(Calculator c, int i)
        {
            int numerator = (int) Math.Pow(c.Numerator, i);
            int denominator = (int) Math.Pow(c.Denominator, i);
            return new Calculator(numerator, denominator);
        }

        public static Calculator sqrt(Calculator c)
        {
            int numerator = (int) Math.Sqrt(c.Numerator);
            int denominator = (int) Math.Sqrt(c.Denominator);
            return new Calculator(numerator, denominator);
        }

        public override string ToString()
        {
            if (Denominator == 1)
                return Numerator.ToString();
            else
                return Numerator + " | " + Denominator;
            
        }

        private int CalculateGCD(int i, int i2)
        {
            if (i2 == 0)
            {
                return i;
            }
            else
            {
                return CalculateGCD(i, i % i2);
            }
        }
    }
}
