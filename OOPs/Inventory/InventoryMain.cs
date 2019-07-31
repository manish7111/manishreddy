// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryMain.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using Newtonsoft.Json;
using System.IO;
using OOPs;
using System.Collections.Generic;

/// <summary>
/// InventoryMain is a class where i defined the methods .
/// </summary>
public class InventoryMain
{
    /// <summary>
    /// The inventory class
    /// </summary>
    Inventory_Class inventory_Class = new Inventory_Class();

    /// <summary>
    /// Displays the data.
    /// </summary>
    /// <param name="filepath">The filepath.</param>
    /// <exception cref="Exception"></exception>
    public void DisplayData(string filepath)
    {
        try
        {
            ////StreamReader is used to read the file to the end.
            using (StreamReader read = new StreamReader(filepath))
            {
                ////Reading the file to the end
                var json = read.ReadToEnd();

                ////For deserializing the json object.
                var items = JsonConvert.DeserializeObject<List<Inventory_Class>>(json);
                Console.WriteLine("Name\tWeight\tRate\tAmount");
                foreach (var item in items)
                {

                    ////Printing the details using foreach loop
                    Console.WriteLine("{0}" + "\t" + "{1}" + "\t" + "{2}" + "\t" + "{3}", item.Name, item.Weight, item.PricePerKg, item.PricePerKg * item.Weight);
                }
            }
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}
   
