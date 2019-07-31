// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using OOPs;
using System;
using System.IO;
/// <summary>
/// ExecutionPrograms is a namespace where my function of the class is declared
/// </summary>
namespace ExecutionPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Inventory Main.\n2.RegularExpression.\n3.StockReportDetails.\n4.Inventory Management.\n5.DeckOfCards.\n6.CommercialDataProcessing.\n7.AddressBook");
            Console.WriteLine("enter the key to execute the program");
            int key = Convert.ToInt32(Console.ReadLine());
            switch (key)
            {
                case 1:
                    InventoryMain inventory = new InventoryMain();
                    string filepath = @"C:\Users\Admin\source\repos\ExecutionPrograms\Inventory_Details.json";
                    inventory.DisplayData(filepath);
                    break;
                case 2:
                    RegularExpression regularExpression = new RegularExpression();
                    regularExpression.Regex1();
                    break;
                case 3:
                    StockReportDetails stockReport = new StockReportDetails();
                    string filepath1 = @"C:\Users\Admin\source\repos\ExecutionPrograms\Stock_Details.json";
                    stockReport.Report(filepath1);
                    break;
                case 4:
                    FirstView.StartInventoryManager();
                    break;
                case 5:
                    DeckOfCards cards = new DeckOfCards();
                    Utility utility = new Utility();
                    cards.InitializeDeckOfCards();
                    utility.Distribute9Cards(1);
                    break;
                case 6:
                    StockAccount stockAccount = new StockAccount();
                    stockAccount.Buy(1000,"ABC");
                    break;
                case 7:
                    AddressBook addressBook = new AddressBook();
                    string file = @"C:\Users\Admin\source\repos\ExecutionPrograms\AddressBook.json";
                    addressBook.Add(file);
                    break;
            }
        }
    } 
}
