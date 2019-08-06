// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainFactory.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// MainFactory is a class where i declared Run method.
/// </summary>
public class MainFactory
{
    /// <summary>
    /// Runs this instance.
    /// </summary>
    public static void Run()
    {
        ComputerFactory factory = null;
        Console.WriteLine("Enter the option to execute.");
        Console.WriteLine("1. Pc.\n2. Laptop.\n3. Server.");
        int option = Convert.ToInt32(Console.ReadLine());
        switch(option)
        {
            case 1:

                ////creating a object and calling pcFactory.
                Console.WriteLine("Computer type is PC");
                factory = new PcFactory("2 GB","500 GB","2.4 GHz");
                break;
            case 2:

                ////creating a object and calling LaptopFactory.
                Console.WriteLine("Computer type is Laptop");
                factory = new LaptopFactory("4 GB", "500 GB", "2.9 GHz");
                break;
            case 3:

                ////creating a object and calling ServerFactory.
                Console.WriteLine("Computer type is Server");
                factory = new ServerFactory("8 GB", "50 TB", "3.5 GHz");
                break;
            default: Console.WriteLine("enter correct option");
                break;
        }
        Computer computer = factory.GetComputer();

        ////printing the elements of each computer present in the factory.
        Console.WriteLine("\nYour computer configurations are : \n");
        Console.WriteLine("RAM: {0}\nHDD: {1}\nCPU: {2}", computer.Ram, computer.Hdd, computer.Cpu);
        Console.WriteLine("Do you still want to execute (y/n)");
        string repeat = Console.ReadLine();
        if (repeat == "y" || repeat == "Y")
        {
            MainFactory.Run();
        }
    }
}
