// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Square.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Square is a class which implements interface IShape.
/// </summary>
public class Square : IShape
{
    /// <summary>
    /// Gets or sets the side.
    /// </summary>
    /// <value>
    /// The side.
    /// </value>
    public double Side
    {
        get;
        set;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Square"/> class.
    /// </summary>
    public Square()
    {

    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Square"/> class.
    /// </summary>
    /// <param name="side">The side.</param>
    public Square(double side)
    {
        this.Side = side;
    }

    /// <summary>
    /// Detailses this instance.
    /// </summary>
    public void Details()
    {
        Console.WriteLine("This is Actual Square");
    }

    /// <summary>
    /// Gets the area.
    /// </summary>
    /// <returns></returns>
    public double GetArea()
    {
        return Side * Side;
    }

    /// <summary>
    /// Gets the shape.
    /// </summary>
    /// <returns></returns>
    public string GetShape()
    {
        return "This is the Square from actual class";
    }
}
