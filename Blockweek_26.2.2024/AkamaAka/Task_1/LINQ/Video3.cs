using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  /**
    * <summary>
    * CC BY NC ND 4.0 international Akama Aka
    * </summary>
    */
namespace LINQTutorial
{

    
    class Video3
    {
        static void MainVideo3(string[] args)
        {
            List<Student> studentenListe = new List<Student>();
            studentenListe.Add(new Student(Studiengang.Biologie, 3, "Sabrina", "Vogel"));
            studentenListe.Add(new Student(Studiengang.Informatik, 5, "Patrick", "Müller"));
            studentenListe.Add(new Student(Studiengang.Informatik, 4, "Kurt", "Meier"));
            studentenListe.Add(new Student(Studiengang.Germanistik, 1, "Anna", "Kohl"));
            studentenListe.Add(new Student(Studiengang.Mathematik, 2, "Sebastian", "Müller"));


            // Ziel: Wir holen die Informatikstudenten aus der StudentenListe Query Syntax
            var informatikStudentenQuerySingle = from Student
                                      in studentenListe
                                      where Student.Studiengang == Studiengang.Informatik // Wenn der Student im Studiengang Informatik ist
                                      select Student; // Dann soll es ausgewählt werden
            // Ziel: Das selbe wie oben nur mit mehreren where abfragen
            var informatikStudentenQueryMultible = from Student
                                      in studentenListe
                                      where (Student.Studiengang == Studiengang.Informatik) || (Student.Semester > 4) // Wenn der Student im Studiengang Informatik ist
                                      select Student; // Dann soll es ausgewählt werden


            foreach (Student student in informatikStudentenQueryMultible)
            {
                Console.WriteLine(student.ToString());
            }

            List<Tier> tierListe = new List<Tier>();

            tierListe.Add(new Hund(4, Geschlecht.Weiblich, "Jill"));
            tierListe.Add(new Reh(2, Geschlecht.Maennlich));
            tierListe.Add(new Reh(5, Geschlecht.Weiblich));
            tierListe.Add(new Hund(2, Geschlecht.Maennlich, "Coco"));
            tierListe.Add(new Hund(4, Geschlecht.Weiblich, "Idefix"));

          // Ziel: Erhalten von Hunden

            var hunde = from hund in tierListe.OfType<Hund>()
                        select hund;

            foreach (Hund hund in hunde) 
            {
                Console.WriteLine(hund.ToString());
            }
            // Ziel: Erhalten von Rehe
            var rehe = from reh in tierListe.OfType<Reh>()
                       select reh;

            foreach (Reh reh in rehe)
            {
                Console.WriteLine(reh.ToString());
            }

            Console.ReadKey();
        }
    }
    enum Studiengang
    {
        Informatik,
        Biologie,
        Germanistik,
        Mathematik
    }
    class Student
    {
        public Studiengang Studiengang { get; set; }
        public int Semester { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }

        public Student(Studiengang studiengang, int semester, string vorname, string nachname)
        {
            Studiengang = studiengang;
            Semester = semester;
            Vorname = vorname;
            Nachname = nachname;
        }

        public override string ToString()
        {
            return Vorname + " " + Nachname + " " + Studiengang + " " + Semester + " ";
        }

    }

    enum Geschlecht
    {
        Weiblich,
        Maennlich
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
        public string Name { get; set; }
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
            Console.WriteLine(Name + " frisst");
        }

        public override void Trinken()
        {
            Console.WriteLine(Name + " trinkt!");

        }

        public override string ToString()
        {
            return "Hund " + "Name" + Name + "Alter" + Alter + " " + Geschlecht;
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
            Console.WriteLine("Das Reh flüchtet");
        }

        public override string ToString()
        {
            return "Reh " + Alter + " Jahre alt" + Geschlecht;
        }
    }

}





