// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Customer.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Custormer is an class where i declared the methods ,properties and construtors.
/// </summary>
public class Customer
{
    /// <summary>
    /// Gets or sets the identifier.
    /// </summary>
    /// <value>
    /// The identifier.
    /// </value>
    public int Id
    {
        get;
        set;
    }
    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>
    /// The name.
    /// </value>
    public string Name
    {
        get;
        set;
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="Customer"/> class.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <param name="name">The name.</param>
    public Customer(int id, string name)
    {
        this.Id = id;
        this.Name = name;
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="Customer"/> class.
    /// </summary>
    public Customer()
    {
        this.Id = -1;
        this.Name = string.Empty;
    }
    /// <summary>
    /// Prints the identifier.
    /// </summary>
    public void PrintId()
    {
        Console.WriteLine("Id is:{0}", this.Id);
    }
    /// <summary>
    /// Prints the name.
    /// </summary>
    public void PrintName()
    {
        Console.WriteLine("Name is:{0}", this.Name);
    }
}
