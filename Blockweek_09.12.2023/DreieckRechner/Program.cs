using System;

namespace DreieckRechner
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Bitte gebe zwei Seitenlängen ein getrennt durch ein Kommer:");
                string eingabe = Console.ReadLine();
                string[] seiten = eingabe.Split(',');
                double seite1 = Convert.ToDouble(seiten[0]);
            
                double seite2 = Convert.ToDouble(seiten[1]);
                double seite3 = Math.Sqrt(Math.Pow(seite1, 2) + Math.Pow(seite2, 2));
                // Berechne Umfang:
            
                double umfang = seite1 + seite2 + seite3;
                // Berechne Fläche:
            
                double flaeche = seite1 * seite2 / 2;
                // Ausgabe:
            
                Console.WriteLine("Die Seitenlängen sind: " + seite1 + ", " + seite2 + ", " + seite3);
                Console.WriteLine("Der Umfang ist: " + umfang);
            
                Console.WriteLine("Die Fläche ist: " + flaeche);
            }

        }
    }
}