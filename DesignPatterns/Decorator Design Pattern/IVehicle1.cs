// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IVehicle1.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// IVehicle is an interface.
/// </summary>
public interface IVehicle1
{
    /// <summary>
    /// Gets the type of the vehicle.
    /// </summary>
    /// <value>
    /// The type of the vehicle.
    /// </value>
    string VehicleType
    {
        get;
    }
    /// <summary>
    /// Gets the price.
    /// </summary>
    /// <value>
    /// The price.
    /// </value>
    double Price
    {
        get;
    }
}

