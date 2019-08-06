// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IStore.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// IStore is an interface.
/// </summary>
public interface IStore
{
    /// <summary>
    /// Visits the specified visitor.
    /// </summary>
    /// <param name="visitor">The visitor.</param>
    void Visit(IVisitor visitor);
}
