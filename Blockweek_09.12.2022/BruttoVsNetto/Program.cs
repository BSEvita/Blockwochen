using System;
using System.Text;
//using System.Xml.Linq;
Console.OutputEncoding = Encoding.UTF8;
while (true) {
    Console.WriteLine("What you want to calculate? Brutto (a) or Netto (b)\n");
    if (Console.ReadKey(true).Key == ConsoleKey.A)
    {
        Console.Write("Please enter the Netto Sum:\n");
        string nettoInput = Console.ReadLine();
        Console.Write("Please enter the 'Mehrwertsteuersatz' Sum:\n");
        string mwstInput = Console.ReadLine();
        if (mwstInput != null || nettoInput != null)
        {
            double netto = double.Parse(nettoInput);
            // Mehrwertsteuersatz
            double mwsst = double.Parse(mwstInput);

            double mwst_div = netto / 100;
            double mwst = mwst_div * mwsst;


            double brutto = netto + mwst;

            Console.WriteLine("+-----------------------------+");
            Console.WriteLine($"| Netto: {netto, 20} |");
            Console.WriteLine($"| Mehrwertsteuer: {mwst, 11} |");
            Console.WriteLine("+-----------------------------+");
            Console.WriteLine($"Brutto: \x1B[4m{brutto,20}€\x1B[0m\n\n");
            //Console.Write("Der Brutto betrag beträgt: {0}\n", sum);

        }
        else
        {
            Console.Write("Please enter a valid Sum!\n");
        }
    }
    else if (Console.ReadKey(true).Key == ConsoleKey.B)
    {
        Console.Write("Please enter the Brutto Sum:\n");
        string bruttoInput = Console.ReadLine();
        Console.Write("Please enter the 'Mehrwertsteuersatz' Sum:\n");
        string mwstInput = Console.ReadLine();
        if (mwstInput != null || bruttoInput != null)
        {
            float brutto = float.Parse(bruttoInput);
            // Mehrwertsteuersatz
            float mwsst = float.Parse(mwstInput);

            float mwst_div = brutto / 100;
            float mwst = mwst_div * mwsst;


            float netto = brutto - mwst;

            Console.WriteLine("+-----------------------------+");
            Console.WriteLine($"| Brutto: {brutto,19} |");
            Console.WriteLine($"| Mehrwertsteuer: {mwst,11} |");
            Console.WriteLine("+-----------------------------+");
            Console.WriteLine($"Netto: \x1B[4m{netto,20}€\x1B[0m\n\n");
            //Console.Write("Der Brutto betrag beträgt: {0}\n", sum);

        }
        else
        {
            Console.Write("Please enter a valid Sum!\n");
        }
    }
    else
    {
        Console.Write("Please enter 'a' or 'b'\n");
    }
}