// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Stack.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.IO;
/// <summary>
/// Stack is a class where we perform the operations such as push and pop refering to linked list.
/// </summary>
public class Stack
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Stack"/> class.
    /// </summary>
    public Stack()
    {

        ////try and catch are used to handle the Exception.
        try
        {
            ////calling of an linked List by creating the object in the stack class.
            Linked_List list = new Linked_List();

            ////reading the text from the file.
            string text = File.ReadAllText(@"C:/Users/Admin/Documents/development.txt");
            string[] words = new string[20];
            Console.WriteLine(words.Length);

            ////spliting of data according to the spaces and string in an array.
            words = text.Split(' ');

            ////if found push and if found pop
            for (int j = 0; j < words.Length; j++)
            {
                if (words[j] == "(")
                {
                   list.Push("(");
                }
                else if (words[j] == ")")
                {
                   list.Pop("(");
                }
            }

            ////displaying the data
            list.IsEmpty();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    /// <summary>
    /// Node is an class where we defined data,next. 
    /// </summary>
    public class Node
    {
        public string data;
        public Node next = null;
        public Node(string data)
        {
            this.data = data;
            this.next = null;
        }
    }
    /// <summary>
    /// Linked list is a class where we perform operations on push,pop,isempty.
    /// </summary>
    public class Linked_List
    {
        Node head = null;
        /// <summary>
        /// Pushes the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Push(string data)
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
        /// Pops the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Pop(string data)
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
                Console.WriteLine("Found and deleted"+" "+data);
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
        /// Determines whether this instance is empty.
        /// </summary>
        public void IsEmpty()
        {
            Node temp = head;
            if (head == null)
            {
                Console.WriteLine("Arthematic Expression is balanced");
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                   
                }
                Console.WriteLine("Arthematic Expression is not balanced");
            }
        }

       
    }
}
