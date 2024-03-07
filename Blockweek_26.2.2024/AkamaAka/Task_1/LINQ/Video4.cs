using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Video4
    {
        static void MainVideo4(string[] args)
        {
            List<Person> personList = new List<Person>();
            personList.Add(new Person(19, "Benjamin", "Blume"));
            personList.Add(new Person(20, "Benjamin", "Kohl"));
            personList.Add(new Person(22, "Alina", "Müller"));
            personList.Add(new Person(43, "Daniela", "kohl"));
            personList.Add(new Person(27, "Carlos", "Sanchez"));


            // Task

            var personQuery = from person in personList
                              orderby person.FirstName
                              select person;
            foreach (Person person in personQuery)
            {
                Console.WriteLine(person.ToString());
            }
            // Aufgrund dessen das wir nur nach FirstName sortieren wird Benjamin nicht richtig Sortiert da die ja den selben vornamen haben. Um das zu fixen kann man folgendes Schreiben

            var personQueryTwo = from person in personList
                                 orderby person.FirstName, person.LastName
                                 select person;

            foreach (Person person in personQueryTwo)
            {
                Console.WriteLine(person.ToString());
            }
            // Jetzt sind alle richtig Sortiert.

            var personQueryMeth = personList.OrderBy(person => person.FirstName).ThenBy(person => person.LastName).ToList();

            foreach (Person person in personQueryMeth)
            {
                Console.WriteLine(person.ToString());
            }
            Console.ReadKey();
        }
        class Person
        {
            // Eigenschaften
            public int Age { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            // Konstruktor
            public Person(int age, string firstName, string lastName)
            {
                Age = age;
                FirstName = firstName;
                LastName = lastName;
            }

            // Methode

            public override string ToString()
            {
                return FirstName + " " + LastName + " (" + Age + ")";
            }


        }
    }
}
