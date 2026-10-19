using System;
using System.Xml;
public abstract class Base

{
     public string name { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"{name} is a {GetType().Name}";
    }
}

interface IInteractive
{
    void Interact();
}

interface IBreakable
{
    int durability { get; set; }
    void Break();
}

interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get; set; }
    public bool isCollected { get; set; }

    public TestObject(string name, int durability, bool isCollected)
    {
        this.name = name;
        this.durability = durability;
        this.isCollected = isCollected;
    }

    public void Interact()
    {
        Console.WriteLine($"You interacted with the {name}.");
    }

    public void Break()
    {
        if (durability > 0)
        {
            durability--;
            Console.WriteLine($"You hit the {name}. It now has {durability} durability left.");
        }
        else
        {
            Console.WriteLine($"The {name} is broken.");
        }
    }

    public void Collect()
    {
        if (!isCollected)
        {
            isCollected = true;
            Console.WriteLine($"You collect the {name}.");
        }
        else
        {
            Console.WriteLine($"The {name} has already been collected.");
        }
    }
}