// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Rectangle.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Rectangle is a class which implements IShape interface.
/// </summary>
public class Rectangle : IShape
{
    /// <summary>
    /// Gets or sets the length.
    /// </summary>
    /// <value>
    /// The length.
    /// </value>
    public double Length
    {
        get;
        set;
    }
    /// <summary>
    /// Gets or sets the breadth.
    /// </summary>
    /// <value>
    /// The breadth.
    /// </value>
    public double Breadth
    {
        get;
        set;
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="Rectangle"/> class.
    /// </summary>
    public Rectangle()
    {

    }
    /// <summary>
    /// Initializes a new instance of the <see cref="Rectangle"/> class.
    /// </summary>
    /// <param name="length">The length.</param>
    /// <param name="breadth">The breadth.</param>
    public Rectangle(double length,double breadth)
    {
        this.Length = length;
        this.Breadth = breadth;
    }
    /// <summary>
    /// Detailses this instance.
    /// </summary>
    public void Details()
    {
        Console.WriteLine("This is Actual Rectangle");
    }
    /// <summary>
    /// Gets the area.
    /// </summary>
    /// <returns></returns>
    public double GetArea()
    {
        return Length * Breadth;
    }
    /// <summary>
    /// Gets the shape.
    /// </summary>
    /// <returns></returns>
    public string GetShape()
    {
        return "This is the Rectangle from actual class";
    }
}
