// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VisitorPattern.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
/// <summary>
/// VisitorPattern is a class which is used as a execution class.
/// </summary>
public class VisitorPattern
{
    /// <summary>
    /// Displays the details.
    /// </summary>
    public static void DisplayDetails()
    {
        ////List comes under collections to store the Items of IStore in the list.
        List<IStore> store = new List<IStore>();

        ////Adding of car types in the list.
        store.Add(new Car() { CarName = "Audi", Price = 2000000, CarType = "Petrol" });
        store.Add(new Car() { CarName = "BMW", Price = 2500000, CarType = "Diesel" });

        ////Adding of Bike types in the list.
        store.Add(new Bike() { BikeName = "FZ", Price = 100000, BikeType = "Petrol" });
        store.Add(new Bike() { BikeName = "Fazer", Price = 110000, BikeType = "Petrol" });

        //Show price of each item
        Discount discount = new Discount();
        foreach (var element in store)
        {
            element.Visit(discount);
        }

        //Show milage of each item
        Milage milage = new Milage();
        foreach (var element in store)
        {
            element.Visit(milage);
        }
    }
}
