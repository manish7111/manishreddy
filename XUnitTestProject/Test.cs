// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Test.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using Employee_Management_System.Controllers;
using Employee_Management_System.Models;
using System;
using System.Web.Mvc;
using Xunit;

/// <summary>
/// XUnitTestProject is the namespace where i declared my class and functions.
/// </summary>
namespace XUnitTestProject
{
    /// <summary>
    /// Test is a class.
    /// </summary>
    public class Test
    {
        /// <summary>
        /// method to call and test.
        /// </summary>
        [Fact]
        public void Create_Given_InvalidModelState_ExpectPartialResultReturned()
        {
            var model = new Employees()
            {
                Name = "John",
                ContactNumber = "7760467611",
                Salary = "100",
                City="nellor"
            };
            HomeController homeController = new HomeController();
            homeController.AddEmployee(model.Name, model.ContactNumber, model.Salary, model.City);
            string expectedView = "Create";

            var actual = homeController.AddEmployee(model.Name,model.ContactNumber,model.Salary,model.City) as PartialViewResult;

            Assert.Equal(expectedView, actual.ViewName);
            Assert.Equal(model, actual.Model);
        }
    }
}
