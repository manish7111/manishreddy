// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryMenu.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Menu to perform operations on Inventory
/// </summary>
public class InventoryMenu
{
    /// <summary>
    /// Inventories the menu view.
    /// </summary>
    /// <param name="inventoryType">Type of the inventory.</param>
    public static void InventoryMenuview(string inventoryType)
    {
        int option = 0;
        while (true)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("1.To view Existing Inventory for " + inventoryType);
            Console.WriteLine("2.To Remove an " + inventoryType + " Item");
            Console.WriteLine("3.To Add " + inventoryType + " Item");
            Console.WriteLine("4.To Edit from Existing " + inventoryType + " Inventory");

            string stringOption = Console.ReadLine();

            if (InventoryMngtUtility.IsNumber(stringOption) == false)
            {
                Console.WriteLine("Invalid input");
                continue;
            }

            option = Convert.ToInt32(stringOption);

            //// Calls the mdethods based on the Option Choosen
            switch (option)
            {
                case 1:
                    InventoryManager.GetInventoryList(inventoryType);
                    break;

                case 2:
                    InputForInventory.TakeInputForRemovingObject(inventoryType);
                    break;

                case 3:
                    InputForInventory.TakeInputsForCreatingObject(inventoryType);
                    break;

                case 4:
                    InventoryManipulationMenu.InventoryManipulationview(inventoryType);
                    break;

                default:
                    return;
            }
        }
    }
}