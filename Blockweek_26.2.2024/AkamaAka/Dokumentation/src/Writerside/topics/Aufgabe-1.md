# Aufgabe 1

### Was ist LINQ?

* LINQ steht für "Language Integrated Query".
* LINQ ist in C# und Visual Basic integriert und ist eine Abfragesprache mit der man Daten aus unterschiedlichsten Datenquellen einfach abfragen kann.
* Mit LINQ kann man auf alle verschiedenen Datenquellen gleich zugreifen so lange die Datenquelle eine LING Integration hat.
* LINQ erleichter das Zugreifen auf Datenstrukturen in .NET

### Einfache Praxis anwendung von LINQ | Video 1

Um LINQ nutzen zu können muss man mithilfe von `using System.Linq;`, LINQ erstmal in das Projekt einbinden um es nutzen zu können.

**LINQ Beispiel zum Abfragen nach einem bestimmten Zeichen**
```c#
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LINQTutorial {
    class Program {
        static void Main(string[] args) {
            string[] names = {"Peter","Günter","Manfred","Uwe"};
            var linqTest = from name in names
                            where name.Contains('t')
                            select name; 
            foreach(string name in linqTest) {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
```
> **Wichtig!**
> Die linqTest Abfrage wird erst dann ausgeführt, wenn man diese auch wo benutzt.
{style="warning"}

In diesem Beispiel wird ein Array mit dem namen `names` erstellen mit den werten `Peter`, `Günter`, `Manfred` und `Uwe`.
Dann wird eine Variable namens `linqTest` erstellt und danach mit einer SQL ähnlichen Syntax mit `name.Contains('t')`nach
Arrays gesucht die den Buchstaben `t` beinhalten und ausgewählt. Im anschluss wird dann eine foreach loop erstellt, wo
dann die jeweiligen Arrays ausgegeben werden.

### Query- und Methoden Syntax von LINQ

