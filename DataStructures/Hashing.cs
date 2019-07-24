// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Hashing.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;

public class Hashing
{
    /// <summary>
    /// Created a Node class to access the data in the linked list
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
    /// Linked list is a class where all the functionalities are defined such as Add,Delete,Display
    /// </summary>
    public class Linked_List
    {
        Node head = null;
        /// <summary>
        /// Add's the data which is not found .
        /// </summary>
        /// <param name="data">The data.</param>
        public void Add(string data)
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
    }
    /// <summary>
    /// Initializes a new instance of the <see cref=".Hashing"/> class.
    /// </summary>
    public Hashing()
	{
        ////Calling of LinkedList class by creating the object.
        Linked_List list = new Linked_List();
        Console.WriteLine("enetr the size of an array");
        int num = Int32.Parse(Console.ReadLine());
        Console.WriteLine("enter the elements in the array");

        ////For storing the number of items in the array.
        int[] array = new int[num];
        int[] hash = new int[num];

        ///reading the elements from the user.
        for(int i=0;i<num;i++)
        {
            array[i] = Int32.Parse(Console.ReadLine());
        }

        ////storing of the number%11 value in the appropriate position in hash array.
        for (int i = 0; i < num; i++)
        {
            for(int j=0;j<num;j++)
            {
                if(array[i]%11==j)
                {
                    hash[i] = array[i];

                    //adding of all the numbers which are found in to linked list.
                    list.Add(hash[j].ToString());
                }      
            }
        }
        ////display of elements linked list.
        list.Display();
        Console.WriteLine("enter a word to search");
        int search = Convert.ToInt32(Console.ReadLine());
        int k = 0;

        ////while loop is for searching the element if found then delete and display;
        while (k < hash.Length)
        {
            if (search == hash[k])
            {
                list.Delete(hash[k].ToString());
                list.Display();
                return;
            }
            k++;
        }

        ////if element is not found then Add the element in the linked list.
        list.Add(search.ToString());
        list.Display();
    }
}
