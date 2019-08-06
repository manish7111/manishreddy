// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Bike.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Bike is a class which implements interface IStore.
/// </summary>
public class Bike : IStore
{
    /// <summary>
    /// Gets or sets the name of the bike.
    /// </summary>
    /// <value>
    /// The name of the bike.
    /// </value>
    public string BikeName
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
    /// Gets or sets the type of the bike.
    /// </summary>
    /// <value>
    /// The type of the bike.
    /// </value>
    public string BikeType
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
