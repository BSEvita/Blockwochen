using System;
using System.Collections;
public class Program
{
    public static void Main()
    {
        // Created in School.
        /*Console.WriteLine("Bitte gebe die Noten ein. (Getrennt durch ein Leerzeichen)");
        string input = Console.ReadLine();
        char[] separators = new char[] { ' ', '.' };
        string[] subs = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        ArrayList arrlist = new ArrayList();
        int count = 0;
        foreach (var sub in subs)
        {
            count = count+1;
            if(sub == "1") {
                Console.WriteLine("Die "+count+". Note ist: Sehr Gut");
            } else if(sub == "2") {;
                Console.WriteLine("Die "+count+". Note ist: Gut");
            } else if(sub == "3") {
                Console.WriteLine("Die "+count+". Note ist: Befriedigend");
            } else if(sub == "4") {
                Console.WriteLine("Die "+count+". Note ist: Genügend");
            } else if(sub == "5") {
                Console.WriteLine("Die "+count+". Note ist: Schlecht");
            } else {
                Console.WriteLine("Das Noten System muss dem Noten System aus Österreich wiederspiegeln! 1-5");
            }
        }
        Main();*/
        // Better Version edited at Home
        Console.WriteLine("Bitte gebe die Noten ein. (Getrennt durch ein Leerzeichen)");
        string input = Console.ReadLine();
        char[] separators = new char[] { ' ', '.' };
        string[] subs = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        ArrayList arrlist = new ArrayList();
        int count = 0;
        foreach (var sub in subs)
        {
            count = count+1;
            switch (sub)
            {
                case "1":
                    Console.WriteLine("Die "+count+". Note ist: Sehr Gut");
                    break;
                case "2":
                    Console.WriteLine("Die "+count+". Note ist: Gut");
                    break;
                case "3":
                    Console.WriteLine("Die "+count+". Note ist: Befriedigend");
                    break;
                case "4":
                    Console.WriteLine("Die "+count+". Note ist: Genügend");
                    break;
                case "5":
                    Console.WriteLine("Die "+count+". Note ist: Schlecht");
                    break;
                default:
                    Console.WriteLine("Das Noten System muss dem Noten System aus Österreich wiederspiegeln! 1-5");
                    break;
            }
        }
        Main();
    }
}