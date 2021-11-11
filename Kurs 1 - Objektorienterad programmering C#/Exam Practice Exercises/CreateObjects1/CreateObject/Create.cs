using System;
using System.Collections.Generic;

namespace Exam
{
    class Create
    {
        public Car CreateOneCar()
        {
            Console.WriteLine("Regnummer?");
            var reg = Console.ReadLine();
            Console.WriteLine("Age?");
            var age = Console.ReadLine();
            if (int.TryParse(age, out int test) && test >= 0 )
            {
                return new Car(reg, test.ToString());
            } else
            {
                Console.WriteLine("Invalid age");
                return null;
            }
             // Ta bort denna rad. Den är här för att programmet inte ska ge kompileringsfel innan du gjort uppgiften.
        }

        public List<Car> CreateThreeCars()
        {
            List<Car> cars = new List<Car>();
            for (int i = 0; i < 3; i++)
            {
                cars.Add(CreateOneCar());
            }
            return cars; // Ta bort denna rad. Den är här för att programmet inte ska ge kompileringsfel innan du gjort uppgiften.
        }
    }
}
