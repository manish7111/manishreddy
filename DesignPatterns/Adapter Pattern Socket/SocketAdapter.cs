// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SocketAdapter.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// SocketAdapter is a class which implements both Socket class and ISocketAdapter.
/// </summary>
public class SocketAdapter : Socket, ISocketAdapter
{
    /// <summary>
    /// Converts the volt.
    /// </summary>
    /// <param name="v">The v.</param>
    /// <param name="i">The i.</param>
    /// <returns></returns>
    private Volt ConvertVolt(Volt v, int i)
    {
        return new Volt(v.GetVolt() / i);
    }
    /// <summary>
    /// Get120s the volt.
    /// </summary>
    /// <returns></returns>
    public Volt Get120Volt()
    {
        return GetVolt();
    }
    /// <summary>
    /// Get12s the volt.
    /// </summary>
    /// <returns></returns>
    public Volt Get12Volt()
    {
        Volt volt = GetVolt();
        return ConvertVolt(volt, 10);
    }
    /// <summary>
    /// Get3s the volt.
    /// </summary>
    /// <returns></returns>
    public Volt Get3Volt()
    {
        Volt volt = GetVolt();
        return ConvertVolt(volt, 40);
    }
}
