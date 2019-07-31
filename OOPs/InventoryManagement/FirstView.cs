// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FirstView.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// First Menu to be displayed to user
/// </summary>
public class FirstView
{
    /// <summary>
    /// Starts the inventory manager.
    /// </summary>
    public static void StartInventoryManager()
    {
        int choice = 0;
        while (true)
        {
            Console.WriteLine("1.Rice");
            Console.WriteLine("2.Wheat");
            Console.WriteLine("3.Pulses");
            Console.WriteLine("\nSelect an Inventory : ");
            string stringchoice = Console.ReadLine();

            ////validate number
            if (InventoryMngtUtility.IsNumber(stringchoice) == false)
            {
                Console.WriteLine("\nInvalid Input");
                continue;
            }

            ////Convert to integer
            choice = Convert.ToInt32(stringchoice);

            ////Calls the metods base on the Choosen choice.
            switch (choice)
            {
                case 1:
                    InventoryMenu.InventoryMenuview("RICE");
                    break;

                case 2:
                    InventoryMenu.InventoryMenuview("WHEAT");
                    break;

                case 3:
                    InventoryMenu.InventoryMenuview("PULSES");
                    break;

                default:
                    return;
            }
        }
    }
}