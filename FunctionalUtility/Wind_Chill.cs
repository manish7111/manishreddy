// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Wind_Chill.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Wind_Chill is a class where i declared Print method to display the wind chill by calculating formula.
/// </summary>
public class Wind_Chill
{
    /// <summary>
    /// Prints this instance.
    /// </summary>
    public void Print()
	{
        Console.WriteLine("Enter temperature");
        ////Reads input temerature from user
        int temp = Convert.ToInt32(Console.ReadLine());
        ////Reads input velocity from user
        Console.WriteLine("Enter Speed of the wind");
        int velocity = Convert.ToInt32(Console.ReadLine());       
        double wind_chill;
        ////Condition --->true enters if block and execute 
        if (temp<50||(velocity>=3 &&velocity<120))                            
        {                                                   
            wind_chill = 35.74 + (0.6215 * temp) + ((0.4275 * temp) - 35.75) * (Math.Pow(velocity, 0.16));
            Console.WriteLine("wind chill:" +wind_chill);
        }
        ////Condition --->false enters else block and execute
        else
        {
            Console.WriteLine("Enter the values within the range");
        }
    }
}
