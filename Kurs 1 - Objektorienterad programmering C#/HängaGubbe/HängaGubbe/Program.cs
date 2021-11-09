using System;

int AntalLiv = 5;
int AntalKorrekt = 0;
string[] Orden = new string[] {"Hejsan", "Testing", "Godmorgon" };

while (true)
{
    Console.Clear();
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Lägg till ord.");
    Console.WriteLine("2. Lista alla möjliga ord.");
    Console.WriteLine("3. Starta Spel.");
    var UserInput = Console.ReadKey(true);

    switch(UserInput.KeyChar)
    {
        case '1':
            Console.WriteLine("Skriv ett ord: ");
            var input = Console.ReadLine();
            string[] newOrden = new string[Orden.Length + 1];
            for (var x = 0; x < Orden.Length; x++)
            {
                newOrden[x] = Orden[x];
            }
            newOrden[^1] = input;
            Orden = newOrden;
            break;
        case '2':
            Console.Clear();
            Console.WriteLine("Dessa ord finns med i listan:");
            foreach (var x in Orden) {
                Console.WriteLine(x);
            }
            Console.ReadLine();
            break;
        case '3':
            char[] Gissade = new char[] { };
            var RandomWord = new Random().Next(Orden.Length);
            var SelectedWord = Orden[RandomWord];
            var wordinchar = SelectedWord.ToCharArray();
            bool[] CorrectLetter = new bool[SelectedWord.Length];

            while (AntalLiv != 0)
            {
                Console.Clear();
                Console.WriteLine("Antal liv kvar: " + AntalLiv);
                Console.Write("Gissade bokstäver: ");
                foreach (var x in Gissade)
                {
                    Console.Write(x);
                }

                Console.WriteLine("\nSkriv en bokstav: ");
                var bokstav = Console.ReadKey(true);
                Console.WriteLine(bokstav.KeyChar);

                char[] newChar = new char[Gissade.Length + 1];
                for (var y = 0; y < Gissade.Length; y++)
                {
                    newChar[y] = Gissade[y];
                }
                newChar[^1] = bokstav.KeyChar;
                Gissade = newChar;
                int turncorr = 0;
                for (var x = 0; x < SelectedWord.Length; x++)
                {
                    if (bokstav.KeyChar.ToString().ToLower() == wordinchar[x].ToString().ToLower())
                    {
                        CorrectLetter[x] = true;
                        turncorr += 1;
                    }
                }
                if (turncorr == 0)
                {
                    Console.WriteLine("Wrong Letter.");
                    AntalLiv--;
                } else
                {
                    Console.WriteLine("Korrekt");
                }
                
                foreach (var c in CorrectLetter)
                {
                    if(c == true)
                    {
                        AntalKorrekt++;
                    }
                }
                if (AntalLiv <= 0)
                {
                    Console.WriteLine("You lost. You're a loser.");
                    AntalLiv = 5;
                    break;
                } else if (AntalKorrekt == CorrectLetter.Length)
                {
                    Console.Clear();
                    Console.WriteLine("You won!");
                    Console.WriteLine("The word:" + Convert.ToString(SelectedWord));
                    Console.ReadLine();
                    break;
                } else
                {
                    AntalKorrekt = 0;
                    Console.WriteLine("Press for another try.");
                    Console.ReadLine();
                }
            } 
            break;
    }
}