global using System;
global using System.Collections.Generic;
global using System.Linq;

namespace LINQ_Tutorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] namesArray = { "Alice", "Bob", "Charlie", 
                                    "Diana", "Eve", "Frank", 
                                    "George", "Hannah", "Ivy", 
                                    "John", "Kelly", "Leo" };

            IEnumerable<string> namesWithA = from name in namesArray
                                             where name.Contains('a')
                                             select name;

            IEnumerable<string> namesWithN = namesArray.Where(name => name.Contains('n'));

            foreach (string name in namesWithA)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            foreach (string name in namesWithN)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            List<Person> personList = new List<Person>
            {
                new Person("Alice", 20), 
                new Person("Bob", 25), 
                new Person("Charlie", 30), 
                new Person("Diana", 22),                                           
                new Person("Eve", 28), 
                new Person("Frank", 33),
                new Person("George", 18), 
                new Person("Hannah", 24),
                new Person("Ivy", 26), 
                new Person("John", 31),
                new Person("Kelly", 19), 
                new Person("Leo", 29)              
            };

            IEnumerable<Person> adults = from person in personList
                                         where person.Age >= 18
                                         select person;

            foreach (Person person in adults)
            {
                Console.WriteLine(person.ToString());
            }
            Console.WriteLine();

            List<Animal> animalList = new List<Animal>
            {
                new Dog(4, Gender.Female, "Jill"),
                new Deer(2, Gender.Male),
                new Deer(5, Gender.Female),
                new Dog(2, Gender.Male, "Coco"),
                new Dog(4, Gender.Female, "Idefix"),
            };

            IEnumerable<Dog> dogs = from dog in animalList.OfType<Dog>()
                                    select dog;
            IEnumerable<Deer> deers = from deer in animalList.OfType<Deer>()
                                      select deer;

            foreach (Dog dog in dogs) 
            {
                Console.WriteLine(dog.ToString());
            }
            Console.WriteLine();

            foreach (Deer deer in deers)
            {
                Console.WriteLine(deer.ToString());
            }
            Console.WriteLine();

            IEnumerable<Person> personQuery1 = from person in personList
                                               orderby person.Name descending, person.Age
                                               select person;

            IEnumerable<Person> personQuery2 = personList.OrderBy(person => person.Name).ThenByDescending(person => person.Age);

            foreach (Person person in personQuery1)
            {
                Console.WriteLine(person.ToString());
            }
            Console.WriteLine();

            foreach (Person person in personQuery2)
            {
                Console.WriteLine(person.ToString());
            }
            Console.WriteLine();

            var groupQuery1 = from person in personList
                              group person by person.Age;

            var groupQuery2 = personList.GroupBy(person => person.Age);

            foreach(var group in groupQuery1)
            {
                Console.WriteLine("Age: " + group.Key);
                Console.WriteLine("-----------");

                foreach (Person person in group) 
                {
                    Console.WriteLine(person.ToString());
                }

                Console.WriteLine();
            }
            Console.WriteLine();

            foreach (var group in groupQuery2)
            {
                Console.WriteLine("Age: " + group.Key);
                Console.WriteLine("-----------");

                foreach (Person person in group)
                {
                    Console.WriteLine(person.ToString());
                }

                Console.WriteLine();
            }
            Console.WriteLine();

            int[] numbers = { 10, 12, 4, 15, 8, 23, 34, 48, 106, 33, 5, 9, 19, 1000, 300 };

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

            string resultStringAggregated = namesArray.Aggregate((concat, name) => concat + " and " + name);

            Console.WriteLine(resultStringAggregated);
            Console.WriteLine();

        }
    }
    

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return Name + " " + Age;
        }
    }

    enum Gender
    {
        Male,
        Female
    }

    abstract class Animal
    {
        public int Age { get; set; }
        public Gender Gender { get; set; }

        public abstract void Eat();
        public abstract void Drink();

    }

    class Dog : Animal
    {
        public string Name { get; set; }

        public Dog(int age, Gender gender, string name)
        {
            Age = age;
            Gender = gender;
            Name = name;
        }

        public void Bark()
        {
            Console.WriteLine(Name + " barks!");
        }

        public override void Eat()
        {
            Console.WriteLine(Name + " eats!");
        }

        public override void Drink()
        {
            Console.WriteLine(Name + " drinks!");
        }

        public override string ToString()
        {
            return "Dog " + "Name: " + Name + " Age: " + Age + " " + Gender;
        }
    }

    class Deer : Animal
    {
        public Deer(int age, Gender gender)
        {
            Age = age;
            Gender = gender;
        }

        public override void Eat()
        {
            Console.WriteLine("The deer eats!");
        }

        public override void Drink()
        {
            Console.WriteLine("The deer drinks!");
        }

        public void Flee()
        { 
            Console.WriteLine("The deer flees!");
        }

        public override string ToString()
        {
            return "Deer " + Age + " years old " + Gender;
        }
    }
}
