using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int userInput = 0;
                Console.WriteLine("Enter a number: ");
                try
                {
                    userInput = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid entry.");
                }

                if (userInput < -200)
                {
                    Console.WriteLine("Too low a number.");
                } else if(userInput > 200)
                {
                    Console.WriteLine("Too high a number.");
                }
                else
                {
                    for (int i = 0; userInput != 100; i++)
                    {
                        if (userInput< 100)
                        {
                            userInput++;
                        } else if(userInput > 100)
                        {
                            userInput--;
                        }
                        Console.WriteLine(userInput);
                    }
                    
                }   
            }
        }
    }
}
