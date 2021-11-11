# Uppgift
I detta projekt finns det en minimal version av ett klädorder system.
Applikationen kan lista tröjor av en viss storlek och lägga till nya
tröjor. Program.cs innehåller exempelanvändning av systemet.

En tröja har en storlek (small, medium eller large). Storleken anges
i dag som en string. Det vore bättre om det var en enum. Ändra koden
i alla klasser så att storleken använder enumen ClothesSize i stället
för en string. Det är alltså propertyn Size i klassen Sweater som ska
ändras först. Sen ska alla ställen där Size används ändras.
