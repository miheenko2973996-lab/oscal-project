# Benutzerhandbuch – OSCAL Viewer

## 1. Einführung

Der OSCAL Viewer ist eine Anwendung zur Anzeige und Analyse von Sicherheitsmaßnahmen aus OSCAL-basierten JSON-Dateien (z. B. BSI Grundschutz).
Die Anwendung ermöglicht es, Inhalte eines Katalogs übersichtlich darzustellen, zu durchsuchen und zu exportieren.

---

## 2. Systemanforderungen

Die Anwendung wird über Visual Studio oder die ausführbare Datei gestartet.
Systemanforderungen
Windows-Betriebssystem
.NET (WPF-Anwendung)
Visual Studio (für Entwicklung)

---

## 3. Programm starten
Anwendung starten
Beim Start wird automatisch eine Standard-JSON-Datei geladen
Die Inhalte werden in der linken Liste angezeigt

## 4. Benutzeroberfläche

Die Oberfläche besteht aus drei Bereichen:

* Menüleiste
   - Datei
   - Bearbeiten
   - Hilfe

* Linke Seite (Navigation)
   - Liste aller Controls (ListBox)
   - Auswahl eines Eintrags zeigt Details rechts
* Rechte Seite (Details)
   - Titel
   - Beschreibung
   - Parameter

---

## 5. Funktionen

### 5.1 📂 Datei

* Öffnen
   - Lädt eine JSON-DateI
   - Unterstützt OSCAL-Kataloge
* Speichern
   - Speichert die aktuelle Datei
* Speichern unter
   - Speichert die Datei unter neuem Namen
* Export als JSON
   - Exportiert die Daten als JSON-Datei
* Export als XML
   - Konvertiert JSON in XML und speichert die Datei

### 5.2 ✏️ Bearbeiten

* Suchen
   - Cursor springt ins Suchfeld
* Suchfeld
   - Eingabe filtert die Liste automatisch
* Löschen
   - Setzt die Suche zurück
* Kopieren
   - Kopiert die Beschreibung in die Zwischenablage

### 5.3 ℹ️ Hilfe

* Über
   - Zeigt Informationen über die Anwendung

---

## 6. Bedienung

### 6.1 🔍 Suchen

* Begriff in Suchfeld eingeben
* Liste wird automatisch gefiltert
* Enter wählt ersten Treffer

### 6.2🧹 Suche löschen

* Klick auf „X“ oder Menü „Löschen“

### 6.3 📋 Kopieren

* Ein Control auswählen
* Menü „Kopieren“ verwenden

---

## 7. Fehlermeldungen

Die Anwendung zeigt Fehlermeldungen in folgenden Fällen:

* Datei nicht gefunden
* Ungültige JSON-Datei
* Nicht unterstützte OSCAL-Struktur
* Export ohne geladene Daten


---

## 6. 8. Hinweise

* Es werden nur OSCAL-Kataloge unterstützt
* Schema-Dateien oder andere Formate können nicht verarbeitet werden

---

## 7. Fazit

Der OSCAL Viewer ermöglicht eine einfache und strukturierte Analyse von Sicherheitskatalogen.
Die Anwendung ist benutzerfreundlich und unterstützt grundlegende Funktionen wie Suche, Anzeige und Export.