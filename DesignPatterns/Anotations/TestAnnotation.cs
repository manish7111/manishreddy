﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TestAnnotation.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

/// <summary>
/// Class to validate the Values.
/// </summary>
public class TestAnnotation
{
    /// <summary>
    /// Displays this instance.
    /// </summary>
    public static void Display()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Employee class Validation");
        Console.WriteLine("---------------------------\n");

        Employee objEmployee = new Employee();

        objEmployee.Name = "Manish";

        objEmployee.Age = 19;
        objEmployee.PhoneNumber = "7760467611";
        objEmployee.Email = "manishreddy@gmail.com";

        ////Inbuilt class to pass object and values.
        ValidationContext context = new ValidationContext(objEmployee, null, null);
        List<ValidationResult> results = new List<ValidationResult>();
        bool valid = Validator.TryValidateObject(objEmployee, context, results, true);

        ////condition to find and print results.
        if (!valid)
        {
            ////foreach loop is used to transverse the data if error occurs prints the error messages in different colours.
            foreach (ValidationResult Totalresult in results)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Member Name :{0}", Totalresult.MemberNames.First());
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("   ::  {0}{1}", Totalresult.ErrorMessage, Environment.NewLine);
            }
        }
        else
        {
            Console.WriteLine("Name: " + objEmployee.Name +"\n"+"Age: "+objEmployee.Age + "\n"+"Phonenumber: " + objEmployee.PhoneNumber);
        }
        ////To print the console in our wish colour.
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\nPress any key to exit");
        Console.ReadKey();


    }
}
