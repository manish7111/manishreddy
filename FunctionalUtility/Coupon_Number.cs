// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Coupon_Number.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Coupen number is a class to find the distinct coupen numbers
/// </summary>
public class Coupon_Number
{
    /// <summary>
    /// Distinct_Coupon is a method through which i will get the distinct coupen numbers and count of numbers neededn to get distinct coupen numbers/
    /// </summary>
	public void Distinct_Coupon()
	{
        Console.WriteLine("Enter n coupon  numbers");

       ////Reads the input from the user
        int num = Convert.ToInt32(Console.ReadLine());

        ////Boolean array to store only distinct numbers while avoiding dupicates
        bool[] collection = new bool[num];                    
        int count = 0;
        int distinct = 0;
        Random random = new Random();
        while(distinct<num)
        { 
            int i = Convert.ToInt32((random.Next(num)));  
            count++;

            ////Verify and enter into if block
            if (!collection[i])                    
            {
                distinct++;
                Console.WriteLine("total distinct numbers are" +distinct);
                collection[i] = true;              
            }
        }
        Console.WriteLine("total random  numbers needed to make all distinct");
        Console.WriteLine(count);
    }
}
