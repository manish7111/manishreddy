// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreditCard.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;

/// <summary>
/// CreditCard is an abstract class.
/// </summary>
public abstract class CreditCard
{
    /// <summary>
    /// Gets the type of the card.
    /// </summary>
    /// <value>
    /// The type of the card.
    /// </value>
    public abstract string CardType
    {
        get;
    }

    /// <summary>
    /// Gets or sets the credit limit.
    /// </summary>
    /// <value>
    /// The credit limit.
    /// </value>
    public abstract int CreditLimit
    {
        get;
        set;
    }

    /// <summary>
    /// Gets or sets the annual charge.
    /// </summary>
    /// <value>
    /// The annual charge.
    /// </value>
    public abstract int AnnualCharge
    {
        get;
        set;
    }
}
