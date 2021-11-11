using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[100];
            for (int i = 0; i < intArray.Length; i++)
            {
                var x = i + 1;
                if (x % 3 == 0)
                {
                    intArray[i] = x * (intArray[i - 1]);
                } else if (x % 5 == 0)
                {
                    intArray[i] = x + 15;
                }
                else
                {
                    intArray[i] = x;
                }
            Console.WriteLine($"IntArray[{i}]: " + intArray[i]);
            }
        }
    }
}
