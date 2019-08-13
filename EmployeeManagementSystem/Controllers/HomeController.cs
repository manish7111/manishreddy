﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HomeController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
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

        EmployeeController employeeController = new EmployeeController();
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
        [HttpGet]
        public ActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        [ActionName("AddEmployee")]
        public ActionResult Add(int id,string name, string contact, string salary, string city)
        {
            Employees employee = new Employees();
            employee.EmpId = id;
            employee.Name = name;
            employee.ContactNumber = contact;
            employee.Salary = salary;
            employee.City = city;
            bool v= employeeRepos.AddEmployee(employee.Name, employee.ContactNumber, employee.Salary, employee.City);
            return View(employee);
        }
        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult UpdateEmployee(int id,string name,string contact,string salary,string city)
        {
            Employees employee = new Employees();
            employee.EmpId = id;
            employee.Name = name;
            employee.ContactNumber = contact;
            employee.Salary = salary;
            employee.City = city;
            return View(employee);
        }
        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <returns></returns>
        public ActionResult DeleteEmployee(int id)
        {
            employeeController.Delete(id);
            return View();
        }
        [HttpPost]
        [ActionName("UpdateEmployee")]
        public ActionResult Update(int id, string name, string contact, string salary, string city)
        {
            employeeController.Update(id, name, contact, salary, city);
            Employees employees = new Employees();

            return View(employees);
        }
       
    }
}
