// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Prime_check.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Prime_Check is a class where we used to find the prime numbers between 1 -1000 and storing them in an 2D array.
/// </summary>
public class Prime_check
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Prime_check"/> class.
    /// </summary>
    public Prime_check()
	{
        //Console.WriteLine("defining an 2d array");
        int[,] prime = new int[10,1000];
        try
        {
            ////condition to check the prime numbers in a range.
            for (int i = 0; i < 10; i++)
            {
                for (int j = (i * 100) + 1; j < (i + 1) * 100; j++)
                {
                   
                    int count = 0;
                    for (int k = j; k >0; k--)
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

            ////printing of prime numbers with in ranges ex.0-100,101-200,etc.
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
        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
       
	}
}
