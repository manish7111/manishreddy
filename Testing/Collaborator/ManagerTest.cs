// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ManagerTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using BussinessManager.Interface;
using BussinessManager.Manager;
using FundooModel;
using FundooRepository.Interface;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Controllers;
using Xunit;

namespace Testing
{
    /// <summary>
    /// ManagerTest is a AdminManager testing class.
    /// </summary>
    public class ManagerTest
    {
       
        /// <summary>
        /// Deletes the collaborator.
        /// </summary>
        [Fact]
        public void DeleteCollaborator()
        {
            var service = new Mock<INotesRepository>();
            var manager = new NotesManager(service.Object);
            var data = manager.RemoveCollaboratorToNote(1);
            Assert.Null(data);
        }
    }
}
