// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcreteSubject.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// ConcreteSubject is a class which implements subject abstract class.
/// </summary>
class ConcreteSubject : Subject
{
    /// <summary>
    /// The text
    /// </summary>
    public string text;

    /// <summary>
    /// Initializes a new instance of the <see cref="ConcreteSubject"/> class.
    /// </summary>
    /// <param name="_text">The text.</param>
    public ConcreteSubject(string _text)
    {
        text = _text;
    }

    /// <summary>
    /// Gets or sets the text.
    /// </summary>
    /// <value>
    /// The text.
    /// </value>
    public string Text
    {
        get
        {
            return text;
        }
        set
        {
            text = value;
            ////calling of notify method.
            Notify();
        }
    }
}
