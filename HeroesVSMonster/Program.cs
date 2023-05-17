using HeroesVSMonster.Models;

// Test du dés
Console.WriteLine("Lancer de D6");
Dés Dé6 = new Dés(6);
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(Dé6.LanceDes());
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Lancer de D20");
Dés Dé20 = new Dés(20);
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(Dé20.LanceDes());
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Test Lancer Multiple");

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Test de 10 D6");
Console.WriteLine();
Console.WriteLine();
Dé6.LancerMultiple(10);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Test de 10 D20");
Console.WriteLine();
Console.WriteLine();
Dé20.LancerMultiple(10);
