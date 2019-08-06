// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProxyCircle.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// ProxyCircle  is a class which implements interface IShape.
/// </summary>
public class ProxyCircle : IShape
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
        Console.WriteLine("This is proxy Circle class");
    }
    /// <summary>
    /// Gets the area.
    /// </summary>
    /// <returns></returns>
    public double GetArea()
    {
        shape = new Circle(15);
        return shape.GetArea();
    }
    /// <summary>
    /// Gets the shape.
    /// </summary>
    /// <returns></returns>
    public string GetShape()
    {
        shape = new Circle();
        return shape.GetShape();

    }
}
