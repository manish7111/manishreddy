// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Unorder_List.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.IO;
/// <summary>
/// DataStructures is the nameSpace which consists of multiple classes in it.
/// </summary>
namespace DataStructures
{
    /// <summary>
    /// Node is a class where we define data and next.
    /// </summary>
    public class Node
    {
       public string data;
        public Node next=null;
        public Node(string data)
        {
            this.data = data;
            this.next = null;
        }
    }
    /// <summary>
    /// Linked list is a class to perform the operations such as add,delete,display.
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
            if(head==null)
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
            
                Console.WriteLine("inserted 2"+" " + node.data);
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
                Console.Write(temp.data+" ");
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
            if (temp==null)
            {
                Console.WriteLine(" empty ");
                return;
            }
            else if(temp.data==data)
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
                if(temp==null)
                {
                    Console.WriteLine("no data found");
                }
            }
        }
    }
    /// <summary>
    /// UnOrdere_List is a class where we search the data and do the operations based on linked list.
    /// </summary>
    public class Unorder_List
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Unorder_List"/> class.
        /// </summary>
        public Unorder_List()
        {

            ////try and catch are used for handle the exception if occured.
            try
            {
                Linked_List list = new Linked_List();

                ////It is used to read the text from the file.
                string text = File.ReadAllText(@"C:/Users/Admin/Documents/development.txt");
                string[] words = new string[20];
                Console.WriteLine(words.Length);

                ////text.split is used to split the data according to the spaces.
                words = text.Split(' ');

                ////this forloop is used to add the data to the linked list.
                for (int i = 0; i < words.Length; i++)
                {
                    Console.WriteLine(words[i]);
                    list.Add(words[i]);
                }
                Console.WriteLine(words.Length);
                Console.WriteLine("enter a word to search");
                string search = Console.ReadLine();
                int k = 0;

                ////while loop is used to search the data if found delete else add to the linked list. 
                while(k<words.Length)
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
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }


}
