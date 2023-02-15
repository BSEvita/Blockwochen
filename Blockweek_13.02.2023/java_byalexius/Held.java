public class Held {
    private String Name;
    private int Level;
    private int Kosten;
    private int Trefferpunkte;
    private int Regenerationszeit;
    private double Schaden;
    private String Spezialfaehigkeit;

    public Held() {
        this.Name = "";
        this.Level = 0;
        this.Kosten = 0;
        this.Trefferpunkte = 0;
        this.Regenerationszeit = 0;
        this.Schaden = 0;
        this.Spezialfaehigkeit = "";
    }
    
    public Held(String name, int level, int kosten, int trefferpunkte, int regenerationszeit, double schaden, String spezialfähigkeit) {
        this.Name = name;
        this.Level = level;
        this.Kosten = kosten;
        this.Trefferpunkte = trefferpunkte;
        this.Regenerationszeit = regenerationszeit;
        this.Schaden = schaden;
        this.Spezialfaehigkeit = spezialfähigkeit;
    }

    public Held(String name, int level, int kosten, int trefferpunkte) {
        this.Name = name;
        this.Level = level;
        this.Kosten = kosten;
        this.Trefferpunkte = trefferpunkte;
        this.Regenerationszeit = 0;
        this.Schaden = 0;
        this.Spezialfaehigkeit = "";
    }
    
    public Held(String name, int level) {
        this.Name = name;
        this.Level = level;
        this.Kosten = 0;
        this.Trefferpunkte = 0;
        this.Regenerationszeit = 0;
        this.Schaden = 0;
        this.Spezialfaehigkeit = "";
    }
    
    public String get_Name() {
        return Name;
    }
    public void set_Name(String name) {
        Name = name;
    }
    public int get_Level() {
        return Level;
    }
    public void set_Level(int level) {
        Level = level;
    }
    public int get_Kosten() {
        return Kosten;
    }
    public void set_Kosten(int kosten) {
        Kosten = kosten;
    }
    public int get_Trefferpunkte() {
        return Trefferpunkte;
    }
    public void set_Trefferpunkte(int trefferpunkte) {
        Trefferpunkte = trefferpunkte;
    }
    public int get_Regenerationszeit() {
        return Regenerationszeit;
    }
    public void set_Regenerationszeit(int regenerationszeit) {
        Regenerationszeit = regenerationszeit;
    }
    public double get_Schaden() {
        return Schaden;
    }
    public void set_Schaden(double schaden) {
        Schaden = schaden;
    }
    public String get_Spezialfaehigkeit() {
        return Spezialfaehigkeit;
    }
    public void set_Spezialfaehigkeit(String spezialfaehigkeit) {
        Spezialfaehigkeit = spezialfaehigkeit;
    }    
}

class Trupp 
{
    private String Name;
    private int Level;
    private int Entwicklungskosten;
    private int Baukosten;
    private boolean Elixier;
    private int Trefferpunkte;
    private double Schaden;
    private int Bewegungsgeschwindigkeit;
    private double Angriffsgeschwindigkeit;
    private int Reichweite;
    private int Wohnraum;
    private boolean Einzel;

    public Trupp()
    {
        this.Name = "";
        this.Level = 0;
        this.Entwicklungskosten = 0;
        this.Baukosten = 0;
        this.Elixier = false;
        this.Trefferpunkte = 0;
        this.Schaden = 0;
        this.Bewegungsgeschwindigkeit = 0;
        this.Angriffsgeschwindigkeit = 0;
        this.Reichweite = 0;
        this.Wohnraum = 0;
        this.Einzel = false;
    }

    public Trupp(String name, int level, int entwicklungskosten, int baukosten, boolean elixier, int trefferpunkte, double schaden, int bewegungsgeschwindigkeit, double angriffsgeschwindigkeit, int reichweite, int wohnraum, boolean einzel) {
        this.Name = name;
        this.Level = level;
        this.Entwicklungskosten = entwicklungskosten;
        this.Baukosten = baukosten;
        this.Elixier = elixier;
        this.Trefferpunkte = trefferpunkte;
        this.Schaden = schaden;
        this.Bewegungsgeschwindigkeit = bewegungsgeschwindigkeit;
        this.Angriffsgeschwindigkeit = angriffsgeschwindigkeit;
        this.Reichweite = reichweite;
        this.Wohnraum = wohnraum;
        this.Einzel = einzel;
    }

    public Trupp(String name, int level, int entwicklungskosten, int baukosten, boolean elixier, int reichweite) {
        this.Name = name;
        this.Level = level;
        this.Entwicklungskosten = entwicklungskosten;
        this.Baukosten = baukosten;
        this.Elixier = elixier;
        this.Trefferpunkte = 0;
        this.Schaden = 0;
        this.Bewegungsgeschwindigkeit = 0;
        this.Angriffsgeschwindigkeit = 0;
        this.Reichweite = reichweite;
        this.Wohnraum = 0;
        this.Einzel = false;
    }
    
    public Trupp(String name, int level, int entwicklungskosten, int baukosten) {
        this.Name = name;
        this.Level = level;
        this.Entwicklungskosten = entwicklungskosten;
        this.Baukosten = baukosten;
        this.Elixier = false;
        this.Trefferpunkte = 0;
        this.Schaden = 0;
        this.Bewegungsgeschwindigkeit = 0;
        this.Angriffsgeschwindigkeit = 0;
        this.Reichweite = 0;
        this.Wohnraum = 0;
        this.Einzel = false;
    }
    public String get_Name() {
        return Name;
    }
    public void set_Name(String name) {
        this.Name = name;
    }
    public int get_Level() {
        return Level;
    }
    public void set_Level(int level) {
        Level = level;
    }
    public int get_Entwicklungskosten() {
        return Entwicklungskosten;
    }
    public void set_Entwicklungskosten(int entwicklungskosten) {
        Entwicklungskosten = entwicklungskosten;
    }
    public int get_Baukosten() {
        return Baukosten;
    }
    public void set_Baukosten(int baukosten) {
        Baukosten = baukosten;
    }
    public boolean get_Elixier() {
        return Elixier;
    }
    public void set_Elixier(boolean elixier) {
        Elixier = elixier;
    }
    public int get_Trefferpunkte() {
        return Trefferpunkte;
    }
    public void set_Trefferpunkte(int trefferpunkte) {
        Trefferpunkte = trefferpunkte;
    }
    public double get_Schaden() {
        return Schaden;
    }
    public void set_Schaden(double schaden) {
        Schaden = schaden;
    }
    public int get_Bewegungsgeschwindigkeit() {
        return Bewegungsgeschwindigkeit;
    }
    public void set_Bewegungsgeschwindigkeit(int bewegungsgeschwindigkeit) {
        Bewegungsgeschwindigkeit = bewegungsgeschwindigkeit;
    }
    public double get_Angriffsgeschwindigkeit() {
        return Angriffsgeschwindigkeit;
    }
    public void set_Angriffsgeschwindigkeit(double angriffsgeschwindigkeit) {
        Angriffsgeschwindigkeit = angriffsgeschwindigkeit;
    }
    public int get_Reichweite() {
        return Reichweite;
    }
    public void set_Reichweite(int reichweite) {
        Reichweite = reichweite;
    }
    public int get_Wohnraum() {
        return Wohnraum;
    }
    public void set_Wohnraum(int wohnraum) {
        Wohnraum = wohnraum;
    }
    public boolean get_Einzel() {
        return Einzel;
    }
    public void set_Einzel(boolean einzel) {
        Einzel = einzel;
    }
}