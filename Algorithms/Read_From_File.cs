// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Read_From_File.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.IO;
/// <summary>
/// Read_From_File is a class where we read the string from the file .
/// After reading the string from file it splits the words from the string.
/// </summary>
public class Read_From_File
{
    /// <summary>
    /// Initializes a new instance of the <see cref=".Read_From_File"/> class.
    /// </summary>
    public Read_From_File()
	{
        try
        {
            string text = File.ReadAllText(@"C:\Users\Admin\Documents\development.txt");
            string[] words = text.Split(',');
            Console.WriteLine("Stringd read from file are:");
            foreach(String str in words)
            {
                Console.WriteLine(str + " ");
            }
            Console.WriteLine("enter search key from above array");
            String key = Console.ReadLine();
            int first = 0, last = words.Length - 1;
            
            while(first<=last)
            {
                int mid = (first + last) / 2;
                int result = key.CompareTo(words[mid]);
                if(result==0)
                {
                    Console.WriteLine("element found at mid");
                    break;
                }
                else if(result<0)
                {
                    last = mid - 1;
                }
                else
                {
                    first = mid + 1;
                }
            }
           if(first>last)
            {
                Console.WriteLine("Element couuld not found");
            }
        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
	}
}
