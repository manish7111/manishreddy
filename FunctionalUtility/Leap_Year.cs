// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Leap_Year.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Leap_Year is a class where i need to check whether the given year is leap year or not.
/// </summary>
public class Leap_Year
{
    /// <summary>
    /// Year is a methos where it calculates and provies the output as leap year or not.
    /// </summary>
    public void Year()
	{
        Console.WriteLine("Enter the year");

        ////Read input year from user 
        int year = Convert.ToInt32(Console.ReadLine());

        ////Condition to check whether the year is leap year or not

        if ((year%4==0&&year%100!=0)||year%400==0)              
        {
            Console.WriteLine("Year is Leap Year");
        }
        else
        {
            Console.WriteLine("Given Year is not a leap Year");
        }
	}
}
