using System;

public enum Rating
{
    Good,      // 0
    Great,     // 1
    Excellent  // 2
}

public struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;

    // Constructor to initialize the struct with values
    public Dog(string name, float age, string owner, Rating rating)
    {
        this.name = name;
        this.age = age;
        this.owner = owner;
        this.rating = rating;
    }

    // Override the ToString method to format the dog details
    public override string ToString()
    {
        return $"Dog Name: {name}\nAge: {age}\nOwner: {owner}\nRating: {rating}";
    }
}
