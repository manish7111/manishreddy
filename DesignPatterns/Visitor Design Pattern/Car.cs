// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Car.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Car is a class which implements interface IStore.
/// </summary>
public class Car : IStore
{
    /// <summary>
    /// Gets or sets the name of the car.
    /// </summary>
    /// <value>
    /// The name of the car.
    /// </value>
    public string CarName
    {
        get;
        set;
    }
    /// <summary>
    /// Gets or sets the price.
    /// </summary>
    /// <value>
    /// The price.
    /// </value>
    public decimal Price
    {
        get;
        set;
    }
    /// <summary>
    /// Gets or sets the type of the car.
    /// </summary>
    /// <value>
    /// The type of the car.
    /// </value>
    public string CarType
    {
        get;
        set;
    }
    /// <summary>
    /// Visits the specified visitor.
    /// </summary>
    /// <param name="visitor">The visitor.</param>
    public void Visit(IVisitor visitor)
    {
        visitor.Accept(this);
    }
}
