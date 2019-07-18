using System;

public class Gregorian_Calender
{
	public static void dayOfWeek()
	{
        Console.WriteLine("Enter Day");

        //reading of input day,month,year from user

        int d = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Month");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Year");
        int y = Convert.ToInt32(Console.ReadLine());
        int y0= y-(14-m)/12;
        int x= y0+y0/4-y0/100+y0/400;
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        int d0 = (d + x + 31 * m0 / 12) % 7;
        Console.WriteLine(d0);

        //passing the parameter d0 as it is the output and acts as input for switch loop
        switch(d0)
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
