// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Laptop.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Laptop is a class which implements abstract class computer.
/// </summary>
public class Laptop : Computer
{
    /// <summary>
    /// The ram
    /// </summary>
    private string ram;

    /// <summary>
    /// The HDD
    /// </summary>
    private string hdd;

    /// <summary>
    /// The cpu
    /// </summary>
    private string cpu;

    /// <summary>
    /// Initializes a new instance of the <see cref="Laptop"/> class.
    /// </summary>
    /// <param name="_ram">The ram.</param>
    /// <param name="_hdd">The HDD.</param>
    /// <param name="_cpu">The cpu.</param>
    public Laptop(string _ram, string _hdd, string _cpu)
    {
        ram = _ram;
        hdd = _hdd;
        cpu = _cpu;
    }

    /// <summary>
    /// Gets or sets the ram.
    /// </summary>
    /// <value>
    /// The ram.
    /// </value>
    public override string Ram
    {
        get
        {
            return ram;
        }
        set
        {
            ram = value;
        }
    }

    /// <summary>
    /// Gets or sets the HDD.
    /// </summary>
    /// <value>
    /// The HDD.
    /// </value>
    public override string Hdd
    {
        get
        {
            return hdd;
        }
        set
        {
            hdd = value;
        }
    }

    /// <summary>
    /// Gets or sets the cpu.
    /// </summary>
    /// <value>
    /// The cpu.
    /// </value>
    public override string Cpu
    {
        get
        {
            return cpu;
        }
        set
        {
            cpu = value;
        }
    }
}
