# Entwicklertagebuch – OSCAL Projekt

---

## 📅 Tag 1 – Projektstart

Heute habe ich mit dem Projekt begonnen.
Ich habe die Aufgabenstellung analysiert und verstanden, dass ich eine Desktop-Anwendung zur Anzeige und Bearbeitung von OSCAL-Katalogen entwickeln soll.

### 🛠️ Durchführung

Ich habe folgende Schritte durchgeführt:

* Projekt in Visual Studio erstellt
* Grundstruktur des Projekts geplant
* erste Ideen für Klassen und Datenmodell gesammelt

### ⚠️ Problem

Ich war mir anfangs nicht sicher, wie die Struktur der Anwendung aufgebaut sein soll.

### ✅ Lösung

Ich habe mich an typischen Desktop-Anwendungen orientiert und eine erste Architektur entworfen.

---

## 📅 Tag 2 – Planung (Klassendiagramm)

Heute habe ich ein Klassendiagramm erstellt.

### 🛠️ Durchführung

Ich habe folgende Klassen modelliert:

* MainWindow
* OscalParser
* SearchService
* Catalog
* Metadata
* Group
* Control
* Parameter
* Part

### ⚠️ Problem

Ich war unsicher bei den Beziehungen zwischen den Klassen (z. B. 1:n Beziehungen).

### ✅ Lösung

Ich habe die Beziehungen mit Listen umgesetzt (z. B. `List<Group>`), um mehrere Objekte speichern zu können.

---

## 📅 Tag 3 – UML Diagramme

Heute habe ich UML-Diagramme erstellt.

### 🛠️ Durchführung

* Klassendiagramm verbessert
* Use-Case-Diagramm erstellt
* Sequenzdiagramm erstellt

### ⚠️ Problem

Ich war unsicher bei der korrekten UML-Darstellung.

### ✅ Lösung

Ich habe die Diagramme anhand von UML-Regeln überarbeitet und verbessert.

## 📅 Tag 4 – Benutzeroberfläche (Mockup)

Heute habe ich ein Mockup für die Benutzeroberfläche erstellt.

### 🛠️ Durchführung

Das Mockup enthält:

* oben eine Menüleiste (Datei, Bearbeiten, Hilfe)
* linke Navigation (Gruppen und Controls)
* rechte Detailansicht (Beschreibung und Parameter)
* Titelbereich mit dem Katalogname und Versionnummer

### ⚠️ Problem

Ich wusste nicht genau, wie ich die Oberfläche sinnvoll strukturieren soll.

### ✅ Lösung

Ich habe mich an bekannten Desktop-Anwendungen orientiert und eine klare Trennung zwischen Navigation und Inhalt umgesetzt.

---

## 📅 Tag 5 – Umsetzung der Benutzeroberfläche (WPF)

heute habe ich das Mockup in eine Funktionierte Benutzeroberfläche in WPF umgesetzt.

### 🛠️ Durchführung

Ich habe die Oberfläche mit WPF erstellt. Dabei habe ich folgende Elemente verwendet:

* Menüliste (Datei,Bearbeiten, Hilfe)
* Titelbereich mit Katalogname und Versionnummer
* linke Navigation mit TreeView, in der alle Controls des Katalogs angezeigt werden
* rechte Detailansicht mit Textblöcken und Listen für Beschreibung und Parameter
* Suchfeld zur Filterung von Einträgen

### ⚠️ Problem

Ich war unsicher; wie ich die Oberfläche sinnvoll strukturieren soll und weiche WPF-Elemente deeignet sind.

### ✅ Lösung

Ich habe Layouts mit Grid erstellt und die Elemente entsprechend angeordnet. Ich habe auch Tutorials und Beispiele für WPF-Designs genutzt, um eine ansprechende Benutzeroberfläche zu gestalten.

---

## 📅 Tag 6 – Implementierung

Heute habe ich mit der Programmierung begonnen.

### 🛠️ Durchführung

* MainWindow erstellt
* erste Klassen implementiert
* Verbindung zwischen UI und Datenmodell vorbereitet

### ⚠️ Probleme

* Zu Beginn war noch unklar, wie die Benutzeroberfläche mit den geladenen OSCAL-Daten verbunden werden soll.
* Die Navigation sollte intuitiv sein, aber es war nicht sofort klar, welche UI-Elemente dafür am besten geeignet sind.
* Beim ersten Aufbau der Oberfläche war noch nicht eindeutig, welche UI-Elemente für Navigation und Detailanzeige verwendet werden sollen.

### ✅ Lösungen

* Die Hauptlogik wurde zunächst im MainWindow zentral umgesetzt, um die Verbindung zwischen Oberfläche und Daten einfacher aufzubauen.
* Für die Navigation wurde eine ListBox gewählt, weil sie einfacher zu implementieren war als eine hierarchische TreeView.
* Das Datenmodell wurde schrittweise vorbereitet, damit Controls, Beschreibungen und Parameter später korrekt angezeigt werden können.

