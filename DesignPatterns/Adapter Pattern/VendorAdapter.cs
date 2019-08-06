// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VendorAdapter.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
/// <summary>
/// VendorAdapter is a class.
/// </summary>
public class VendorAdapter
{
    /// <summary>
    /// Gets the list of products.
    /// </summary>
    /// <returns></returns>
    public List<string> GetListOfProducts()
    {
        ////using list collections by creating the object.
        List<string> products = new List<string>();

        ////Adding of products in the List.
        products.Add("FZ");
        products.Add("R15");
        products.Add("Royal Enfield");
        return products;
    }
}
