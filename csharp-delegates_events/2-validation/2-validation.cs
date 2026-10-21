using System;

public delegate void CalculateHealth(float amount);

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

    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            damage = 0;
        }

        Console.WriteLine($"{name} takes {damage:G7} damage!");
        ValidateHP(hp - damage);
    }

    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            heal = 0;
        }

        Console.WriteLine($"{name} heals {heal:G7} HP!");
        ValidateHP(hp + heal);
    }

    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            hp = 0;
        }
        else if (newHp > maxHp)
        {
            hp = maxHp;
        }
        else
        {
            hp = newHp;
        }
    }
}
