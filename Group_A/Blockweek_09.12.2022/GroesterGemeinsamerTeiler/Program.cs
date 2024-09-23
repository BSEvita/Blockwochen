using System;

namespace GroesterGemeinsamerTeiler
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bitte gebe den Startwert vom größten gemeinsamen Teiler ein:");
            int startwert = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte gebe den Endwert vom größten gemeinsamen Teiler ein:");
            int endwert = Convert.ToInt32(Console.ReadLine());
            int ggT = 0;
            for (int i = startwert; i > 0; i--)
            {
                if (startwert % i == 0 && endwert % i == 0)
                {
                    ggT = i;
                    break;
                }
            }
            Console.WriteLine("Der größte gemeinsame Teiler von " + startwert + " und " + endwert + " ist " + ggT);
        }
    }
}