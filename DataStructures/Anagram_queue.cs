// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Anagram_Queue.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
/// <summary>
/// Anagram_Queue is a class where storing the anagrams in the queue and retriving the data from the queue.
/// </summary>
public class Anagram_Queue
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Anagram_Queue"/> class.
    /// </summary>
    public Anagram_Queue()
	{
        ////try and catch is used to handle the exception.
        try
        {
            int count_prime = 0, count_prime1 = 0;
            int[] array = new int[1000];

            ////logic to find the prime numbers
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
            int[] anagram = new int[count_prime];
            int[] anagram1 = new int[count_prime];
            int[] anagram2 = new int[500];
            ////storing of prime numbers in an defined array.
            for (int i = 0, j = 0; i < array.Length - 1; i++)
            {
                if (array[i] != 0)
                {
                    Console.Write(array[i] + " ");
                    anagram[j] = array[i];
                    j++;
                }
            }
            int k = 0;

            ////printing of anagram and storing of anagram in a queue
            for (int i = 0; i < anagram.Length - 1; i++)
            {
                for (int j = i + 1; j < anagram.Length - 1; j++)
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
            Console.WriteLine("anagrams are:");
            for (int i = 0; i < count_prime1; i++)
            {
                Console.Write(anagram1[i] + " ");
            }
            Console.WriteLine();
        }
        catch (Exception e)
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

        ////converting the numbers to strings and check where both the strings are equal ,if equal Anagram else noit a anagram.
        string str1 = n1.ToString();
        string str2 = n2.ToString();

        ////converting string to charecter.
        char[] ch1 = str1.ToCharArray();
        char[] ch2 = str2.ToCharArray();
        ////sorting of charecters by using inbuilt function array.sort
        Array.Sort(ch1);
        Array.Sort(ch2);
        if (ch1.Length == ch2.Length)
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