---

## 📅 Tag 7 – Oberfläche und Interaktion

Heute habe ich die Funktionalität der Benutzeroberfläche (UI) erweitert und mit Logik verknüpft.

### 🛠️ Durchführung	

Ich habe folgende Methoden implementiert:

* Benutzeroberfläche (ControlsListBox_SelectionChanged)

* Suchfunktion (TextBox_TextChanged, SearchBox_KeyDown, SearchMenu_Click, ClearSearch_Click)

### ⚠️ Probleme

* Anfangs wurde die Suche nicht korrekt aktualisiert
* Placeholder („Suche…“) wurde nicht richtig angezeigt
* Event-Handler waren teilweise falsch verbunden

### ✅ Lösungen

* Event TextChanged korrekt implementiert
* Sichtbarkeit des Placeholder gesteuert
* Filterlogik für Liste verbessert
* UI-Elemente korrekt verbunden

---

## 📅 Tag 8 – Datenverarbeitung

Heute habe ich die Verarbeitung der OSCAL-Daten implementiert.

### 🛠️ Durchführung

Ich habe folgende Methoden umgesetzt:
* Laden und Parsen der JSON-Datei (`LoadOscalData()`)
* Rekursives Lesen der Gruppenstruktur (`ReadGroups()`)
* Extrahieren der Controls und Parameter (`ReadControls()`, `ReadParameters()`)
* Auslesen der Beschreibung (`GetDescription()`)
* Auslesen der Parameter (`GetParameters()`)

### ⚠️ Probleme

* Unterschiedliche OSCAL-Dateien hatten verschiedene Strukturen (z. B. mit oder ohne groups)
* Einige Dateien waren keine gültigen Kataloge (z. B. Schema-Dateien)
* Beim ersten Versuch wurden Daten doppelt geladen oder nicht korrekt angezeigt

### ✅ Lösungen

* Unterstützung für unterschiedliche Strukturen (groups und controls) wurde ergänzt
* Fehlerbehandlung für nicht unterstützte Dateien wurde eingebaut
* Die Datenliste wird vor dem Laden geleert (_allControlls.Clear())
* Die Verarbeitung wurde stabilisiert und an die tatsächliche JSON-Struktur angepasst

---

## 📅 Tag 9 – JSON / XML Verarbeitung

Heute habe ich den Parser implementiert.

### 🛠️ Durchführung

Ich habe folgende Methoden umgesetzt:

* Laden von JSON-Dateien (`LoadOscalData()`)
* Speichern von JSON-Dateien (`SaveJson()`, `SaveAs()`))
* Export von JSON-Datein (`ExportJson()`)
* Export von JSON-Dateien nach XML (`ExportXml()`)

### ⚠️ Problem

Beim Laden der Dateien gab es Fehler.

### ✅ Lösung

Ich habe die Dateipfade überprüft und das Format der Dateien angepasst.

---

## 📅 Tag 10 – Testen der Anwendung

Heute habe ich die Anwendung systematisch getestet.

### 🛠️ Durchführung

Dabei wurden alle implementierten Funktionen überprüft, insbesondere:
* Laden von JSON-Dateien
* Anzeigen der Controls und Details
* Suchfunktion und Filterung
* Löschen der Suche
* Kopieren von Beschreibungstexten
* Speichern und „Speichern unter“
* Export als JSON und XML

### ⚠️ Probleme

* Beim Öffnen falscher Dateien (z. B. Schema-Dateien) kam es zu Fehlermeldungen
* Unterschiedliche JSON-Strukturen führten anfangs zu Problemen beim Laden
* Kleine Anzeigeprobleme bei der Suche und Auswahl wurden festgestellt
 
### ✅ Lösungen

* Fehlermeldungen wurden verbessert und verständlicher formuliert
* Die Suchfunktion und Anzeige wurden korrigiert und stabilisiert
* 
### 📊 Ergebnis

Alle wichtigen Funktionen der Anwendung arbeiten korrekt.
Die Anwendung reagiert stabil und zeigt verständliche Fehlermeldungen bei Problemen.

## 📅 Tag 11 – GitHub

Heute habe ich mein Projekt auf GitHub veröffentlicht.

### 🛠️ Durchführung

* Repository erstellt
* Projekt hochgeladen (Push)
* README-Datei hinzugefügt
* Test Git Push
---

## 📌 Fazit

In diesem Projekt habe ich gelernt:

* wie man ein Softwareprojekt strukturiert
* wie UML-Diagramme erstellt werden
* wie man mit JSON und XML arbeitet
* wie GitHub zur Versionskontrolle genutzt wird

### 🚀 Ausblick

In Zukunft würde ich:

* die Benutzeroberfläche moderner gestalten
* zusätzliche Funktionen implementieren
* die Anwendung weiter optimieren

---


## 🔗 GitHub Repository

👉 https://github.com/miheenko2973996-lab/oscal-project
