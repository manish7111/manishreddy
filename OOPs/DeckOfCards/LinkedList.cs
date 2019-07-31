// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkedList.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;

/// <summary>
/// Noede is a class
/// </summary>
public class Node
{
    public string data;
    public Node next = null;
    /// <summary>
    /// Initializes a new instance of the <see cref="Node"/> class.
    /// </summary>
    /// <param name="data">The data.</param>
    public Node(string data)
    {
        this.data = data;
        this.next = null;
    }
}
/// <summary>
/// Linked_list is a class to perfrom the operations such as enqueue and dequeue.
/// </summary>
public class LinkedList
{
    Node head = null;
    /// <summary>
    /// Enqueues the specified data.
    /// </summary>
    /// <param name="data">The data.</param>
    public void Enqueue(string data)
    {
        Node node = new Node(data);
        if (head == null)
        {
            head = node;
            Console.WriteLine("inserted 1" + " " + node.data);
        }
        else
        {
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = node;

            Console.WriteLine("inserted 2" + " " + node.data);
        }

    }
    /// <summary>
    /// Dequeues the specified data.
    /// </summary>
    /// <param name="data">The data.</param>
    public void Dequeue(string data)
    {
        Node temp = head;
        Node prev = head;
        if (temp == null)
        {
            Console.WriteLine(" empty ");
            return;
        }
        else if (temp.data == data)
        {
            head = temp.next;
            Console.WriteLine("your transcation is done and you can leave" + " " + data);
            return;
        }
        else
        {
            while (temp != null)
            {

                if (temp.data == data)
                {
                    prev.next = temp.next;
                    Console.WriteLine("found");
                    Console.WriteLine("your transcation is done ......thankyou" + " " + temp.data);
                    return;
                }
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
            {
                Console.WriteLine("no data found");
            }
        }
    }
    /// <summary>
    /// Determines whether this instance is empty.
    /// </summary>
    public void IsEmpty()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.Write(temp.data + " ");
            temp = temp.next;
        }
        if (temp == null)
        {
            Console.WriteLine("\n queue is empty");
        }
    }
}