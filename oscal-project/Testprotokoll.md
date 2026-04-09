##  Testprotokoll – OSCAL Anwendung

| Nr. | Testfall                | Beschreibung                       | Erwartetes Ergebnis                                | Ergebnis |
|-----|-------------------------|------------------------------------|----------------------------------------------------|----------|
| 1   | App starten             | Anwendung öffnen                   | Standard-JSON wird geladen und angezeigt           |    OK    |
| 2   | Datei öffnen (gültig)   | OSCAL-Katalog laden                | Daten werden korrekt angezeigt                     |    OK    |
| 3   | Datei öffnen (ungültig) | Falsche Datei (z.B, Schema) öffnen | Fehlermeldung wird angezeigt                       |    OK    |
| 4   | Suche (Treffer)         | Begriff eingeben (z.B. „ISMS“)     | Liste wird gefiltert                               |    OK    |
| 5   | Suche (kein Treffer)    | Unbekannten Begriff eingeben       | Liste bleibt leer                                  |    OK    |
| 6   | Suche löschen (Button)  | Klick auf „X“                      | Suchfeld wird geleert, Liste zurückgesetzt         |    OK    |
| 7   | Suche löschen (Menü)    | Bearbeiten → Löschen               | Suchfeld wird geleert                              |    OK    |
| 8   | Enter in Suche          | Enter drücken                      | Erster Treffer wird ausgewählt                     |    OK    |
| 9   | Control auswählen       | Eintrag anklicken                  | Titel, Beschreibung und Parameter werden angezeigt |    OK    |
|10   | Kopieren                | Beschreibung kopieren              | Text ist in Zwischenablage                         |    OK    |
|11   | Speichern               | Datei speichern                    | Datei wird überschrieben                           |    OK    |
|12   | Speichern unter         | Neue Datei speichern               | Neue Datei wird erstellt                           |    OK    |
|13   | Export JSON             | Export durchführen                 | JSON-Datei wird erstellt                           |    OK    |
|14   | Export XML              | Export durchführen                 | XML-Datei wird erstellt                            |    OK    |
|15   | Kein JSON geladen       | Export ohne Datei                  | Fehlermeldung erscheint                            |    OK    |

##  Bewertung

Alle getesteten Funktionen arbeiten wie erwartet.  
Fehlersituationen werden korrekt erkannt und verständlich angezeigt.  
Die Anwendung ist stabil und benutzerfreundlich.