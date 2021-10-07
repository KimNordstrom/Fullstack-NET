using System;
using System.Collections.Generic;
using Djurpark;

var ani1 = new Lion("Ben");
ani1.Feed(Food.Meat);

var ani2 = new Zebra("Karl");
ani2.Feed(Food.Hamburger);

var zoo1 = new Zoo(new List<Animal> { new Zebra("Sarah"), new Zebra("Rose"), new Lion("Bob") });
zoo1.FeedAllAnimals(Food.Veggies);
zoo1.PetAnimal("Rose");
zoo1.PetAnimal("Bob");
zoo1.PetAnimal("Zack");
zoo1.PetAnimal("Sarah");


Console.WriteLine("\n");
zoo1.ListAnimals();
Console.WriteLine("\n");
zoo1.ListHerbivores();
Console.WriteLine("\n");
zoo1.ListCarnivores();