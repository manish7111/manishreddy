﻿using System;

public class Quadratic
{
	public void Calculate()
	{
        Console.WriteLine("for finding the roots of the equation enter values of a,b,c");
        double a = Convert.ToDouble(Console.ReadLine());
        double b= Convert.ToDouble(Console.ReadLine());
        double c= Convert.ToDouble(Console.ReadLine());
        double delta = (b * b) - 4 * a * c;
        double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
        double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
        Console.WriteLine("root1 of equation is:"+root1);
        Console.WriteLine("root2 of equation is:" + root2);
    }
}
