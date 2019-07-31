// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryStructure.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Defines the structure of the inventory
/// </summary>
public class InventoryStructure
{
    /// <summary>
    /// The rice list
    /// </summary>
    private List<Rice> riceList = new List<Rice>();

    /// <summary>
    /// The wheat list
    /// </summary>
    private List<Wheat> wheatList = new List<Wheat>();

    /// <summary>
    /// The pulses list
    /// </summary>
    private List<Pulses> pulsesList = new List<Pulses>();

    /// <summary>
    /// Gets or sets the rice list.
    /// </summary>
    /// <value>
    /// The rice list.
    /// </value>
    public List<Rice> RiceList
    {
        get
        {
            return this.riceList;
        }

        set
        {
            this.riceList = value;
        }
    }

    /// <summary>
    /// Gets or sets the wheat list.
    /// </summary>
    /// <value>
    /// The wheat list.
    /// </value>
    public List<Wheat> WheatList
    {
        get
        {
            return this.wheatList;
        }

        set
        {
            this.wheatList = value;
        }
    }

    /// <summary>
    /// Gets or sets the pulses list.
    /// </summary>
    /// <value>
    /// The pulses list.
    /// </value>
    public List<Pulses> PulsesList
    {
        get
        {
            return this.pulsesList;
        }

        set
        {
            this.pulsesList = value;
        }
    }
}