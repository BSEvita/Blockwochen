

Willkommen beim 4. Block den Grundlagen der objektorientierten Programmierung.

Sie haben diese Woche 7 Programmieraufgaben zu erledigen. Die ersten 4 Aufgaben sind in erster Linie Klassen-Programmierungen, welche über eine automatische Abgabe bewertet werden. Deswegen halten Sie sich sehr genau an die Angaben! Die letzten 3 Aufgaben lassen dann mehr Freiheiten, da sie auch individuell bewertet werden.

Sie können die ersten 4 Aufgaben in Java oder C# programmieren. Die Abgabe ist leider nur in Java möglich. Falls es Probleme gibt, bitte übers Forum melden! Die letzten 3 Beispiele sind in C# zu programmieren!


## Bewertung

| Aufgaben   | Programmieren | Gesamt |
|------------|---------------|--------|
| 1. Aufgabe | 9%            | 6,3%   |
| 2. Aufgabe | 9%            | 6,3%   | 
| 3. Aufgabe | 10%           | 7%     | 
| 4. Aufgabe | 15%           | 10,5%  |
| 5. Aufgabe | 19%           | 13,3%  |
| 6. Aufgabe | 19%           | 13,3%  |
| 7. Aufgabe | 19%           | 13,3%  |
| Gesamt:    | 100%          | 70%    |
   Jedes Beispiel, welches Sie lösen, soll als dokumentierter Source-Code in Ihrem Portfolio landen. Für die letzten 3 Beispiele soll ebenfalls eine genaue Bedienungsanleitung Ihres Programmes sowie die Testfälle dort zu finden sein.

## Zusammenfassung:

* 70% Programmieren
* 30% Portfolio

| Höchste | Niedrigste | Note |
|---------|------------|------|
| 100,00% | 	87,50%    | 	1   |
| 87,49 % | 75,00 %    | 2    |
| 74,99 % | 62,50 %    | 3    |
| 61,99 % | 50,00 %    | 4    |
| 49,99 % | 0,00 %     | 5    |

Viel Spaß!



# EINFÜHRUNG

http://openbook.rheinwerk-verlag.de/visual_csharp_2012/1997_03_001.html#dodtpf766d18e-5ded-46aa-8e8e-625d86cb0d78

https://java-tutorial.org/klassen-in-java.html

http://openbook.rheinwerk-verlag.de/visual_csharp_2012/1997_03_001.html#dodtpf766d18e-5ded-46aa-8e8e-625d86cb0d78

http://openbook.rheinwerk-verlag.de/visual_csharp_2012/1997_03_001.html#dodtpf766d18e-5ded-46aa-8e8e-625d86cb0d78

### Bücher

