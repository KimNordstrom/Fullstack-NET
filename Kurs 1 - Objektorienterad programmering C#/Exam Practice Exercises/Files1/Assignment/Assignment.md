# Uppgift
I programmet finns en fil som heter books.txt. Den innehåller en
lista med böcker. Filen är strukturerad så att varje rad i filen
motsvarar en bok. För varje bok finns det information om tre olika
saker för den boken. Den första raden i filen är inte bok utan
header-information som anger vilken typ av information som finns i
varje kolumn i filen. Varje del på raden avgränsas av ett
paragraftecken (§).

## A
Skapa en klass som kan innehålla information om en bok. Använd
informationen i books.txt för att bestämma vilken information som ska
finnas i din klass.

## B
Skriv kod i Main-metoden som läser in innehållet i books.txt och
skapar upp instanser av klassen du skapade i del A. All information
i filen måste finnas med i objekten.

## C
Skriv kod i Main-metoden som skriver ut en lista med böcker till
console:en. Skriv bara ut böcker som har genren "Programming".
Formatet i listan ska vara följande:

```
Titel                         Författare          Genre
Clean Code: A Handbook of Agi Robert C. Martin    Programming
Code Complete                 Steve McConnell     Programming
```

Notera att titlar som är längre än 29 tecken förkortas (det finns en
metod på string som kan göra detta).
