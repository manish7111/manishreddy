// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Volt.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Volt is a class.
/// </summary>
public class Volt
{
    /// <summary>
    /// The volts
    /// </summary>
    private int volts;

    /// <summary>
    /// Initializes a new instance of the <see cref="Volt"/> class.
    /// </summary>
    /// <param name="volts">The volts.</param>
    public Volt(int volts)
    {
       this.volts = volts;
    }
    /// <summary>
    /// Gets the volt.
    /// </summary>
    /// <returns></returns>
    public int GetVolt()
    {
        return this.volts;
    }
    /// <summary>
    /// Sets the volt.
    /// </summary>
    /// <param name="volts">The volts.</param>
    public void SetVolt(int volts)
    {
        this.volts = volts;
    }
}
