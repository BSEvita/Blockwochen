
using System.Runtime.CompilerServices;

class Buch
{
    string Titel;
    string Author;
    string ISBN;
    string Genre;
    string Verlag;
    string Erscheinungsjahr;
    string Kommentar;

    public void set_Titel(string args)
    {
        Titel = args;
    }
    public void set_Author(string args)
    {
        Author = args;
    }
    public void set_ISBN(string args)
    {
        ISBN = args;
    }
    public void set_Genre(string args)
    {
        Genre = args;
    }
    public void set_Verlag(string args)
    {
        Verlag = args;
    }
    public void set_Erscheinungsjahr(string args)
    {
        Erscheinungsjahr = args;
    }
    public void set_Komentar(string args)
    {
        Kommentar = args;
    }
    public string get_Titel()
    {
        return Titel;
    }
    public string get_Author(string args)
    {
        return Author;
    }
    public string get_ISBN(string args)
    {
        return ISBN;
    }
    public string get_Genre(string args)
    {
        return Genre;
    }
    public string get_Verlag(string args)
    {
        return Verlag;
    }
    public string get_Erscheinungsjahr(string args)
    {
        return Erscheinungsjahr;
    }
    public string get_Kommentar(string args)
    {
        return Kommentar;
    }
    static void Main(string[] args)
    {
        Buch buch = new Buch();
        buch.set_Titel("Herr der Ringe");
        Console.WriteLine(buch.get_Titel());
    }
}
