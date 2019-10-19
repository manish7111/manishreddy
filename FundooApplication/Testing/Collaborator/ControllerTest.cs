// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ControllerTest.cs" company="Bridgelabz">
//   Copyright � 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using BussinessManager.Interface;
using FundooModel;
using Moq;
using System;
using WebApplication1.Controllers;
using Xunit;

namespace Testing
{
    /// <summary>
    /// ControllerTest is a controller testing class.
    /// </summary>
    public class ControllerTest
    {
        /// <summary>
        /// Adds the collaborator to note.
        /// </summary>
        [Fact]
        public void AddCollaboratorToNote()
        {
            var service = new Mock<INotes>();
            var controller = new NotesController(service.Object);
            var notes = new CollaboratorModel()
            {
                Id = 1,
                Email = "mmkr7111@gmail.com"
            };
            var data = controller.AddCollaboratorToNote(notes);
            Assert.NotNull(data);
        }
        /// <summary>
        /// Removes the collaborator to note.
        /// </summary>
        [Fact]
        public void RemoveCollaboratorToNote()
        {
            var service = new Mock<INotes>();
            var controller = new NotesController(service.Object);
            var data = controller.RemoveCollaboratorToNote(1);
            Assert.NotNull(data);
        }
    }
}