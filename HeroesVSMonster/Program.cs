using HeroesVSMonster.Models;

// Test du dés
Console.WriteLine("Lancer de D6");
Dés Dé6 = new Dés(1, 6);
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(Dé6.LanceDes());
}

Console.WriteLine();

Console.WriteLine("Lancer de D20");
Dés Dé20 = new Dés(1, 20);
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(Dé20.LanceDes());
}
