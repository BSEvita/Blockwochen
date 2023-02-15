public class Buch {
    private String Titel;
    private String Author;
    private String ISBN;
    private String Genre;
    private String Verlag;
    private int Erscheinungsjahr;
    private String Kommentar;

    // Konstruktor mit Titel und Author als Übergabewerte
    public Buch(String titel, String author) {
        this.Titel = titel;
        this.Author = author;
        this.ISBN = "";
        this.Genre = "";
        this.Verlag = "";
        this.Erscheinungsjahr = 0;
        this.Kommentar = "";
    }

    // Konstruktor mit Titel, Author, ISBN und Erscheinungsjahr als Übergabewerte
    public Buch(String titel, String author, String ISBN, int erscheinungsjahr) {
        this.Titel = titel;
        this.Author = author;
        this.ISBN = ISBN;
        this.Genre = "";
        this.Verlag = "";
        this.Erscheinungsjahr = erscheinungsjahr;
        this.Kommentar = "";
    }

    // Konstruktor mit allen Feldern als Übergabewerte
    public Buch(String titel, String author, String ISBN, String genre, String verlag, int erscheinungsjahr, String kommentar) {
        this.Titel = titel;
        this.Author = author;
        this.ISBN = ISBN;
        this.Genre = genre;
        this.Verlag = verlag;
        this.Erscheinungsjahr = erscheinungsjahr;
        this.Kommentar = kommentar;
    }

    // Konstruktor ohne Übergabewerte
    public Buch() {
        this.Titel = "";
        this.Author = "";
        this.ISBN = "";
        this.Genre = "";
        this.Verlag = "";
        this.Erscheinungsjahr = 0;
        this.Kommentar = "";
    }

    // Getter-Methode für das Feld Titel
    public String get_Titel() {
        return this.Titel;
    }

    // Setter-Methode für das Feld Titel
    public void set_Titel(String titel) {
        this.Titel = titel;
    }

    // Getter-Methode für das Feld Author
    public String get_Author() {
        return this.Author;
    }

    // Setter-Methode für das Feld Author
    public void set_Author(String author) {
        this.Author = author;
    }

    // Getter-Methode für das Feld ISBN
    public String get_ISBN() {
        return this.ISBN;
    }

    // Setter-Methode für das Feld ISBN
    public void set_ISBN(String ISBN) {
        this.ISBN = ISBN;
    }

    // Getter-Methode für das Feld Genre
    public String get_Genre() {
        return this.Genre;
    }

    // Setter-Methode für das Feld Genre
    public void set_Genre(String genre) {
        this.Genre = genre;
    }

    // Getter-Methode für das Feld Verlag
    public String get_Verlag() {
        return this.Verlag;
    }

    // Setter-Methode für das Feld Verlag
    public void set_Verlag(String verlag) {
        this.Verlag = verlag;
    }

    // Getter-Methode für das Feld Erscheinungsjahr
    public int get_Erscheinungsjahr() {
        return this.Erscheinungsjahr;
    }

    // Setter-Methode für das Feld Erscheinungsjahr
    public void set_Erscheinungsjahr(int erscheinungsjahr) {
        this.Erscheinungsjahr = erscheinungsjahr;
    }

    // Getter-Methode für das Feld Kommentar
    public String get_Kommentar() {
        return this.Kommentar;
    }

    // Setter-Methode für das Feld Kommentar
    public void set_Kommentar(String kommentar) {
        this.Kommentar = kommentar;
    }
}