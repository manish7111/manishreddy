// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Distance.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Distance is the class where i have calculate method.
/// </summary>
public class Distance
{
    /// <summary>
    /// Calculates this instance.
    /// </summary>
    public void Calculate()
	{
        Console.WriteLine("Enter 1st Coordinate numbers");

        ////Reading of x and y from user (1st coordinate)
        double x = Convert.ToInt32(Console.ReadLine());         
        double y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter 2nd Coordinate numbers");
        
        ////Reading of a,b values from user(2nd coordinate)
        double a = Convert.ToInt32(Console.ReadLine());         
        double b = Convert.ToInt32(Console.ReadLine());

        ////Squareroot of (x-a)^2
        double root1 = Math.Pow((x - a), 2);

        ////Squareroot of (y-b)^2
        double root2 = Math.Pow((y - b), 2);                        
            if (x > a && y > b)
            {

                 ////Square root of ((x-a)^2+(y-b)^2)
                double dist = Math.Sqrt(root1 + root2);                      
                Console.WriteLine("Distance is :" + dist);
            }

    }
}
