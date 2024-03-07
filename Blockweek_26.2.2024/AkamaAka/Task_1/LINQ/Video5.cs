using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Video5
    {
        static void MainVideo5(string[] args)
        {
            List<Person> personList = new List<Person>();
            personList.Add(new Person(20, "Benjamin", "Kohl", "Programmierer"));
            personList.Add(new Person(19, "Benjamin", "Blume", "Bäcker"));
            personList.Add(new Person(22, "Alina", "Müller", "Programmierer"));
            personList.Add(new Person(43, "Daniela", "Kohl", "Bäcker"));
            personList.Add(new Person(27, "Carlos", "Sanchez", "Maler"));


            // Task: Erstellen von Gruppen

            var groupQuery = from person in personList
                             group person by person.Job;

            foreach(var group in groupQuery)
            {
                Console.WriteLine(group.Key);
                Console.WriteLine("--------");
                foreach (Person person in group)
                {
                    Console.WriteLine(person.ToString());
                }
                Console.WriteLine();
            }


            var groupQueryMeth = personList.GroupBy(person => person.Job);

            foreach (var group in groupQueryMeth)
            {
                Console.WriteLine(group.Key);
                Console.WriteLine("--------");
                foreach (Person person in group)
                {
                    Console.WriteLine(person.ToString());
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        
    }
    class Person
    {
        // Eigenschaften
        
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Job { get; set; }

        // Konstrukor

        public Person(int age, string firstName, string lastName, string job)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
            Job = job;
        }

        // Methode

        public override string ToString()
        {
            return FirstName + " " + LastName + " (" + Age + ")" + " Job: " + Job;
        }
    }
}
