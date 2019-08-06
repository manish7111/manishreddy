// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CarSeller.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// CarSeller is a class which implements ICar interface and i declared the methods in it.
/// </summary>
public class CarSeller : ICar
{
    /// <summary>
    /// Gets the diesel car.
    /// </summary>
    public void GetDieselCar()
    {
        Console.WriteLine("Your Booking towards Diesel car is successful");
    }
    /// <summary>
    /// Gets the petrol car.
    /// </summary>
    public void GetPetrolCar()
    {
        Console.WriteLine("Your Booking towards Petrol car is successful");
    }
}
