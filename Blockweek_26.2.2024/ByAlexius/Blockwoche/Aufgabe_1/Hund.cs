namespace Aufgabe_1
{
    public class Hund : Tier
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
            Console.WriteLine(Name + " frisst!");
        }

        public override void Trinken()
        {
            Console.WriteLine(Name + " trinkt!");
        }
    
        public override string ToString()
        {
            return $"Hund Name: {Name} Alter: {Alter} {Geschlecht}";
        }
    }
}