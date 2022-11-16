# 04-lleitgeb-Random
**Warum könnte man Zufall beim Programmieren brauchen?**
Da es sich bei Computern um endliche Zustandsmaschinen handelt, sollten sie niemals in der Lage sein, echte Zufallszahlen zu erzeugen. Aber Zahlen, die für die meisten praktischen Anwendungen zufällig genug sind, können wir mit normalen Computern erzeugen. Man kann Random zum Beispiel verwenden, um ein Element aus einer Liste auszuwählen, gewichtete Entscheidungen zu treffen oder zu testen, ob eine Aktion auf der Grundlage eines Wahrscheinlichkeitsprozentsatzes erfolgreich ist oder nicht

**Unterschied zwischen System und Unity Engine**
UnityEngine.Random verwendet einen eigenen Zufallszahlengenerator. Es wird einem als statische Mitgliedsklasse präsentiert, sodass man bei Bedarf keinen neuen Zufallszahlengenerator instanziieren müssen.

System.Random muss erstellt werden. Normalerweise erstellen die Leute in einem Spiel eine und haben eine statische Eigenschaft, um darauf zuzugreifen. Unity hat das im Grunde genommen für Sie erledigt, indem es UnityEngine.Random erstellt hat.


**Warum ist es sinnvoll bei Random ein seed zu setzen?**
Die Seed-Funktion wird verwendet, um den Zustand einer Zufallsfunktion zu speichern, so dass man bei mehreren Ausführungen des Codes auf demselben Rechner oder auf verschiedenen Rechnern (für einen bestimmten Seed-Wert) dieselben Zufallszahlen erzeugen kann. Der Seed-Wert ist die zuvor vom Generator erzeugte Zahl.

**Was macht Random Range?**
Random Range ist sehr nützlich, um eine Zufallszahl innerhalb eines Wertebereichs zu erzeugen. Es kann jedoch auch vorkommen, dass man nur einen einzigen Fließkommawert zwischen 0 und 1 generieren möchten. In diesem Fall braucht man Random Range nicht verwenden.
