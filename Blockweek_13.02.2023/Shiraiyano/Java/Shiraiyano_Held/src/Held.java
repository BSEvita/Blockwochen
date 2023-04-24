class Held
{
    private String Name;
    private int Level;
    private int Kosten;
    private int Trefferpunkte;
    private int Regenerationszeit;
    private double Schaden; //Schaden pro Schlag
    private String Spezialfaehigkeit;

    public Held(String name, int level) {
        Name = name;
        Level = level;
        Kosten = 0;
        Trefferpunkte = 0;
        Regenerationszeit = 0;
        Schaden = 0;
        Spezialfaehigkeit = "";
    }

    public Held(String name, int level, int kosten, int trefferpunkte) {
        Name = name;
        Level = level;
        Kosten = kosten;
        Trefferpunkte = trefferpunkte;
        Regenerationszeit = 0;
        Schaden = 0;
        Spezialfaehigkeit = "";
    }

    public Held(String name, int level, int kosten, int trefferpunkte, int regenerationszeit, double schaden,
                String spezialfaehigkeit) {
        Name = name;
        Level = level;
        Kosten = kosten;
        Trefferpunkte = trefferpunkte;
        Regenerationszeit = regenerationszeit;
        Schaden = schaden;
        Spezialfaehigkeit = spezialfaehigkeit;
    }

    public Held() {
        Name = "";
        Level = 0;
        Kosten = 0;
        Trefferpunkte = 0;
        Regenerationszeit = 0;
        Schaden = 0;
        Spezialfaehigkeit = "";
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
    private boolean Elixier; // (0= dunkles Elixier und 1 = normales Elixier)
    private int Trefferpunkte;
    private double Schaden; // (Pro Schlag)
    private int Bewegungsgeschwindigkeit;
    private double Angriffsgeschwindigkeit;
    private int Reichweite;
    private int Wohnraum;
    private boolean Einzel; // (Schadensart 0 = mehrere Ziele, 1 = einzelne Ziele)

    public Trupp(String name, int level, int entwicklungskosten, int baukosten) {
        Name = name;
        Level = level;
        Entwicklungskosten = entwicklungskosten;
        Baukosten = baukosten;
        Elixier = false;
        Trefferpunkte = 0;
        Schaden = 0;
        Bewegungsgeschwindigkeit = 0;
        Angriffsgeschwindigkeit = 0;
        Reichweite = 0;
        Wohnraum = 0;
        Einzel = false;
    }

    public Trupp(String name, int level, int entwicklungskosten, int baukosten, boolean elixier, int reichweite) {
        Name = name;
        Level = level;
        Entwicklungskosten = entwicklungskosten;
        Baukosten = baukosten;
        Elixier = elixier;
        Trefferpunkte = 0;
        Schaden = 0;
        Bewegungsgeschwindigkeit = 0;
        Angriffsgeschwindigkeit = 0;
        Reichweite = reichweite;
        Wohnraum = 0;
        Einzel = false;
    }

    public Trupp(String name, int level, int entwicklungskosten, int baukosten, Boolean elixier, int trefferpunkte,
                 double schaden, int bewegungsgeschwindigkeit, double angriffsgeschwindigkeit, int reichweite, int wohnraum,
                 Boolean einzel) {
        Name = name;
        Level = level;
        Entwicklungskosten = entwicklungskosten;
        Baukosten = baukosten;
        Elixier = elixier;
        Trefferpunkte = trefferpunkte;
        Schaden = schaden;
        Bewegungsgeschwindigkeit = bewegungsgeschwindigkeit;
        Angriffsgeschwindigkeit = angriffsgeschwindigkeit;
        Reichweite = reichweite;
        Wohnraum = wohnraum;
        Einzel = einzel;
    }

    public Trupp() {
        Name = "";
        Level = 0;
        Entwicklungskosten = 0;
        Baukosten = 0;
        Elixier = false;
        Trefferpunkte = 0;
        Schaden = 0;
        Bewegungsgeschwindigkeit = 0;
        Angriffsgeschwindigkeit = 0;
        Reichweite = 0;
        Wohnraum = 0;
        Einzel = false;
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
    public void set_Elixier(Boolean elixier) {
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
    public void set_Einzel(Boolean einzel) {
        Einzel = einzel;
    }

}