In dem Video [C# LINQ Tutorial Deutsch / German #2 - Die Query-Syntax und die Method-Syntax](https://www.youtube.com/watch?v=htgqFXYfvBw&list=PL_pqkvxZ6ho0FX6Ro3noCmwQ3ix5Cdu_D&index=2) 
wird erklärt wie die Query und der Methoden Syntax von LINQ funktioniert. 

#### Die Query Syntax

Die Query Syntax ist eines der beiden möglichen Kodierungs arten mit denen man mit LINQ Abfragen erstellen kann.

Wie schon oben erklärt kann man mit 

```c#
            var linqTest = from name in names
                            where name.Contains('t')
                            select name; 
```

eine LINQ Abfrage machen. Diese LINQ Abfrage benutzt die Query Syntax von LINQ und ähnelt der SQL Sprache mehr. 
Und deswegen ist die Query Syntax von LINQ für die sehr zu Empfehlen die viel mit Datenbanken Arbeiten da es bei dieser 
Syntax wenige unterschiede, gibt. 

Den Code kann man wie folgt interpretieren

| Syntax                   | interpretation                                                                                                                         |
|--------------------------|----------------------------------------------------------------------------------------------------------------------------------------|
| from name                | `from` ist soweit ich es verstanden habe einfach nur eine Variable die man dann benutzt zum Ausgaben oder nutzen von weiteren Anfragen |
| in names                 | `in` und die variable danach ist dann die Variable die man von linq verarbeitet haben will                                             |
| where name.Contains('t') | `where name.Contains('t')` wird dann genutzt um die `names` durchzufiltern und zu schauen welches der Werte `t` beinhält               |
| select name              | `select name` ist dann da das wir das endresultat von der `name` variable auswählen                                                    |

#### Die Methode Syntax

Die Methode Syntax ist für die Personen nützlich die nicht viel mit SQL zu tun haben oder sich das nicht geben wollen und gerne mit C# Methoden Arbeiten wollen.

Die Obere Query Syntax sieht dann als Methoden Syntax wie folgt aus:

```c#
var linqTest = names.Where(name => name.Contains('t'));
```

Wenn man bei LINQ mit der Methoden Syntax arbeitet, muss man für `Where` dann Lambda anwenden. 
Was ist Lambda? Lambda ist in diesem fall das `=>` in der `name => name.Contains('t')` abfrage.
Das sagt nichts weiter aus als es am Anfang eine Variable erstellt namens `name` und danach `name.Contains('t')` ausgeführt wird mit den Daten von name.
Einfach gesagt es überprüft, ob die Variable `name` ein `t` beinhält und wenn das der Fall ist gibt der true zurück und wenn nicht, dann false.

![Visual Studio Code Editor - Lambda LINQ Method Syntax implementation](img_24.png)

### LINQ Filtern mit Where und OfType

In dem Video [C# LINQ Tutorial Deutsch / German #3 - Filtern mit Where und OfType](https://www.youtube.com/watch?v=IUgebK3MHKo&list=PL_pqkvxZ6ho0FX6Ro3noCmwQ3ix5Cdu_D&index=3) 
wird es wie im Titel beschrieben um das Filtern mit Where und OfType erklärt. Dafür hat der YouTuber folgende Vorlage angefertigt

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTutorial
{
    class Video3
    {
        static void Main(string[] args)
        {
            List<Student> studentenListe = new List<Student>();
            studentenListe.Add(new Student(Studiengang.Biologie, 3, "Sabrina", "Vogel"));
            studentenListe.Add(new Student(Studiengang.Informatik, 5, "Patrick", "Müller"));
            studentenListe.Add(new Student(Studiengang.Informatik, 4, "Kurt", "Meier"));
            studentenListe.Add(new Student(Studiengang.Germanistik, 1, "Anna", "Kohl"));
            studentenListe.Add(new Student(Studiengang.Mathematik, 2, "Sebastian", "Müller"));

        }
    }
    enum Studiengang
    {
        Informatik,
        Biologie,
        Germanistik,
        Mathematik
    }
    class Student
    {
        public Studiengang Studiengang { get; set; }
        public int Semester { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }

        public Student(Studiengang studiengang, int semester, string vorname, string nachname)
        {
            Studiengang = studiengang;
            Semester = semester;
            Vorname = vorname;
            Nachname = nachname;
        }

        public override string ToString()
        {
            return Vorname + " " + Nachname + " " + Studiengang + " " + Semester + " ";
        }

    }

}
```

#### Die `Where` Methode

Die Where Methode ist dafür da um Ergebnisse nach deren Booleschen Wert Filtern. Das heißt man kann eine abfragen machen 
mit Elementen und wenn diese Elemente sich gleichen dann ist der Wert auch `True` und wenn nicht, dann `False`. (Für mehr 
Informationen bezüglich der Booleschen Tabelle und wie die Funktioniert lese hierzu die Akami Solutions Dokumentation)

Jetzt wollen wir von der Liste nur die Schüler ausgeben die im Studiengang `Informatik` sind. 
hier müssen wir folgenden Code Schreiben:


````c#
[...]
// Query Syntax einzelne where Abfrage
var informatikStudenten = from Student
                          in studentenListe
                          where Student.Studiengang == Studiengang.Informatik // Wenn der Student im Studiengang Informatik ist
                          select Student; // Dann soll es ausgewählt werden
[...]
````

In diesem Code Beispiel wird eine Variable Namens informatikStudenten erstellt. Um die Informatik Studenten zu bekommen, 
definieren wir mit `from` eine variable namens Student und sagen mithilfe von `in` das es die Daten aus der `studentenListe` 
Array nehmen soll. Und dann sagen wir mithilfe von `where` das der nur diese Arrays nimmt, bei denen der Studiengang Informatik ist.

Aufgrund dessen das diese Variable nicht direkt ausgeführt wird müssen wir noch folgenden Code unten dran geben:

```C#
[...]
foreach (Student student in informatikStudenten) {
    Console.WriteLine(student.ToString());
}
[...]
```

in diesem Code Beispiel gehen wir mit `foreach` durch alle Arrays aus der informatikStudenten Variable durch und die 
einzelnen Arrays bekommen den Namen student und dann wird mit `Console.WriteLine(student.ToString())` die Student daten ausgegeben.

Wenn das Programm ausgeführt wird, wird dann folgendes ausgegeben:

![img_23](img_25.png)

Wenn man mehrere sachen Abfragen will wie z.B. nur die Schüler die über dem 4. Studiengang sind dann kann man das wie folgt machen:

````c#
[...]

var informatikStudenten = from Student
                          in studentenListe
                          where (Student.Studiengang == Studiengang.Informatik) && (Student.Semester > 4) // Wenn der Student im Studiengang Informatik ist
                          select Student; // Dann soll es ausgewählt werden*/
[...]
````

Wie man sieht, muss man die einzelnen `where` abfragen dann in einer `()` geben und mit `&&` trennen. Sollte man ein oder 
gebrauchen dann muss man anstatt `&&`, `||` machen.