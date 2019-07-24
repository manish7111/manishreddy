// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Queue.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.IO;
/// <summary>
/// Queue is a class where we store the data in the form of FIFO.
/// </summary>
public class Queue
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Queue"/> class.
    /// </summary>
    public Queue()
	{
        ////try and catch are used to handle the exception.
        try
        {

            ////calling of linkedlist by creating the object of that class and to perform operations such as Enqueue,Dequeue,display.
            Linked_List list = new Linked_List();
            Console.WriteLine("enter the size of an array");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] names = new string[n];
            Console.WriteLine("Enter amount");

            ////reading the amount from the input.
            double amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter names");

            ////names entered has to stored in the list
            for(int i=0;i<n;i++)
            {
                names[i] = Console.ReadLine();
                list.Enqueue(names[i]);
            }
            ////if money is withdrawn or deposit we have to dequeue the person from the list.
            for (int j = 0; j < names.Length; j++)
            {
                Console.WriteLine("withdraw/deposit??");
                string reason = Console.ReadLine();

                ////reading the reason whether person wants to deposit or withdraw.
                if (reason == "withdraw")
                {
                    Console.WriteLine("enter the amouth u want to withdraw");
                    int withdraw_amount = Convert.ToInt32(Console.ReadLine());
                    if (withdraw_amount <= 20000 && withdraw_amount > 0)
                    {
                        ////amaount of withdraw should be lesser than or equal to amaount present in the atm.
                        if (withdraw_amount<=amount)
                        {
                            ////remove the withdraw amount from the total amount and print the status and dequeue the person from the queue.
                            amount -= withdraw_amount;
                            Console.WriteLine("remaining amount----->" + " " + amount);
                            list.Dequeue(names[j]);
                        }
                        else
                        {
                            Console.WriteLine("Insufficient fund......Please try again...thankyou");
                        }
                       
                    }
                    else
                    {
                        Console.WriteLine("you cannot cross above 20000 per transaction");
                    }
                }
                else if (reason == "deposit")
                {
                    Console.WriteLine("enter the amount u want are depositing");
                    double deposit_amount = Convert.ToInt32(Console.ReadLine());

                    ////if reason is deposit then add the amount to the net amount and display the amount and dequeue the person from the list.
                    amount += deposit_amount;
                    Console.WriteLine("remaining amount----->" + " " + amount);
                    list.Dequeue(names[j]);
                }
                else
                {
                    Console.WriteLine("you can leave");
                }
                
            }
            ////display the persons in a queue.
            list.IsEmpty();
        }
        catch (Exception e)
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
    /// Linked_list is a class to perfrom the operations such as enqueue and dequeue.
    /// </summary>
    public class Linked_List
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
            if(temp==null)
            {
                Console.WriteLine("\n queue is empty");
            }
        }


    }
}
