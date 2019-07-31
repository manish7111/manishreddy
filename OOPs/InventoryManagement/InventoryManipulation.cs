// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryManipulation.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// To manipulate the existing data by adding or removing or changing the name of the item  
/// </summary>
public class InventoryManipulation
{
    /// <summary>
    /// Makes the changes.
    /// </summary>
    /// <param name="inventoryType">Type of the inventory.</param>
    /// <param name="itemName">Name of the item.</param>
    public static void ChangeName(string inventoryType, string itemName)
    {
        string newName;
        while (true)
        {
            Console.WriteLine("\nEnter the New name for " + inventoryType);
            newName = Console.ReadLine();

            if (InventoryMngtUtility.ContainsCharacter(newName))
            {
                Console.WriteLine("\nNo Character Allowed");
                continue;
            }


            if (InventoryMngtUtility.ContainsDigit(newName))
            {
                Console.WriteLine("\nNo Digits Allowed");
                continue;
            }

            if (InventoryMngtUtility.CheckString(newName))
            {
                Console.WriteLine("\nYou should Specify a name");
                continue;
            }

            break;
        }

        InventoryStructure inventoryTypes = InventoryFactory.ReadJsonFile();

        if (inventoryType.Equals("RICE"))
        {
            List<Rice> riceList = inventoryTypes.RiceList;

            foreach (Rice rice in riceList)
            {
                if (rice.Name.Equals(itemName))
                {
                    rice.Name = newName;
                    break;
                }
            }

            InventoryMngtUtility.WriteToFile(inventoryTypes);
            Console.WriteLine("\nUpdated successfully");
        }

        if (inventoryType.Equals("WHEAt"))
        {
            List<Wheat> wheatList = inventoryTypes.WheatList;

            foreach (Wheat wheat in wheatList)
            {
                if (wheat.Name.Equals(itemName))
                {
                    wheat.Name = newName;
                    break;
                }
            }

            InventoryMngtUtility.WriteToFile(inventoryTypes);
            Console.WriteLine("\nUpdated successfully");
        }

        if (inventoryType.Equals("PULSES"))
        {
            List<Pulses> pulseList = inventoryTypes.PulsesList;

            foreach (Pulses pulse in pulseList)
            {
                if (pulse.Name.Equals(itemName))
                {
                    pulse.Name = newName;
                    break;
                }
            }

            InventoryMngtUtility.WriteToFile(inventoryTypes);
            Console.WriteLine("\nUpdated successfully");
        }
    }

    /// <summary>
    /// Changes the weight.
    /// </summary>
    /// <param name="inventoryType">Type of the inventory.</param>
    /// <param name="itemName">Name of the item.</param>
    public static void ChangeWeight(string inventoryType, string itemName)
    {
        double newWeight;
        InventoryStructure inventoryTypes = InventoryFactory.ReadJsonFile();

        while (true)
        {
            Console.WriteLine("\nEnter the Weight");
            string stringWeight = Console.ReadLine();

            try
            {
                newWeight = Convert.ToDouble(stringWeight);
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("\nInvalid Input For Weight");
                continue;
            }
        }

        if (inventoryType.Equals("RICE"))
        {
            List<Rice> riceList = inventoryTypes.RiceList;

            foreach (Rice rice in riceList)
            {
                if (rice.Name.Equals(itemName))
                {
                    rice.Weight = newWeight;
                    break;
                }
            }

            InventoryMngtUtility.WriteToFile(inventoryTypes);
            Console.WriteLine("\nUpdated successfully");
        }

        if (inventoryType.Equals("WHEAt"))
        {
            List<Wheat> wheatList = inventoryTypes.WheatList;

            foreach (Wheat wheat in wheatList)
            {
                if (wheat.Name.Equals(itemName))
                {
                    wheat.Weight = newWeight;
                    break;
                }
            }

            InventoryMngtUtility.WriteToFile(inventoryTypes);
            Console.WriteLine("\nUpdated successfully");
        }

        if (inventoryType.Equals("PULSES"))
        {
            List<Pulses> pulseList = inventoryTypes.PulsesList;

            foreach (Pulses pulse in pulseList)
            {
                if (pulse.Name.Equals(itemName))
                {
                    pulse.Weight = newWeight;
                    break;
                }
            }

            InventoryMngtUtility.WriteToFile(inventoryTypes);
            Console.WriteLine("\nUpdated successfully");
        }
    }

    /// <summary>
    /// Changes the price.
    /// </summary>
    /// <param name="inventoryType">Type of the inventory.</param>
    /// <param name="itemName">Name of the item.</param>
    public static void ChangePrice(string inventoryType, string itemName)
    {
        double newPricePerKG;
        InventoryStructure inventoryTypes = InventoryFactory.ReadJsonFile();

        while (true)
        {
            Console.WriteLine("\nSpecify Price per Kg");
            string stringPrice = Console.ReadLine();
            try
            {
                newPricePerKG = Convert.ToDouble(stringPrice);
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("\nInvalid Input For Price Per KG");
                continue;
            }
        }

        if (inventoryType.Equals("RICE"))
        {
            List<Rice> riceList = inventoryTypes.RiceList;

            foreach (Rice rice in riceList)
            {
                if (rice.Name.Equals(itemName))
                {
                    rice.PricePerKg = newPricePerKG;
                    break;
                }
            }

            InventoryMngtUtility.WriteToFile(inventoryTypes);
            Console.WriteLine("\nUpdated successfully");
        }

        if (inventoryType.Equals("WHEAt"))
        {
            List<Wheat> wheatList = inventoryTypes.WheatList;

            foreach (Wheat wheat in wheatList)
            {
                if (wheat.Name.Equals(itemName))
                {
                    wheat.PricePerKg = newPricePerKG;
                    break;
                }
            }

            InventoryMngtUtility.WriteToFile(inventoryTypes);
            Console.WriteLine("\nUpdated successfully");
        }

        if (inventoryType.Equals("PULSES"))
        {
            List<Pulses> pulseList = inventoryTypes.PulsesList;

            foreach (Pulses pulse in pulseList)
            {
                if (pulse.Name.Equals(itemName))
                {
                    pulse.PricePerKg = newPricePerKG;
                    break;
                }
            }

            InventoryMngtUtility.WriteToFile(inventoryTypes);
            Console.WriteLine("\nUpdated successfully");
        }
    }
}