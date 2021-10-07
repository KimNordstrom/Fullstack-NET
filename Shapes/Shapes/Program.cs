using System;
using Shapes;
using System.Collections.Generic;

List<IShape> shapes = new List<IShape>() { new Square(5), new Triangle(10,3), new Circle(14) };
foreach (IShape x in shapes)
{
    Console.WriteLine($"The {x.GetType().Name} area is {x.GetArea()}");
}
