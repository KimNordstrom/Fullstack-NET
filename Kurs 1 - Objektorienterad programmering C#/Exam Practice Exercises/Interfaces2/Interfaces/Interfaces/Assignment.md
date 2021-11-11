# Uppgift
Läs igenom koden och försök förstå vad den gör. Tanken med
applikationen är att den ska läsa in input från användaren och skicka
den vidare till en annan klass som gör någon form av bearbetning av
inputen. När användaren matat in all input hen vill skicka in så görs
en bearbetning av datan. Bearbetningen sammanställs till en sträng
och skrivs ut i console:en.

Det saknas en del i applikationen. Den klass som tar emot, bearbetar
inputen och skapar outputen. Det är din uppgift att bygga denna
klass. Det ska alltså vara en (!) klass som implementerar båda
interface:en.

Implementera din klass så att den sparar alla inputs i en lista och
när outputen ska skapas ska listan skrivas ut i omvänd ordning med
varje värde på en egen rad. Så om vi får följande input:

```
1, 2, 3, 10
```

Så ska outputen vara:

```
10
3
2
1
```
