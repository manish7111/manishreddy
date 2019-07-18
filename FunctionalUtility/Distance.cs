using System;

public class Distance
{
	public void Calculate()
	{
        Console.WriteLine("Enter 1st Coordinate numbers");

        //reading of x and y from user (1st coordinate)
        double x = Convert.ToInt32(Console.ReadLine());         
        double y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter 2nd Coordinate numbers");

        //reading of a,b values from user(2nd coordinate)
        double a = Convert.ToInt32(Console.ReadLine());         
        double b = Convert.ToInt32(Console.ReadLine());

        //squareroot of (x-a)^2
        double m = Math.Pow((x - a), 2);

        //squareroot of (y-b)^2
        double n = Math.Pow((y - b), 2);                        
            if (x > a && y > b)
            {

                 //square root of ((x-a)^2+(y-b)^2)
                double dist = Math.Sqrt(m + n);                      
                Console.WriteLine("Distance is :" + dist);
            }

    }
}
