// --------------------------------------------------------------------------------------------------------------------
// <copyright file="KarnatakaBank.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// KarnatakaBank is a class which ia implementing the interface IRbi.
/// </summary>
public class KarnatakaBank : IRbi
{
    /// <summary>
    /// Gets the rate of intrest.
    /// </summary>
    public void GetRateOfIntrest()
    {
        ////print the rate of intrest of Karnataka bank.
        Console.WriteLine("Rate of intrest in Karnataka Bank is: 8.5%");
    }
}
