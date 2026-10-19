using System;
using System.Xml;
public abstract class Base

{
    public XmlNode? Name { get; set; } = null;

    public override string ToString()
    {
        return $"{Name} is a {this.GetType().Name}";
    }
}