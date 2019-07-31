// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Pulses.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// class to store pulses data
/// </summary>
public class Pulses
{
    /// <summary>
    /// The name
    /// </summary>
    private string name;

    /// <summary>
    /// The weight
    /// </summary>
    private double weight;

    /// <summary>
    /// The price per kg
    /// </summary>
    private double pricePerKG;

    /// <summary>
    /// Initializes a new instance of the <see cref="Pulses"/> class.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <param name="weight">The weight.</param>
    /// <param name="pricePerKG">The price per kg.</param>
    public Pulses(string name, double weight, double pricePerKG)
    {
        this.name = name;
        this.weight = weight;
        this.pricePerKG = pricePerKG;
    }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>
    /// The name.
    /// </value>
    public string Name
    {
        get
        {
            return this.name;
        }

        set
        {
            this.name = value;
        }
    }

    /// <summary>
    /// Gets or sets the weight.
    /// </summary>
    /// <value>
    /// The weight.
    /// </value>
    public double Weight
    {
        get
        {
            return this.weight;
        }

        set
        {
            this.weight = value;
        }
    }

    /// <summary>
    /// Gets or sets the price per kg.
    /// </summary>
    /// <value>
    /// The price per kg.
    /// </value>
    public double PricePerKg
    {
        get
        {
            return this.pricePerKG;
        }

        set
        {
            this.pricePerKG = value;
        }
    }

    /// <summary>
    /// Creates the pulses object.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <param name="weight">The weight.</param>
    /// <param name="pricePerKG">The price per kg.</param>
    public static void CreatePulsesObject(string name, double weight, double pricePerKG)
    {
        Pulses pulse = new Pulses(name, weight, pricePerKG);
        InventoryStructure inventoryTypes = InventoryFactory.ReadJsonFile();
        inventoryTypes.PulsesList.Add(pulse);
        InventoryMngtUtility.WriteToFile(inventoryTypes);
        Console.WriteLine("Added To inventory Succefully");
    }

    /// <summary>
    /// Removes the pulses object.
    /// </summary>
    /// <param name="itemName">Name of the item.</param>
    public static void RemovePulseObject(string itemName)
    {
        InventoryStructure inventoryTypes = InventoryFactory.ReadJsonFile();
        List<Pulses> pulseList = inventoryTypes.PulsesList;

        foreach (Pulses pulse in pulseList)
        {
            if (pulse.Name.Equals(itemName))
            {
                pulseList.Remove(pulse);
                InventoryMngtUtility.WriteToFile(inventoryTypes);
                Console.WriteLine("Item " + itemName + "removed Successfully");
                Console.WriteLine("--------------------------------------------");

                return;
            }
        }

        Console.WriteLine("Item " + itemName + "to be removed not found");
    }

    /// <summary>
    /// Does the object exist.
    /// </summary>
    /// <param name="itemName">Name of the item.</param>
    /// <returns>returns true or false</returns>
    public static bool DoesObjectExist(string itemName)
    {
        InventoryStructure inventoryTypes = InventoryFactory.ReadJsonFile();
        List<Pulses> pulseList = inventoryTypes.PulsesList;

        foreach (Pulses pulse in pulseList)
        {
            if (pulse.Name.Equals(itemName))
            {
                return true;
            }
        }

        return false;
    }

    /// <summary>
    /// Converts to string.
    /// </summary>
    /// <returns>
    /// A <see cref="System.String" /> that represents this instance.
    /// </returns>
    public override string ToString()
    {
        return "Name  : " + this.Name + "\nWeight : " + this.Weight + "\nPrice Per Kg : " + this.pricePerKG;
    }
}