// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Anagram.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Anagram is a class where i created a check method,to check whether the string is anagram or not.
/// </summary>
public class Anagram
{
    /// <summary>
    /// Check is a method to check whether the two given strings are anagram or not.
    /// </summary>
    public void Check()                       
	{
        ////Reading of 1st strings 
        Console.WriteLine("enter 1st string");
        String string1 = Console.ReadLine();

        Console.WriteLine("enter 2nd string");
        ////Reading of 2 strings 
        String string2 = Console.ReadLine();
        
        if(string1.Length==string2.Length)              
        {
            int count = 0;

            ////converting string to array
            char[] ch1=string1.ToCharArray();        
            char[] ch2 = string2.ToCharArray();

            ////Sorting of array`
            Array.Sort(ch1);                  
            Console.WriteLine(ch1);
            Array.Sort(ch2);
            Console.WriteLine(ch2);
            for (int i=0;i<ch1.Length;i++)
            {
                    if(ch1[i]==ch2[i])
                    {
                     count++;
                    }
            }
            if(count==string1.Length)
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("Not a Anagram");
            }
          
        }
        else
        {
            Console.WriteLine("String's entered should be of some length");
        }
    }
}
