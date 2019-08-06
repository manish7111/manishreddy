// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProxyRectangle.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// ProxyRectangle is a class which implements IShape interface.
/// </summary>
public class ProxyRectangle : IShape
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
        Console.WriteLine("This is proxy Rectangle class");
    }

    /// <summary>
    /// Gets the area.
    /// </summary>
    /// <returns></returns>
    public double GetArea()
    {
        shape = new Rectangle(10, 20);
        return shape.GetArea();
    }

    /// <summary>
    /// Gets the shape.
    /// </summary>
    /// <returns></returns>
    public string GetShape()
    {
        shape = new Rectangle();
        return shape.GetShape();
        
    }
}
