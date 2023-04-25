class Buch
{
    private String Titel;
    private String Author;
    private String ISBN;
    private String Genre;
    private String Verlag;
    private int Erscheinungsjahr;
    private String Kommentar;

    public Buch(String title, String author)
    {
        this.Titel = title;
        this.Author = author;
        this.ISBN = "";
        this.Genre = "";
        this.Verlag = "";
        this.Erscheinungsjahr = 0;
        this.Kommentar = "";
    }

    public Buch(String title, String author, String isbn, int erscheinungsjahr)
    {
        this.Titel = title;
        this.Author = author;
        this.ISBN = isbn;
        this.Genre = "";
        this.Verlag = "";
        this.Erscheinungsjahr = erscheinungsjahr;
        this.Kommentar = "";
    }

    public Buch(String title, String author, String iSBN, String genre, String verlag, int erscheinungsjahr, String kommentar) {
        this.Titel = title;
        this.Author = author;
        this.ISBN = iSBN;
        this.Genre = genre;
        this.Verlag = verlag;
        this.Erscheinungsjahr = erscheinungsjahr;
        this.Kommentar = kommentar;
    }

    public Buch()
    {
        this.Titel = "";
        this.Author = "";
        this.ISBN = "";
        this.Genre = "";
        this.Verlag = "";
        this.Erscheinungsjahr = 0;
        this.Kommentar = "";
    }

    public String get_Titel() {
        return Titel;
    }

    public void set_Titel(String title) {
        Titel = title;
    }

    public String get_Author() {
        return Author;
    }

    public void set_Author(String author) {
        Author = author;
    }

    public String get_ISBN() {
        return ISBN;
    }

    public void set_ISBN(String iSBN) {
        ISBN = iSBN;
    }

    public String get_Genre() {
        return Genre;
    }

    public void set_Genre(String genre) {
        Genre = genre;
    }

    public String get_Verlag() {
        return Verlag;
    }

    public void set_Verlag(String verlag) {
        Verlag = verlag;
    }

    public int get_Erscheinungsjahr() {
        return Erscheinungsjahr;
    }

    public void set_Erscheinungsjahr(int erscheinungsjahr) {
        Erscheinungsjahr = erscheinungsjahr;
    }

    public String get_Kommentar() {
        return Kommentar;
    }

    public void set_Kommentar(String kommentar) {
        Kommentar = kommentar;
    }
}