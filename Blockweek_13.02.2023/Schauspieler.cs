using System.Runtime.ExceptionServices;

namespace block;
public class Schauspieler
{
    string Vorname;
    string Nachname;
    string Spitzname;
    string Geburtsort;
    string Geburtsdatum;
    string Nationalitaet;
    Int64 Groese;

    public Schauspieler(string vorname, string nachname)
    {
        this.Vorname = vorname;
        this.Nachname = nachname;
    }
    public Schauspieler(string vorname, string nachname, string spitzname, Int64 groese)
    {
        this.Vorname = vorname;
        this.Nachname = nachname;
        this.Spitzname = spitzname;
        this.Groese = groese;
    }
    public Schauspieler(string vorname, string nachname, string spitzname, string geburtsort, string geburtsdatum, string nationalitaet, long groese)
    {
        this.Spitzname = spitzname;
        this.Geburtsort = geburtsort;
        this.Geburtsdatum = geburtsdatum;
        this.Nationalitaet = nationalitaet;
        this.Groese = groese;
    }
    public Schauspieler()
    {
        this.Vorname = null;
        this.Geburtsort = null;
        this.Geburtsdatum = null;
        this.Nachname = null;
        this.Nationalitaet = null;
        this.Groese = 0;
    }


    public void set_Vorname(string vorname)
    {
        this.Vorname = vorname;
    }

    public void set_Nachname(string nachname)
    {
        this.Nachname = nachname;
    }

    public void set_Geburtsort(string geburtsort)
    {
        this.Geburtsort = geburtsort;
    }

    public void set_Geburtsdatum(string geburtsdatum)
    {
        this.Geburtsdatum = geburtsdatum;
    }

    public void set_Nationaliaet(string nationaliaet)
    {
        this.Nationalitaet = nationaliaet;
    }
    public void set_Groese(Int64 groese)
    {
        this.Groese = groese;
    }


    public string get_Vorname()
    {
        return this.Vorname;
    }

    public string get_Nachname()
    {
        return this.Nachname;
    }

    public string get_Geburtsort()
    {
        return this.Geburtsort;
    }

    public string get_Geburtsdatum()
    {
        return this.Geburtsdatum;
    }

    public string get_Nationaliaet()
    {
        return this.Nationalitaet;
    }
    public Int64 get_Groese()
    {
        return this.Groese;
    }

}

class Program
{
    
    static void Main()
    {
        Schauspieler schauspieler = new Schauspieler();

        schauspieler.set_Vorname("Harrison");

        Console.WriteLine(schauspieler.get_Vorname());
    }

    
}
