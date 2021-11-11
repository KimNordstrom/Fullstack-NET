using System;
using System.Collections.Generic;
using System.IO;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            FileStream fs = File.OpenRead("books.txt");
            using(StreamReader sr = new StreamReader(fs))
            {
                while (!sr.EndOfStream)
                {
                    var x = sr.ReadLine().Split("§");
                    Book book = new Book()
                    {
                        Title = x[0],
                        Author = x[1],
                        Genre = x[2]
                    };
                    books.Add(book);
                }
            }
            Print();
            void Print()
            {
                foreach (var item in books)
                {
                    if(item.Genre == "Programming")
                    {
                        string title = item.Title;
                        if (item.Title.Length > 30)
                        {
                            title = item.Title.Substring(0, 29);
                        }
                        Console.WriteLine(string.Format("{0,-30}{1,-20}{2,0}", title, item.Author, item.Genre));
                    }
                    
                }
            }
        }
    }
}
