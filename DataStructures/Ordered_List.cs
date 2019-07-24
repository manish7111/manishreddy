// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Ordered_List.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.IO;
/// <summary>
/// Ordered_List is a class to perform the operations on linked list.
/// </summary>
public class Ordered_List
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Ordered_List"/> class.
    /// </summary>
    public Ordered_List()
	{
        ////try and catch are used to handle the Exception if occured.
        try
        {
            ////calling of linked list class by creating the object.
            Linked_List list = new Linked_List();

            ////reading of contents from the file.
            string text = File.ReadAllText(@"C:/Users/Admin/Documents/development.txt");
            string[] words = new string[20];
            Console.WriteLine(words.Length);

            ////splits the contents acoording to the spaces.
            words = text.Split(' ');

            ////sorting of array.
            Array.Sort(words);

            ////storing of data in the linked list add method.
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i]);
                Console.WriteLine();
                list.Add(words[i]);
            }
            Console.WriteLine(words.Length);
            Console.WriteLine("enter a word to search");
            string search = Console.ReadLine();
            int k = 0;

            ////while loop is uded to search the content if found delete else add.
            while (k < words.Length)
            {
                if (search == words[k])
                {
                    list.Delete(words[k]);
                    list.Display();
                    return;
                }
                k++;
            }
            list.Add(search);
            list.Display();
            ////for continue the process if Y continue else end.
            Console.WriteLine("are u still want to run(y/n)?");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch=='y'||ch=='Y')
            {
                Ordered_List list1 = new Ordered_List();
            }
            else
            {
                Console.WriteLine("end");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
/// <summary>
/// Created the node class to store data and next.
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
/// Created the class linked list to perform specified operations.
/// </summary>
public class Linked_List
{
    Node head = null;
    /// <summary>
    /// Adds the specified data.
    /// </summary>
    /// <param name="data">The data.</param>
    public void Add(string data)
    {
        Node node = new Node(data);
        if (head == null)
        {
            head = node;
            Console.WriteLine("\n inserted 1" + " " + node.data);
        }
        else
        {
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = node;

            Console.WriteLine("\n inserted 2" + " " + node.data);
        }

    }
    /// <summary>
    /// Deletes the specified data.
    /// </summary>
    /// <param name="data">The data.</param>
    public void Delete(string data)
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
            Console.WriteLine("Found");
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
                    Console.WriteLine("Deleting...." + " " + temp.data);
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
    /// Displays this instance.
    /// </summary>
    public void Display()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.Write(temp.data + " ");
            temp = temp.next;
        }
    }
}
