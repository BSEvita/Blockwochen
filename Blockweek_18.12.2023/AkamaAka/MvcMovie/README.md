# Blockwoche
## Entwicklung einer C# MVC-Anwendung mit Entity Framework


    1. Installation vom MSSQL Server
    2. Installation vom SSMS auf Linux
    3. Installation von ASP.NET Core MVC mit Rider unter Linux
    4. Erste Schritte mit ASP.NET Core MVC
    5. Erste Schritte
    6. Hinzufügen eines Controllers
    7. Ansicht hinzufügen
    8. Modell hinzufügen
    9. Arbeiten mit einer Datenbank
    10. Controlleraktionen und Ansichten
    11. Hinzufügen der Suche
    12. Hinzufügen eines neuen Felds
    13. Hinzufügen der Validierung
    14. Untersuchen von Details und Löschvorgang

# Installation vom MSSQL Server

Bei der Installation vom SQL Server und von SSMS musste ich auf der angegebenen Seite etwas weiter Runter Scrollen. Unten angekommen habe ich dann gesehen das dort das Typische Linux Logo ist und dann habe ich auf „Choose your installation setup“ geklickt. Dann wurde ein Modal geöffnet und da Debian nicht aufgelistet war was ich derzeit habe, habe ich Ubuntu ausgewählt die Installation bei deinen so gut wie fast immer die selbe ist.


Als ich da dann drauf geklickt habe wurde dann folgende Seite geöffnet:
https://learn.microsoft.com/de-DE/sql/linux/quickstart-install-connect-ubuntu?view=sql-server-ver16&tabs=ubuntu2204

hier habe ich erstmal die ersten zwei Schritte ausgeführt um den GPG Key vom Microsoft Packaging Server zu erhalten um Sicher die ganzen Programme und Server Installieren zu können.
Bei Schritt 3 in der Anleitung musste ich dann das ganze etwas anders machen. Und zwar musste ich dann den gegebenen ersten Link abändern. Dazu habe ich einfach die Seite besucht und „ubuntu/22.04/prod.list“ aus dem Link entfernt. Dann wurde mir auf der Seite schon debian und dann schon die Version angezeigt die ich auswählen muss. In meinem fall habe ich 12 ausgewählt da ich diese Debian Version habe. Dies kann man auch unter „lsb_release -a“ herausfinden. Danach habe ich den Link mit dem jetzige ausgebessert und dann einfach prod.list hinzugefügt und ausgewählt. Danach musste ich nur noch „sudo apt update“ ausführen und schon wurden die Microsoft Programme und Server zum Download bereit.Nach dem ich „sudo apt-get install mssql-tools“ ausgeführt habe wurden die MSSQL Tools und Server schon heruntergeladen.

Als nächstes muss ich nur noch die Lizenzen und Bedingungen von MSSQL Akzeptieren

Dies geht ganze einfach indem ich die Pfeiltasten und die Enter Taste Betätigt habe.
Am ende sah das ganze dann so aus:



Nach dem ich gemerkt habe das ich mich auf der Microsoft Seite verirrt hatte und die Schritte weiter unten befolgt habe, habe ich gemerkt das der SSMS Server nicht für Debian gibt deswegen habe ich einfach die Schritte von der Microsoft Seite befolgt.
Nach dem ich sudo apt-get install -y mssql-server eingegeben habe um den mssql-server zu Installieren sollte das endergbenis so aussehen:

Wie auch unten erklärt muss man dann nur noch „sudo /opt/mssql/bin/mssql-conf setup“ ausführen um das Setup zu Starten.
Sobald das Setup gestartet wurde wirst du gefragt was für eine MSSQL Version du haben willst. Hier habe ich für’s erste die Developer Version also die Nummer 2 ausgewählt. Die ist Kostenlos allerdings darf man die nicht soweit ich verstanden habe diese Version für Inhalte Verwenden die Öffentlich sind.  
Jetzt werde ich wieder gefragt ob ich die Lizenz Richtlinien Akzeptiere und da Schreibe ich auch „Yes“ rein um diese zu Akzeptieren.

