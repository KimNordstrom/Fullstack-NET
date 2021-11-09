using System;
using System.Collections.Generic;

namespace FilesSerialize
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonSerializer personSerializer = new PersonSerializer();
            Deserializer deserializer = new Deserializer();

            personSerializer.SerializeInOneFile(Data.People);

            personSerializer.SerializeInManyFiles(Data.People);

            Console.WriteLine("Read from one files: ");
            PrintFromPersonList(deserializer.ReadFromSingleFile("persons.txt"));

            Console.WriteLine("Read from many files: ");
            PrintFromPersonList(deserializer.ReadFromMultipleFiles());
            
            void PrintFromPersonList(List<Person> list)
            {
                foreach (var item in list)
                {
                    Console.WriteLine(item.Id + " " + item.Name + " " + item.Age);
                }
            }
        }
    }
}
