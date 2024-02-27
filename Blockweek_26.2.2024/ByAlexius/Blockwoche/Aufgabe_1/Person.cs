namespace Aufgabe_1
{
    public class Person
    {
        public int Alter { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
    
        public Person(int alter, string vorname, string nachname)
        {
            Alter = alter;
            Vorname = vorname;
            Nachname = nachname;
        }
    
        public override string ToString()
        {
            return $"{Vorname} {Nachname} ({Alter} Jahre)";
        }
    }
}