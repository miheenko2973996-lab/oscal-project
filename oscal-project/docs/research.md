# Research

## 1. Grundschutz / ISMS

- IT-Grundschutz ist Teil des BSI-Kontexts für Informationssicherheit.
- OSCAL dient dazu, Sicherheitsvorgaben maschinenlesbar und automatisierbar abzubilden.

---

## 2. OSCAL

- OSCAL ist ein standardisiertes Format für Security- und Compliance-Daten.
- Für dieses Projekt ist insbesondere das **Catalog Model** relevant.

### Wichtige Elemente im OSCAL-Katalog:
- metadata
- groups
- controls
- params (Parameter)
- back-matter

---

## 3. Ausgangslage

- Der BSI-Grundschutz++-Katalog liegt als JSON-Datei im Repository vor.
- Die Datei ist relativ groß (ca. 3,94 MB auf GitHub).

### Technische Konsequenzen:
- Die Anwendung sollte effizient mit großen Dateien umgehen können.
- Mögliche Ansätze:
  - Lazy Loading
  - Performante Suchfunktion