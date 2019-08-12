// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeRepos.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Raavi Ramcharan"/>
// --------------------------------------------------------------------------------------------------------------------
using Employee_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Http;

/// <summary>
/// Repository is a folder where i declared EmployeeRepos class
/// </summary>
namespace Employee_Management_System.Repository
{
    /// <summary>
    /// EmployeeRepos is a class where i declared the functionalities.
    /// </summary>
    public class EmployeeRepos
    {
        /// <summary>
        /// The connect
        /// </summary>
        private SqlConnection connect;
        /// <summary>
        /// Connections this instance.
        /// </summary>
        public void Connection()
        {
            ////connecting to the database by using configuration manager.
            string constr = ConfigurationManager.ConnectionStrings["getconn"].ToString();
            connect = new SqlConnection(constr);
        }
        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="contact">The contact.</param>
        /// <param name="salary">The salary.</param>
        /// <param name="city">The city.</param>
        /// <returns></returns>
        [Route("api/post")]
        public bool AddEmployee(string name, string contact, string salary, string city)
        {
            Connection();

            ////connecting to the database and validating queries.
            SqlCommand command = new SqlCommand("AddEmployee", connect);
            Employees employee = new Employees();
            employee.Name = name;
            employee.ContactNumber = contact;
            employee.Salary = salary;
            employee.City = city;
            command.CommandType =CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Name", employee.Name);
            command.Parameters.AddWithValue("@ContactNumber", employee.ContactNumber);
            command.Parameters.AddWithValue("@Salary", employee.Salary);
            command.Parameters.AddWithValue("@City", employee.City);
            connect.Open();
            int i = command.ExecuteNonQuery();
            if(i>=1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="contact">The contact.</param>
        /// <param name="salary">The salary.</param>
        /// <param name="city">The city.</param>
        /// <returns></returns>
        public bool UpdateEmployee(int id,string name, string contact, string salary, string city)
        {
            Connection();
            SqlCommand command = new SqlCommand("UpdateEmployee", connect);
            Employees employee = new Employees();
            employee.EmpId = id;
            employee.Name = name;
            employee.ContactNumber = contact;
            employee.Salary = salary;
            employee.City = city;
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", employee.EmpId);
            command.Parameters.AddWithValue("@Name", employee.Name);
            command.Parameters.AddWithValue("@ContactNumber", employee.ContactNumber);
            command.Parameters.AddWithValue("@Salary", employee.Salary);
            command.Parameters.AddWithValue("@City", employee.City);
            connect.Open();
            int i = command.ExecuteNonQuery();
            connect.Close();
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public bool DeleteEmployee(int id)
        {

            Connection();
            SqlCommand command = new SqlCommand("DeleteEmployee", connect);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", id);

            connect.Open();
            int i = command.ExecuteNonQuery();
            connect.Close();
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Gets the list of employees.
        /// </summary>
        /// <returns></returns>
        [Route("api/get")]
        public List<Employees> GetListOfEmployees()
        {
            Connection();
            List<Employees> employees = new List<Employees>();
            SqlCommand command = new SqlCommand("AllEmployeeDetails", connect);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            connect.Open();
            adapter.Fill(dataTable);
            connect.Close();

            employees = (from DataRow data in dataTable.Rows

                         select new Employees()
                         {
                             EmpId = Convert.ToInt32(data["Id"]),
                             Name = Convert.ToString(data["Name"]),
                             ContactNumber = Convert.ToString(data["ContactNumber"]),
                             Salary = Convert.ToString(data["Salary"]),
                             City = Convert.ToString(data["City"])
                         }).ToList();

            return employees;
        }
    }
}
