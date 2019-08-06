// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcreteObserver.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// ConcreteObserver is a class which implements interface IObserver.
/// </summary>
class ConcreteObserver : IObserver
{
    /// <summary>
    /// The name
    /// </summary>
    public string name = "";
    /// <summary>
    /// The text
    /// </summary>
    public string text = "";
    /// <summary>
    /// The subject
    /// </summary>
    private ConcreteSubject subject;

    /// <summary>
    /// Initializes a new instance of the <see cref="ConcreteObserver"/> class.
    /// </summary>
    /// <param name="_subject">The subject.</param>
    /// <param name="_name">The name.</param>
    public ConcreteObserver(ConcreteSubject _subject, string _name)
    {
        subject = _subject;
        text = subject.Text;
        name = _name;
    }

    /// <summary>
    /// Updates this instance.
    /// </summary>
    public void Update()
    {
        Console.WriteLine(name + " detected a change from: " + text + " to " + subject.Text);
        text = subject.Text;
    }
}
