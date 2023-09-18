User für Login:
----------------------------
Username:       User
Password:       1234

Username:       Larissa
Password:       12345
----------------------------

----------------------------
Funktoinale Anforderungen
----------------------------


Erfassung von Mitarbeitenden, Lehrlingen und Kunden:
	Nach Eingabe von Pflichtfeldern via Button "Neuer Kontakt"
	Einträge werden automatisch als Mitarbeitender oder Lehring erfasst, wenn entsprechender Reiter gepflegt ist.

Mutieren von Mitarbeitenden, Lehrlingen und Kunden:
	Nach erfolgter Änderung via Button "Kontakt ändern"

Aktivieren und deaktivieren von Mitarbeitenden, Lehrlingen und Kunden:
	Via Radio-Button "Status"

Löschen Mitarbeitenden, Lehrlingen und Kunden:
	Zu löschende Person in Kontakt-Liste auswählen, anschliessend via Button "Kontakt löschen"

Autmatische Vergabe von Mitarbeitern-Nummern:
	Automatisch im Reiter Mitarbeiter

Protokollierten von Notizen in Kundenkontakten inkl. Historie
	Im Reiter Kunde

Suchmöglichkeiten über alle gespeicherten Informationen:
	Suche ist in über alle Eingabefelder möglich. Gewünschten Suchbegriff eingeben, auf "Kontakt suchen" drücken.
	Ergebnisfenster wird geöffnet. Entsprehcenden Kontakt auswählen.
	ACHTUNG: Suche ist case sensitive

Speichern des Datenstamms auf Festplatte:
	Mit dem Betätigen der "Daten in File speichern" werden die Daten automatisch auf die Festplatte gespeichert.


----------------------------
Umgesetzte optionale funktionale Anforderungen
----------------------------


Login
	Logindaten am Anfang des ReadMe aufgelistet.

Import von Kontakten im CSV-Format oder VCard-Format
	Mit Button "Daten aus CSV laden" kann ein CSV-File mit der entsprechenden Struktur Person in die Kontaktliste importiert werden.
	Beim Import wird die bestehende Datenbank gelöscht und durch die importierten Daten ersetzt.
	Im Projekt befindet sich eine CSV-Datei, welche für den Import genutzt werden kann.



----------------------------
Nicht umgesetzte optionale funktionale Anforderungen
----------------------------


Mutationshistorie von Kontaktdaten

Dashboard-View