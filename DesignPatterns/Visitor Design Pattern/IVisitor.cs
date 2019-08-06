// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IVisitor.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// IVisitor is an interface.
/// </summary>
public interface IVisitor
{
    /// <summary>
    /// Accepts the specified car.
    /// </summary>
    /// <param name="car">The car.</param>
    void Accept(Car car);
    /// <summary>
    /// Accepts the specified bike.
    /// </summary>
    /// <param name="bike">The bike.</param>
    void Accept(Bike bike);
}
