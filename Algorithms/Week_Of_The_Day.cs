// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Week_Of_The_Day.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Gregorian_Calender ia class where we find the day example as date of birth.
/// </summary>
public class Week_Of_The_Day
{
    /// <summary>
    /// Dayofweek is a method to find the day.
    /// </summary>
    public static void DayOfWeek()
    {
        Console.WriteLine("Enter Day");

        ////Reading of input day,month,year from user

        int day = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Month");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Year");
        int year = Convert.ToInt32(Console.ReadLine());
        int year0 = year - (14 - month) / 12;
        int x = year0 + year0 / 4 - year0 / 100 + year0 / 400;
        int month0 = month + 12 * ((14 - month) / 12) - 2;
        int day0 = (day + x + 31 * month0 / 12) % 7;
        Console.WriteLine(day0);

        ////Passing the parameter d0 as it is the output and acts as input for switch loop
        switch (day0)
        {
            case 0:
                Console.WriteLine("sunday");
                break;
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thrusday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            default:
                Console.WriteLine("nub");
                break;
        }
    }
}
