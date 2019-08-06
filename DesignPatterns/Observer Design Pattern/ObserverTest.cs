// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ObserverTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// ObserverServer is a class where i declared Display method.
/// </summary>
public class ObserverTest
{
    /// <summary>
    /// Displays this instance.
    /// </summary>
    public static void Display()
    {
        ////creating the object for ConcreteSubject class.
        ConcreteSubject subject = new ConcreteSubject("hello");

        ////Creating the object for ConcreteObserver class.
        ConcreteObserver observerOne = new ConcreteObserver(subject, "One");
        ConcreteObserver observerTwo = new ConcreteObserver(subject, "Two");
        subject.Attach(observerOne);
        subject.Attach(observerTwo);
        subject.Text = "Hello World!";
    }
   
}
