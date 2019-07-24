// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Prime_Num.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Prime_Num is a class where we created a method demo.
/// </summary>
public class Prime_Num
{
    /// <summary>
    /// Demoe is an method created where we will check the prime numbers and also the prime number is palendrome or not.
    /// </summary>
    public void Demo()
    {
        Console.WriteLine("Enter n");
        int n = Convert.ToInt32(Console.ReadLine());
        this.Check(n);
    }
	public void Check(int n)
	{
        ////Indexing for prime num array
        int k = 0;
        Console.WriteLine("prime numbers are:");
        int countPrime = 0;

        ////Array for storing prime number 
        int[] array = new int[n];
        for (int i = 1; i <=n; i++)
        {
            int count = 0;
            for (int j = i; j >=1; j--)
            {

                ////Condition of prime number
                if (i%j == 0)
                {
                    count++;
                }
            }

            ////If my count becomes 2 such that number has to divide of one and itself
            if(count==2)
            {
                Console.Write(i+" ");

                ////Storing the prime numbers in this array
                array[k++] = i;
                countPrime++;
            }
        }
        Console.WriteLine("\nPalindrome: ");
        for (int e = 0; e <countPrime; e++)
        {
            int sum = 0;
            int value = array[e];
            if (value != 0)
            {
                if (value > 9)

                    ////Condition to check whether the primenumber is palendrome or not
                    while (value > 0)
                    {
                        int rem = value % 10;
                        sum = sum * 10 + rem;
                        value = value / 10;
                    }
                if (sum == array[e])
                {
                    Console.Write("palendrome"+array[e] + " ");
                }
            }
        }
    }
}
