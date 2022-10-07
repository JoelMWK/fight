using System;
public class Weapon
{
    public int maxAttack = 8;
    public int minAttack = 1;
    public int stamina = 50;
    public string name;
    private Random generator = new Random();

    public int attack(){
        return generator.Next(minAttack, maxAttack);
    }
}
