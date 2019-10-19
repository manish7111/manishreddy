// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IEmailSender.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// BussinessManager is the project.
/// </summary>
namespace BussinessManager.Interface
{
    /// <summary>
    /// IEmailSender is the interface.
    /// </summary>
    public interface IEmailSender
    {
        /// <summary>
        /// Sends the email asynchronous.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="subject">The subject.</param>
        /// <param name="htmlMessage">The HTML message.</param>
        /// <returns></returns>
        Task SendEmailAsync(string email, string subject, string htmlMessage);
    }
}
