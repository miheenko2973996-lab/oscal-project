# Projektumfang Version 1

## 1. Ziel des Systems

Ziel des Projekts ist die Entwicklung einer Desktop-Anwendung zur Bearbeitung der Grundschutz-Bibliothek im OSCAL-Format. Die Anwendung ermöglicht es, bestehende Kataloge zu laden, strukturiert darzustellen, zu bearbeiten und wieder zu speichern. Dabei liegt der Fokus auf einer benutzerfreundlichen grafischen Oberfläche sowie der Unterstützung der Formate JSON und XML.

Die Anwendung richtet sich an Anwender im Bereich Informationssicherheit, die mit dem IT-Grundschutz arbeiten und Kataloginhalte effizient verwalten möchten.

---

## 2. Funktionsumfang (In Scope)

Die folgenden Funktionen werden in Version 1 der Anwendung umgesetzt:

### 2.1.Dateiverwaltung

Import von OSCAL-Katalogen im JSON-Format
Import von OSCAL-Katalogen im XML-Format
Speichern von bearbeiteten Katalogen
Export in JSON
Export in XML

### 2.2.Datenanzeige und Bearbeitung

Strukturierte Darstellung des Katalogs in einer grafischen Oberfläche
Anzeige und Bearbeitung von:
Metadaten (metadata)
Gruppen (groups)
Controls (controls)
Parts (parts)
optional: Parameter (params)
Bearbeitung von Textfeldern und strukturierten Inhalten

### 2.3.Suchfunktion

CSuche nach:
IDs
Titeln
Textinhalten
Anzeige der Suchergebnisse innerhalb der Struktur

### 2.4.Validierung

Grundlegende Validierung der OSCAL-Struktur beim Laden und Speichern
Ausgabe verständlicher Fehlermeldungen bei ungültigen Daten

### 2.5.Benutzeroberfläche

Grafische Desktop-Oberfläche
Navigation durch Baumstruktur (Katalog → Gruppen → Controls)
Detailansicht zur Bearbeitung ausgewählter Elemente
Menüleiste für Datei- und Bearbeitungsfunktionen

---

## 3. Nicht im Umfang enthalten (Out of Scope)

Folgende Funktionen sind nicht Bestandteil von Version 1:

Unterstützung weiterer OSCAL-Modelle außer dem Catalog-Modell
Mehrbenutzerbetrieb
Cloud-Anbindung oder Synchronisation
Benutzer- und Rollenverwaltung
Gleichzeitige Bearbeitung durch mehrere Nutzer
Erweiterte Workflow- oder Freigabemechanismen
Vollständige Bearbeitung des back-matter (nur eingeschränkt oder lesend)

---

## 4.Technische Rahmenbedingungen

Umsetzung als Desktop-Anwendung (z. B. Windows)
Offline-Nutzung ohne Internetverbindung möglich
Verarbeitung von lokalen Dateien
Reaktionszeit bei Suchanfragen unter 2 Sekunden bei üblicher Datenmenge
Wartbare und modulare Softwarearchitektur
Erweiterbarkeit für zukünftige Versionen

---

## 5. Mockup

![Mockup der Benutzeroberfläche](mockup.png)
