// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SocketAdapterImpl.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// SocketAdapterImpl is a implementation class of interface ISocketAdapter.
/// </summary>
public class SocketAdapterImpl : ISocketAdapter
{
    /// <summary>
    /// The socket
    /// </summary>
    private Socket socket = new Socket();
    
    /// <summary>
    /// Converts the volt.
    /// </summary>
    /// <param name="volt">The volt.</param>
    /// <param name="volts">The volts.</param>
    /// <returns></returns>
    private Volt ConvertVolt(Volt volt, int volts)
    {
        return new Volt(volt.GetVolt() / volts);
    }

    /// <summary>
    /// Get120s the volt.
    /// </summary>
    /// <returns></returns>
    public Volt Get120Volt()
    {
        return socket.GetVolt();
    }

    /// <summary>
    /// Get12s the volt.
    /// </summary>
    /// <returns></returns>
    public Volt Get12Volt()
    {
        Volt volt = socket.GetVolt();
        return ConvertVolt(volt, 10);
    }

    /// <summary>
    /// Get3s the volt.
    /// </summary>
    /// <returns></returns>
    public Volt Get3Volt()
    {
        Volt volt = socket.GetVolt();
        return ConvertVolt(volt, 40);
    }
}
