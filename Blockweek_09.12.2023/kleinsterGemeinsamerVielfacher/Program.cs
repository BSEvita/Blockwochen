using System;

namespace kleinsterGemeinsamerTeiler
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // kleinste gemeinsame Vielfache Rechner
            Console.WriteLine("Bitte gebe den ersten Wert des kleinste gemeinsame Vielfachen ein:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte gebe den zweiten Wert des kleinste gemeinsame Vielfachen ein:");
            int b = Convert.ToInt32(Console.ReadLine());
            
            int kleinsteGemeinsameVielfache = 0;
            int i = 1;
            int j = 1;
            
            while (kleinsteGemeinsameVielfache == 0)
            {
                if (a * i == b * j)
                {
                    kleinsteGemeinsameVielfache = a * i;
                }
                else if (a * i < b * j)
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }
            
            Console.WriteLine("Das kleinste gemeinsame Vielfache ist: " + kleinsteGemeinsameVielfache);

        }
    }
}