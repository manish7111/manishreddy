// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Test.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;

/// <summary>
/// test is a class where i declared a DisplayOrder method.
/// </summary>
public class Test
{
    /// <summary>
    /// Displays the order.
    /// </summary>
    public static void DisplayOrder()
    {

        ////Giving an option to place an order.
        Console.WriteLine("enter your option to place an order");
        Console.WriteLine("1.MotorCycle.\n2.Car");
        int option = Convert.ToInt32(Console.ReadLine());

        ////Creating an object for FacadeShopping class.
        FacadeShopping facadeShopping = new FacadeShopping();

        ////switch case to choose the option and Execute.
        switch (option)
        {
            case 1:
                Console.WriteLine("Enter option to buy the product");
                Console.WriteLine("1.Cycle.\n2.Bike");
                int select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        facadeShopping.OrderCycle();
                        break;
                    case 2:
                        facadeShopping.OrderBike();
                        break;
                }

                break;
            case 2:
                Console.WriteLine("Enter option to buy the product");
                Console.WriteLine("1.PetrolCar.\n2.DieselCar");
                int opt = Convert.ToInt32(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        facadeShopping.OrderPetrolCar();
                        break;
                    case 2:
                        facadeShopping.OrderDieselCar();
                        break;
                }
                break;
        }

        ////repeating the execution process happens here.
        Console.WriteLine("Do u want to continue again to buy motorCycle or Car(y/n)");
        string repeat = Console.ReadLine();
        if (repeat == "y" || repeat == "Y")
        {
            Test.DisplayOrder();
        }
    }
}


