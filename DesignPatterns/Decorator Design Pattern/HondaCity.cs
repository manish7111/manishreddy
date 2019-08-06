// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HondaCity.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// HondaCity is a class which implements IVehicle interface.
/// </summary>
public class HondaCity : IVehicle1
{
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
            return "HondaCity";
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
            return 100000;
        }
    }
}

