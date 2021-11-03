using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesSerialize
{
    class PersonSerializer
    {
        private string _path;
        public PersonSerializer()
        {
            _path = @"C:\People\";
        }
        public void SerializeInOneFile(List<Person> people)
        {
            List<string> peoplelist = new List<string>();

            foreach (var item in people)
            {
                string total = item.Id +","+ item.Name + "," + item.Age;
                peoplelist.Add(total);
            }

            using (var sw = new StreamWriter(_path + "persons.txt"))
            {
                foreach (var item in peoplelist)
                {
                    sw.WriteLine(item);
                }
            };
        }
        public void SerializeInManyFiles(List<Person> people)
        {
            foreach (Person person in people)
            {
                List<string> total = new List<string>();

                total.Add($"{person.Id}");
                total.Add(person.Name);
                total.Add($"{person.Age}");

                using (var sw = new StreamWriter(_path + $"person_{person.Id}.txt"))
                {
                    foreach (var item in total)
                    {
                        sw.WriteLine(item);
                    }
                };
            }
        }
    }
}
