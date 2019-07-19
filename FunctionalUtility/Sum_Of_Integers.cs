// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Sum_Of_Integers.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Sum_Of_Integers is a class where i created the method Sum.
/// </summary>
public class Sum_Of_Integers
{
    /// <summary>
    /// Sums this instance.
    /// </summary>
    public void Sum()
	{
        Console.WriteLine("Enter the value of n");

        ////Read length of array 'n' value from the user
        int num = Convert.ToInt32(Console.ReadLine());   
        
        ////Define a array of integer type as we are Storing integer type elements
        int[] array = new int[num];                               
        int count = 0;

        ////Read array elements until condition fails
        for (int i=0;i<num;i++)                                
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        ////To ckeck the triplets nested forloops are used

        for (int i = 0; i < num; i++)                        
        {
            for (int j = 0; j < num; j++)
            {
                for (int k = 0; k < num; k++)
                {

                    //triplet condition

                    if (array[i]+array[j]+array[k]==0)                   
                    {
                        count++;
                        Console.WriteLine("triplets are:" + array[i] + " " + array[j] + " " + array[k]);
                    }
                }
            }
        }

        ////Prints the count of number of triplets present
        Console.WriteLine("count-->"+count);               
    }
}
