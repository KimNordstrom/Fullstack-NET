using System;

int PlayerHP = 20;
int ComputerHP = 20;
int AttackDamage = 5;
int[] Blocked = new int[2] { 0, 0 };
int[] BlockedC =  new int[2] { 0, 0 };
string[] Actions = new string[] { "Attack", "Big Attack", "Block", "Heal" };
string[] Players = new string[] { "Player", "Computer" };

Console.WriteLine("What's your username?");
var username = Console.ReadLine();


while (PlayerHP > 0 && ComputerHP > 0)
{
    var HealthBar = string.Format("{0,-20} {1,20}", $"{username} (HP: {PlayerHP})", $"Computer (HP: {ComputerHP})");
    //Console.Clear();

    foreach (var x in Players)
    {
        System.Threading.Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine(HealthBar);
        for (var y = 0; y < Actions.Length; y++)
        {
            Console.WriteLine($"{y + 1}. {Actions[y]}");
        }
        switch (x)
        {
            case "Player":
                Console.WriteLine($"Turn: {username}");
                Console.WriteLine("Select an action:");
                var input = Console.ReadKey(true);

                if (input.KeyChar == '1')
                {
                    Console.Write($"{username} Attacks computer for {AttackDamage} damage");
                    if (BlockedC[0] > 0) { Console.Write($", but {BlockedC[0]} is blocked"); }
                    ComputerHP -= AttackDamage + BlockedC[0];
                }
                else if (input.KeyChar == '2')
                {
                    int Multiplier = new Random().Next(0, 3);
                    var newAttack = (AttackDamage * Multiplier) + BlockedC[0];
                    Console.Write($"{username} Attacks computer for {newAttack} damage");
                    if (BlockedC[0] > 0) 
                    { 
                        Console.Write($", but {BlockedC[0]} is blocked");
                        BlockedC[1] = 1;
                    }
                    ComputerHP -= newAttack;
                } else if (input.KeyChar == '3')
                {
                    Blocked[0] = new Random().Next(1, 5);
                    Console.WriteLine($"Blocking {Blocked[0]} damage next attack");
                }
                else if (input.KeyChar == '4')
                {
                    var Heal = new Random().Next(1, 5);
                    PlayerHP += Heal;
                    Console.WriteLine($"Healing for {Heal}");
                }
                if (BlockedC[1] > 0)
                {
                    Console.WriteLine("\nComputers block has been used.");
                    BlockedC[0] = 0;
                    BlockedC[1] = 0;
                }
                System.Threading.Thread.Sleep(1000);
                break;
            case "Computer":
                Console.WriteLine($"Turn: {x}");
                var ComputerAction = new Random().Next(1, 5);
                Console.WriteLine($"Computer selected action: {Actions[ComputerAction - 1]}");
                if (ComputerHP <= 0)
                {
                    break;
                }
                else if (ComputerAction == 1)
                {
                    Console.Write($"Computer Attacks {username} for {AttackDamage} damage");
                    if (Blocked[0] > 0) { Console.Write($", but {Blocked[0]} is blocked"); }
                    PlayerHP -= AttackDamage + Blocked[0];
                }
                else if (ComputerAction == 2)
                {
                    int Multiplier = new Random().Next(0, 3);
                    var newAttack = (AttackDamage * Multiplier) + Blocked[0];
                    Console.Write($"Computer Attacks {username} for {newAttack} damage");
                    if (Blocked[0] > 0) 
                    { 
                        Console.Write($", but {Blocked[0]} is blocked");
                        Blocked[1] = 1;
                    }
                    PlayerHP -= newAttack;
                } else if (ComputerAction == 3)
                {
                    BlockedC[0] = new Random().Next(1, 5);
                    Console.WriteLine($"Blocking {BlockedC[0]} damage next attack");
                } else if (ComputerAction == 4)
                {
                    var Heal = new Random().Next(1, 5);
                    ComputerHP += Heal;
                    Console.WriteLine($"Healing for {Heal}");
                }
                if (Blocked[1] > 0)
                {
                    Console.WriteLine("\nPlayers block has been used.");
                    Blocked[0] = 0;
                    Blocked[1] = 0;
                }
                Console.WriteLine("\nPress to continue");
                Console.ReadLine();
                System.Threading.Thread.Sleep(1000);
                break;
        }
    }
}
Console.Clear();
Console.WriteLine("{0,-20} {1,20}", $"{username} (HP: {PlayerHP})", $"Computer (HP: {ComputerHP})");
if (PlayerHP <= 0)
{
    Console.WriteLine("Game over. You died.");
} else if (ComputerHP <= 0)
{
    Console.WriteLine("You won. The computer died.");
}

