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