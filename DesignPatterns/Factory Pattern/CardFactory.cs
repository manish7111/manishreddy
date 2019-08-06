// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CardFactory.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;

/// <summary>
/// CardFactory is an abstract class.
/// </summary>
public abstract class CardFactory
{
    /// <summary>
    /// Gets the credit card.
    /// </summary>
    /// <returns></returns>
    public abstract CreditCard GetCreditCard();
}
