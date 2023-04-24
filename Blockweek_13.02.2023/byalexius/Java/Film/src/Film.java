import java.util.ArrayList;
import java.util.List;

public class Film
{
    private String Titel;
    private int Erscheinungsjahr;
    private String Genre;
    private int Laufzeit;
    private List<Schauspieler> Cast;
    private String Sprache;
    private int FSK;

    public Film(String titel, int erscheinungsjahr) {
        this.Titel = titel;
        this.Erscheinungsjahr = erscheinungsjahr;
        this.Genre = "";
        this.Laufzeit = 0;
        this.Cast = new ArrayList<Schauspieler>();
        this.Sprache = "";
        this.FSK = 0;
    }

    public Film(String titel, int erscheinungsjahr, String genre, int laufzeit) {
        this.Titel = titel;
        this.Erscheinungsjahr = erscheinungsjahr;
        this.Genre = genre;
        this.Laufzeit = laufzeit;
        this.Cast = new ArrayList<Schauspieler>();
        this.Sprache = "";
        this.FSK = 0;
    }

    public Film(String titel, int erscheinungsjahr, String genre, int laufzeit, List<Schauspieler> cast, String sprache, int fSK) {
        this.Titel = titel;
        this.Erscheinungsjahr = erscheinungsjahr;
        this.Genre = genre;
        this.Laufzeit = laufzeit;
        this.Cast = cast;
        this.Sprache = sprache;
        this.FSK = fSK;
    }

    public Film() {
        this.Titel = "";
        this.Erscheinungsjahr = 0;
        this.Genre = "";
        this.Laufzeit = 0;
        this.Cast = new ArrayList<Schauspieler>();
        this.Sprache = "";
        this.FSK = 0;
    }

    public String get_Titel() {
        return Titel;
    }
    public void set_Titel(String titel) {
        Titel = titel;
    }
    public int get_Erscheinungsjahr() {
        return Erscheinungsjahr;
    }
    public void set_Erscheinungsjahr(int erscheinungsjahr) {
        Erscheinungsjahr = erscheinungsjahr;
    }
    public String get_Genre() {
        return Genre;
    }
    public void set_Genre(String genre) {
        Genre = genre;
    }
    public int get_Laufzeit() {
        return Laufzeit;
    }
    public void set_Laufzeit(int laufzeit) {
        Laufzeit = laufzeit;
    }
    public List<Schauspieler> get_Cast() {
        return Cast;
    }
    public void set_Cast(List<Schauspieler> cast) {
        Cast = cast;
    }
    public String get_Sprache() {
        return Sprache;
    }
    public void set_Sprache(String sprache) {
        Sprache = sprache;
    }
    public int get_FSK() {
        return FSK;
    }
    public void set_FSK(int fSK) {
        FSK = fSK;
    }
}

class Schauspieler
{
    private String Vorname;
    private String Nachname;
    private String Spitzname;
    private String Geburtsort;
    private String Geburtsdatum;
    private String Nationalitaet;
    private double Groesse;

    public Schauspieler(String vorname, String nachname) {
        this.Vorname = vorname;
        this.Nachname = nachname;
        this.Spitzname = "";
        this.Geburtsort = "";
        this.Geburtsdatum = "";
        this.Nationalitaet = "";
        this.Groesse = 0;
    }

    public Schauspieler(String vorname, String nachname, String spitzname, double groesse) {
        this.Vorname = vorname;
        this.Nachname = nachname;
        this.Spitzname = spitzname;
        this.Geburtsort = "";
        this.Geburtsdatum = "";
        this.Nationalitaet = "";
        this.Groesse = groesse;
    }

    public Schauspieler(String vorname, String nachname, String spitzname, String geburtsort, String geburtsdatum, String nationalitaet, double groesse) {
        this.Vorname = vorname;
        this.Nachname = nachname;
        this.Spitzname = spitzname;
        this.Geburtsort = geburtsort;
        this.Geburtsdatum = geburtsdatum;
        this.Nationalitaet = nationalitaet;
        this.Groesse = groesse;
    }

    public Schauspieler() {
        this.Vorname = "";
        this.Nachname = "";
        this.Spitzname = "";
        this.Geburtsort = "";
        this.Geburtsdatum = "";
        this.Nationalitaet = "";
        this.Groesse = 0;
    }

    public String get_Vorname() {
        return Vorname;
    }

    public void set_Vorname(String vorname) {
        Vorname = vorname;
    }

    public String get_Nachname() {
        return Nachname;
    }

    public void set_Nachname(String nachname) {
        Nachname = nachname;
    }

    public String get_Spitzname() {
        return Spitzname;
    }

    public void set_Spitzname(String spitzname) {
        Spitzname = spitzname;
    }

    public String get_Geburtsort() {
        return Geburtsort;
    }

    public void set_Geburtsort(String geburtsort) {
        Geburtsort = geburtsort;
    }

    public String get_Geburtsdatum() {
        return Geburtsdatum;
    }

    public void set_Geburtsdatum(String geburtsdatum) {
        Geburtsdatum = geburtsdatum;
    }

    public String get_Nationalitaet() {
        return Nationalitaet;
    }

    public void set_Nationalitaet(String nationalitaet) {
        Nationalitaet = nationalitaet;
    }

    public double get_Groesse() {
        return Groesse;
    }

    public void set_Groesse(double groesse) {
        Groesse = groesse;
    }
}