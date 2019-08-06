// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Circle.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Circle is a class which implements interface IShape.
/// </summary>
public class Circle : IShape
{
    /// <summary>
    /// Gets or sets the radius.
    /// </summary>
    /// <value>
    /// The radius.
    /// </value>
    public double Radius
    {
        get;
        set;
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="Circle"/> class.
    /// </summary>
    public Circle()
    {

    }
    /// <summary>
    /// Initializes a new instance of the <see cref="Circle"/> class.
    /// </summary>
    /// <param name="side">The side.</param>
    public Circle(double side)
    {
        this.Radius = side;
    }
    /// <summary>
    /// Detailses this instance.
    /// </summary>
    public void Details()
    {
        Console.WriteLine("This is Actual Circle");
    }
    /// <summary>
    /// Gets the area.
    /// </summary>
    /// <returns></returns>
    public double GetArea()
    {
        return (3.14 * Radius * Radius);
    }
    /// <summary>
    /// Gets the shape.
    /// </summary>
    /// <returns></returns>
    public string GetShape()
    {
        return "This is the Circle from actual class";
    }
}
