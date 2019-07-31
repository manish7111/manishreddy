// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBookDetails.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;

public class AddressBookDetails
{
    private string name;
    /// <summary>
    /// The number of share
    /// </summary>
    private long contactNumber;
    /// <summary>
    /// The share price
    /// </summary>
    private string address;
    /// <summary>
    /// The state
    /// </summary>
    private string state;
    /// <summary>
    /// The pin
    /// </summary>
    private long pin;
    /// <summary>
    /// Gets or sets the name of the stock.
    /// </summary>
    /// <value>
    /// The name of the stock.
    /// </value>
    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            this.name = value;
        }
    }
    /// <summary>
    /// Gets or sets the number of share.
    /// </summary>
    /// <value>
    /// The number of share.
    /// </value>
    public long ContactNumber
    {
        get
        {
            return this.contactNumber;
        }
        set
        {
            this.contactNumber = value;
        }
    }
    /// <summary>
    /// Gets or sets the share price.
    /// </summary>
    /// <value>
    /// The share price.
    /// </value>
    public string Address
    {
        get
        {
            return this.address;
        }
        set
        {
            this.address = value;
        }
    }
    public string State
    {
        get
        {
            return this.state;
        }
        set
        {
            this.state = value;
        }
    }
    public long Pin
    {
        get
        {
            return this.pin;
        }
        set
        {
            this.pin = value;
        }
    }
}

