// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockAccount.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

/// <summary>
/// StockAccount is a class used to perform operations.
/// </summary>
public class StockAccount
{
    /// <summary>
    /// Buys the specified amount.
    /// </summary>
    /// <param name="amount">The amount.</param>
    /// <param name="symbol">The symbol.</param>
    public void Buy(long amount, string symbol)
    {
        try
        {
            if (File.Exists(@"C:\Users\Admin\source\repos\OOPs\CommercialDataProcessing\Company.json"))
            {
                ////Read data from file in string variable
                string jsonData = File.ReadAllText(@"C:\Users\Admin\source\repos\OOPs\CommercialDataProcessing\Company.json");

                ////deserialize the json object into system string
                CompanyShares[] jsonObjectArray = JsonConvert.DeserializeObject<CompanyShares[]>(jsonData);

                ////reading of another file and storing it in array
                string jsonData1 = File.ReadAllText(@"C:\Users\Admin\source\repos\OOPs\CommercialDataProcessing\Members.json");
                MemberShares[] shares = JsonConvert.DeserializeObject<MemberShares[]>(jsonData1);

                for (int i = 0; i < jsonObjectArray.Length; i++)
                {
                    ////for calculating the shares which company lost and member adds.
                    long share = amount / (long)jsonObjectArray[i].PriceOfShare;

                    ////checks the condition and enters the if condition
                    if (symbol == jsonObjectArray[i].Symbol)
                    {
                        ////if condition is true number of shares which are taken are reduced by the company.
                        jsonObjectArray[i].NumberOfShares -= share;

                        ////For serialization of object into json file
                        string save = JsonConvert.SerializeObject(jsonObjectArray);
                        System.IO.File.WriteAllText(@"C:\Users\Admin\source\repos\OOPs\CommercialDataProcessing\Company.json", save);
                        Console.WriteLine("added to company");

                        Console.WriteLine("search the name u want to update");
                        string search = Console.ReadLine();
                        if (shares[i].Name.Equals(search))
                        {
                            shares[i].NumberOfShares += share;
                            string save1 = JsonConvert.SerializeObject(shares);
                            System.IO.File.WriteAllText(@"C:\Users\Admin\source\repos\OOPs\CommercialDataProcessing\Members.json", save1);
                            Console.WriteLine("added to member");

                        }
                        else
                        {
                            string add = "{'name':" + search + ",'NumberOfShares':" + share + ",'NumberOfShares':" + amount + "'}";

                            File.AppendAllText(@"C:\Users\Admin\source\repos\OOPs\CommercialDataProcessing\Members.json", add);
                            Console.WriteLine("added to member");
                        }


                        return;
                    }

                }
            }
            else
            {
                Console.WriteLine("\nSpecified file path does not exist");

            }
        }catch(Exception e)
        {
            throw new Exception(e.Message);
        }
        ////Check the filepath if exists then enters else gives a warning.
       

    }
    /// <summary>
    /// Sells the specified amount.
    /// </summary>
    /// <param name="amount">The amount.</param>
    /// <param name="symbol">The symbol.</param>
    public void sell(int amount,string symbol)
    {
        ////enter company name of yours to sell the shares
        Console.WriteLine("enter the symbol name u want to sell the shares");

        ////Reading of company name from the user
        string name = Console.ReadLine();
        
        ////Reading of how many shares u want to sell
        Console.WriteLine("How many shares u want to sell");
        long share = Convert.ToInt64(Console.ReadLine());

        ////Reading of json file and deserialize the json data to string 
        string jsonData1 = File.ReadAllText(@"C:\Users\Admin\source\repos\OOPs\CommercialDataProcessing\Members.json");
        MemberShares[] shares = JsonConvert.DeserializeObject<MemberShares[]>(jsonData1);
        for(int i=0;i<shares.Length;i++)
        {
            if (name == shares[i].Symbol && shares[i].NumberOfShares<=share)
            {

                ////removal to sold shares from the member
                shares[i].NumberOfShares -= share;

                ////converting the string data into json data by using serialization
                string save1 = JsonConvert.SerializeObject(shares);
                System.IO.File.WriteAllText(@"C:\Users\Admin\source\repos\OOPs\CommercialDataProcessing\Members.json", save1);
                Console.WriteLine("added to member");
                return;
            }
        }
       
    }
}
