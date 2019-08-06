// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AxisCardFactory.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;

/// <summary>
/// AxisCardFactory is a class which implements CardFactory.
/// </summary>
public class AxisCardFactory : CardFactory
{
    /// <summary>
    /// The credit limit
    /// </summary>
    private int creditLimit;

    /// <summary>
    /// The annual charge
    /// </summary>
    private int annualCharge;

    /// <summary>
    /// Initializes a new instance of the <see cref="AxisCardFactory"/> class.
    /// </summary>
    /// <param name="_creditLimit">The credit limit.</param>
    /// <param name="_annualCharge">The annual charge.</param>
    public AxisCardFactory(int _creditLimit,int _annualCharge)
    {
        creditLimit = _creditLimit;
        annualCharge = _annualCharge;
    }

    /// <summary>
    /// Gets the credit card.
    /// </summary>
    /// <returns></returns>
    public override CreditCard GetCreditCard()
    {
        return new Axis(creditLimit, annualCharge);
    }
}
