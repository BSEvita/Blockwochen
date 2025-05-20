using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

namespace block;
public class Held
{
    string Name; // |
    int Level; // |
    decimal Kosten; // |
    decimal Trefferpunkte; // |
    decimal Regenerationszeit; // ?
    decimal Schaden; // |
    string Spezialfähigkeit;


    public Held(string name, int level)
    {
        this.Name = name;
        this.Level = level;
    }

    public Held(string name, int level, decimal costs, decimal hitpoints)
    {
        this.Name = name;
        this.Level = level;
        this.Kosten= costs;
        this.Trefferpunkte= hitpoints;
    }

    public Held(string name, int level, decimal costs, decimal hitpoints, decimal regenerationtime, decimal damage, string targetCapability) : this(name, level, costs, hitpoints)
    {
        this.Regenerationszeit= regenerationtime;
        this.Schaden = damage;
        this.Spezialfähigkeit= targetCapability;
    }
    public Held()
    {
        this.Name = null;
        this.Level = 0;
        this.Kosten= 0;
        this.Trefferpunkte= 0;
        this.Regenerationszeit= 0;
        this.Schaden = 0;
        this.Spezialfähigkeit= null;
    }



    public void set_Name(string name)
    {
        this.Name = name;
    }

    public void set_Level(int level)
    {
        this.Level = level;
    }

    public void set_Kosten(decimal costs)
    {
        this.Kosten= costs;
    }

    public void set_Trefferpunkte(decimal hitpoints)
    {
        this.Trefferpunkte= hitpoints;
    }

    public void set_Regeneratoinszeit(decimal regeneration)
    {
        this.Regenerationszeit= regeneration;
    }

    public void set_Schaden(decimal damage)
    {
        this.Schaden = damage;
    }

    public void set_Spezialfähigkeit(string target)
    {
        this.Spezialfähigkeit= target;
    }





    public string get_Name()
    {
        return this.Name;
    }

    public int get_Level()
    {
        return this.Level;
    }

    public decimal get_Kosten()
    {
        return this.Kosten;
    }

    public decimal get_Trefferpunkte()
    {
        return this.Trefferpunkte;
    }

    public decimal get_Regeneratoinszeit()
    {
        return this.Regenerationszeit;
    }

    public decimal get_Schaden()
    {
        return this.Schaden;
    }

    public string get_Spezialfähigkeit()
    {
        return this.Spezialfähigkeit;
    }
}

public class Trupp
{
    string Name; // |
    int Level; // |
    decimal Entwicklungskosten; // |
    decimal Baukosten; // -
    bool Elexier; // 0 false / 1 true
    int Angriffspunkte; // |
    int Schaden; // |
    int Bewegungsgeschwindigkeit; // |
    decimal Angriffsgeschwindigkeit; // |
    decimal Reichweite; // |
    decimal Wohnraum; // |
    bool Einzel; // 0 = false / 1 = true

    public Trupp(string Name, int Level, decimal Entwicklungskosten, decimal Baukosten)
    {
        this.Name = Name;
        this.Level = Level;
        this.Entwicklungskosten = Entwicklungskosten;
        this.Baukosten = Baukosten;
    }
    public Trupp(string Name, int Level, decimal Entwicklungskosten, decimal Baukosten, decimal Elixier, decimal Reichweite) : this(Name, Level, Entwicklungskosten, Baukosten)
    {
        this.Elexier = Elexier;
        this.Reichweite = Reichweite;
    }

    public Trupp(string name, int level, decimal entwicklungskosten, decimal baukosten, bool elexier, int angriffspunkte, int schaden, int bewegungsgeschwindigkeit, decimal angriffsgeschwindigkeit, decimal reichweite, decimal wohnraum, bool einzel) : this(name, level, entwicklungskosten, baukosten)
    {
        this.Name = Name;
        this.Level = Level;
        this.Entwicklungskosten = Entwicklungskosten;
        this.Baukosten = Baukosten;
        this.Elexier = elexier;
        this.Angriffspunkte = angriffspunkte;
        this.Schaden = schaden;
        this.Bewegungsgeschwindigkeit = bewegungsgeschwindigkeit;
        this.Angriffsgeschwindigkeit = angriffsgeschwindigkeit;
        this.Reichweite = reichweite;
        this.Wohnraum = wohnraum;
        this.Einzel = einzel;
    }

    public Trupp()
    {
        this.Name = null;
        this.Level = 0;
        this.Entwicklungskosten = 0;
        this.Baukosten = 0;
        this.Elexier = false;
        this.Angriffspunkte = 0;
        this.Schaden = 0;
        this.Bewegungsgeschwindigkeit = 0;
        this.Angriffsgeschwindigkeit = 0;
        this.Reichweite = 0;
        this.Wohnraum = 0;
        this.Einzel = false;
    }

    public void set_Name(string Name)
    {
        this.Name = Name;
    }

    public void set_Level(int Level)
    {
        this.Level = Level;
    }

    public void set_Entwiklungskosten(int kosten)
    {
        this.Entwicklungskosten = kosten;
    }

    public void set_Baukosten(decimal kosten)
    {
        this.Baukosten = kosten;
    }

    public void set_Reichweite(decimal weite)
    {
        this.Baukosten = weite;
    }

    public void set_Elixier(bool elixier)
    {
        this.Elexier = elixier;
    }

    public void set_Angriffspunkte(int punkte)
    {
        this.Angriffspunkte = punkte;
    }

    public void set_Schaden(int schaden)
    {
        this.Schaden = schaden;
    }

    public void set_Bewegungsgeschwindigkeit(int geschwindigkeit)
    {
        this.Bewegungsgeschwindigkeit = geschwindigkeit;
    }

    public void set_Angriffsgeschwindigkeit(decimal geschwindigkeit)
    {
        this.Angriffsgeschwindigkeit = geschwindigkeit;
    }

    public void set_Wohnraum(decimal wohnraum)
    {
        this.Wohnraum = wohnraum;
    }

    public void set_Einzel(bool einzel)
    {
        this.Einzel = einzel;
    }








    public string get_Name()
    {
        return this.Name;
    }

    public decimal get_Level()
    {
        return this.Level;
    }

    public decimal get_Entwiklungskosten()
    {
        return this.Entwicklungskosten;
    }

    public decimal get_Baukosten()
    {
        return this.Baukosten;
    }

    public decimal get_Reichweite()
    {
        return this.Baukosten;
    }

    public bool get_Elixier()
    {
        return this.Elexier;
    }

    public int get_Angriffspunkte()
    {
        return this.Angriffspunkte;
    }

    public decimal get_Schaden()
    {
        return this.Schaden;
    }

    public int get_Bewegungsgeschwindigkeit()
    {
        return this.Bewegungsgeschwindigkeit;
    }

    public decimal get_Angriffsgeschwindigkeit()
    {
        return this.Angriffsgeschwindigkeit;
    }

    public decimal get_Wohnraum()
    {
        return this.Wohnraum;
    }

    public bool get_Einzel()
    {
        return this.Einzel;
    }
}
class Program
{

    static void Main()
    {

    }


}