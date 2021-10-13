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
    Console.Write("\nAdd item to truck: ");
    int input = Convert.ToInt32(Console.ReadLine());
    selectedMaterials.Add((Material)theStorage.inventory[input - 1]);
    theStorage.inventory.RemoveAt(input - 1);

    Console.WriteLine("Send? (y/n)");
    var send = Console.ReadKey(true);
    if(send.KeyChar == 'y')
    {
        ShowTruck();
        Console.WriteLine("Sending truck...");
        var newProduct = theFactory.CreateProductFrom(selectedMaterials);
        theStorage.AddToStorage(newProduct.leftovers);
        theStorage.inventory.Add(newProduct);
        ShowInventory();
    } else
    {
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