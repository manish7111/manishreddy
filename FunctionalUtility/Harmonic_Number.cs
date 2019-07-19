// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Harmonic_Number.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Harmonic number is a class in which display methos is created to display the Nth Harmonic number
/// </summary>
public class Harmonic_Number
{
    /// <summary>
    /// Displays the Harmonic number aand series of harmonic number.
    /// </summary>
    public void Display()
	{
        Console.WriteLine("Enter number");

        ////Reading of harmonic nth number from the user
        int num = Convert.ToInt32(Console.ReadLine());

        ////Hormonic number printing in the specific form such as 1/n
        Console.Write(1 + "/" + num + "=");                   
        double sum = 0;
        for (double i=1;i<=num&&num>0;i++)
        {
            double j=1/i;

            ////Tor finding the sum of the harmonic number
            sum+=j;                                 
            Console.Write(1+"/" +i);

            ////This if condition checks and prints the "+" after each each increment of number
            if (i<num)                                        
            {
                Console.Write("+");
            }
        }
        Console.WriteLine();
        Console.WriteLine(sum);
	}
}
