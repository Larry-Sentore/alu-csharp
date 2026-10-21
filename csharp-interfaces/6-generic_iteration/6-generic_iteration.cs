using System;
using System.Collections.Generic;

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

public class Door : Base, IInteractive
{
    public Door(string name = "Door")
    {
        this.name = name;
    }

    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}

public class Decoration : Base, IInteractive, IBreakable
{
    public int durability { get; set; }
    public bool isQuestItem { get; set; }

    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new ArgumentException("Durability must be greater than 0", nameof(durability));
        }

        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine($"The {name} has been broken.");
        }
        else if (isQuestItem)
        {
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        }
        else
        {
            Console.WriteLine($"You look at the {name}. Not much to see here.");
        }
    }

    public void Break()
    {
        durability--;

        if (durability > 0)
        {
            Console.WriteLine($"You hit the {name}. It cracks.");
        }
        else if (durability == 0)
        {
            Console.WriteLine($"You smash the {name}. What a mess.");
        }
        else
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }
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

public class Objs<T> : IEnumerable<T>
{
    private readonly List<T> objects = new List<T>();

    public void Add(T item)
    {
        objects.Add(item);
    }

    public IEnumerator<T> GetEnumerator()
    {
        return objects.GetEnumerator();
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

class Program
{
    static void Main()
    {
        Door sideDoor = new Door("Side Door");
        Decoration photo = new Decoration("Awkward Family Portrait");
        Decoration antiqueVase = new Decoration("Antique Vase", 5, true);

        Objs<Decoration> decorations = new Objs<Decoration>();

        decorations.Add(photo);
        decorations.Add(antiqueVase);

        foreach (Decoration deco in decorations)
        {
            Console.WriteLine(deco);
            while (deco.durability > 0)
            {
                deco.Break();
            }
        }

        Console.WriteLine("------------");

        Objs<IInteractive> interactables = new Objs<IInteractive>();

        interactables.Add(sideDoor);
        interactables.Add(photo);
        interactables.Add(antiqueVase);

        foreach (IInteractive obj in interactables)
        {
            Console.WriteLine(obj);
            obj.Interact();
        }
    }
}