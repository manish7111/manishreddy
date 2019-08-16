// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IEmployeeManagement.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
/// <summary>
/// EmployeeManagementSystem is a namespace where i declared interface.
/// </summary>
namespace Employee_Management_System.Models
{
    /// <summary>
    /// IEmployeeManagement is a interface.
    /// </summary>
    public interface IEmployeeManagement
    {
        /// <summary>
        /// Gets the list of employees.
        /// </summary>
        /// <returns></returns>
        List<Employees> GetListOfEmployees();
        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="contact">The contact.</param>
        /// <param name="salary">The salary.</param>
        /// <param name="city">The city.</param>
        /// <returns></returns>
        bool AddEmployee(string name, string contact, string salary, string city);
        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="contact">The contact.</param>
        /// <param name="salary">The salary.</param>
        /// <param name="city">The city.</param>
        /// <returns></returns>
        bool UpdateEmployee(int id, string name, string contact, string salary, string city);
        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        bool DeleteEmployee(string name);
    }
}