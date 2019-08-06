// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Subject.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
/// <summary>
/// Subject is a class.
/// </summary>
public abstract class Subject
{
    /// <summary>
    /// The observers
    /// </summary>
    private List<IObserver> observers = new List<IObserver>();

    /// <summary>
    /// Attaches the specified observer.
    /// </summary>
    /// <param name="observer">The observer.</param>
    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }

    /// <summary>
    /// Detaches the specified observer.
    /// </summary>
    /// <param name="observer">The observer.</param>
    public void Detach(IObserver observer)
    {
        observers.Remove(observer);
    }

    /// <summary>
    /// Notifies this instance.
    /// </summary>
    public void Notify()
    {

        ////foreach loop is used to update .
        foreach (IObserver observer in observers)
        {
            observer.Update();
        }
    }
}
