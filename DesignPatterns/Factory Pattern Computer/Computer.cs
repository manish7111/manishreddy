// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Computer.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Computer is an Abstract class.
/// </summary>
public abstract class Computer
{
    /// <summary>
    /// Gets or sets the ram.
    /// </summary>
    /// <value>
    /// The ram.
    /// </value>
    public abstract string Ram
    {
        get;
        set;
    }
    /// <summary>
    /// Gets or sets the HDD.
    /// </summary>
    /// <value>
    /// The HDD.
    /// </value>
    public abstract string Hdd
    {
        get;
        set;
    }
    /// <summary>
    /// Gets or sets the cpu.
    /// </summary>
    /// <value>
    /// The cpu.
    /// </value>
    public abstract string Cpu
    {
        get;
        set;
    }
}
