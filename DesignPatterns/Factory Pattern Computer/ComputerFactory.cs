// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ComputerFactory.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// ComputerFactory is an abstract class.
/// </summary>
public abstract class ComputerFactory
{
    /// <summary>
    /// Gets the computer.
    /// </summary>
    /// <returns></returns>
    public abstract Computer GetComputer();
}
