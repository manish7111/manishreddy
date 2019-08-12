// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Employees.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Raavi Ramcharan"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

/// <summary>
/// Employees is a model class i have created in Employment management system name space
/// </summary>
namespace Employee_Management_System.Models
{
    /// <summary>
    /// Employees is a class i.e.model class
    /// </summary>
    public class Employees
    {
        /// <summary>
        /// Gets or sets the emp identifier.
        /// </summary>
        /// <value>
        /// The emp identifier.
        /// </value>
        [Display(Name="Id")]
        public int EmpId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [Required(ErrorMessage = "First name is required.")]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the contact number.
        /// </summary>
        /// <value>
        /// The contact number.
        /// </value>
        [Required(ErrorMessage = "Contact Number is required.")]
        public string ContactNumber
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the salary.
        /// </summary>
        /// <value>
        /// The salary.
        /// </value>
        public string Salary
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        [Required(ErrorMessage = "City is required.")]
        public string City
        {
            get;
            set;
        }
    }
}