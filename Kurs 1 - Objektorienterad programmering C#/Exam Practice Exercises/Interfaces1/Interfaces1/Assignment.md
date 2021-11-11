# Uppgift
I denna uppgift finns en liten applikation som först samlar in en
lista med todos och sen skriver ut listan med icke-klarmarkerade
todos. Klassen TodoCollection används i två metoder i Program.cs.

De två metoderna CollectTodos och PrintNonFinishedTodos får nu in 
hela TodoCollection-instansen även om metoderna inte behöver
kännedom om hela objektet. Vi vill begränsa åtkomsten i metoderna så
att varje metod bara kommer åt de metoder i TodoCollection som
metoden behöver komma åt.

## A
Skapa ett interface som deklarerar alla metoder som behövs för att
skapa en Todo. Låt sedan TodoCollection implementera interface:et och
ersätt parameter-typen CollectTodos så att den tar in en instans av
interface:et i stället för en TodoCollection.

Du ska alltså analysera koden i CollectTodos och identifiera alla
stället där TodoCollection används. Skapa utifrån det ett interface
som kan utföra samma operationer.

## B
Gör nu samma sak för metoden PrintNonFinishedTodos. Analysera koden i
metoden och skapa ett interface som kan ersätta TodoCollection i den
metoden. Låt sedan TodoCollection implementera interface:et och
ersätt parameter-typen i PrintNonFinishedTodos så att den använder
ditt interface.
