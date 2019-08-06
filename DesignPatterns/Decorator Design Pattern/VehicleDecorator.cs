// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VehicleDecorator.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// VehicleDecorator is a abstract clas which implements Ivehicle1 interface.
/// </summary>
public abstract class VehicleDecorator : IVehicle1
{
    /// <summary>
    /// The vehicle
    /// </summary>
    private IVehicle1 vehicle;
    /// <summary>
    /// Initializes a new instance of the <see cref="VehicleDecorator"/> class.
    /// </summary>
    /// <param name="_vehicle">The vehicle.</param>
    protected VehicleDecorator(IVehicle1 _vehicle)
    {
        vehicle = _vehicle;
    }
    /// <summary>
    /// Gets the type of the vehicle.
    /// </summary>
    /// <value>
    /// The type of the vehicle.
    /// </value>
    public string VehicleType
    {
        get
        {
            return vehicle.VehicleType;
        }
    }
    /// <summary>
    /// Gets the price.
    /// </summary>
    /// <value>
    /// The price.
    /// </value>
    public double Price
    {
        get
        {
            return vehicle.Price;
        }
    }
}

