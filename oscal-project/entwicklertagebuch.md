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

## 📅 Tag 3 – Benutzeroberfläche (Mockup)

Heute habe ich ein Mockup für die Benutzeroberfläche erstellt.

### 🛠️ Durchführung

Das Mockup enthält:

* oben eine Menüleiste (Datei, Bearbeiten, Ansicht, Hilfe)
* linke Navigation (Gruppen und Controls)
* rechte Detailansicht (Beschreibung und Parameter)
* Titelbereich mit dem Katalogname und Versionnummer

### ⚠️ Problem

Ich wusste nicht genau, wie ich die Oberfläche sinnvoll strukturieren soll.

### ✅ Lösung

Ich habe mich an bekannten Desktop-Anwendungen orientiert und eine klare Trennung zwischen Navigation und Inhalt umgesetzt.

---

## 📅 Tag 4 – Umsetzung der Benutzeroberfläche (WPF)

heute habe ich das Mockup in eine Funktionierte Benutzeroberfläche in WPF umgesetzt.

### 🛠️ Durchführung

Ich habe die Oberfläche mit WPF erstellt. Dabei habe ich folgende Elemente verwendet:

* Menüliste (Datei,Bearbeiten, Hilfe)
* Titelbereich mit Katalogname und Versionnummer
* linke Navigation mit TreeView für Gruppen und Controls
* rechte Detailansicht mit Textblöcken und Listen für Beschreibung und Parameter
* Suchfeld zur Filterung von Einträgen

### ⚠️ Problem

Ich war unsicher; wie ich die Oberfläche sinnvoll strukturieren soll und weiche WPF-Elemente deeignet sind.

### ✅ Lösung

Ich habe Layouts mit Grid und StackPanel erstellt und die Elemente entsprechend angeordnet. Ich habe auch Tutorials und Beispiele für WPF-Designs genutzt, um eine ansprechende Benutzeroberfläche zu gestalten.

## 📅 Tag 5 – Implementierung

Heute habe ich mit der Programmierung begonnen.

### 🛠️ Durchführung

* MainWindow erstellt
* erste Klassen implementiert
* Verbindung zwischen UI und Datenmodell vorbereitet

---

## 📅 Tag 6 – JSON / XML Verarbeitung

Heute habe ich den Parser implementiert.

### 🛠️ Durchführung

Ich habe folgende Methoden umgesetzt:

* `LoadJson()`
* `LoadXml()`
* `SaveJson()`
* `SaveXml()`

### ⚠️ Problem

Beim Laden der Dateien gab es Fehler.

### ✅ Lösung

Ich habe die Dateipfade überprüft und das Format der Dateien angepasst.

---

## 📅 Tag 7 – UML Diagramme

Heute habe ich UML-Diagramme erstellt.

### 🛠️ Durchführung

* Klassendiagramm verbessert
* Use-Case-Diagramm erstellt
* Sequenzdiagramm erstellt

### ⚠️ Problem

Ich war unsicher bei der korrekten UML-Darstellung.

### ✅ Lösung

Ich habe die Diagramme anhand von UML-Regeln überarbeitet und verbessert.

---

## 📅 Tag 8 – GitHub

Heute habe ich mein Projekt auf GitHub veröffentlicht.

### 🛠️ Durchführung

* Repository erstellt
* Projekt hochgeladen (Push)
* README-Datei hinzugefügt

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

👉 https://github.com/DEIN-USERNAME/oscal-project
