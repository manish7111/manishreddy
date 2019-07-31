// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RegularExpression.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Text.RegularExpressions;
/// <summary>
/// RegularExpression is a class it contains the conditions of check.
/// </summary>
public class RegularExpression
{
    /// <summary>
    /// Regex1s this instance.
    /// </summary>
    public void Regex1()
    {
        try
        {
            string[] rName = null;
            Console.WriteLine("enter full name");
            string fullName = Console.ReadLine();

            ////string name in an REGEX form
            string name = @"^[a-zA-Z]";
            Regex regex = new Regex(name);

            ////condition to avoid numbers in the name
            if (!regex.IsMatch(fullName))
            {
                Console.WriteLine("please provide only characters");
                return;
            }
            else
            {
                ////splitting of full name
                rName = fullName.Split(' ');
            }
            Console.WriteLine("enter contact number");
            double contactNumber = Convert.ToDouble(Console.ReadLine());
            ////number in the form of REGEX expression
            string number = @"^[0-9]{10}";

            ////Calling of regex class
            Regex regexNumber = new Regex(number);

            ////it avoids charecters and should contain 10 digits of number
            if (!regexNumber.IsMatch(contactNumber.ToString()))
            {
                Console.WriteLine("please provide only 10 numbers between 0-9 ");
                return;
            }
            string date = System.DateTime.Today.ToString();
            string expression = "Hello <<name>>, We have your full name as <<full name>> in our system. your contact number is 91-xxxxxxxxxx. Please,let us know in case of any clarification Thank you BridgeLabz 01/01/2016.";
            ////output of an string by using only regex expression
            string output = expression.Replace("<<name>>", rName[0]).Replace("<<full name>>", fullName).Replace("xxxxxxxxxx", contactNumber.ToString()).Replace("01/01/2016", date);
            Console.WriteLine(output);
        }
        catch(Exception e)
        {
            throw new Exception(e.Message);
        }
       
    }
}
