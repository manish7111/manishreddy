// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Anagram.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
/// <summary>
/// Anagram is a class where i defined a constructor to find the prime numbers and store the anagrams in one array and not the anagrams in another array.
/// </summary>
public class Anagram
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Anagram"/> class.
    /// </summary>
    public Anagram()
	{
        
        int[,] prime = new int[10, 1000];
        ////Code is enclosed between try and catch ,if exception is occured it catches the exception and prints the message.
        try
        {

            ////Logic to find the prime nnumbers between 0 to 1000.
            for (int i = 0; i < 10; i++)
            {
                for (int j = (i * 100) + 1; j < (i + 1) * 100; j++)
                {

                    int count = 0;
                    for (int k = j; k > 0; k--)
                    {
                        if (j > 2)
                        {
                            if (j % k == 0)
                            {
                                count++;
                            }
                        }
                    }
                    if (count == 2)
                    {
                        prime[i, j] = j;
                    }

                }
                Console.WriteLine();
            }

            ////printing of prime numbers according to the ranges
            Console.WriteLine("Prime numbers in the ranges are:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("prime Numbers between :" + i * 100 + "-" + (i * 100 + 100));
                for (int j = (i * 100) + 1; j < (i + 1) * 100 && j < prime.Length; j++)
                {
                    if (prime[i, j] != 0)
                    {
                        Console.Write(prime[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
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
    public Boolean IsAnagram(int n1,int n2)
    {
        string str1 = " " + n1;
        string str2 = " " + n2;
        if (str1.Length == str2.Length)
        {
            if (str1.Equals(str2))
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
