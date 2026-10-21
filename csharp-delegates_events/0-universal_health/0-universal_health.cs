using System;

public class Player
{
    private string name { get; set; }
    private float maxHp { get; set; }
    private float hp { get; set; }

    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp <= 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        else
        {
            this.maxHp = maxHp;
        }

        hp = this.maxHp;
    }

    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp:G7} / {maxHp:G7} health");
    }
}
