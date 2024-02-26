global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;
global using global::System.Collections;

namespace übungsprojekt
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] pokedexArray = { "Serpifeu", "Floink", "Ottaro", 
                                    "Nagelotz", "Yorkleff", "Felilou", 
                                    "Vegimak", "Grillmak", "Sodamak", 
                                    "Somniam", "Dusselgurr", "Elezeba" };

            IEnumerable<string> linqTest1 = from pokemon in pokedexArray
                                           where pokemon.Contains('a')
                                           select pokemon;

            IEnumerable<string> linqTest2 = pokedexArray.Where(pokemon => pokemon.Contains('n'));

            foreach (string pokemon in linqTest1)
            {
                Console.WriteLine(pokemon);
            }
            Console.WriteLine();

            foreach (string pokemon in linqTest2)
            {
                Console.WriteLine(pokemon);
            }
            Console.WriteLine();

            List<Pokemon> pokedexList = 
            [
                new Pokemon("Serpifeu", "PFLANZE"), 
                new Pokemon("Floink", "FEUER"), 
                new Pokemon("Ottaro", "WASSER"), 
                new Pokemon("Nagelotz", "NORMAL"),                                           
                new Pokemon("Yorkleff", "NORMAL"), 
                new Pokemon("Felilou", "UNLICHT"),
                new Pokemon("Vegimak", "PFLANZE"), 
                new Pokemon("Grillmak", "FEUER"),
                new Pokemon("Sodamak", "WASSER"), 
                new Pokemon("Somniam", "PSYCHO"),
                new Pokemon("Dusselgurr", "NORMAL, FLUG"), 
                new Pokemon("Elezeba", "ELEKTRO")
                    
                    ];

            IEnumerable<Pokemon> normalPokemon = from pokemon in pokedexList
                                                 where (pokemon.Typ.Contains("NORMAL")) && (pokemon.Name.Contains("e"))
                                                 select pokemon;

            foreach (Pokemon pokemon in normalPokemon)
            {
                Console.WriteLine(pokemon.ToString());
            }
            Console.WriteLine();

            List<Tier> tierListe =
            [
                new Hund(4, Geschlecht.Weiblich, "Jill"),
                new Reh(2, Geschlecht.Maennlich),
                new Reh(5, Geschlecht.Weiblich),
                new Hund(2, Geschlecht.Maennlich, "Coco"),
                new Hund(4, Geschlecht.Weiblich, "Idefix"),
            ];

            IEnumerable<Hund>  hunde = from hund in tierListe.OfType<Hund>()
                                       select hund;
            IEnumerable<Reh> rehe = from reh in tierListe.OfType<Reh>()
                                      select reh;

            foreach (Hund hund in hunde) 
            {
                Console.WriteLine(hund.ToString());
            }
            Console.WriteLine();

            foreach (Reh reh in rehe)
            {
                Console.WriteLine(reh.ToString());
            }
            Console.WriteLine();

            IEnumerable<Pokemon> pokemonQuery1 = from pokemon in pokedexList
                                                orderby pokemon.Name descending, pokemon.Typ
                                                select pokemon;

            IEnumerable<Pokemon> pokemonQuery2 = pokedexList.OrderBy(pokemon => pokemon.Name).ThenByDescending(pokemon => pokemon.Typ).ToList();

            foreach (Pokemon pokemon in pokemonQuery1)
            {
                Console.WriteLine(pokemon.ToString());
            }
            Console.WriteLine();

            foreach (Pokemon pokemon in pokemonQuery2)
            {
                Console.WriteLine(pokemon.ToString());
            }
            Console.WriteLine();

            var groupQuery1 = from pokemon in pokedexList
                                     group pokemon by pokemon.Typ;

            var groupQuery2 = pokedexList.GroupBy(pokemon => pokemon.Typ);

            foreach(var group in groupQuery1)
            {
                Console.WriteLine(group.Key);
                Console.WriteLine("-----------");

                foreach (Pokemon pokemon in group) 
                {
                    Console.WriteLine(pokemon.ToString());
                }

                Console.WriteLine();
            }
            Console.WriteLine();

            foreach (var group in groupQuery2)
            {
                Console.WriteLine(group.Key);
                Console.WriteLine("-----------");

                foreach (Pokemon pokemon in group)
                {
                    Console.WriteLine(pokemon.ToString());
                }

                Console.WriteLine();
            }
            Console.WriteLine();

            int[] numbers = [10, 12, 4, 15, 8, 23, 34, 48, 106, 33, 5, 9, 19, 1000, 300];

            int resultMax = numbers.Max();
            int resultMin = numbers.Min();

            Console.WriteLine(resultMax);
            Console.WriteLine(resultMin);
            Console.WriteLine();

            int resultMinFiltered = numbers.Where(number => number > 10).Min();

            Console.WriteLine(resultMinFiltered);
            Console.WriteLine();

            double resultAverage = numbers.Average();

            Console.WriteLine(resultAverage);
            Console.WriteLine();

            int resultSum = numbers.Sum();

            Console.WriteLine(resultSum);
            Console.WriteLine();

            int resultCount = numbers.Count();

            Console.WriteLine(resultCount);
            Console.WriteLine();

            int resultCountFiltered = numbers.Where(number => number > 10).Count();

            Console.WriteLine(resultCountFiltered);
            Console.WriteLine();

            int resultAggregated = numbers.Aggregate((sum, val) => sum + val);

            Console.WriteLine(resultAggregated);
            Console.WriteLine();

            string resultStringAggregated = pokedexArray.Aggregate((concat, name) => concat + " und " + name);

            Console.WriteLine(resultStringAggregated);
            Console.WriteLine();

        }
    }
    

    class Pokemon
    {
        public string Name { get; set; }
        public string Typ { get; set;}

        public Pokemon(string name, string typ)
        {
            Name = name;
            Typ = typ;
        }

        public override string ToString()
        {
            return Name + " " + Typ;
        }
    }

    enum Geschlecht
    {
        Maennlich,
        Weiblich
    }

    abstract class Tier
    {
        public int Alter { get; set; }
        public Geschlecht Geschlecht { get; set; }

        public abstract void Essen();
        public abstract void Trinken();

    }

    class Hund : Tier
    {
        public string Name { get; set;}

        public Hund(int alter, Geschlecht geschlecht, string name)
        {
            Alter = alter;
            Geschlecht = geschlecht;
            Name = name;
        }

        public void Bellen()
        {
            Console.WriteLine(Name + " bellt!");
        }

        public override void Essen()
        {
            Console.WriteLine(Name + " frisst!");
        }

        public override void Trinken()
        {
            Console.WriteLine(Name + " trinkt!");
        }

        public override string ToString()
        {
            return "Hund " + "Name: " + Name + " Alter: " + Alter + " " + Geschlecht;
        }
    }

    class Reh : Tier
    {
        public Reh(int alter, Geschlecht geschlecht)
        {
            Alter = alter;
            Geschlecht = geschlecht;
        }

        public override void Essen()
        {
            Console.WriteLine("Das Reh frisst!");
        }

        public override void Trinken()
        {
            Console.WriteLine("Das Reh trinkt!");
        }

        public void Flucht()
        { 
            Console.WriteLine("Das Reh flüchtet!");
        }

        public override string ToString()
        {
            return "Reh " + Alter + " Jahre alt " + Geschlecht;
        }
    }
}