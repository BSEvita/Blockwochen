using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LINQTutorial
{
    class Video2
    {
        static void MainVideo2(string[] args)
        {
            string[] names = { "Peter", "Günter", "Manfred", "Uwe" };
            var linqTest = from name in names
                           where name.Contains('t')
                           select name;
            foreach (string name in linqTest)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}