# Anforderungsanalyse

## 1. Funktionale Anforderungen

Die folgenden funktionalen Anforderungen beschreiben die Funktionen, die die Anwendung bereitstellen muss:

1. Die Anwendung muss einen OSCAL-Katalog aus JSON laden können.
2. Die Anwendung muss einen OSCAL-Katalog aus XML laden können.
3. Die Anwendung muss Katalogdaten strukturiert anzeigen.
4. Die Anwendung muss Metadaten bearbeiten können.
5. Die Anwendung muss Gruppen und Controls anzeigen und bearbeiten können.
6. Die Anwendung muss nach IDs, Titeln und Textinhalten suchen können.
7. Die Anwendung muss Änderungen speichern können.
8. Die Anwendung muss den Katalog als JSON exportieren können.
9. Die Anwendung muss den Katalog als XML exportieren können.
10. Die Anwendung soll die OSCAL-Struktur validieren können.
11. Die Anwendung soll ungültige Eingaben verständlich melden.

---

## 2. Nichtfunktionale Anforderungen

Die folgenden nichtfunktionalen Anforderungen beschreiben Qualitätsmerkmale der Anwendung:

1. Die Anwendung ist als Desktop-Anwendung für Windows umzusetzen.
2. Die Reaktionszeit bei Suchanfragen soll unter 2 Sekunden liegen (bei normaler Nutzung).
3. Die Bedienung soll auch ohne OSCAL-Vorkenntnisse möglich sein.
4. Die Benutzeroberfläche soll klar und konsistent gestaltet sein.
5. Das Laden und Speichern soll fehlerrobust erfolgen.
6. Der Code soll wartbar und schichtenbasiert aufgebaut sein.
7. Die Anwendung soll offline nutzbar sein.

---

## 3. Abgrenzung

Die Anwendung konzentriert sich in Version 1 auf das OSCAL Catalog Model. 
Weitere OSCAL-Modelle sind nicht Bestandteil dieser Version.