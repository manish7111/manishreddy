using System;

public class Distance
{
	public void Calculate()
	{
        Console.WriteLine("Enter 1st Coordinate numbers");
        double x = Convert.ToInt32(Console.ReadLine());
        double y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter 2nd Coordinate numbers");
        double a = Convert.ToInt32(Console.ReadLine());
        double b = Convert.ToInt32(Console.ReadLine());
        double m = Math.Pow((x - a), 2);
        double n = Math.Pow((y - b), 2);
            if (x > a && y > b)
            {
            double dist = Math.Sqrt(m + n);
            Console.WriteLine("Distance is :" + dist);
            }

    }
}
