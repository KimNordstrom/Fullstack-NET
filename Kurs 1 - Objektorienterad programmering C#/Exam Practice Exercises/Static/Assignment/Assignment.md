# Uppgift
I den här uppgiften finns det en applikation som läser int siffror
från consolen och sparar dem i en klass som heter IntCollection.
IntCollection kan också skriva ut alla siffror den sparat undan.

## A
Det finns ett fel i IntCollection. Den sparar inte siffrorna mellan
varven i loopen. Åtgärda detta genom att göra listan intValues static.
Du får inte ändra koden i Program.cs för att lösa denna deluppgift.

## B
Lägg till en metod i IntCollection som tömmer intValues på värden.

## C
Ändra i Program.cs så att om användaren skicka in en tom sträng
i stället för en siffra så anropas metoden du skapade i deluppgift B.

Ex:

| Input   | Output |
|------------------|
| 1       | 1      |
| 2       | 1,2    |
| 3       | 1,2,3  |
| [tom]   |        |
| 1       | 1      |
| 2       | 1,2    |
