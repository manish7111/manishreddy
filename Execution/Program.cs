// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using DataStructures;

namespace Execution
{
    class Program
    {
        static void Main(string[] args)
        {
            ////displaying all the programes to chexk and execute.
            Console.WriteLine("\n 1.Unorderd_list. \n 2.Ordered_list. \n 3.Simple Balanced Parentheses. \n 4.Simulate Banking Cash Counter. \n 5.Palindrome-Checker.");
            Console.WriteLine("\n 6.Hashing Function to search a Number in a slot. \n 7.Number of Binary Search Tree. \n 8.Calendar. \n 9.Calendar1. \n 10.Prime numbers.");
            Console.WriteLine("\n 11.Anagram. \n 12.Anagram_Queue. \n 13.Anagram.Stack.");
            Console.WriteLine("enter the number to execute");

            ////reading the number from the system and pasing to switch to execute.
            int num = Convert.ToInt32(Console.ReadLine());
            switch(num)
            {
                case 1:
                    Unorder_List list = new Unorder_List();
                    break;
                case 2:
                    Ordered_List list1 = new Ordered_List();
                    break;
                case 3:
                    Stack stack = new Stack();
                    break;
                case 4:
                    Queue queue = new Queue();
                    break;
                case 5:
                    Palindrome_Check check = new Palindrome_Check();
                    break;
                case 6:
                    Hashing hash = new Hashing();
                    break;
                case 7:
                    BST_Count bst = new BST_Count();
                    break;
                case 8:
                    Calender calender = new Calender();
                    break;
                case 9:
                    Calender1 calender1 = new Calender1();
                    break;
                case 10:
                    Prime_check prime = new Prime_check();
                    break;
                case 11:
                    Anagram anagram = new Anagram();
                    break;
                case 12:
                    Anagram_Queue a_queue = new Anagram_Queue();
                    break;
                case 13:
                    Anagram_Stack a_stack = new Anagram_Stack();
                    break;
                default:
                    Console.WriteLine("enter the correct number to execute");
                    break;

            }
        }
    }
}
