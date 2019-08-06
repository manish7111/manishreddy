// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PcFactory.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// PcFactory is a class which implements abstract class ComputerFactory.
/// </summary>
public class PcFactory : ComputerFactory
{
    /// <summary>
    /// The ram
    /// </summary>
    private string ram, hdd, cpu;

    /// <summary>
    /// Initializes a new instance of the <see cref="PcFactory"/> class.
    /// </summary>
    /// <param name="_ram">The ram.</param>
    /// <param name="_hdd">The HDD.</param>
    /// <param name="_cpu">The cpu.</param>
    public PcFactory(string _ram,string _hdd,string _cpu)
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
        return new Pc(ram,hdd,cpu);
    }
}
