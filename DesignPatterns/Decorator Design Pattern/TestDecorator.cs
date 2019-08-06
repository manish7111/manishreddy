// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TestDecorator.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// TestDecorator is a class where i declared Display method.
/// </summary>
public class TestDecorator
{
    /// <summary>
    /// Displays this instance.
    /// </summary>
    public static void Display()
    {

        ////Calling the HondaCity class by creating the object.
        HondaCity hondaCity = new HondaCity();
        Console.WriteLine("HondaCity normal price without discount is :" + hondaCity.Price);
        ////creating the object for specialoffer class.
        SpecialOffer specialOffer = new SpecialOffer(hondaCity);
        specialOffer.Discount = 20;
        specialOffer.Offer = "20% Discount";
        Console.WriteLine("{1} Diwali offer and price is {0}", specialOffer.Price, specialOffer.Offer);
    }
}

