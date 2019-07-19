// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fibonocci_Series.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Fibonocci_Series is the class name which i have created to find the series of fibonocci numbers between "n".
/// </summary>
public class Fibonocci_Series
{
    /// <summary>
    /// Series is an instance method where the logic of my Fibonocci_Series is present.
    /// </summary>
    public void Series()
	{
        Console.WriteLine("enter number between which u want to find the series");

        ////Read of number from the user
        int num = Convert.ToInt32(Console.ReadLine());

        ////Initializing the values
        int first=0,second=1,third=2;                               
        Console.WriteLine("Fibonocci series are:");

        ////For loop until conditions comes false
        for (int i=0;i<num;i++)                            
        {
            ////Print f0 as it gives us the required result
            Console.Write(first + " ");

            ////As known always 3rd value will be the sum of 1st and 2nd 
            third = first + second;

            ////Initializing of 1st variable with 2nd
            first = second;

            ////Initializing of 2nd variable with 3rd
            second = third;                                    
        }
	}
}
