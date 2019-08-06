// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AndhraBank.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// AndhraBank is a class which implements interface IRbi.
/// </summary>
public class AndhraBank : IRbi
{
    /// <summary>
    /// Gets the rate of intrest.
    /// </summary>
    public void GetRateOfIntrest()
    {
        ////printing the rate of intrest of a bank.
        Console.WriteLine("Rate of intrest in Andhra Bank is: 12.5%");
    }
}
