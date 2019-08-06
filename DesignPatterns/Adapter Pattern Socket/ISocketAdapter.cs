// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISocketAdapter.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// ISocket is an Interface.
/// </summary>
public interface ISocketAdapter
{
    /// <summary>
    /// Get120s the volt.
    /// </summary>
    /// <returns></returns>
    Volt Get120Volt();

    /// <summary>
    /// Get12s the volt.
    /// </summary>
    /// <returns></returns>
    Volt Get12Volt();

    /// <summary>
    /// Get3s the volt.
    /// </summary>
    /// <returns></returns>
    Volt Get3Volt();
}
