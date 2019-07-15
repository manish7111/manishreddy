using System;

public class Leap_Year
{
	public void Year()
	{
        Console.WriteLine("Enter the year");
        int year = Convert.ToInt32(Console.ReadLine());
        if((year%4==0&&year%100!=0)||year%400==0)
        {
            Console.WriteLine("Year is Leap Year");
        }
        else
        {
            Console.WriteLine("Given Year is not a leap Year");
        }
	}
}
