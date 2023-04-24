using System;

class Bruch
{
    private int zähler; // Zähler des Bruchs
    private int nenner; // Nenner des Bruchs

    public Bruch(int zähler, int nenner) // Konstruktor des Bruchs
    {
        if (nenner == 0) // Überprüfung, ob der Nenner 0 ist
        {
            throw new ArgumentException("Nenner darf nicht 0 sein!");
        }

        this.zähler = zähler;
        this.nenner = nenner;
        Kürzen(); // Kürze den Bruch, um ihn so weit wie möglich zu vereinfachen
    }

    private void Kürzen() // Methode, um den Bruch zu kürzen
    {
        int ggt = GGT(Math.Abs(zähler), Math.Abs(nenner)); // Berechne den größten gemeinsamen Teiler des Zählers und des Nenners
        zähler /= ggt; // Teile den Zähler durch den größten gemeinsamen Teiler
        nenner /= ggt; // Teile den Nenner durch den größten gemeinsamen Teiler
        if (nenner < 0) // Wenn der Nenner negativ ist, dann mache den Zähler negativ
        {
            zähler = -zähler;
            nenner = -nenner;
        }
    }

    private int GGT(int a, int b) // Methode, um den größten gemeinsamen Teiler zweier Zahlen zu berechnen
    {
        while (b != 0) // Solange b nicht 0 ist
        {
            int rest = a % b; // Berechne den Rest der Division von a durch b
            a = b; // Setze a auf b
            b = rest; // Setze b auf den Rest
        }
        return a; // Gib a zurück, der jetzt den größten gemeinsamen Teiler enthält
    }

    // Operatorüberladung für die Addition von zwei Brüchen
    public static Bruch operator +(Bruch a, Bruch b)
    {
        int neuerNenner = a.nenner * b.nenner; // Multipliziere die Nenner, um den neuen Nenner zu erhalten
        int neuerZähler = a.zähler * b.nenner + b.zähler * a.nenner; // Multipliziere die Zähler mit dem jeweils anderen Nenner und addiere sie, um den neuen Zähler zu erhalten
        return new Bruch(neuerZähler, neuerNenner); // Gib einen neuen Bruch zurück, der das Ergebnis der Addition ist
    }

    // Operatorüberladung für die Subtraktion von zwei Brüchen
    public static Bruch operator -(Bruch a, Bruch b)
    {
        int neuerNenner = a.nenner * b.nenner; // Multipliziere die Nenner, um den neuen Nenner zu erhalten
        int neuerZähler = a.zähler * b.nenner - b.zähler * a.nenner; // Multipliziere die Zähler mit dem jeweils anderen Nenner und subtrahiere sie, um den neuen Zähler zu erhalten
        return new Bruch(neuerZähler, neuerNenner); // Gib einen neuen Bruch zurück, der das Ergebnis der Subtraktion ist
    }
    // Operatorüberladung für die Multiplikation von zwei Brüchen
    public static Bruch operator *(Bruch a, Bruch b)
    {
        int neuerZähler = a.zähler * b.zähler; // Multipliziere die Zähler, um den neuen Zähler zu erhalten
        int neuerNenner = a.nenner * b.nenner; // Multipliziere die Nenner, um den neuen Nenner zu erhalten
        return new Bruch(neuerZähler, neuerNenner); // Gib einen neuen Bruch zurück, der das Ergebnis der Multiplikation ist
    }

    // Operatorüberladung für die Division von zwei Brüchen
    public static Bruch operator /(Bruch a, Bruch b)
    {
        int neuerZähler = a.zähler * b.nenner; // Multipliziere den Zähler des ersten Bruchs mit dem Nenner des zweiten Bruchs, um den neuen Zähler zu erhalten
        int neuerNenner = a.nenner * b.zähler; // Multipliziere den Nenner des ersten Bruchs mit dem Zähler des zweiten Bruchs, um den neuen Nenner zu erhalten
        return new Bruch(neuerZähler, neuerNenner); // Gib einen neuen Bruch zurück, der das Ergebnis der Division ist
    }

