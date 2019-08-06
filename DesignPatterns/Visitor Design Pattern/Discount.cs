// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Discount.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Discount is a class which implements IVisitor interface.
/// </summary>
public class Discount : IVisitor
{
    /// <summary>
    /// The car discount
    /// </summary>
    private const int carDiscount = 10;
    /// <summary>
    /// The bike discount
    /// </summary>
    private const int bikeDiscount = 5;
    /// <summary>
    /// Accepts the specified car.
    /// </summary>
    /// <param name="car">The car.</param>
    public void Accept(Car car)
    {
        ////calculating the finalPrice of the car.
        decimal finalCarPrice = car.Price - ((car.Price / 100) * 10);
        Console.WriteLine("Car {0} price: {1}", car.CarName, finalCarPrice);
    }
    /// <summary>
    /// Accepts the specified bike.
    /// </summary>
    /// <param name="bike">The bike.</param>
    public void Accept(Bike bike)
    {
        ////calculating the finalprice of the bike.
        decimal finalBikePrice = bike.Price - ((bike.Price / 100) * 5);
        Console.WriteLine("Bike {0} price: {1}", bike.BikeName, finalBikePrice);
    }
}
