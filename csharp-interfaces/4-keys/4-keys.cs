using System;

public abstract class Base
{
    public string name { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"{name} is a {GetType().Name}";
    }
}

interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

public class Key : Base, ICollectable
{
    public bool isCollected { get; set; }

    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    public void Collect()
    {
        if (!isCollected)
        {
            isCollected = true;
            Console.WriteLine($"You pick up the {name}.");
        }
        else
        {
            Console.WriteLine($"You have already picked up the {name}.");
        }
    }
}