using System;
using OOUppgift;

Person person1 = new("Kim");
person1.Run();

person1.Speed = 10;
person1.Run();

Backpack bag1 = new();
Console.WriteLine(bag1.Brand);
Backpack bag2 = new("Test");
Console.WriteLine(bag2.Brand);

person1.LookInBag();

person1.Eat();

