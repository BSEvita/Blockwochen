namespace Aufgabe_1
{
    public enum Studiengang
    {
        Informatik,
        Biologie,
        Germanistik,
        Mathematik
    }

    public class Student
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
            return $"{Vorname} {Nachname} ({Studiengang}, {Semester}. Semester)";
        }
    }
}