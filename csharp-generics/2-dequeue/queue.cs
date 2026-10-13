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
        public T? value { get; set; }

        /// <summary>
        /// Gets or sets the next node in the queue.
        /// </summary>
        public Node? next { get; set; } = null;

        /// <summary>
        /// Initializes a new node with the specified value.
        /// </summary>
        public Node(T? value)
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
    public void Enqueue(T? value)
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
    /// Removes the first value in the queue and returns it.
    /// </summary>
    public T? Dequeue()
    {
        if (head == null)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        T? value = head.value;
        head = head.next;
        count--;

        if (head == null)
        {
            tail = null;
        }

        return value;
    }

    /// <summary>
    /// Gets the number of nodes in the queue.
    /// </summary>
    public int Count()
    {
        return count;
    }
}
