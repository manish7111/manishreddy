// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InputForInventory.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Text.RegularExpressions;

/// <summary>
/// Take Input from user to make changes in inventory
/// </summary>
public class InputForInventory
{
    /// <summary>
    /// Takes input from user to create objects
    /// </summary>
    /// <param name="inventoryType">inventory Type</param>
    public static void TakeInputsForCreatingObject(string inventoryType)
    {
        string name = null;
        double weight = 0;
        double pricePerKG = 0;

        ////Validate name entered by user
        while (true)
        {
            Console.WriteLine("\nEnter the Name for " + inventoryType);
            name = Console.ReadLine();

            if (InventoryMngtUtility.ContainsCharacter(name))
            {
                Console.WriteLine("\nCharacter not allowed");
                continue;
            }

            if (InventoryMngtUtility.ContainsDigit(name))
            {
                Console.WriteLine("\nDigits not allowed");
                continue;
            }

            if (InventoryMngtUtility.CheckString(name))
            {
                Console.WriteLine("\nYou should Specify a name");
                continue;
            }

            break;
        }

        ////Validate weight entered by user
        while (true)
        {
            Console.WriteLine("\nEnter the Weight");
            string stringWeight = Console.ReadLine();

            try
            {
                weight = Convert.ToDouble(stringWeight);
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("\nInvalid Input For Weight");
                continue;
            }
        }

        ////Validate price entered by user
        while (true)
        {
            Console.WriteLine("\nSpecify Price per Kg");
            string stringPrice = Console.ReadLine();
            try
            {
                pricePerKG = Convert.ToDouble(stringPrice);
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("\nInvalid Input For Price Per KG");
                continue;
            }
        }

        //// Checks For Which Inventory Item Object should be created.
        if (inventoryType.Equals("RICE"))
        {
            Rice.CreateRiceObject(name, weight, pricePerKG);
        }

        //// Checks For Which Inventory Item Object should be created.
        if (inventoryType.Equals("WHEAT"))
        {
            Wheat.CreateWheatObject(name, weight, pricePerKG);
        }

        //// Checks For Which Inventory Item Object should be created.
        if (inventoryType.Equals("PULSES"))
        {
            Pulses.CreatePulsesObject(name, weight, pricePerKG);
        }
    }

    /// <summary>
    /// Takes Input necessary for Removing a object from inventory.
    /// </summary>
    /// <param name="inventoryType">inventory type</param>
    public static void TakeInputForRemovingObject(string inventoryType)
    {
        while (true)
        {
            Console.WriteLine("\nEnter the Item name you want to remove : ");
            string itemName = Console.ReadLine();
            if (inventoryType.Equals("RICE"))
            {
                Rice.RemoveRiceObject(itemName);
            }

            if (inventoryType.Equals("WHEAT"))
            {
                Wheat.RemoveWheatObject(itemName);
            }

            if (inventoryType.Equals("PULSES"))
            {
                Pulses.RemovePulseObject(itemName);
            }

            break;
        }
    }
}