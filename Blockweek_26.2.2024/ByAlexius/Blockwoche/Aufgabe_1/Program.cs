using Aufgabe_1;

internal class Program
{
    public static void Main(string[] args)
    {
        QuerySyntax();
        Console.WriteLine("-------------------------");
        Filter1();
        Console.WriteLine("-------------------------");
        Filter2();
        Console.WriteLine("-------------------------");
        OrderBy();
        Console.WriteLine("-------------------------");
        GroupBy();
        Console.WriteLine("-------------------------");
        Aggregate();

    }

    public static void QuerySyntax()
    {
        string[] names = { "Peter", "Günther", "Manfred", "Uwe" };

        var linqTest = from name in names
            where name.Contains('t')
            select name;

        var linqTest2 = names.Where(name => name.Contains('t'));

        names[0] = "Gustav";

        foreach (string name in linqTest)
        {
            Console.WriteLine(name);
        }

        Console.ReadKey();
    }

    public static void Filter1()
    {
        List<Student> studentListe = new List<Student>();
        studentListe.Add(new Student(Studiengang.Biologie, 3, "Sabrina", "Vogle"));
        studentListe.Add(new Student(Studiengang.Informatik, 5, "patrick", "Müller"));
        studentListe.Add(new Student(Studiengang.Informatik, 4, "Kurt", "Meier"));
        studentListe.Add(new Student(Studiengang.Germanistik, 1, "Anna", "Kohl"));
        studentListe.Add(new Student(Studiengang.Mathematik, 2, "Sebastian", "Müller"));

        var  informatikStudenten = from student in studentListe
                                    where (student.Studiengang == Studiengang.Informatik) && (student.Semester > 4)
                                    select student;

        foreach (Student student in informatikStudenten)
        {
            Console.WriteLine(student.ToString());
        }
        
        Console.ReadKey();
    }

    public static void Filter2()
    {
        List<Tier> tierListe = new List<Tier>();
        tierListe.Add(new Hund(4, Geschlecht.Weiblich, "Jill"));
        tierListe.Add(new Reh(2, Geschlecht.Maennlich));
        tierListe.Add(new Reh(5, Geschlecht.Weiblich));
        tierListe.Add(new Hund(2, Geschlecht.Maennlich, "Coco"));
        tierListe.Add(new Hund(4, Geschlecht.Weiblich, "Idefix"));

        var rehe = from hund in tierListe.OfType < Reh >()
                select hund;

        foreach (Reh reh in rehe)
        {
            Console.WriteLine(reh.ToString());
        }

        Console.ReadKey();
    }

    public static void OrderBy()
    {
        List<Person> personListe = new List<Person>();
        personListe.Add(new Person(20, "Benjamin", "Kohl"));
        personListe.Add(new Person(19, "Benjamin", "Blume"));
        personListe.Add(new Person(22, "Alina", "Müller"));
        personListe.Add(new Person(43, "Daniela", "Kohl"));
        personListe.Add(new Person(27, "Carlos", "Sanchez"));
        
        var personQuery = from person in personListe
            orderby person.Vorname, person.Nachname
            select person;
        
        var personQuery2 = personListe.OrderByDescending(person => person.Vorname).ThenByDescending(person => person.Nachname).ToList();

        foreach (Person person in personQuery2)
        {
            Console.WriteLine(person.ToString());
        }
        
        Console.ReadKey();
    }

    public static void GroupBy()
    {
        List<Person2> personListe = new List<Person2>();
        personListe.Add(new Person2(20, "Benjamin", "Kohl", "Programmierer"));
        personListe.Add(new Person2(19, "Benjamin", "Blume", "Bäcker"));
        personListe.Add(new Person2(22, "Alina", "Müller", "Programmierer"));
        personListe.Add(new Person2(43, "Daniela", "Kohl", "Bäcker"));
        personListe.Add(new Person2(27, "Carlos", "Sanchez", "Maler"));

        var groupQuery = from person in personListe
            group person by person.Beruf;
        
        var groupQuery2 = personListe.GroupBy(person => person.Beruf);

        foreach (var group in groupQuery2)
        {
            Console.WriteLine(group.Key);
            Console.WriteLine("-------------");
            foreach (Person2 person in group)
            {
                Console.WriteLine(person.ToString());
            }
            Console.WriteLine();
        }
        
        Console.ReadKey();
    }

    public static void Aggregate()
    {
        int[] numbers = new int[] { 10, 12, 4, 15, 8 };

        // var result = numbers.Where(number => number > 10).Min();
        // var result = numbers.Average();
        // var result = numbers.Sum();
        // var result = numbers.Where(number => number > 10).Count();
        var result = numbers.Aggregate((sum, val) => sum + val);
        
        Console.WriteLine(result);

        string[] names = new string[] { "Johnson", "Claudia", "Sabrina", "Peter" };
        
        var result2 = names.Aggregate((concat, name) => concat + ", " + name);
        
        Console.WriteLine(result2);
        
        Console.ReadKey();
    }
}