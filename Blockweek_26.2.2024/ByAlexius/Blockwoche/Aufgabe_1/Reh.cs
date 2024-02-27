namespace Aufgabe_1
{
    public class Reh : Tier
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
            Console.WriteLine("Das Reh flüchtet!");
        }

        public override string ToString()
        {
            return $"Reh {Alter} Jahre alt {Geschlecht}";
        }
    }
}