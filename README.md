# CarList_C-
Planering
Innan jag började programmera tänkte jag igenom vilka krav som ställdes på
bedömningsuppgiften. Jag insåg att den skulle behöva kunna:
- Skapa och lagra fordon av olika typer (bil, båt, flygplan etc.)
- Visa information om alla fordon som finns i klassen
- Söka efter ett specifikt fordon baserat på index nummer. Detta beslut
fattade jag eftersom om man raderar ett fordon i mitten av listan, då kan
man inte radera det sista indexet för att längden i listan blir mindre men
id-numret kommer inte att bli mindre. Till exempel, om du har en lista med 5
fordon och du raderar det tredje fordonet, då kommer det fjärde fordonet att
flytta till plats 3 och det femte fordonet till plats 4. Men om du försöker radera
det femte fordonet med index nummer 5, kommer du att få ett
felmeddelande eftersom det inte finns något fordon på den platsen längre.
Därför är det bättre att använda index nummer för att söka efter ett specifikt
fordon i den listan.
- Ta bort ett fordon från klassen
Jag bestämde mig för att använda en lista (List<Fordon>) för att lagra
fordonen i klassen, eftersom det är en dynamisk datastruktur som kan växa
och krympa efter behov. Jag skrev också ner vilka metoder som klassen skulle
ha och vad de skulle göra.
Val av lösning och motivering
Jag valde att använda konstruktorer som skulle ta olika parametrar för att
skapa ett fordon, beroende på vilken information som fanns tillgänglig. Jag
tyckte att det var en bra lösning eftersom det gjorde det möjligt att skapa
fordon på ett flexibelt sätt.
Jag valde den här lösningen eftersom den är effektiv och flexibel. Den gör det
möjligt att skapa fordon av olika typer med samma konstruktor och lagra
dem i samma lista.
Genomförande
Jag började med att definiera klassen Fordon och deklarera de fyra
egenskaperna Make, Model, Color och Year. Jag använde också automatiska
egenskaper med set- och get-metoder för att tilldela och hämta värden.
Sedan deklarerade jag den statiska variabeln ID med ett initialt värde på noll
och den instansvariabeln id som skulle tilldelas ett värde från ID. Därefter
skrev jag tre konstruktorer som tog olika parametrar för att skapa ett fordon. I
varje konstruktor ökade jag värdet på ID med ett och tilldelade det till id.
Sedan skrev jag metoden getID som returnerade id-värdet för ett fordon.
Sedan skapade jag klassen FordonManager och en lista fordon. Jag
implementerade metoderna increase(), print() och decrease() enligt
planeringen. Jag använde en switch-sats för att låta användaren välja vilken
typ av fordon hen ville skapa i increase-metoden.
Jag körde programmet och provade att lägga till, visa, söka och ta bort olika
typer av fordon för att se om allt fungerade som det skulle.
Reflektion
Jag tycker att det som var svårt med uppgiften var att komma på hur jag
skulle använda den statiska variabeln ID för att generera unika id-värden för
varje fordon. Jag fick läsa om statiska variabler i C# och hur de fungerar i
relation till instansvariabler.
Det som var enkelt med uppgiften var att definiera egenskaperna och
konstruktorerna för klassen Fordon.
Det jag skulle vilja kunna göra bättre är att testa min kod mer noggrant och
se om den fungerar som förväntat. Jag skulle också vilja lära mig mer om hur
man dokumenterar sin kod på ett bra sätt.
