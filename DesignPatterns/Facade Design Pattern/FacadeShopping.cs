// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FacadeShopping.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// FacadeShopping is a class .
/// </summary>
public class FacadeShopping
{
    /// <summary>
    /// The motor cycle
    /// </summary>
    private IMotorCycle motorCycle;

    /// <summary>
    /// The car
    /// </summary>
    private ICar car;

    /// <summary>
    /// Initializes a new instance of the <see cref="FacadeShopping"/> class.
    /// </summary>
    public FacadeShopping()
    {
        motorCycle = new MotorCycleSeller();
        car = new CarSeller();
    }

    /// <summary>
    /// Orders the cycle.
    /// </summary>
    public void OrderCycle()
    {
        motorCycle.GetCycle();
    }

    /// <summary>
    /// Orders the bike.
    /// </summary>
    public void OrderBike()
    {
        motorCycle.GetBike();
    }

    /// <summary>
    /// Orders the petrol car.
    /// </summary>
    public void OrderPetrolCar()
    {
        car.GetPetrolCar();
    }

    /// <summary>
    /// Orders the diesel car.
    /// </summary>
    public void OrderDieselCar()
    {
        car.GetDieselCar();
    }
}
