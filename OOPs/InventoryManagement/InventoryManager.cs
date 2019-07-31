// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Manager to manage whole inventory operations
/// </summary>
public class InventoryManager
{
    /// <summary>
    /// Gets the inventory list.
    /// </summary>
    /// <param name="inventoryType">Type of the inventory.</param>
    public static void GetInventoryList(string inventoryType)
    {
        ////Getting Inventory Objects from the inventory factory.
        InventoryStructure inventoryTypes = InventoryFactory.ReadJsonFile();

        ////Print details of type choosen by user
        if (inventoryType.Equals("RICE"))
        {
            List<Rice> riceList = inventoryTypes.RiceList;
            foreach (Rice rice in riceList)
            {
                Console.WriteLine("\nRice type : ");
                Console.WriteLine("Name : " + rice.Name + "\nWeight : " + rice.Weight + "\nPrice per Kg : " + rice.PricePerKg);
                Console.WriteLine("Total price of " + rice.Name + " : " + (rice.Weight * rice.PricePerKg));
                Console.WriteLine("*********************************");
            }

            return;
        }

        if (inventoryType.Equals("WHEAT"))
        {
            List<Wheat> wheatList = inventoryTypes.WheatList;
            foreach (Wheat wheat in wheatList)
            {
                Console.WriteLine("\nWheat type");
                Console.WriteLine("Name : " + wheat.Name + "\nWeight : " + wheat.Weight + "\nPrice per Kg : " + wheat.PricePerKg);
                Console.WriteLine("Total price of " + wheat.Name + " = " + (wheat.Weight * wheat.PricePerKg));
                Console.WriteLine("*********************************");
            }

            return;
        }

        if (inventoryType.Equals("PULSES"))
        {
            List<Pulses> pulsesList = inventoryTypes.PulsesList;
            foreach (Pulses pulse in pulsesList)
            {
                Console.WriteLine("Pulse type");
                Console.WriteLine("Name : " + pulse.Name + "\nWeight : " + pulse.Weight + "\nPrice per Kg : " + pulse.PricePerKg);
                Console.WriteLine("Total price of " + pulse.Name + " = " + (pulse.Weight * pulse.PricePerKg));
                Console.WriteLine("*********************************");
            }
        }
    }
}