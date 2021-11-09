using System;
using System.Collections.Generic;
using MagicalFactory;

var theStorage = new Warehouse();
var theFactory = new Factory();
List<Material> selectedMaterials = new List<Material>();
bool Done = false;

while(Done != true)
{
    ShowInventory();
    Console.Write("\nWhen truck is ready, write (send) ");
    Console.Write("\nAdd item to truck: ");
    var input = Console.ReadLine();
    if (input == "send")
    {
        ShowTruck();
        Console.WriteLine("Sending truck...");
        var newProduct = theFactory.CreateProductFrom(selectedMaterials);
        theStorage.AddToStorage(newProduct.leftovers);
        theStorage.inventory.Add(newProduct);
        selectedMaterials.Clear();
    }
    else
    {
        var inputAsInt = Convert.ToInt32(input);
        selectedMaterials.Add((Material)theStorage.inventory[inputAsInt - 1]);
        theStorage.inventory.RemoveAt(inputAsInt - 1);
        ShowTruck();
    }
}

void ListToSend()
{
    foreach (Material x in selectedMaterials)
    {
        Console.WriteLine(x.GetType().Name);
    }
}

void ShowTruck()
{
    Console.Clear();
    if (selectedMaterials.Count > 0)
    {
        Console.WriteLine("Truck");
        Console.WriteLine("------------------------------");
        ListToSend();
        Console.WriteLine("------------------------------\n");
    }
}

void ShowInventory()
{
    Console.WriteLine("Inventory");
    Console.WriteLine("------------------------------");
    theStorage.ListStorage();
    Console.WriteLine("------------------------------\n");
}