[Infos](https://en.wikipedia.org/wiki/BibTeX)

**Aufgabenstellung:**

Hier ist die genaue Aufgabenstellung für die Klasse "Buch".

Programmieren Sie eine Klasse namens "Buch" für die Speicherung von Büchern. Die Klasse muss folgende Felder haben:

1. Titel
2. Author 
3. ISBN 
4. Genre 
5. Verlag 
6. Erscheinungsjahr 
7. Kommentar

Definieren Sie die Felder mit den passenden Formaten, wie zum Beispiel `private String Titel;`

Die Klasse soll folgende Konstruktoren enthalten:

1. Konstruktor der Titel und Author übergeben bekommt, alles anderes wird leer initialisiert 
2. Konstruktor der Titel, Author, ISBN und Erscheinungsjahr übergeben bekommt, alles anderes wird leer initialisiert 
3. Konstruktor der alle Felder übergeben bekommt 
4. Konstruktor der nichts übergeben bekommt und alles leer initialisiert
Jedes Feld soll eine get- und set-Methode namens get_<Name des Feldes> bzw. set_<Name des Feldes> haben, wie zum Beispiel `public String get_Titel()`

Achten Sie auf die Namensgebung und die Reihenfolge der Übergabewerte bei den Konstruktoren!

Viel Erfolg!

### Schauspieler

[Infos](https://www.imdb.com/)

**Aufgabenstellung:**

Hier ist die genaue Aufgabenstellung für die Klasse "Schauspieler".

Programmieren Sie eine Klasse namens "Schauspieler" für die Speicherung von Schaupielern. Die Klasse muss folgende Felder haben:

1. Vorname 
2. Nachname 
3. Spitzname 
4. Geburtsort 
5. Geburtsdatum 
6. Nationalitaet 
7. Groesse(in Meter)

Definieren Sie die Felder mit den passenden Formaten, wie zum Beispiel `private String Vorname;`

Die Klasse soll folgende Konstruktoren enthalten:

1. Konstruktor der Vorname und Nachname übergeben bekommt, alles anderes wird leer initialisiert 
2. Konstruktor der Vorname, Nachname, Spitzname und Groesse übergeben bekommt, alles anderes wird leer initialisiert 
3. Konstruktor der alle Felder übergeben bekommt 
4. Konstruktor der nichts übergeben bekommt und alles leer initialisiert
5. 
Jedes Feld soll eine get- und set-Methode namens get_<Name des Feldes> bzw. set_<Name des Feldes> haben, wie zum Beispiel `public String get_Vorname()`

Achten Sie auf die Namensgebung und die Reihenfolge der Übergabewerte bei den Konstruktoren!

Viel Erfolg!

### Filme

[Infos](https://www.imdb.com/)

**Aufgabenstellung:**

Hier ist die genaue Aufgabenstellung für die Klasse "Film".

Programmieren Sie eine Klasse namens "Film" für die Speicherung von Filmen. Die Klasse muss folgende Felder haben:

1. Titel 
2. Erscheinungsjahr 
3. Genre 
4. Laufzeit(in ganzen Minuten)
5. Cast(Schauspieler)
6. Sprache 
7. FSK

Definieren Sie die Felder mit den passenden Formaten, wie zum Beispiel `private String Titel;`
Der Cast ist eine Liste von Schauspielern **(Klasse der vorherigen Aufgabe)**!

Die Klasse soll folgende Konstruktoren enthalten:

1. Konstruktor der **Titel** und **Erscheinungsjahr** übergeben bekommt, alles anderes wird leer initialisiert 
2. Konstruktor der **Titel**, **Erscheinungsjahr**, **Genre** und **Laufzeit** übergeben bekommt, alles anderes wird leer initialisiert 
3. Konstruktor der **alle Felder** übergeben bekommt 
4. Konstruktor der **nichts** übergeben bekommt und alles leer initialisiert

Jedes Feld soll eine get- und set-Methode namens get_<Name des Feldes> bzw. set_<Name des Feldes> haben, wie zum Beispiel `public String get_Titel()`

Achten Sie auf die Namensgebung und die Reihenfolge der Übergabewerte bei den Konstruktoren!

Viel Erfolg!

### Clash of Clans

[Infos](https://clashofclans.fandom.com/de/wiki/Clash_of_Clans_Wiki)

**Aufgabenstellung:**

Hier ist die genaue Aufgabenstellung für die COC-Klassen.

1.Aufgabe
Programmieren Sie eine Klasse namens "Held" für die Speicherung von Helden. Die Klasse muss folgende Felder haben:

Name
Level
Kosten
Trefferpunkte
Regenerationszeit
Schaden (Pro Schlag)
Spezialfähigkeit
Definieren Sie die Felder mit den passenden Formaten, wie zum Beispiel private String Name;

Die Klasse soll folgende Konstruktoren enthalten:

Konstruktor der Name und Level übergeben bekommt, alles anderes wird leer initialisiert
Konstruktor der Name, Level, Kosten und Trefferpunkte übergeben bekommt, alles anderes wird leer initialisiert
Konstruktor der alle Felder übergeben bekommt
Konstruktor der nichts übergeben bekommt und alles leer initialisiert
Jedes Feld soll eine get- und set-Methode namens get_<Name des Feldes> bzw. set_<Name des Feldes> haben, wie zum Beispiel public String get_Name()


2.Aufgabe

Programmieren Sie eine Klasse namens **"Trupp"** für die Speicherung von Truppen. Die Klasse muss folgende Felder haben:Level

1.    Name
2.    Level
3.    Entwicklungskosten
4.    Baukosten
5.    Elixier (0= dunkles Elixier und 1 = normales Elixier)
6.    Trefferpunkte
7.    Schaden (Pro Schlag)
8.    Bewegungsgeschwindigkeit
9.    Angriffsgeschwindigkeit
10.    Reichweite
11.    Wohnraum
12.    Einzel (Schadensart 0 = mehrere Ziele, 1 = einzelne Ziele)
13. 
Definieren Sie die Felder mit den passenden Formaten, wie zum Beispiel **private Integer Level;**

Die Klasse soll folgende Konstruktoren enthalten:

1. Konstruktor der **Name, Level, Entwicklungskosten** und **Baukosten** übergeben bekommt, alles anderes wird leer initialisiert
2. Konstruktor der **Name**, **Level**, **Entwicklungskosten**, **Baukosten**, **Elixier** und **Reichweite** übergeben bekommt, alles anderes wird leer initialisiert
3. Konstruktor der **alle Felder** übergeben bekommt
4. Konstruktor der **nichts** übergeben bekommt und alles leer initialisiert

Jedes Feld soll eine get- und set-Methode namens get_<Name des Feldes> bzw. set_<Name des Feldes> haben, wie zum Beispiel `public Integer get_Level()`

**Achten Sie auf die Namensgebung und die Reihenfolge der Übergabewerte bei den Konstruktoren! Recherchieren Sie ausführlich im Fan-Wiki damit die Datenformate passen!**

Viel Erfolg!

### Taschenrechner

[Infos](https://web2.0rechner.de/)

**Aufgabenstellung:**

Hier ist die genaue Aufgabenstellung für den Taschenrechner.

Programmieren Sie einen Taschenrechner mit Klassen in einer Konsolen-Anwendung. Es bleibt Ihnen selber überlassen wie Sie es lösen. Folgende Rechenoperationen sollen mit Kommazahlen möglich sein und als Methoden realisiert werden:

1. Addition
2. Subtraction
3. Multiplikation
4. Division
5. Potenzieren
6. Wurzel ziehen
7. Logarithmus
8. Fakultät
9. Sinus, Cosinus und Tangens


Überlegen Sie sich mindestens **9 gute Testfälle** und dokumentieren Sie diese im Portfolio.

Der Taschenrechner muss sich immer das letzte Ergebnis merken. Wie sie die Eingaben des Users regeln überlasse ich auch Ihrer Kreativität!

Viel Erfolg!

### Bruchrechner

[Infos](https://www.bruchrechner.com/)

**Aufgabenstellung:**

Hier ist die genaue Aufgabenstellung für den Bruchrechner.

Programmieren Sie einen Bruchrechner mit Klassen in einer Konsolen-Anwendung. Es bleibt Ihnen selber überlassen wie Sie es lösen. Folgende Rechenoperationen sollen mit Brüchen(teilweise mit Operatorüberladung) möglich sein und als Methoden realisiert werden:

1. Addition
2. Subtraction
3. Multiplikation
4. Division
5. Potenzieren
6. Wurzel ziehen

Überlegen Sie sich mindestens **12 gute Testfälle** und dokumentieren Sie diese im Portfolio.

**Das Ergebnis muss immer soweit wie möglich gekürzt sein!** Der Bruchrechner muss sich immer das letzte Ergebnis merken. Wie sie die Eingaben des Users regeln überlasse ich auch Ihrer Kreativität!

Viel Erfolg!

### Zahlensystem umrechner

[Infos](https://www.tutorials.at/einfuehrung/03-zahlensysteme.html)

**Aufgabenstellung:**

Hier ist die genaue Aufgabenstellung für den Zahlensystemumrechner.

Programmieren Sie einen Zahlenumrechner mit Klassen in einer Konsolen-Anwendung. Es bleibt Ihnen selber überlassen wie Sie es lösen. Folgende Rechenoperationen sollen in allen Zahlensystemen(teilweise mit Operatorüberladung) möglich sein und als Methoden realisiert werden:

1. Addition
2. Subtraction
3. Multiplikation
4. Division

Die folgenden Zahlensysteme sollen in die jeweils anderen umrechenbar sein und als Methoden realisiert werden:

1. Binär
2. Oktal
3. Dezimal
4. Hexadezimal

Überlegen Sie sich mindestens **12 gute Testfälle** und dokumentieren Sie diese im Portfolio.

Wie sie die Eingaben des Users regeln überlasse ich auch Ihrer Kreativität!

Viel Erfolg!