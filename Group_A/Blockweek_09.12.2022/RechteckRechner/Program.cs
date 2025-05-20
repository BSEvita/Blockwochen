using System;

namespace RechteckRechner
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Bitte gebe die Breite ein:");
                var breite = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Bitte gebe die Höhe ein:");
                var hoehe = Convert.ToInt32(Console.ReadLine());
            
            
                Console.WriteLine("Das Rechteck hat eine Fläche von " + breite * hoehe + " und einen Umfang von " + (breite + hoehe) * 2);
            }
        }
    }
}