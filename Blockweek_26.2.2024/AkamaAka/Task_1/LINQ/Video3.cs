using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTutorial
{
    class Video3
    {
        static void Main(string[] args)
        {
            List<Student> studentenListe = new List<Student>();
            studentenListe.Add(new Student(Studiengang.Biologie, 3, "Sabrina", "Vogel"));
            studentenListe.Add(new Student(Studiengang.Informatik, 5, "Patrick", "Müller"));
            studentenListe.Add(new Student(Studiengang.Informatik, 4, "Kurt", "Meier"));
            studentenListe.Add(new Student(Studiengang.Germanistik, 1, "Anna", "Kohl"));
            studentenListe.Add(new Student(Studiengang.Mathematik, 2, "Sebastian", "Müller"));


            // Ziel: Wir holen die Informatikstudenten aus der StudentenListe Query Syntax
            /*var informatikStudenten = from Student
                                      in studentenListe
                                      where Student.Studiengang == Studiengang.Informatik // Wenn der Student im Studiengang Informatik ist
                                      select Student; // Dann soll es ausgewählt werden*/
            // Ziel: Das selbe wie oben nur mit mehreren where abfragen
            var informatikStudenten = from Student
                                      in studentenListe
                                      where (Student.Studiengang == Studiengang.Informatik) || (Student.Semester > 4) // Wenn der Student im Studiengang Informatik ist
                                      select Student; // Dann soll es ausgewählt werden

            foreach (Student student in informatikStudenten)
            {
                Console.WriteLine(student.ToString());
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

}