public class Held {
    private String name;
    private int level;
    private int kosten;
    private int trefferpunkte;
    private int regenerationszeit;
    private double schaden;
    private String spezialfähigkeit;
    
    public Held(String name, int level) {
        this.name = name;
        this.level = level;
    }
    
    public Held(String name, int level, int kosten, int trefferpunkte) {
        this(name, level);
        this.kosten = kosten;
        this.trefferpunkte = trefferpunkte;
    }
    
    public Held(String name, int level, int kosten, int trefferpunkte, int regenerationszeit, double schaden, String spezialfähigkeit) {
        this(name, level, kosten, trefferpunkte);
        this.regenerationszeit = regenerationszeit;
        this.schaden = schaden;
        this.spezialfähigkeit = spezialfähigkeit;
    }
    
    public Held() {
        this("", 0, 0, 0, 0, 0, "");
    }
    
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
    
    public int get_Kosten() {
        return kosten;
    }
    
    public void set_Kosten(int kosten) {
        this.kosten = kosten;
    }
    
    public int get_Trefferpunkte() {
        return trefferpunkte;
    }
    
    public void set_Trefferpunkte(int trefferpunkte) {
        this.trefferpunkte = trefferpunkte;
    }
    
    public int get_Regenerationszeit() {
        return regenerationszeit;
    }
    
    public void set_Regenerationszeit(int regenerationszeit) {
        this.regenerationszeit = regenerationszeit;
    }
    
    public double get_Schaden() {
        return schaden;
    }
    
    public void set_Schaden(double schaden) {
        this.schaden = schaden;
    }
    
    public String get_Spezialfaehigkeit() {
        return spezialfähigkeit;
    }
    
    public void set_Spezialfaehigkeit(String spezialfähigkeit) {
        this.spezialfähigkeit = spezialfähigkeit;
    }
}
