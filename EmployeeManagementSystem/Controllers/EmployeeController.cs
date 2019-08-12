// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Raavi Ramcharan"/>
// --------------------------------------------------------------------------------------------------------------------
using Employee_Management_System.Models;
using Employee_Management_System.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
/// <summary>
/// EmployeeManagementSystem is a namespace where i declared the class.
/// </summary>
namespace Employee_Management_System.Controllers
{
    /// <summary>
    /// EmployeeController is a controller class which is implementing nApiController by default.
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class EmployeeController : ApiController
    {
        /// <summary>
        /// The employee repos
        /// </summary>
        private readonly EmployeeRepos employeeRepos = new EmployeeRepos();

        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns></returns>
        [Route("api/getemployees")]
        [HttpGet]
        public IEnumerable<Employees> Get()
        {
            return (employeeRepos.GetListOfEmployees().AsEnumerable());
        }

        /// <summary>
        /// Posts the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="contact">The contact.</param>
        /// <param name="salary">The salary.</param>
        /// <param name="city">The city.</param>
        /// <returns></returns>
        [Route("api/add")]
        [HttpPost]
        public string Post(string name,string contact,string salary,string city)
        {
            employeeRepos.AddEmployee(name, contact, salary, city);
            return "Added successfully";
        }

        /// <summary>
        /// Updates the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="contact">The contact.</param>
        /// <param name="salary">The salary.</param>
        /// <param name="city">The city.</param>
        /// <returns></returns>
        [Route("api/update")]
       [HttpPut]
       public string Update(int id, string name, string contact, string salary, string city)
        {
            employeeRepos.UpdateEmployee(id,name,contact,salary,city);
            return "updated successfully";
        }

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [Route("api/delete")]
        [HttpDelete]
        public string Delete(int id)
        {
            employeeRepos.DeleteEmployee(id);
            return "Deleted Successfully";
        }
    }
}