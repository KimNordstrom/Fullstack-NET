using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesSerialize
{
    class Deserializer
    {
        private string _path;
        public Deserializer()
        {
            _path = @"C:\People\";
        }
        public List<Person> ReadFromSingleFile(string file)
        {
            List<Person> people = new List<Person>();

            using (StreamReader sr = new StreamReader(_path + file))
            {
                while (!sr.EndOfStream)
                {
                    var x = sr.ReadLine().Split(",");
                    people.Add(new Person() { Id = Convert.ToInt32(x[0]), Name = x[1], Age = Convert.ToInt32(x[2]) });
                }
            }
            return people;
        }
        public List<Person> ReadFromMultipleFiles()
        {
            List<Person> people = new List<Person>();
            var filePaths = Directory.GetFiles(_path);

            for (int i = 0; i < filePaths.Length; i++)
            {
                using (StreamReader sr = new StreamReader(filePaths[i]))
                {
                    var fileName = Path.GetFileName(filePaths[i]);
                    if (fileName.StartsWith("person_"))
                    {
                        string id = sr.ReadLine();
                        string name = sr.ReadLine();
                        string age = sr.ReadLine();

                        people.Add(new Person() { Name = name, Id = Convert.ToInt32(id), Age = Convert.ToInt32(age) });
                    }
                }
            }
            return people;
        }
    }
}
