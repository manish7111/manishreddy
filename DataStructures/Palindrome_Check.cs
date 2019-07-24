// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Palindrome_Check.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
/// <summary>
/// Palendrome_check is a class to check the word is palendrome or not.
/// </summary>
public class Palindrome_Check
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Palindrome_Check"/> class.
    /// </summary>
    public Palindrome_Check()
    {

        ////try and catch are used tohandle the exception.
        try
        {
            Linked_List list = new Linked_List();
            Console.WriteLine("enter a string");
            string word = Console.ReadLine();
            char[] ch = new char[20];
            ////converting the string to charecter.
            ch = word.ToCharArray();
            Console.WriteLine(ch);
            string s1 = "";

            ////storing the charecters array to list by converting them again into string.
            for (int i = ch.Length - 1; i >= 0; i--)
            {
                s1 += list.Enqueue(ch[i].ToString());
            }
            Console.WriteLine(s1);
            string s2 = "";

            ////dequeue of the elements .
            for (int i = 0; i < ch.Length; i++)
            {

                s2 += list.Dequeue(ch[i].ToString());
            }
            Console.WriteLine(s2);
            ////condition to check the elements added and deleted  if same palendrom else not
            if (s1 == s2)
            {
                Console.WriteLine("Palendrome");
            }
            else
            {
                Console.WriteLine("Not a palendrome");
            }
        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    /// <summary>
    /// Node is a class to store the data and next.
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
    /// Linked_List is a class where we perform the operations such as enqueue dequeue and display.
    /// </summary>
    public class Linked_List
    {
        Node head = null;
        /// <summary>
        /// Enqueues the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        public string Enqueue(string data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
                Console.WriteLine("inserted 1" + " " + node.data);
                return node.data;
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
                return node.data;
            }

        }
        /// <summary>
        /// Dequeues the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        public string Dequeue(string data)
        {
            Node temp = head;
            Node prev = head;
            if (temp == null)
            {
                Console.WriteLine(" empty ");
                return null;
            }
            else if (temp.data == data)
            {
                head = temp.next;
                Console.WriteLine("Found" + " " + data);
                return data;
            }
            else
            {
                while (temp != null)
                {

                    if (temp.data == data)
                    {
                        prev.next = temp.next;
                    
                        Console.WriteLine("Found1" + " " + temp.data);
                        return temp.data;
                        
                    }
                    prev = temp;
                    temp = temp.next;
                }
                if (temp == null)
                {
                    Console.WriteLine("no data found");
                }
            }
            return null;
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
}
