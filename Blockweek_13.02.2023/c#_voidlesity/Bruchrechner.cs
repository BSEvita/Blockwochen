class Bruch
{
    private int zaehler;
    private int nenner;

    public Bruch(int zaehler, int nenner)
    {
        this.zaehler = zaehler;
        this.nenner = nenner;
        this.Kuerzen();
    }

    public int Zaehler
    {
        get { return zaehler; }
    }

    public int Nenner
    {
        get { return nenner; }
    }

    public static Bruch operator +(Bruch a, Bruch b)
    {
        int zaehler = a.zaehler * b.nenner + b.zaehler * a.nenner;
        int nenner = a.nenner * b.nenner;
        return new Bruch(zaehler, nenner);
    }

    public static Bruch operator -(Bruch a, Bruch b)
    {
        int zaehler = a.zaehler * b.nenner - b.zaehler * a.nenner;
        int nenner = a.nenner * b.nenner;
        return new Bruch(zaehler, nenner);
    }

    public static Bruch operator *(Bruch a, Bruch b)
    {
        int zaehler = a.zaehler * b.zaehler;
        int nenner = a.nenner * b.nenner;
        return new Bruch(zaehler, nenner);
    }

    public static Bruch operator /(Bruch a, Bruch b)
    {
        int zaehler = a.zaehler * b.nenner;
        int nenner = a.nenner * b.zaehler;
        return new Bruch(zaehler, nenner);
    }

    public static Bruch operator ^(Bruch a, int exponent)
    {
        int zaehler = (int)Math.Pow(a.zaehler, exponent);
        int nenner = (int)Math.Pow(a.nenner, exponent);
        return new Bruch(zaehler, nenner);
    }

    public static Bruch operator *(int skalar, Bruch a)
    {
        int zaehler = skalar * a.zaehler;
        int nenner = a.nenner;
        return new Bruch(zaehler, nenner);
    }

    private void Kuerzen()
    {
        int teiler = this.GgT(this.zaehler, this.nenner);
        this.zaehler /= teiler;
        this.nenner /= teiler;

        if (this.nenner < 0)
        {
            this.zaehler *= -1;
            this.nenner *= -1;
        }
    }

    private int GgT(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);

        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        return a;
    }

    public override string ToString()
    {
        if (nenner == 1)
        {
            return zaehler.ToString();
        }
        else
        {
            return zaehler.ToString() + "/" + nenner.ToString();
        }
    }
}

class Bruchrechner
{
    static void Main(string[] args)
    {
        do {
Console.WriteLine(@"
Welche Rechenoperation möchtest du ausführen?:
1. [+]
2. [-]
3. [*]
4. [/]
5. [^]
6. [√]
--------------------------------------");
        string operation = Console.ReadLine();

        Console.WriteLine("Geben Sie den ersten Bruch ein (Zähler/Nenner):");
        string[] bruch1String = Console.ReadLine().Split('/');
        int zaehler1 = int.Parse(bruch1String[0]);
        int nenner1 = int.Parse(bruch1String[1]);
        Bruch bruch1 = new Bruch(zaehler1, nenner1);

        Console.WriteLine("Geben Sie den zweiten Bruch ein (Zähler/Nenner):");
        string[] bruch2String = Console.ReadLine().Split('/');
        int zaehler2 = int.Parse(bruch2String[0]);
        int nenner2 = int.Parse(bruch2String[1]);
        Bruch bruch2 = new Bruch(zaehler2, nenner2);

        Bruch ergebnis = new Bruch(0, 1);

        switch (operation)
        {
            case "1":
                ergebnis = bruch1 + bruch2;
                break;
            case "2":
                ergebnis = bruch1 - bruch2;
                break;
            case "3":
                ergebnis = bruch1 * bruch2;
                break;
            case "4":
                ergebnis = bruch1 / bruch2;
                break;
            case "5":
                Console.WriteLine("Geben Sie den Exponenten ein:");
                int exponent = int.Parse(Console.ReadLine());
                ergebnis = bruch1 ^ exponent;
                break;
            case "6":
                ergebnis = new Bruch((int)Math.Sqrt(bruch1.Zaehler), (int)Math.Sqrt(bruch1.Nenner));
                break;
            default:
                Console.WriteLine("Ungültige Eingabe!");
                return;
        }
Console.Write(@"
--------------------------------------

Press Y to run the program again, or any other key to exit: ");
        Console.WriteLine("Das Ergebnis ist: " + ergebnis);
        } while (Console.ReadKey(true).Key == ConsoleKey.Y);
        Console.Clear();
    }
}