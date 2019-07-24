// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Calender.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Calender is a class to find the calender of a month of a specified year.
/// </summary>
public class Calender
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Calender"/> class.
    /// </summary>
    public Calender()
    {
        Console.WriteLine("enter year");
        int year = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter month");
        int month = Convert.ToInt32(Console.ReadLine());
        int day = 1, space = 0;

        ////formula to find out the off days.
        int year0 = year - (14 - month) / 12;
        int x = year0 + year0 / 4 - year0 / 100 + year0 / 400;
        int m0 = month + 12 * ((14 - month) / 12) - 2;
        int d0 = (day + x + 31 * m0 / 12) % 7;
        int days=1;
        Console.WriteLine(d0);
        Console.WriteLine("   " + year + " " + month);
        Console.WriteLine("---------------------------");
        ////switch case to find the number of days in a month.
        switch (month)
        {

            case 1:
                days = 31;
                break;
            case 2:
                if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                    days = 28;
                else
                    days = 29;
                break;
            case 3:
                days = 31;
                break;
            case 4:
                days = 30;
                break;
            case 5:
                days = 31;
                break;
            case 6:
                days = 30;
                break;
            case 7:
                days = 31;
                break;
            case 8:
                days = 31;
                break;
            case 9:
                days = 30;
                break;
            case 10:
                days = 31;
                break;
            case 11:
                days = 30;
                break;
            case 12:
                days = 31;
                break;
            default:
                Console.WriteLine("no month found");
                break;
        }
        Console.WriteLine(" " + " sun" + " " + "mon" + " " + "tues" + " " + "wed" + " " + "thrus" + " " + "fri" + " " + "sat" + " ");

        ////for loop to print the calender dates.
        for(int i=0;i<7;i++)
        {
            for (int j = 0; j < i; j++)
            {
                if(space < d0)
                {
                    Console.Write(" ");
                }
                else
                Console.Write(days);
                days++;
            }
        }
        

    }
}