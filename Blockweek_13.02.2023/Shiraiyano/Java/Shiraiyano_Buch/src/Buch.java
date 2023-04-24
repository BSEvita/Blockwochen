class Buch
{
    private String Titel;
    private String Author;
    private String ISBN;
    private String Genre;
    private String Verlag;
    private int Erscheinungsjahr;
    private String Kommentar;

    public Buch(String titel, String author)
    {
        Titel = titel;
        Author = author;
    }

    public Buch(String titel, String author, String isbn, int erscheinungsjahr)
    {
        Titel = titel;
        Author = author;
        ISBN = isbn;
        Erscheinungsjahr = erscheinungsjahr;
    }

    public Buch(String titel, String author, String isbn, String genre, String verlag, int erscheinungsjahr, String kommentar)
    {
        Titel = titel;
        Author = author;
        ISBN = isbn;
        Genre = genre;
        Verlag = verlag;
        Erscheinungsjahr = erscheinungsjahr;
        Kommentar = kommentar;
    }

    public Buch()
    {
        Titel = "";
        Author = "";
        ISBN = "";
        Genre = "";
        Verlag = "";
        Erscheinungsjahr = 0;
        Kommentar = "";
    }

    public String get_Titel() {
        return Titel;
    }

    public void set_Titel(String titel) {
        Titel = titel;
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