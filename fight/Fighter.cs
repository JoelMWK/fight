using System;
public class Fighter
{
    public string name;
    public int hp = 40;
    public Weapon weapon;
    private Random generator = new Random();

    public void damageTaken(Fighter target)
    {
        int damageGiven = weapon.attack();
        target.hp -= damageGiven;

        Console.WriteLine($"{name} attacked {target.name} and did {damageGiven}");
    }
    public void heal(Fighter target)
    {
        int healGain = generator.Next(5, 10);
        target.hp += healGain;
        if (target.hp > 40)
        {
            target.hp = 40;
        }
        Console.WriteLine($"{name} healed {healGain} hp");
    }
    public void dodge()
    {

    }
    public void checkHp()
    {
        if (hp <= 0)
        {
            hp = 0;
        }
    }
}
