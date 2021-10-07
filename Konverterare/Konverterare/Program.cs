using System;

while (true)
{
    Console.WriteLine("Pick something to convert:");
    Console.WriteLine("1. Currency");
    Console.WriteLine("2. Length");
    Console.WriteLine("3. Weight");
    var input = Console.ReadKey(true);

    switch(input.KeyChar)
    {
        case'1':
            string[] Currency = new string[] {"Kronor", "Euro", "Dollar" };
            double[,] ConvertRate = new double[3, 3] { {1.0, 0.0987, 0.1157}, {10.1315, 1.0, 1.1718 }, {8.6462, 0.8534, 1.0 } };
            Console.WriteLine("What currency do you want to covert from?");
            for (var y = 0; y < Currency.Length; y++)
            {
                Console.WriteLine($"{y + 1}. {Currency[y]}");
            }
            var currency1 = Console.ReadKey(true);
            var IntCurrency1 = int.Parse(currency1.KeyChar.ToString());
            Console.WriteLine("What currency do you want to convert to?");
            
            for (var y = 0; y< Currency.Length; y++)
            {
                if (int.Parse(currency1.KeyChar.ToString()) != y +1)
                {
                    Console.WriteLine($"{y + 1}. {Currency[y]}");
                }
            }
            var currency2 = Console.ReadKey(true);
            var IntCurrency2 = int.Parse(currency2.KeyChar.ToString());

            Console.WriteLine("And how much?");
            var CurrencyAmount = double.Parse(Console.ReadLine().ToString());
            var Conversion = CurrencyAmount * ConvertRate[IntCurrency1 - 1, IntCurrency2 - 1];
            Console.WriteLine($"{CurrencyAmount} {Currency[IntCurrency1-1]} is {Conversion} {Currency[IntCurrency2-1]}");

            break;
        case '2':
            string[] Lengths = new string[] { "Meters", "Yards", "Feet" };
            double[,] ConvertLength = new double[3,3] { {1,1.093,3.28 }, {0.9144,1,3 }, {0.3048,0.3333,1 } };
            Console.WriteLine("What Lenght do you want to covert from?");
            for (var y = 0; y < Lengths.Length; y++)
            {
                Console.WriteLine($"{y + 1}. {Lengths[y]}");
            }
            var length1 = Console.ReadKey(true);
            var IntLeng1 = int.Parse(length1.KeyChar.ToString());
            Console.WriteLine("What length do you want to convert to?");

            for (var y = 0; y < Lengths.Length; y++)
            {
                if (int.Parse(length1.KeyChar.ToString()) != y + 1)
                {
                    Console.WriteLine($"{y + 1}. {Lengths[y]}");
                }
            }
            var length2 = Console.ReadKey(true);
            var IntLeng2 = int.Parse(length2.KeyChar.ToString());

            Console.WriteLine("And how much?");
            var LengthAmount = double.Parse(Console.ReadLine().ToString());
            var LengthConversion = LengthAmount * ConvertLength[IntLeng1 - 1, IntLeng2 - 1];
            Console.WriteLine($"{LengthAmount} {Lengths[IntLeng1 - 1]} is {LengthConversion} {Lengths[IntLeng2 - 1]}");
            break;
        case '3':
            string[] Weights = new string[] { "Kilos", "Pounds", "Stones" };
            double[,] ConvertWeight = new double[3, 3] { { 1, 2.2046, 0.1574 }, { 0.4535, 1, 0.0714 }, { 6.3502, 14, 1 } };
            Console.WriteLine("What weight do you want to covert from?");
            for (var y = 0; y < Weights.Length; y++)
            {
                Console.WriteLine($"{y + 1}. {Weights[y]}");
            }
            var weight1 = Console.ReadKey(true);
            var IntWeight1 = int.Parse(weight1.KeyChar.ToString());
            Console.WriteLine("What weight do you want to convert to?");

            for (var y = 0; y < Weights.Length; y++)
            {
                if (int.Parse(weight1.KeyChar.ToString()) != y + 1)
                {
                    Console.WriteLine($"{y + 1}. {Weights[y]}");
                }
            }
            var weight2 = Console.ReadKey(true);
            var IntWeight2 = int.Parse(weight2.KeyChar.ToString());

            Console.WriteLine("And how much?");
            var WeightAmount = double.Parse(Console.ReadLine().ToString());
            var WeightConversion = WeightAmount * ConvertWeight[IntWeight1 - 1, IntWeight2 - 1];
            Console.WriteLine($"{WeightAmount} {Weights[IntWeight1 - 1]} is {WeightConversion} {Weights[IntWeight2 - 1]}");
            break;
    }
}
