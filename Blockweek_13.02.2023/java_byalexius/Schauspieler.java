public class Schauspieler
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