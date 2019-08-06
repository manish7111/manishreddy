// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProxySquare.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// ProxySquare is a class.
/// </summary>
public class ProxySquare : IShape
{
    /// <summary>
    /// The shape
    /// </summary>
    IShape shape;
    /// <summary>
    /// Detailses this instance.
    /// </summary>
    public void Details()
    {
        Console.WriteLine("This is proxy Square class");
    }
    /// <summary>
    /// Gets the area.
    /// </summary>
    /// <returns></returns>
    public double GetArea()
    {
        shape = new Square(10);
        return shape.GetArea();
    }
    /// <summary>
    /// Gets the shape.
    /// </summary>
    /// <returns></returns>
    public string GetShape()
    {
        shape = new Square();
        return shape.GetShape();

    }
}
