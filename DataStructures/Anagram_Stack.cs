// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Anagram_Stack.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Anagram_Stack is a class where i used to store the anagrams in a stack.
/// </summary>
public class Anagram_Stack
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Anagram_Stack"/> class.
    /// </summary>
    public Anagram_Stack()
	{

        ////try and catch are used to handle the Exception.
        try
        {
            int count_prime = 0, count_prime1 = 0;
            int[] array = new int[1000];

            ////condition to check the prime numbers.
            for (int i = 0; i < 1000; i++)
            {
                int count = 0;
                for (int j = i; j > 0; j--)
                {
                    if (i > 2)
                    {
                        if (i % j == 0)
                        {
                            count++;
                        }
                    }
                }
                if (count == 2)
                {
                    
                    array[i] = i;
                    count_prime++;
                }
            }

            ////declaration of arrays and storing the data in the arrays.
            int[] anagram = new int[count_prime];
            int[] anagram1 = new int[count_prime];

            ////condition to store the anagrams in the arrays while avoind the unnecessary data
            for (int i=0,j=0;i<array.Length-1;i++)
            {
                if (array[i] != 0)
                {
                    Console.Write(array[i] + " ");
                    anagram[j] = array[i];
                    j++;
                }
            }
            int k = 0;

            ////printing only the anagrams between the range and storing the anagrams .
            for (int i = 0; i <anagram.Length-1; i++)
            {    
                for (int j = i+1; j < anagram.Length-1; j++)
                {
                    if (IsAnagram(anagram[i], anagram[j]))
                    {
                        Console.WriteLine("---------------->" + anagram[i] + "," + anagram[j]);
                        if (anagram[i] != anagram[j])
                        {
                            anagram1[k] = anagram[j];
                            k++;
                            count_prime1++;
                        }

                    }
                  }               
            }

            ///printing the anagrams.
            Console.WriteLine("anagrams are:");
            for(int i=0;i<count_prime1;i++)
            {
                Console.Write(anagram1[i]+" ");
            }
            Console.WriteLine();
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
	}
    /// <summary>
    /// Determines whether the specified n1 is anagram.
    /// </summary>
    /// <param name="n1">The n1.</param>
    /// <param name="n2">The n2.</param>
    /// <returns>
    ///   <c>true</c> if the specified n1 is anagram; otherwise, <c>false</c>.
    /// </returns>
    public Boolean IsAnagram(int n1, int n2)
     {
        string str1 = n1.ToString();
        
        string str2 = n2.ToString();
        char[] ch1 = str1.ToCharArray();
        char[] ch2 = str2.ToCharArray();
        Array.Sort(ch1);
        Array.Sort(ch2);
        
        if (ch1.Length==ch2.Length)
        {
          
            int count = 0;
            for (int i = 0; i < ch1.Length; i++)
            {
                if (ch1[i] == ch2[i])
                {
                    count++;
                }
            }
            if (count == ch1.Length)
            {
                return true;
            }
            else
                return false;
        }
        else
            return false;
     }
}
