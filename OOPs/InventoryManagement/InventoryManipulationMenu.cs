// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryManipulationMenu.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Menu to do manipulations in inventory
/// </summary>
public class InventoryManipulationMenu
{
    /// <summary>
    /// Method to show manipulation view.
    /// </summary>
    /// <param name="inventoryType">Type of the inventory.</param>
    public static void InventoryManipulationview(string inventoryType)
    {
        Console.WriteLine("\nEnter the Item Name you Want to Edit");
        string itemName = Console.ReadLine();

        if (inventoryType.Equals("RICE"))
        {
            if (Rice.DoesObjectExist(itemName) == false)
            {
                Console.WriteLine("\nitem " + itemName + " does not exist");
                return;
            }
        }

        if (inventoryType.Equals("WHEAT"))
        {
            if (Wheat.DoesObjectExist(itemName) == false)
            {
                Console.WriteLine("\nitem " + itemName + " does not exist");
                return;
            }
        }

        if (inventoryType.Equals("PULSES"))
        {
            if (Pulses.DoesObjectExist(itemName) == false)
            {
                Console.WriteLine("\nitem " + itemName + " does not exist");
                return;
            }
        }

        EditMenu(inventoryType, itemName);
    }

    /// <summary>
    /// Edits the menu.
    /// </summary>
    /// <param name="inventoryType">Type of the inventory.</param>
    /// <param name="itemName">Name of the item.</param>
    public static void EditMenu(string inventoryType, string itemName)
    {
        while (true)
        {

            Console.WriteLine("1.Name");
            Console.WriteLine("2.Weight");
            Console.WriteLine("3.Price Per Kg");
            Console.WriteLine("\nChoose the property you want to edit");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    {
                        InventoryManipulation.ChangeName(inventoryType, itemName);
                        break;
                    }

                case "2":
                    {
                        InventoryManipulation.ChangeWeight(inventoryType, itemName);
                        break;
                    }

                case "3":
                    {
                        InventoryManipulation.ChangePrice(inventoryType, itemName);
                        break;
                    }

                default:
                    return;
            }
        }
    }
}