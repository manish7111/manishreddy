// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IEmployee.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// IEmployee is an interface.
/// </summary>
public interface IEmployee
{
    /// <summary>
    /// Clones this instance.
    /// </summary>
    /// <returns></returns>
    IEmployee Clone();

    /// <summary>
    /// Gets the details.
    /// </summary>
    /// <returns></returns>
    string GetDetails();
}
