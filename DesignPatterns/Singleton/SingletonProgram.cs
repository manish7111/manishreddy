// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SingletonProgram.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using DesignPatterns;
using System;
using System.Threading.Tasks;

/// <summary>
/// SingletonProgram is a class.
/// </summary>
public class SingletonProgram
{
    /// <summary>
    /// Managers the request.
    /// </summary>
    public static void ManagerRequest()
    {
        ////creating the object and calling through its reference.
        Singleton fromManager = Singleton.Instance;
        fromManager.PrintMessage("Request from manager");
    }
    /// <summary>
    /// Employees the request.
    /// </summary>
    public static void EmployeeRequest()
    {
        ////creating the object and calling through its reference.
        Singleton fromEmployee = Singleton.Instance;
        fromEmployee.PrintMessage("Request from Employee");
    }

}
