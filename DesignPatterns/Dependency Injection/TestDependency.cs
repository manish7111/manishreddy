// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TestDependency.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;

public class TestDependency
{
    /// <summary>
    /// Dependencies the injection.
    /// </summary>
    public static void DependencyInjection()
	{
        ////Creating the object of AndhraBank.
        AndhraBank andhraBank = new AndhraBank();
        ////Creating the object of KarnatakaBank.
        KarnatakaBank karnatakaBank = new KarnatakaBank();
        ////Creating the object of Client class and passing the objects of AndhraBank and KarnatakaBank.
        Client client1 = new Client(andhraBank);
        Client client2 = new Client(karnatakaBank);
        client1.Intrest();
        client2.Intrest();
	}
}
