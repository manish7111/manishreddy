// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Execute.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;

/// <summary>
/// Execute is an class Where i declared the static method Run.
/// </summary>
public class Execute
{
    /// <summary>
    /// Runs this instance.
    /// </summary>
    public static void Run()
    {
        CardFactory factory = null;
        Console.WriteLine("Enter Option to execute");
        Console.WriteLine("1.Axis.\n2.Hdfc");
        int option = Convert.ToInt32(Console.ReadLine());

        ////switch case is used to execute required option.
        switch(option)
        {
            case 1:
                factory = new AxisCardFactory(5000, 100);
                break;
            case 2:
                factory = new HdfcCardFactory(10000, 500);
                break;
            default:Console.WriteLine("Enter correct option to execute");
                break;
        }
        CreditCard creditCard = factory.GetCreditCard();
        Console.WriteLine("\nYour card details are below : \n");

        ////displaying the details.
        Console.WriteLine("Card Type: {0}\nCredit Limit: {1}\nAnnual Charge: {2}",creditCard.CardType, creditCard.CreditLimit, creditCard.AnnualCharge);
        Console.WriteLine("Do you still want to execute (y/n)");
        string repeat = Console.ReadLine();

        ////if we want to repeat the process.
        if(repeat=="y"||repeat=="Y")
        {
            Execute.Run();
        }
    }

}
