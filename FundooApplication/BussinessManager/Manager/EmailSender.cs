// --------------------------------------------------------------------------------------------------------------------
// <copyright file=EmailSender.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------

using BussinessManager.Interface;
using FundooModel;
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

/// <summary>
/// BussinessManager is the project.
/// </summary>
namespace BussinessManager.Manager
{
    /// <summary>
    /// EmailSender is a class which implements IEmailSender interface.
    /// </summary>
    /// <seealso cref="BussinessManager.Interface.IEmailSender" />
    public class EmailSender : IEmailSender
    {
        /// <summary>
        /// The email settings
        /// </summary>
        private readonly EmailSettings emailSettings;
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailSender"/> class.
        /// </summary>
        /// <param name="emailSettings">The email settings.</param>
        public EmailSender(EmailSettings emailSettings)
        {
            this.emailSettings = emailSettings;
        }
        /// <summary>
        /// Sends the email asynchronous.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="subject">The subject.</param>
        /// <param name="htmlMessage">The HTML message.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            try
            {

                var credentials = new NetworkCredential(this.emailSettings.Sender, this.emailSettings.Password);
                var mail = new MailMessage()
                {
                    From = new MailAddress(this.emailSettings.Sender, this.emailSettings.SenderName),
                    Subject = subject,
                    Body = htmlMessage,
                    IsBodyHtml = true
                };
                mail.To.Add(new MailAddress(email));
                var client = new SmtpClient()
                {
                    Port = this.emailSettings.MailPort,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Host = this.emailSettings.MailServer,
                    EnableSsl = true,
                    Credentials = credentials
                };
                client.Send(mail);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return Task.CompletedTask;
        }
    }
}
