// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TestShape.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// TestShape is a class where i declared DisplayShape method.
/// </summary>
public class TestShape
{
    /// <summary>
    /// Displays the shape.
    /// </summary>
    /// <exception cref="Exception"></exception>
    public static void DisplayShape()
    {
        Console.WriteLine("Enter option to get the details");
        Console.WriteLine("1.Rectangle.\n2.Square.\n3.Circle.");
        int option = Convert.ToInt32(Console.ReadLine());

        ////try and catch is used to handle the exception.
        try
        {
            switch (option)
            {
                case 1:

                    ////Creating the object of ProxyRectangle class.
                    ProxyRectangle proxyRectangle = new ProxyRectangle();
                    proxyRectangle.Details();
                    string rectangleDetails = proxyRectangle.GetShape();
                    Console.WriteLine(rectangleDetails);
                    double rectangleArea = proxyRectangle.GetArea();
                    Console.WriteLine("Area of Rectangle is: " + rectangleArea);
                    break;
                case 2:

                    ////Creating the object of ProxySquare class.
                    ProxySquare proxySquare = new ProxySquare();
                    proxySquare.Details();
                    string squareDetails = proxySquare.GetShape();
                    Console.WriteLine(squareDetails);
                    double squareArea = proxySquare.GetArea();
                    Console.WriteLine("Area of Square is: " + squareArea);
                    break;
                case 3:

                    ////Creating the object of ProxyCircle class.
                    ProxyCircle proxyCircle = new ProxyCircle();
                    proxyCircle.Details();
                    string circleDetails = proxyCircle.GetShape();
                    Console.WriteLine(circleDetails);
                    double circleArea = proxyCircle.GetArea();
                    Console.WriteLine("Area of Circle is: " + circleArea);
                    break;
            }

            ////for Repeating the process of execution again.
            Console.WriteLine("Do u want to continue again (y/n)");
            string repeat = Console.ReadLine();
            if (repeat == "Y" || repeat == "y")
            {
                TestShape.DisplayShape();
            }
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}
