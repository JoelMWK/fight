Fighter f1 = new Fighter();
Fighter f2 = new Fighter();

f1.weapon = new Weapon();
f2.weapon = new Weapon();

f1.name = "Shrek";
f2.name = "Farquaad";
f1.weapon.name = "Donkey's head";
f2.weapon.name = "Dragon sword";

int round = 0;

while (f1.hp > 0 && f2.hp > 0)
{
    Console.WriteLine($"Round: {round}");
    Console.WriteLine($"Figher 1: {f1.name}, {f1.hp} hp, weapon: {f1.weapon.name} \nFighter 2: {f2.name}, {f2.hp} hp, weapon: {f2.weapon.name}");

    Console.WriteLine("\nChoose an action:");
    Console.WriteLine("1) Attack \n2) Heal \n3) Dodge");

    string action = Console.ReadLine();
    action = action.ToLower();

    if (action == "1")
    {
        f1.damageTaken(f2);
    }
    else if (action == "2")
    {
        f1.heal(f1);
    }
    else if (action == "3")
    {
        f1.dodge();
    }
    else
    {
        Console.WriteLine("Choose an action!");
    }

    f2.damageTaken(f1);

    f1.checkHp();
    f2.checkHp();

    round++;
    Console.ReadLine();
    Console.Clear();
}

if (f1.hp == 0)
{
    Console.WriteLine($"{f2.name} won with {f2.hp} hp left in round {round}");
    Console.WriteLine(f1.hp);
}
else if (f2.hp == 0)
{
    Console.WriteLine($"{f1.name} won with {f1.hp} hp left in round {round}");
    Console.WriteLine(f2.hp);
}
else
{
    Console.WriteLine("Both sucked so bad that they died together!");
    Console.WriteLine(f1.hp);
    Console.WriteLine(f2.hp);
}
Console.ReadLine();

