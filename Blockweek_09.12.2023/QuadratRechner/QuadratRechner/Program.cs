using System;

namespace QuadratRechner
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Bitte gebe die Seitenlänge des Quadrates ein:");
                var seitenlaenge = Convert.ToDouble(Console.ReadLine());
                var flaeche = seitenlaenge * seitenlaenge;
                var umfang = seitenlaenge * 4;
            
                Console.WriteLine("Die Fläche des Quadrates beträgt: " + flaeche);
                Console.WriteLine("Der Umfang des Quadrates beträgt: " + umfang);
            }
            
        }
    }
}