// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Power.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Power is the class which consists of Pow method.
/// </summary>
public class Power
{
    /// <summary>
    /// Pows is the method where i display the 2^i table (i<n).
    /// </summary>
    public void Pow()
	{
        Console.WriteLine("Enter the number");

        ////Reads the number from the user
        double num = Convert.ToInt32(Console.ReadLine());
        double pow=0;

        //Condition to check the number present between 0 and 31
        if (num > 0 && num < 31)                                               
        {
            for (int i = 0; i < num; i++)
            {
                ////Using power function to find the power of 2
                pow = Math.Pow(2, i);                                        
                if (pow <= Math.Pow(2, num))
                {

                    ////Printing of 2 power table
                    Console.WriteLine(2+"^"+i +"=" +pow);                     
                }
                Console.WriteLine();
            }
           
        }
        else
        {

            ////Enter the value which is in range btw 0 and 31
            Console.WriteLine("Emter the n value with in the range");      
        }
        

	}
}
