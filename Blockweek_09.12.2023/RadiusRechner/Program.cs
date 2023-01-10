using System;

namespace RadiusRechner
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Bitte gebe den Radius des Kreises ein:");
                var radius = Convert.ToDouble(Console.ReadLine());
                var umfang = 2 * Math.PI * radius;
                var flaeche = Math.PI * Math.Pow(radius, 2);
            
                Console.WriteLine("Der Umfang des Kreises ist: " + umfang);
                Console.WriteLine("Die Fläche des Kreises ist: " + flaeche);
            }
        }
    }
}