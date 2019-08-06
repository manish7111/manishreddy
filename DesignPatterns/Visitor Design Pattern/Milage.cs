// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Milage.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Milage is an class which implements IVisitor interface.
/// </summary>
public class Milage : IVisitor
{
    /// <summary>
    /// Accepts the specified car.
    /// </summary>
    /// <param name="car">The car.</param>
    public void Accept(Car car)
    {
        Console.WriteLine("Enter type of car");
        Console.WriteLine("1.Audi.\n2.BMW");
        car.CarName = Console.ReadLine();
        ////switch case to get result of the specified option.
        switch (car.CarName)
        {
            case "Audi":
                Console.WriteLine("Car {0} Milage: {1} KM", car.CarName,7);
                break;
            case "BMW":
                Console.WriteLine("Car {0} Milage: {1} KM", car.CarName, 6);
                break;
        }
    }
    /// <summary>
    /// Accepts the specified bike.
    /// </summary>
    /// <param name="bike">The bike.</param>
    public void Accept(Bike bike)
    {
        Console.WriteLine("Enter type of Bike");
        Console.WriteLine("1.FZ.\n2.Fazer");
        bike.BikeName = Console.ReadLine();
        ////switch case to get result of the specified option.
        switch (bike.BikeName)
        {
            case "FZ":
                Console.WriteLine("Bike {0} Milage: {1} KM", bike.BikeName, 40);
                break;
            case "Fazer":
                Console.WriteLine("Bike {0} Milage: {1} KM", bike.BikeName, 45);
                break;
        }
    }
}
