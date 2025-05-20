class BruchRechner {
    private int counter;
    private int denominator;

    public BruchRechner(int counter, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("You entered an invalid denominator!");
        }

        this.counter = counter;
        this.denominator = denominator;
        Reduce();
    }

    private void Reduce()
    {
        int ggt = GGT(Math.Abs(counter), Math.Abs((denominator)));
        counter /= ggt;
        denominator /= ggt;
        if (denominator < 0)
        {
            counter = -counter;
            denominator = -denominator;
        }
    }

    private int GGT(int a, int b)
    {
        while (b != 0)
        {
            int rest = a % b;
            a = b;
            b = rest;
        }

        return a;
    }
    
    public static BruchRechner operator +(BruchRechner a, BruchRechner b)
    {
        int newDenominator = a.denominator * b.denominator;
        int newCounter = a.counter * b.denominator + b.counter * a.denominator;
        return new BruchRechner(newCounter, newDenominator);
    }
    
    public static BruchRechner operator -(BruchRechner a, BruchRechner b)
    {
        int newDenominator = a.denominator * b.denominator;
        int newCounter = a.counter * b.denominator - b.counter * a.denominator;
        return new BruchRechner(newCounter, newDenominator);
    }
    
    public static BruchRechner operator *(BruchRechner a, BruchRechner b)
    {
        int newCounter = a.counter * b.counter;
        int newDenominator = a.denominator * b.denominator;
        return new BruchRechner(newCounter, newDenominator);
    }
    
    public static BruchRechner operator /(BruchRechner a, BruchRechner b)
    {
        int newCounter = a.counter * b.denominator;
        int newDenominator = a.denominator * b.counter;
        return new BruchRechner(newCounter, newDenominator);
    }
    public BruchRechner Root(int n)
    {
        int newCounter = (int) Math.Pow(counter, 1.0 / n);
        int newDenominator = (int) Math.Pow(denominator, 1.0 / n);
        return new BruchRechner(newCounter, newDenominator);
    }
    public BruchRechner Power(int exponent)
    {
        int newCounter = (int) Math.Pow(counter, exponent);
        int newDenominator = (int) Math.Pow(denominator, exponent);
        return new BruchRechner(newCounter, newDenominator);
    }
    
    public override string ToString()
    {
        return $"{counter}/{denominator}";
    }
}

class Program
{
    static void Main()
    {
        do
        {
            Console.WriteLine("Bitte gebe den Zähler vom ersten Bruch ein:");
            int counter1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Bitte gebe den Nenner vom ersten Bruch ein:");
            int denominator1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Bitte gebe den Zähler vom zweiten Bruch ein:");
            int counter2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Bitte gebe den Nenner vom zweiten Bruch ein:");
            int denominator2 = int.Parse(Console.ReadLine());
            BruchRechner bruch1 = new BruchRechner(counter1, denominator1);
            BruchRechner bruch2 = new BruchRechner(counter2, denominator2);
            Console.WriteLine("Die Summe der beiden Brüche ist: " + (bruch1 + bruch2));
            Console.WriteLine("Die Differenz der beiden Brüche ist: " + (bruch1 - bruch2));
            Console.WriteLine("Das Produkt der beiden Brüche ist: " + (bruch1 * bruch2));
            Console.WriteLine("Der Quotient der beiden Brüche ist: " + (bruch1 / bruch2));
            Console.WriteLine("Der erste Bruch hoch die zweite Zahl ist: " + bruch1.Power(counter2));
            Console.WriteLine("Der erste Bruch hoch die zweite Zahl ist: " + bruch1.Root(counter2));
            Console.WriteLine("Möchtest du nochmal eine Berechnung durchführen? (j/n)");
        } while (Console.ReadLine() == "j");
    }
}