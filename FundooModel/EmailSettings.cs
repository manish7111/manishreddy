// --------------------------------------------------------------------------------------------------------------------
// <copyright file=EmailSettings.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// FundooModel is the namespace.
/// </summary>
namespace FundooModel
{
    /// <summary>
    /// EmailSettings is the Model class.
    /// </summary>
    public class EmailSettings
    {
        /// <summary>
        /// Gets or sets the mail server.
        /// </summary>
        /// <value>
        /// The mail server.
        /// </value>
        public string MailServer
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the mail port.
        /// </summary>
        /// <value>
        /// The mail port.
        /// </value>
        public int MailPort
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the name of the sender.
        /// </summary>
        /// <value>
        /// The name of the sender.
        /// </value>
        public string SenderName
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the sender.
        /// </summary>
        /// <value>
        /// The sender.
        /// </value>
        public string Sender
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the enable SSL.
        /// </summary>
        /// <value>
        /// The enable SSL.
        /// </value>
        public string EnableSSL
        {
            get;
            set;
        }
    }
}
