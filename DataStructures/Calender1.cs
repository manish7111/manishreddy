// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Calender1.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Calender 1 is a class where we perform the operations to get the calender of a specified month and year.
/// </summary>
public class Calender1
{
    /// <summary>
    /// Calenders this instance.
    /// </summary>
    public void Calender()
	{
        Console.WriteLine("enter year");
        int year= Int32.Parse(Console.ReadLine());
        Console.WriteLine("enter month");
        int month = Int32.Parse(Console.ReadLine());

        ////storing the months in an array.
        String[] months = {"","January", "February", "March","April", "May", "June","July", "August", "September","October", "November", "December"};

        ////storing the numbers of days in a month in an array.
        int[] days = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

        ////condition to find the days in an leap year.
        if (month == 2 && isLeapYear(year))
        {
            days[month] = 29;
        }   
        Console.WriteLine("   " + months[month] + " " + year);
        Console.WriteLine(" S  M Tu  W Th  F  S");
        int day =Day(month, 1, year);
        for (int i = 0; i < day; i++)
        {
            Console.Write("   ");
        }

        ////condition to print the calender.
        for (int i = 1; i <= days[month]; i++)
        {
            Console.Write( i+"  ");
            if (((i + day) % 7 == 0) || (i == days[month]))
            {
                Console.WriteLine();
            }  
        }
    }
    /// <summary>
    /// Days the specified month.
    /// </summary>
    /// <param name="month">The month.</param>
    /// <param name="day">The day.</param>
    /// <param name="year">The year.</param>
    /// <returns></returns>
    public static int Day(int month, int day, int year)
    {
        ////validate the data and return the odd days.
        int y = year - (14 - month) / 12;
        int x = y + y / 4 - y / 100 + y / 400;
        int m = month + 12 * ((14 - month) / 12) - 2;
        int d = (day + x + (31 * m) / 12) % 7;
        return d;
    }
    /// <summary>
    /// Determines whether [is leap year] [the specified year].
    /// </summary>
    /// <param name="year">The year.</param>
    /// <returns>
    ///   <c>true</c> if [is leap year] [the specified year]; otherwise, <c>false</c>.
    /// </returns>
    public static Boolean isLeapYear(int year)
    {
        if ((year % 4 == 0) && (year % 100 != 0))
        {
            return true;
        }  
        if (year % 400 == 0)
        {
            return true;
        }  
        return false;
    }

}

