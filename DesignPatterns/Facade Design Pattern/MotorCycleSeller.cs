// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MotorCycleSeller.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// MotorCycleSeller is a class which implements IMotorCyle interface.
/// </summary>
public class MotorCycleSeller:IMotorCycle
{
    /// <summary>
    /// Gets the bike.
    /// </summary>
    public void GetBike()
    {
        Console.WriteLine("Your Booking towards Bike is successful");
    }

    /// <summary>
    /// Gets the cycle.
    /// </summary>
    public void GetCycle()
    {
        Console.WriteLine("Your Booking towards Cycle is successful");
    }
}
