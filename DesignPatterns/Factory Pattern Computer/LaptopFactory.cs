// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LaptopFactory.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Laptop factory is a class which implements COmputer factory abstract class.
/// </summary>
public class LaptopFactory : ComputerFactory
{
    /// <summary>
    /// The ram
    /// </summary>
    private string ram, hdd, cpu;

    /// <summary>
    /// Initializes a new instance of the <see cref="LaptopFactory"/> class.
    /// </summary>
    /// <param name="_ram">The ram.</param>
    /// <param name="_hdd">The HDD.</param>
    /// <param name="_cpu">The cpu.</param>
    public LaptopFactory(string _ram, string _hdd, string _cpu)
    {
        ram = _ram;
        hdd = _hdd;
        cpu = _cpu;
    }

    /// <summary>
    /// Gets the computer.
    /// </summary>
    /// <returns></returns>
    public override Computer GetComputer()
    {
        return new Pc(ram, hdd, cpu);
    }
}
