using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LINQTutorial
{
    class Video1
    {
        static void MainVideo1(string[] args)
        { 
            string[] names = { "Peter", "Günter", "Manfred", "Uwe" };

            // Query Syntax

            var linqTest = from name in names
                           where name.Contains('t')
                           select name;

            // Methode Syntax

            var linqTestMethode = names.Where(name => name.Contains('t'));

            foreach (string name in linqTest)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}