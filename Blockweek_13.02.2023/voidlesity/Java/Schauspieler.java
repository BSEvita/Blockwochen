public class Schauspieler {
    private String Vorname;
    private String Nachname;
    private String Spitzname;
    private String Geburtsort;
    private String Geburtsdatum;
    private String Nationalitaet;
    private double Groesse;
    
    // Konstruktor mit Vorname und Nachname als Übergabeparameter
    public Schauspieler(String vorname, String nachname) {
        this.Vorname = vorname;
        this.Nachname = nachname;
    }
    
    // Konstruktor mit Vorname, Nachname, Spitzname und Groesse als Übergabeparameter
    public Schauspieler(String vorname, String nachname, String spitzname, double groesse) {
        this.Vorname = vorname;
        this.Nachname = nachname;
        this.Spitzname = spitzname;
        this.Groesse = groesse;
    }
    
    // Konstruktor mit allen Felder als Übergabeparameter
    public Schauspieler(String vorname, String nachname, String spitzname, String geburtsort, 
                        String geburtsdatum, String nationalitaet, double groesse) {
        this.Vorname = vorname;
        this.Nachname = nachname;
        this.Spitzname = spitzname;
        this.Geburtsort = geburtsort;
        this.Geburtsdatum = geburtsdatum;
        this.Nationalitaet = nationalitaet;
        this.Groesse = groesse;
    }
    
    // Konstruktor ohne Übergabeparameter
    public Schauspieler() { }
    
    // Getter-Methoden für die Felder
    public String get_Vorname() {
        return Vorname != null ? Vorname : "";
    }
    public String get_Nachname() {
        return Nachname != null ? Nachname : "";
    }
    public String get_Spitzname() {
        return Spitzname != null ? Spitzname : "";
    }
    public String get_Geburtsort() {
        return Geburtsort != null ? Geburtsort : "";
    }
    public String get_Geburtsdatum() {
        return Geburtsdatum != null ? Geburtsdatum : "";
    }
    public String get_Nationalitaet() {
        return Nationalitaet != null ? Nationalitaet : "";
    }
    public double get_Groesse() {
        return Groesse;
    }
    
    // Setter-Methoden für die Felder
    public void set_Vorname(String vorname) {
        this.Vorname = vorname != null ? vorname : "";
    }
    
    public void set_Nachname(String nachname) {
        this.Nachname = nachname != null ? nachname : "";
    }
    
    public void set_Spitzname(String spitzname) {
        this.Spitzname = spitzname != null ? spitzname : "";
    }
    
    public void set_Geburtsort(String geburtsort) {
        this.Geburtsort = geburtsort != null ? geburtsort : "";
    }
    
    public void set_Geburtsdatum(String geburtsdatum) {
        this.Geburtsdatum = geburtsdatum != null ? geburtsdatum : "";
    }
    
    public void set_Nationalitaet(String nationalitaet) {
        this.Nationalitaet = nationalitaet != null ? nationalitaet : "";
    }
    
    public void set_Groesse(double groesse) {
        this.Groesse = groesse;
    }
}