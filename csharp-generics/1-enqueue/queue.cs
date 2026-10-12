using System;

/// <summary>
/// Represents a generic queue.
/// </summary>
public class Queue<T>
{
    /// <summary>
    /// Represents a value and its link to the next queue node.
    /// </summary>
    public class Node
    {
        /// <summary>
        /// Gets or sets the value stored in this node.
        /// </summary>
        public object? value { get; set; } = null;

        /// <summary>
        /// Gets or sets the next node in the queue.
        /// </summary>
        public Node? next { get; set; } = null;

        /// <summary>
        /// Initializes a new node with the specified value.
        /// </summary>
        public Node(object? value)
        {
            this.value = value;
        }
    }

    /// <summary>
    /// Gets or sets the first node in the queue.
    /// </summary>
    public Node? head { get; set; } = null;

    /// <summary>
    /// Gets or sets the last node in the queue.
    /// </summary>
    public Node? tail { get; set; } = null;

    /// <summary>
    /// Gets or sets the number of nodes in the queue.
    /// </summary>
    public int count { get; set; } = 0;

    /// <summary>
    /// Gets the type used by this queue.
    /// </summary>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>
    /// Adds a value to the end of the queue.
    /// </summary>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);

        if (head == null)
        {
            head = newNode;
        }
        else
        {
            tail!.next = newNode;
        }

        tail = newNode;
        count++;
    }

    /// <summary>
    /// Gets the number of nodes in the queue.
    /// </summary>

    public int Count()
    {
        return count;
    }
}
