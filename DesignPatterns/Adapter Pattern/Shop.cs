// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Shop.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Shop is a class where i declared a Static Buy method.
/// </summary>
public class Shop
{
    /// <summary>
    /// Buys this instance and display the products.
    /// </summary>
    /// <exception cref="Exception"></exception>
    public static void Buy()
	{
        ////try and catch is used to handle the exception.
        try
        {
            IVehicle vehicle = new Vendor();

            ////foreach loop is used to print the products present in the vehicle.
            foreach (string products in vehicle.GetProducts())
            {
                Console.WriteLine(products);
            }
        }catch(Exception e)
        {
            throw new Exception(e.Message);
        }
	}
}
