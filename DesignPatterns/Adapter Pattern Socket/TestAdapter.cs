// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TestAdapter.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// TestAdapter is a class.
/// </summary>
public class TestAdapter
{
    /// <summary>
    /// Tests the object adapter.
    /// </summary>
    public static void TestObjectAdapter()
    {
        ////creating the object of implementation class through interface i.e. Upcasting.
        ISocketAdapter socket = new SocketAdapterImpl();
        Volt v3 = GetVolt(socket, 3);
        Volt v12 = GetVolt(socket, 12);
        Volt v120 = GetVolt(socket, 120);
        Console.WriteLine("v3 volts using Object Adapter=" + v3.GetVolt());
        Console.WriteLine("v12 volts using Object Adapter=" + v12.GetVolt());
        Console.WriteLine("v120 volts using Object Adapter=" + v120.GetVolt());
    }

    /// <summary>
    /// Tests the class adapter.
    /// </summary>
    public static void TestClassAdapter()
    {

        ////creating the object of  ScoketAdapter.
        SocketAdapter socket = new SocketAdapter();
        Volt v3 = GetVolt(socket, 3);
        Volt v12 = GetVolt(socket, 12);
        Volt v120 = GetVolt(socket, 120);
        Console.WriteLine("v3 volts using Class Adapter=" + v3.GetVolt());
        Console.WriteLine("v12 volts using Class Adapter=" + v12.GetVolt());
        Console.WriteLine("v120 volts using Class Adapter=" + v120.GetVolt());
    }

    /// <summary>
    /// Gets the volt.
    /// </summary>
    /// <param name="sockAdapter">The sock adapter.</param>
    /// <param name="i">The i.</param>
    /// <returns></returns>
    public static Volt GetVolt(ISocketAdapter sockAdapter, int i)
    {
        switch (i)
        {
            case 3: return sockAdapter.Get3Volt();
            case 12: return sockAdapter.Get12Volt();
            case 120: return sockAdapter.Get120Volt();
            default: return sockAdapter.Get120Volt();
        }
    }
}
