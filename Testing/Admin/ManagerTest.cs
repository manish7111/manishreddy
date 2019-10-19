// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ManagerTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using BussinessManager.Manager;
using FundooModel;
using FundooRepository.Interface;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Testing.Admin
{
    /// <summary>
    /// ManagerTest is a class.
    /// </summary>
    public class ManagerTest
    {
        /// <summary>
        /// Registrations this instance.
        /// </summary>
        [Fact]
        public void Registration()
        {
            var service = new Mock<IAdminRepository>();
            var manager = new AdminManager(service.Object);
            var add = new AdminLoginModel()
            {
                Email = "manish@gmail.com",
                FirstName = "manishkumar",
                LastName = "com",
                Password = "charan"
            };
            var data = manager.RegistrationAsync(add);
            Assert.NotNull(data);
        }
        /// <summary>
        /// Logins this instance.
        /// </summary>
        [Fact]
        public void Login()
        {
            var service = new Mock<IAdminRepository>();
            var manager = new AdminManager(service.Object);
            var add = new AdminLoginModel()
            {
                Email = "manish@gmail.com",
                Password = "manish"
            };
            var data = manager.LoginAsync(add);
            Assert.NotNull(data);
        }
    
    }
}
