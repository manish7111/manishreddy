using System;

public class Leap_Year
{
	public void Year()
	{
        Console.WriteLine("Enter the year");

        //read input year from user 
        int year = Convert.ToInt32(Console.ReadLine());

        //condition to check whether the year is leap year or not

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
