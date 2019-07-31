// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockReportDetails.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
/// <summary>
/// StockReportDetails is a class of stock market
/// </summary>
public class StockReportDetails
{
    /// <summary>
    /// Reports the specified file.
    /// </summary>
    /// <param name="file">The file.</param>
    /// <exception cref="Exception"></exception>
    public void Report(string file)
	{
        Console.WriteLine("enter the company name where i want to invest");

        ////displaying of stocks we are maintaining
        Console.WriteLine("1.bridgeLabz \n2.amazon \n3.flipKart \n4.IBM \n5.greytHr");

        ////Reading of company name from the user in which he likes to invest.
        string companyName = Console.ReadLine();
        Console.WriteLine("Enter the amount you want to invest");

        ////Reading the amount which he wants to invest.
        long amount = Convert.ToInt32(Console.ReadLine());
        string message = null; ;

        ////calling of StockReport class
        StockReport reports = new StockReport();
        try
        {
            ////reading of file by using streamreader
            using (StreamReader read = new StreamReader(file))
            {
                ////reading the file to the end.
                var json = read.ReadToEnd();

                ////for deserializing the json data into string data
                StockReport[] data = JsonConvert.DeserializeObject<StockReport[]>(json);
                if(amount>0)
                {
                    for (int i = 0; i < data.Length; i++)
                    {
                        if (companyName == data[i].Name && data[i].SharePrice <= amount && amount > 0)
                        {
                            Console.WriteLine(i);
                            Console.WriteLine("Stockname is:" + " " + data[i].Name);
                            Console.WriteLine("Stock Shares are:" + " " + (data[i].NumberOfShare + 1));
                            Console.WriteLine("Stock rate of each stocks is:" + " " + data[i].SharePrice);
                            Console.WriteLine("Total stock amount is:" + " " + (data[i].NumberOfShare + 1) * data[i].SharePrice);
                            amount -= data[i].SharePrice;
                            message = " ";
                        }
                        else
                        {
                            message="You cannot invest in,we dont have ur required stocks,thankyou";
                        }
                    }
                    Console.WriteLine(message);
                } 
                Console.WriteLine("Remaining amount you can invest:"+" "+amount);
                Console.WriteLine("do u want to invest(y/n)");
                string repeat = Console.ReadLine();

                ////for repeating the process.
                if(repeat=="y" ||repeat=="Y")
                {
                    StockReportDetails stockReportDetails = new StockReportDetails();
                    stockReportDetails.Report(file);
                }
            }
        }
        catch(Exception e)
        {
            throw new Exception(e.Message);
        }
       
	}
}
