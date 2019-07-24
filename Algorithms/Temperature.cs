// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Temperature.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Class name is Temperature where we can find the temperature conversions from celcius to fahrenheit and vice versa.
/// </summary>
public class Temperature
{
    /// <summary>
    /// Celciouses to fahrenheit.
    /// </summary>
    /// <param name="celcius">The c.</param>
    public void Celcious_To_Fahrenheit(double celcius)
	{

        ////Formula to find fahrenheit temperature
        double fahrenheit = (celcius * 9 / 5) + 32;
        Console.WriteLine(fahrenheit);
    }
    /// <summary>
    /// Fahrenheits to celcious.
    /// </summary>
    /// <param name="fahrenheit">The fahrenheit.</param>
    public void Fahrenheit_To_Celcious(double fahrenheit)
    {
        ////Formula to find celcius temperature
        double celcius = (fahrenheit - 32)*5/9;
        Console.WriteLine(celcius);
    }
    /// <summary>
    /// Tests this instance.
    /// </summary>
    public void Test()
    {
        Console.WriteLine("Enter Celcius temperature");
        double celcius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Fahrenheit temperature");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        this.Celcious_To_Fahrenheit(celcius);
        this.Fahrenheit_To_Celcious(fahrenheit);
    }
}