Danach wirst du gefragt welche Sprache der SQL Server haben soll, ich wähle Deutsch aus damit das ganze einfacher ist.
Nachdem du die Sprache ausgewählt hast kannst du das Admin Passwort setzen. Dieses Passwort musst du dir Merken da du ohne diesem Passwort nicht mehr auf deine Datenbank dann Zugreifen kannst mit dem Nutzer. Beachte auch das Passworteingaben unter Linux nicht Sichtbar sind aus Sicherheitsgründen. Nachdem du das Administrator Passwort zwei mal eingegeben hast solltest du Folgende ausgabe zurückbekommen

Jetzt kannst du mit „systemctl status mssql-server –no-pager“ einsehen ob der MSSQL Server Aktiv ist oder nicht.
Aufgrund das wir bereits schon mssql-tools installiert haben kannst du folgenden Befehl Verwenden um auch die mssql-tools Befehle nutzen zu können: „export PATH=$PATH:/opt/mssql-tools/bin/“
Jetzt können wir auch mit dem „sqlcmd -S 127.0.0.1 -U sa“ befehl uns mit der Datenbank Verwenden. „-U sa“ sagt dem sqlcmd Befehl das du dich mit dem Benutzer „sa“ Anmelden willst das für „Systemadministrator“ steht.
Sobald du das gemacht hast musst du hier das Passwort eingeben das du Vorher beim Setup eingegeben hast.


Auf der „https://learn.microsoft.com/de-DE/sql/linux/quickstart-install-connect-ubuntu?view=sql-server-ver16&tabs=ubuntu2204“ Seite findest du ganz unten Eingaben die du jetzt aus Test Zwecken ausführen kannst.

# Installation vom SSMS auf Linux

Um das einstellen und Managen von Datenbanken zu Vereinfachen kann man sich das SSMS von Microsoft auch auf Linux Installieren allerdings gibt es dazu bestimmte umwege die man machen muss. SSMS steht für „SQL Server Management Studio“ und ist eine Grafische Umgebung mit der du deine MSSQL Datenbank Managen kannst.
Mit einer einfachen Google suche wie man SSMS auf Linux Installieren kann wird die Seite „https://learn.microsoft.com/en-us/sql/linux/sql-server-linux-manage-ssms?view=sql-server-ver16“ Vorgeschlagen.
Um SSMS auf Linux zu Nutzen lade ganz normal die SSMS exe von der Offiziellen Microsoft Seite herunter. Dann musst du auf deinem Linux System „wine“ Installieren. Dies kannst du mit „sudo apt install wine“ surchführen.
Sobald wine Installiert ist kannst du die .exe Datei mit dem Befehel „wine SSMS-Setup-ENU.exe“ starten.
Dies sieht dann wie folgt aus:

Dann klickst du auf „Install“ und dann wird alles Installiert. Sobald SSMS Installiert wurde kannst du auf „Close“ drücken. Solltest du KDE Plasma nutzen auf deinem Linux System kannst du dann unten Links auf das Logo klicken und dann auf „Wine“ Hovern. Dann solltest du wie bei mir alle deine Wine installierten Programme sowie die SSMS Porgramme sehen.

Nun kannst du das „SQL Server Management Studio 19“ Öffnen und dich dann mit deiner Lokalen Datenbank Verbinden. Es kann sein das sich der Management Studio schließt dies kann dann bedeuten dass das Management Studio nicht mehr Funktioniert über wine.

Installation von ASP.NET Core MVC mit Rider unter Linux

Aufgrund dessen das Visual Studio auf einem Linux System nicht funktioniert muss ich hier auf Rider umsteigen was von der Firma JetBrains Programmiert und gewartet wird. Solltest du eine Lehrperson oder ein Schüler sein kannst du alle JetBrains Produkte Gratis Erwerben durch den GitHub Student Pack oder indem du deinen Schüler ausweis oder deine Schul E-Mail Adresse bei JetBrains angibst und dich für den Student Pack registrierst.
Der ASP.NET Core MVC ist Standartmäßig von Rider vorinstalliert und du brauchst nur noch „New Solution“ und dann unter „.NET / .NET Core“,  „ASP.NET Core Web Application“  auswählen. Dann gibst du bei Solution Name den Namen deines Projektes an wählst dein Pfad wo es Installiert werden soll, machst bei „Put solution and project in the same Directory“ ein Hacken rein. Zu allerletzt musst du dann bei „Typ“, „Web App (Model-View-Controller)“ auswählen damit das Projekt auch wirklich ein MVC Projekt ist. Solltest du mit Microsoft Azure oder mit Windows Authentifizierung Arbeiten wollen dann wähle auch bei „Auth“ deine Verifizierungsmethode aus die du haben willst. Das ergebnis soll dann so aussehen:

