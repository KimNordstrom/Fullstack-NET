# Uppgift

Deklarera en klass enligt följande beskrivning:

* Klassen ska heta Programmer
* Klassen ska innehålla två properties
  1. En property som heter Name av typen string som är läsbar publikt
     och går bara att sätta när objeket skapas
  2. En property som heter Age av typen int som är läsbar publikt men
     kan bara sättas intern i klassen. Det ska alltså gå att ändra
     värdet men bara inne i klassen
* Klassen ska innehålla ett fält
  1. Ett fält som heter _isHappy av typen bool. Fältet ska bara vara
     nåbart inne i klassen
* Klassen ska ha en konstruktor som är publikt tillgänglig och inte
  tar några parametrar. Implementera konstruktorn så att den sätter
  _isHappy till false
* Klassen ska innehålla tre metoder
  1. En publikt tillgänglig metod som returnerar en int och heter
     ProduceCode. Metoden tar inga parametrar. Implementera metoden
     så att den returnerar 100 om _isHappy är true och 50 om _isHappy
     är false
  2. En publikt tillgänglig metod som inte returnerar någonting och
     heter DrinkCoffee. Metoden tar inga parametrar. Implementera
     metoden så att den sätter _isHappy till true
  3. En publikt tillgänglig metod som inte returnerar någonting och
     heter CelebrateBirthday. Metoden tar inga parametrar.
     Implementera metoden så att den ökar Age med 1 och sätter
     _isHappy till true
