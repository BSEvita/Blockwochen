namespace Aufgabe_1
{
    public enum Geschlecht
    {
        Maennlich,
        Weiblich
    }

    public abstract class Tier
    {
        public int Alter { get; set; }
        public Geschlecht Geschlecht { get; set; }
    
        public abstract void Essen();
        public abstract void Trinken();
    }
}