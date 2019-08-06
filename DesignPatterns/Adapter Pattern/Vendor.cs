// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Vendor.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
/// <summary>
/// Vendor is a class which implements interface vehicle.
/// </summary>
public class Vendor : IVehicle
{
    /// <summary>
    /// Gets the products.
    /// </summary>
    /// <returns></returns>
    public List<string> GetProducts()
    {

        ////creating the object for Vendor Adapter and returning the list of products present in the Vendor Adapter.
        VendorAdapter adapter = new VendorAdapter();
        return adapter.GetListOfProducts();
    }
}
