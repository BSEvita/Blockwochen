import java.util.*;

class Schauspieler
{
    private String Vorname;
    private String Nachname;
    private String Spitzname;
    private String Geburtsort;
    private String Geburtsdatum;
    private String Nationalitaet;
    private double Groesse; //in Meter

    public Schauspieler(String vorname, String nachname) {
        Vorname = vorname;
        Nachname = nachname;
        Spitzname = "";
        Geburtsort = "";
        Geburtsdatum = "";
        Nationalitaet = "";
        Groesse = 0;
    }

    public Schauspieler(String vorname, String nachname, String spitzname, double groesse) {
        Vorname = vorname;
        Nachname = nachname;
        Spitzname = spitzname;
        Geburtsort = "";
        Geburtsdatum = "";
        Nationalitaet = "";
        Groesse = groesse;
    }

    public Schauspieler(String vorname, String nachname, String spitzname, String geburtsort, String geburtsdatum, String nationalitaet, double groesse) {
        Vorname = vorname;
        Nachname = nachname;
        Spitzname = spitzname;
        Geburtsort = geburtsort;
        Geburtsdatum = geburtsdatum;
        Nationalitaet = nationalitaet;
        Groesse = groesse;
    }
    
    public Schauspieler() {
        Vorname = "";
        Nachname = "";
        Spitzname = "";
        Geburtsort = "";
        Geburtsdatum = "";
        Nationalitaet = "";
        Groesse = 0;
    }

    //Get-Methoden

    public String get_Vorname() {
        return Vorname;
    }
    public String get_Nachname() {
        return Nachname;
    }
    public String get_Spitzname() {
        return Spitzname;
    }
    public String get_Geburtsort() {
        return Geburtsort;
    }
    public String get_Geburtsdatum() {
        return Geburtsdatum;
    }
    public String get_Nationalitaet() {
        return Nationalitaet;
    }
    public double get_Groesse() {
        return Groesse;
    }

    //Set-Methoden

    public void set_Vorname(String vorname) {
        Vorname = vorname;
    }
    public void set_Nachname(String nachname) {
        Nachname = nachname;
    }
    public void set_Spitzname(String spitzname) {
        Spitzname = spitzname;
    }
    public void set_Geburtsort(String geburtsort) {
        Geburtsort = geburtsort;
    }
    public void set_Geburtsdatum(String geburtsdatum) {
        Geburtsdatum = geburtsdatum;
    }
    public void set_Nationalitaet(String nationalitaet) {
        Nationalitaet = nationalitaet;
    }
    public void set_Groesse(double groesse) {
        Groesse = groesse;
    }
}

public class Film
{
    private String Titel;
    private int Erscheinungsjahr;
    private String Genre;
    private int Laufzeit; //in ganzen Minuten
    private List<Schauspieler> Cast; //Schauspieler
    private String Sprache;
    private int FSK;

    public Film(String titel, int erscheinungsjahr) {
        Titel = titel;
        Erscheinungsjahr = erscheinungsjahr;
        Genre = "";
        Laufzeit = 0;
        Cast = new ArrayList<Schauspieler>();
        Sprache = "";
        FSK = 0;
    }

    public Film(String titel, int erscheinungsjahr, String genre, int laufzeit) {
        Titel = titel;
        Erscheinungsjahr = erscheinungsjahr;
        Genre = genre;
        Laufzeit = laufzeit;
        Cast = new ArrayList<Schauspieler>();
        Sprache = "";
        FSK = 0;
    }

    public Film(String titel, int erscheinungsjahr, String genre, int laufzeit, List<Schauspieler> cast, String sprache, int fSK) {
        Titel = titel;
        Erscheinungsjahr = erscheinungsjahr;
        Genre = genre;
        Laufzeit = laufzeit;
        Cast = cast;
        Sprache = sprache;
        FSK = fSK;
    }

    public Film() {
        Titel = "";
        Erscheinungsjahr = 0;
        Genre = "";
        Laufzeit = 0;
        Cast = new ArrayList<Schauspieler>();
        Sprache = "";
        FSK = 0;
    }

        //Get-Methoden
        
    public String get_Titel() {
        return Titel;
    }
    public int get_Erscheinungsjahr() {
        return Erscheinungsjahr;
    }
    public String get_Genre() {
        return Genre;
    }
    public int get_Laufzeit() {
        return Laufzeit;
    }
    public List<Schauspieler> get_Cast() {
        return Cast;
    }
    public String get_Sprache() {
        return Sprache;
    }
    public int get_FSK() {
        return FSK;
    }

    //Set-Methoden

    public void set_Titel(String titel) {
        Titel = titel;
    }
    public void set_Erscheinungsjahr(int erscheinungsjahr) {
        Erscheinungsjahr = erscheinungsjahr;
    }
    public void set_Genre(String genre) {
        Genre = genre;
    }
    public void set_Laufzeit(int laufzeit) {
        Laufzeit = laufzeit;
    }
    public void set_Cast(List<Schauspieler> cast) {
        Cast = cast;
    }
    public void set_Sprache(String sprache) {
        Sprache = sprache;
    }
    public void set_FSK(int fSK) {
        FSK = fSK;
    }
}