Dann klickst du auf „Create“ und dann wird die Basis deines Projektes erstellt.

Das ganze sieht dann so aus:

Nun kannst du das Projekt Starten indem man auf den Grünen Hacken klickt oben rechts. Dann sollte sich ein Browser Fenster Öffnen. Beachte das Folgendes aufkommen kann:


Wenn du den Fehler siehst klicke einfach auf „Erweitert“ und dann auf „Risiko Akzeptieren und Fortsetzen“.

# Erste Schritte mit ASP.NET Core MVC

Das Tutorial auf der Microsoft-Website führt Sie durch die Schritte zur Erstellung einer ASP.NET Core MVC-App. Es ist in mehrere Abschnitte unterteilt, die jeweils einen bestimmten Aspekt der App-Entwicklung behandeln. Hier ist eine Zusammenfassung der von Ihnen angegebenen Unterthemen:
## Erste Schritte
• Laden Sie Visual Studio herunter und installieren Sie es.
• Erstellen Sie ein neues Projekt in Visual Studio.
• Wählen Sie die ASP.NET Core Webanwendungsvorlage aus.
• Wählen Sie das Modell-View-Controller-Template aus.
## Hinzufügen eines Controllers
• Klicken Sie im Projektmappen-Explorer mit der rechten Maustaste auf den Ordner “Controller”.
• Klicken Sie auf “Hinzufügen” und dann auf “Controller”.
• Wählen Sie im Dialogfeld “Neues Gerüstelement hinzufügen” die Option “MVC-Controller - leer” aus.
• Geben Sie im Dialogfeld “Neues Element hinzufügen: MvcMovie” den Namen “HelloWorldController.cs” ein und klicken Sie auf “Hinzufügen”.
## Ansicht hinzufügen
• Klicken Sie im Projektmappen-Explorer mit der rechten Maustaste auf den Ordner “Views”.
• Klicken Sie auf “Hinzufügen” und dann auf “Ansicht”.
• Geben Sie im Dialogfeld “Neues Element hinzufügen: MvcMovie” den Namen “Index.cshtml” ein und klicken Sie auf “Hinzufügen”.
## Modell hinzufügen
• Klicken Sie im Projektmappen-Explorer mit der rechten Maustaste auf den Ordner “Models”.
• Klicken Sie auf “Hinzufügen” und dann auf “Klasse”.
• Geben Sie im Dialogfeld “Neues Element hinzufügen: MvcMovie” den Namen “Movie.cs” ein und klicken Sie auf “Hinzufügen”.

## Arbeiten mit einer Datenbank
• Öffnen Sie die Datei “appsettings.json”.
• Fügen Sie die Verbindungszeichenfolge für Ihre Datenbank hinzu.
• Fügen Sie den EF Core-Dienst in der Startup.cs-Datei hinzu.
• Fügen Sie den MovieContext-Dienst in der Startup.cs-Datei hinzu.
## Controlleraktionen und Ansichten
• Öffnen Sie die Datei “HelloWorldController.cs”.
• Fügen Sie eine Aktion hinzu, die eine Ansicht zurückgibt.
• Fügen Sie eine Ansicht hinzu, die von der Aktion zurückgegeben wird.
## Hinzufügen der Suche
• Fügen Sie eine Suchfunktion hinzu, die auf der Titelspalte der Movie-Tabelle basiert.
## Hinzufügen eines neuen Felds
• Fügen Sie ein neues Feld zur Movie-Klasse hinzu.
• Aktualisieren Sie die Datenbank, um das neue Feld zu unterstützen.
• Aktualisieren Sie die Ansicht, um das neue Feld anzuzeigen.
## Hinzufügen der Validierung
• Fügen Sie Validierungsattribute zur Movie-Klasse hinzu.
• Aktualisieren Sie die Ansicht, um die Validierungsfehler anzuzeigen.
## Untersuchen von Details und Löschvorgang
• Fügen Sie eine Aktion hinzu, die Details zu einem Film anzeigt.
• Fügen Sie eine Aktion hinzu, die einen Film löscht.

<small>Diese Readme beinhält nicht alles aus dem Protokoll, es ist umgeschrieben als Anleitung für besseres Verständnis.</small>