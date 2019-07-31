// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CompanyShares.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// store properties of Shares of Company
/// </summary>
public class CompanyShares
{
    /// <summary>
    /// The number of shares
    /// </summary>
    private long numberOfShares;

    /// <summary>
    /// The price of share
    /// </summary>
    private double priceOfShare;

    /// <summary>
    /// The symbol
    /// </summary>
    private string symbol;

    /// <summary>
    /// The datetime
    /// </summary>
    private string dateTime;

    /// <summary>
    /// Initializes a new instance of the <see cref="CompanyShares"/> class.
    /// </summary>
    /// <param name="numberOfShares">The number of shares.</param>
    /// <param name="price">The price.</param>
    /// <param name="symbol">The symbol.</param>
    /// <param name="datetime">The datetime.</param>
    public CompanyShares(long numberOfShares, double price, string symbol, string datetime)
    {
        this.numberOfShares = numberOfShares;
        this.priceOfShare = price;
        this.symbol = symbol;
        this.dateTime = datetime;
    }

    /// <summary>
    /// Gets or sets the number of shares.
    /// </summary>
    /// <value>
    /// The number of shares.
    /// </value>
    public long NumberOfShares
    {
        get
        {
            return this.numberOfShares;
        }

        set
        {
            this.numberOfShares = value;
        }
    }

    /// <summary>
    /// Gets or sets the price of share.
    /// </summary>
    /// <value>
    /// The price of share.
    /// </value>
    public double PriceOfShare
    {
        get
        {
            return this.priceOfShare;
        }

        set
        {
            this.priceOfShare = value;
        }
    }

    /// <summary>
    /// Gets or sets the symbol.
    /// </summary>
    /// <value>
    /// The symbol.
    /// </value>
    public string Symbol
    {
        get
        {
            return this.symbol;
        }

        set
        {
            this.symbol = value;
        }
    }

    /// <summary>
    /// Gets or sets the date time.
    /// </summary>
    /// <value>
    /// The date time.
    /// </value>
    public string DateTime
    {
        get
        {
            return this.dateTime;
        }

        set
        {
            this.dateTime = value;
        }
    }
}