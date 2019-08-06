// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Hdfc.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Hdfc is a class which implements abstract class CreditCard.
/// </summary>
public class Hdfc : CreditCard
{
    /// <summary>
    /// The card type
    /// </summary>
    private readonly string cardType;
    /// <summary>
    /// The credit limit
    /// </summary>
    private int creditLimit;
    /// <summary>
    /// The annual charge
    /// </summary>
    private int annualCharge;
    /// <summary>
    /// Initializes a new instance of the <see cref="Hdfc"/> class.
    /// </summary>
    /// <param name="_creditLimit">The credit limit.</param>
    /// <param name="_annualCharge">The annual charge.</param>
    public Hdfc(int _creditLimit, int _annualCharge)
    {
        cardType = "HDFC";
        creditLimit = _creditLimit;
        annualCharge = _annualCharge;
    }
    /// <summary>
    /// Gets the type of the card.
    /// </summary>
    /// <value>
    /// The type of the card.
    /// </value>
    public override string CardType
    {
        get
        {
            return cardType;
        }
    }
    /// <summary>
    /// Gets or sets the credit limit.
    /// </summary>
    /// <value>
    /// The credit limit.
    /// </value>
    public override int CreditLimit
    {
        get
        {
            return creditLimit;
        }
        set
        {
            creditLimit = value;
        }
    }
    /// <summary>
    /// Gets or sets the annual charge.
    /// </summary>
    /// <value>
    /// The annual charge.
    /// </value>
    public override int AnnualCharge
    {
        get
        {
            return annualCharge;
        }
        set
        {
            annualCharge = value;
        }
    }
}
