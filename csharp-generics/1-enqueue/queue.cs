using System;

/// <summary>
/// generic queue.
/// </summary>
public class Queue<T>
{
    /// <summary>
    /// Gets the type used by this queue and returns the type.
    /// </summary>
     
    public Node Head { get; set; }
    public Node Tail { get; set; }
    public int Count { get; set; }

    public Type CheckType()
    {
        return typeof(T);
    }

    public class Node
    {
        public T Value { get; set; }
        public Node Next { get; set; }

        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }
    
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);
        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            Tail.Next = newNode;
            Tail = newNode;
        }
        Count++;
    }
    
}