    // Methode zum Potenzieren eines Bruchs
    public Bruch Power(int exponent)
    {
        if (exponent < 0) // Wenn der Exponent negativ ist, werfe eine Ausnahme
        {
            throw new ArgumentException("Exponent darf nicht negativ sein!");
        }

        int neuerZähler = (int)Math.Pow(zähler, exponent); // Potenziere den Zähler auf den Exponenten
        int neuerNenner = (int)Math.Pow(nenner, exponent); // Potenziere den Nenner auf den Exponenten
        return new Bruch(neuerZähler, neuerNenner); // Gib einen neuen Bruch zurück, der das Ergebnis der Potenzierung ist
    }

    // Methode zum Ziehen einer Wurzel aus einem Bruch
    public Bruch Root(int n)
    {
        if (n < 0) // Wenn der Wurzelexponent negativ ist, werfe eine Ausnahme
        {
            throw new ArgumentException("Wurzelexponent darf nicht negativ sein!");
        }

        // Bringe den Nenner auf eine Potenz von n
        int neuerNenner = (int)Math.Pow(nenner, (double)n / 2);

        // Potenziere den Zähler und den Nenner auf die n-te Wurzel
        int neuerZähler = (int)Math.Pow(zähler, 1.0 / n);
        neuerNenner = (int)Math.Pow(neuerNenner, 1.0 / n);

        return new Bruch(neuerZähler, neuerNenner); // Gib einen neuen Bruch zurück, der das Ergebnis der Wurzelziehung ist
    }

    // Methode zur Darstellung des Bruchs als Zeichenkette
    public override string ToString()
    {
        if (nenner == 1) // Wenn der Nenner 1 ist, gib nur den Zähler aus
        {
            return zähler.ToString();
        }
        else // Ansonsten gib den Bruch als "Zähler/Nenner" aus
        {
        return $"{zähler}/{nenner}";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
Console.Write(@"
  ___             _    ___        _                 
 | _ )_ _ _  _ __| |_ | _ \___ __| |_  _ _  ___ _ _ 
 | _ \ '_| || / _| ' \|   / -_) _| ' \| ' \/ -_) '_|
 |___/_|  \_,_\__|_||_|_|_\___\__|_||_|_||_\___|_|  
 ---------------------------------------------------
");
        do 
        {
            Console.Clear();
            // Lese die Eingaben des Benutzers für den ersten Bruch
            Console.Write("Gib den Zähler des ersten Bruchs ein: ");
            int z1 = int.Parse(Console.ReadLine());
            Console.Write("Gib den Nenner des ersten Bruchs ein: ");
            int n1 = int.Parse(Console.ReadLine());
            Bruch a = new Bruch(z1, n1);

            // Lese die Eingaben des Benutzers für den zweiten Bruch
            Console.Write("Gib den Zähler des zweiten Bruchs ein: ");
            int z2 = int.Parse(Console.ReadLine());
            Console.Write("Gib den Nenner des zweiten Bruchs ein: ");
            int n2 = int.Parse(Console.ReadLine());
            Bruch b = new Bruch(z2, n2);

            // Frage den Benutzer nach dem Exponenten und berechne die Potenz des ersten Bruchs, wenn ein Exponent angegeben wurde
            Console.Write("Gib den Exponenten ein: ");
            string exponentString = Console.ReadLine();

            // Führe die verschiedenen Rechenoperationen durch und gib die Ergebnisse aus
            Bruch c = a + b;
            Console.WriteLine($"{a} + {b} = {c}");

            c = a - b;
            Console.WriteLine($"{a} - {b} = {c}");

            c = a * b;
            Console.WriteLine($"{a} * {b} = {c}");

            c = a / b;
            Console.WriteLine($"{a} / {b} = {c}");

            if (!string.IsNullOrEmpty(exponentString)) // Wenn der Benutzer einen Exponenten angegeben hat
            {
                int exponent = int.Parse(exponentString);
                c = a.Power(exponent);
                Console.WriteLine($"{a}^{exponent} = {c}");
            }

            // Berechne die Wurzel des ersten Bruchs und gib das Ergebnis aus
            c = a.Root(2);
            Console.WriteLine($"sqrt({a}) = {c}");

//ask for Restart
Console.Write(@"
--------------------------------------

Press Y to run the program again, or any other key to exit: "); 
        }
        while (Console.ReadKey(true).Key == ConsoleKey.Y);
    Console.Clear();
    }
}