// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Prime_Factor.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Prime_factor is a class which contains Factor method helps in displaying prime factors of a number.
/// </summary>
public class Prime_Factor
{
    /// <summary>
    /// Factor is a methos used to claculate and display the factors of a number.
    /// </summary>
    public void Factor()
	{
        Console.WriteLine("Enter number");

        ////read input from user
        int num = Convert.ToInt32(Console.ReadLine());    
        for(int i=2;i<num;i++)
        {

            ////condition to find a number which divides input number
            if (num%i==0)                                  
            {
                for(int j=2;j<=i;j++)
                {
                    ////condition to check the prime factors of a number
                    if (i%j==0&&i==j)                   
                    {
                        Console.WriteLine(i);
                    }

                }
  
            }
        }

	}
}
