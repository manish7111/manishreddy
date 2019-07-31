// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryFactory.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.IO;
using Newtonsoft.Json;

/// <summary>
/// Inventory factory to store data read from file into Inventory
/// </summary>
public class InventoryFactory
{
    /// <summary>
    /// The path of input file
    /// </summary>
    

    /// <summary>
    /// Reads the file.
    /// </summary>
    /// <returns>returns Inventory details</returns>
    public static InventoryStructure ReadJsonFile()
    {
        ////checks Wheather File Exist or Not.
        if (File.Exists(@"C:\Users\Admin\source\repos\OOPs\InventoryManagement\json1.json"))
        {
            ////Read data from file in string variable
            string jsonData = File.ReadAllText(@"C:\Users\Admin\source\repos\OOPs\InventoryManagement\json1.json");

            ////Getting the inventoryTypes Object from the  JSon String.
            InventoryStructure jsonObjectArray = JsonConvert.DeserializeObject<InventoryStructure>(jsonData);
            return jsonObjectArray;
        }
        else
        {
            Console.WriteLine("\nSpecified file path does not exist");

            ////return new empty inventory
            return new InventoryStructure();
        }
    }
}