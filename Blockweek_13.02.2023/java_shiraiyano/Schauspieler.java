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

    public Schauspieler(String vorname, String nachname, String spitzname, String geburtsort, 
        String geburtsdatum, String nationalitaet, double groesse) {

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