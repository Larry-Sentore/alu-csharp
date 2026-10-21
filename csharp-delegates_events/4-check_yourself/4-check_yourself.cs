using System;

public enum Modifier
{
    Weak,
    Base,
    Strong
}

public delegate void CalculateHealth(float amount);
public delegate float CalculateModifier(float baseValue, Modifier modifier);

public class CurrentHPArgs : EventArgs
{
    public float currentHp { get; }

    public CurrentHPArgs(float newHp)
    {
        currentHp = newHp;
    }
}

public class Player
{
    private string name { get; set; }
    private float maxHp { get; set; }
    private float hp { get; set; }
    private string status { get; set; }

    public event EventHandler<CurrentHPArgs>? HPCheck;

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
        status = $"{name} is ready to go!";
        HPCheck += CheckStatus;
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

        HPCheck?.Invoke(this, new CurrentHPArgs(hp));
    }

    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        return modifier switch
        {
            Modifier.Weak => baseValue / 2,
            Modifier.Base => baseValue,
            Modifier.Strong => baseValue * 1.5f,
            _ => baseValue
        };
    }

    private void CheckStatus(object? sender, CurrentHPArgs e)
    {
        if (e.currentHp == maxHp)
        {
            status = $"{name} is in perfect health!";
        }
        else if (e.currentHp >= maxHp / 2)
        {
            status = $"{name} is doing well!";
        }
        else if (e.currentHp >= maxHp / 4)
        {
            status = $"{name} isn't doing too great...";
        }
        else if (e.currentHp > 0)
        {
            status = $"{name} needs help!";
        }
        else
        {
            status = $"{name} is knocked out!";
        }

        Console.WriteLine(status);
    }
}
