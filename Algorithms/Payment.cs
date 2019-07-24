// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Payment.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Payment is a class where i created the Monthly payment method to find the rate of intrest.
/// </summary>
public class Payment
{
    /// <summary>
    /// MonthlyPayment is a method which is used to find the simple intrest and display.
    /// </summary>
    public void MonthlyPayment()
	{
        Console.WriteLine("enter Principle loan amount");

        ////Reading of principle intrest from user
        double p_amount = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("enter Years to pay the amount");

        ////Reading of number of years from the user
        double year = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("enter Rate of Intrest");

        ////Reading of rate of interest from the user
        double Rate = Convert.ToDouble(Console.ReadLine());
        double num = 12 * year;
        double r = Rate / (12 * 100);

        ////Using the formula by using required functions
        double payment = (p_amount * r) / (1 - Math.Pow((1 + r), -num));
        Console.WriteLine(Math.Round(payment));
    }
}
