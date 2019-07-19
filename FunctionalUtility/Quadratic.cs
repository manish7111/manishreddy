// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Quadratic.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Quadratic is a class which is used to display the roots of a equation
/// </summary>
public class Quadratic
{
    /// <summary>
    /// Calculate is a methos where it calculates the roots and display the output.
    /// </summary>
    public void Calculate()
	{
        Console.WriteLine("for finding the roots of the equation enter values of a,b,c");

        ////Read input a,b,c from user

        double a = Convert.ToDouble(Console.ReadLine());     
        double b= Convert.ToDouble(Console.ReadLine());
        double c= Convert.ToDouble(Console.ReadLine());

        ////Calculation of delta
        double delta = (b * b) - 4 * a * c;

        ////Calculation of roots by using square root function
        double root1 = (-b + Math.Sqrt(delta)) / (2 * a);   
        double root2 = (-b - Math.Sqrt(delta)) / (2 * a);

        ////Crints roots as output
        Console.WriteLine("root1 of equation is:"+root1);    
        Console.WriteLine("root2 of equation is:" + root2);
    }
}
