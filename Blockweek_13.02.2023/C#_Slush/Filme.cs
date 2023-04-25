import java.util.*;  

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

    public string get_geburtsort()
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

public class Film
{
    string Titel;
    string Erscheinungsjahr;
    string Genre;
    string Laufzeit;
    string Cast;
    string Sprache;
    string[] FSK;

    public Film(string titel, string publishDate)
    {
        this.Titel = titel;
        this.Erscheinungsjahr = publishDate;
        this.Genre = null;
        this.Laufzeit = null;
        this.Cast = null;
        this.Sprache = null;
        this.FSK = null;
    }
    public Film(string titel, string publishDate, string genre, string runtime)
    {
        this.Titel = titel;
        this.Erscheinungsjahr = publishDate;
        this.Genre = genre;
        this.Laufzeit = runtime;
        this.Cast = null;
        this.Sprache = null;
        this.FSK = null;
    }
    public Film(string titel, string publishDate, string genre, string runtime, string cast, string language, string[] fsk) : this(titel, publishDate, genre, runtime)
    {
        this.Cast = cast;
        this.Sprache = language;
        this.FSK = fsk;
    }

    public Film()
    {
        this.Titel = null;
        this.Erscheinungsjahr = null;
        this.Genre = null;
        this.Laufzeit = null;
        this.Cast = null;
        this.Sprache = null;
        this.FSK = null;
    }



    public void set_Title(string titel)
    {
        this.Titel = titel;
    }

    public void set_ErscheinungsJahr(string publishDate)
    {
        this.Erscheinungsjahr = publishDate;
    }

    public void set_Genre(string genre)
    {
        this.genre = Genre;
    }

    public void set_Laufzeit(string runtime)
    {
        this.Laufzeit = runtime;
    }

    public void set_Cast(string cast)
    {
        this.Cast = cast;
    }
    public void set_Sprache(string language)
    {
        this.Sprache = language;
    }

    public void set_FSK(string[] fsk)
    {
        this.fsk = FSK;
    }



    public string get_Title(string titel)
    {
        return this.Titel;
    }

    public string get_ErscheinungsJahr(string publishDate)
    {
        return this.Erscheinungsjahr;
    }

    public string get_Genre(string genre)
    {
        return this.Genre;
    }

    public string get_Laufzeit(string runtime)
    {
        return this.Laufzeit;
    }

    public string get_Cast(string cast)
    {
        return this.Cast;
    }
    public string get_Sprache(string language)
    {
        return this.Sprache;
    }

    public string[] get_FSK(string[] fsk)
    {
        return this.FSK;
    }
}
