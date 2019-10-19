 // --------------------------------------------------------------------------------------------------------------------
// <copyright file=ControllerTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using BussinessManager.Interfaces;
using FundooModel;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Controllers;
using Xunit;

namespace Testing.Admin
{
    /// <summary>
    /// ControllerTest is a testing class.
    /// </summary>
    public class ControllerTest
    {
        /// <summary>
        /// Bulks the trash.
        /// </summary>
        [Fact]
        public void BulkTrash()
        {
            var service = new Mock<IAdmin>();
            var controller = new AdminController(service.Object);
            var data = controller.BulkTrash();
            Assert.NotNull(data);
        }
    }
}
