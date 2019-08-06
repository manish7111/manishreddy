// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Client.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Client is a class.
/// </summary>
public class Client
{
    /// <summary>
    /// The rbi
    /// </summary>
    private IRbi rbi;
    /// <summary>
    /// Initializes a new instance of the <see cref=".Client"/> class.
    /// </summary>
    /// <param name="_rbi">The rbi.</param>
    public Client(IRbi _rbi)
    {
        rbi = _rbi;
    }
    /// <summary>
    /// Intrests this instance.
    /// </summary>
    public void Intrest()
    {
        rbi.GetRateOfIntrest();
    }
}
