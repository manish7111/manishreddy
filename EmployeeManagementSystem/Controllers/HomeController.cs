// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HomeController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Raavi Ramcharan"/>
// --------------------------------------------------------------------------------------------------------------------

using Employee_Management_System.Models;
using Employee_Management_System.Repository;
using System.Collections.Generic;
using System.Web.Mvc;

/// <summary>
/// Controller is the namespace.
/// </summary>
namespace Employee_Management_System.Controllers
{
    /// <summary>
    /// HomeController is a class where i declared action methods.
    /// </summary>
    /// <seealso cref="System.Web.Mvc.Controller" />
    public class HomeController : Controller
    {
        /// <summary>
        /// calling the employeeRepos class
        /// </summary>
        EmployeeRepos employeeRepos = new EmployeeRepos();
        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        /// <summary>
        /// Lists the of employees.
        /// </summary>
        /// <returns></returns>
        public ActionResult ListOfEmployees()
        {
            Employees employees = new Employees();
            List<Employees> list= employeeRepos.GetListOfEmployees();

            return View(list);
        }
        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <returns></returns>
        public ActionResult AddEmployee(string name,string contact,string salary,string city)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Employees employee = new Employees();
                    employee.Name = name;
                    employee.ContactNumber = contact;
                    employee.Salary = salary;
                    employee.City = city;
                    if (employeeRepos.AddEmployee(employee.Name,employee.ContactNumber,employee.Salary,employee.City))
                    {
                        ViewBag.Message = "Employee details added successfully";
                    }
                }

                return View();
            }
            catch
            {
                return View();
            }
        }
        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <returns></returns>
        public ActionResult UpdateEmployee()
        {
            return View();
        }
        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <returns></returns>
        public ActionResult DeleteEmployee()
        {

            return View();
        }
    }
}
