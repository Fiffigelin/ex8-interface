# Övning 8 – Interface

## Uppgift

Skapa en konsolapplikation.

1. Skapa två klasser som heter `Program1` och `Program2`.

2. Den första klassen ska ha en metod `Run()` med returtypen `void`. Den andra klassen ska ha en metod `Go()`, också med returtypen `void`.

3. I metoderna ska du skriva ut följande meddelanden:
   - `Nu kör vi program 1`
   - `Nu kör vi program 2`

4. Skapa objekt av båda klasserna i `Main()` och anropa metoderna.

5. Kommentera sedan bort metodanropen och metoderna i klasserna.

6. Skapa ett interface som innehåller en metod `Start()`.

7. Implementera interfacet i båda klasserna och se till att interfacets kontrakt uppfylls.

8. Besvara frågan: **Vad är fördelen med att använda ett interface jämfört med den ursprungliga lösningen?**

*Mitt svar: Fördelen med ett interface är att flera olika klasser kan använda samma kontrakt och att en klass kan ha flera olika interfaces. Det gör koden flexiblare och lättare att underhålla.*

9. Skapa ytterligare ett interface och implementera det i den första klassen. Lägg till en valfri metod och se till att alla kontrakt uppfylls.

## Extra uppgift

1. Skapa två interface som båda innehåller en metod med namnet `Run()`.
   - Det första interfacet ska ha returtypen `void`.
   - Det andra interfacet ska ha returtypen `int`.

2. Skapa en klass som implementerar båda interfacen och uppfyller båda kontrakten.

3. Implementera två metoder med samma namn:
   - Den ena metoden ska ha returtypen `void`.
   - Den andra metoden ska ha returtypen `int` och returnera talet `7`.

4. I varje metod ska du skriva ut vilken metod som körs.

5. Skapa en instans av klassen och anropa båda metoderna.

*Min kommentar: Om två interfaces har samma metodsnamn och parameter men olika returtyper behöver jag tydliggöra för int Run() att den är via IExtra2-interfacet.*

*Detta heter explicit-implementation - lärt mig något nytt*