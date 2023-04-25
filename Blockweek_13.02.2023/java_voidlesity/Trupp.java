public class Trupp {
    private String name;
    private int level;
    private int entwicklungskosten;
    private int baukosten;
    private boolean elixier;
    private int trefferpunkte;
    private double schaden;
    private int bewegungsgeschwindigkeit;
    private double angriffsgeschwindigkeit;
    private int reichweite;
    private int wohnraum;
    private boolean einzel;

    // Konstruktor der Name, Level, Entwicklungskosten und Baukosten übergeben bekommt, alles anderes wird leer initialisiert
    public Trupp(String name, int level, int entwicklungskosten, int baukosten) {
        this.name = name;
        this.level = level;
        this.entwicklungskosten = entwicklungskosten;
        this.baukosten = baukosten;
    }

    // Konstruktor der Name, Level, Entwicklungskosten, Baukosten, Elixier und Reichweite übergeben bekommt, alles anderes wird leer initialisiert
    public Trupp(String name, int level, int entwicklungskosten, int baukosten, boolean elixier, int reichweite) {
        this.name = name;
        this.level = level;
        this.entwicklungskosten = entwicklungskosten;
        this.baukosten = baukosten;
        this.elixier = elixier;
        this.reichweite = reichweite;
    }

    // Konstruktor der alle Felder übergeben bekommt
    public Trupp(String name, int level, int entwicklungskosten, int baukosten, boolean elixier, int trefferpunkte, double schaden, int bewegungsgeschwindigkeit, double angriffsgeschwindigkeit, int reichweite, int wohnraum, boolean einzel) {
        this.name = name;
        this.level = level;
        this.entwicklungskosten = entwicklungskosten;
        this.baukosten = baukosten;
        this.elixier = elixier;
        this.trefferpunkte = trefferpunkte;
        this.schaden = schaden;
        this.bewegungsgeschwindigkeit = bewegungsgeschwindigkeit;
        this.angriffsgeschwindigkeit = angriffsgeschwindigkeit;
        this.reichweite = reichweite;
        this.wohnraum = wohnraum;
        this.einzel = einzel;
    }

    // Konstruktor der nichts übergeben bekommt und alles leer initialisiert
    public Trupp() {
        this.name = "";
        this.level = 0;
        this.entwicklungskosten = 0;
        this.baukosten = 0;
        this.elixier = false;
        this.trefferpunkte = 0;
        this.schaden = 0;
        this.bewegungsgeschwindigkeit = 0;
        this.angriffsgeschwindigkeit = 0;
        this.reichweite = 0;
        this.wohnraum = 0;
        this.einzel = false;
    }

    // Getter und Setter für alle Felder
    public String get_Name() {
        return name;
    }

    public void set_Name(String name) {
        this.name = name;
    }

    public int get_Level() {
        return level;
    }
    
    public void set_Level(int level) {
        this.level = level;
    }
    
    public int get_Entwicklungskosten() {
        return entwicklungskosten;
    }
    
    public void set_Entwicklungskosten(int entwicklungskosten) {
        this.entwicklungskosten = entwicklungskosten;
    }
    
    public int get_Baukosten() {
        return baukosten;
    }
    
    public void set_Baukosten(int baukosten) {
        this.baukosten = baukosten;
    }
    
    public boolean get_Elixier() {
        return elixier;
    }
    
    public void set_Elixier(boolean elixier) {
        this.elixier = elixier;
    }
    
    public int get_Trefferpunkte() {
        return trefferpunkte;
    }
    
    public void set_Trefferpunkte(int trefferpunkte) {
        this.trefferpunkte = trefferpunkte;
    }
    
    public double get_Schaden() {
        return schaden;
    }
    
    public void set_Schaden(double schaden) {
        this.schaden = schaden;
    }
    
    public int get_Bewegungsgeschwindigkeit() {
        return bewegungsgeschwindigkeit;
    }
    
    public void set_Bewegungsgeschwindigkeit(int bewegungsgeschwindigkeit) {
        this.bewegungsgeschwindigkeit = bewegungsgeschwindigkeit;
    }
    
    public double get_Angriffsgeschwindigkeit() {
        return angriffsgeschwindigkeit;
    }
    
    public void set_Angriffsgeschwindigkeit(double angriffsgeschwindigkeit) {
        this.angriffsgeschwindigkeit = angriffsgeschwindigkeit;
    }
    
    public int get_Reichweite() {
        return reichweite;
    }
    
    public void set_Reichweite(int reichweite) {
        this.reichweite = reichweite;
    }
    
    public int get_Wohnraum() {
        return wohnraum;
    }
    
    public void set_Wohnraum(int wohnraum) {
        this.wohnraum = wohnraum;
    }
    
    public boolean get_Einzel() {
        return einzel;
    }
    
    public void set_Einzel(boolean einzel) {
        this.einzel = einzel;
    }
}    