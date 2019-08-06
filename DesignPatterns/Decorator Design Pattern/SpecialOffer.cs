// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SpecialOffer.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// SpecialOffer is a class which is implementing VehicleDecorator.
/// </summary>
class SpecialOffer : VehicleDecorator
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SpecialOffer"/> class.
    /// </summary>
    /// <param name="vehicle">The vehicle.</param>
    public SpecialOffer(IVehicle1 vehicle) : base(vehicle)
    {

    }
    /// <summary>
    /// Gets or sets the discount.
    /// </summary>
    /// <value>
    /// The discount.
    /// </value>
    public int Discount
    {
        get;
        set;
    }
    /// <summary>
    /// Gets or sets the offer.
    /// </summary>
    /// <value>
    /// The offer.
    /// </value>
    public string Offer
    {
        get;
        set;
    }
    /// <summary>
    /// Gets the price.
    /// </summary>
    /// <value>
    /// The price.
    /// </value>
    public new double Price
    {
        get
        {
            double price = base.Price;

            ////calculating the final price.
            double finalPrice = price-(price * Discount / 100);
            return finalPrice;
        }
    }
}

