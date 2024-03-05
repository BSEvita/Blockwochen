# Aufgabe 1

### Was ist LINQ?

* LINQ steht für "Language Integrated Query".
* LINQ ist in C# und Visual Basic integriert und ist eine Abfragesprache mit der man Daten aus unterschiedlichsten Datenquellen einfach abfragen kann.
* Mit LINQ kann man auf alle verschiedenen Datenquellen gleich zugreifen so lange die Datenquelle eine LING Integration hat.
* LINQ erleichter das Zugreifen auf Datenstrukturen in .NET

### Einfache Praxis anwendung von LINQ

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