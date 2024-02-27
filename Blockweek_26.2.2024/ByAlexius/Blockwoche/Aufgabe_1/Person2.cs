namespace Aufgabe_1
{
    public class Person2
    {
        public int Alter { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Beruf { get; set; }
    
        public Person2(int alter, string vorname, string nachname, string beruf)
        {
            Alter = alter;
            Vorname = vorname;
            Nachname = nachname;
            Beruf = beruf;
        }
    
        public override string ToString()
        {
            return $"{Vorname} {Nachname} ({Alter} Job: {Beruf})";
        }
    }
}