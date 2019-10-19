// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LoginModel.cs" company="Bridgelabz">
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
    /// LoginModel is a model class.
    /// </summary>
    public class LoginModel
    {
        /// <summary>
        /// The email
        /// </summary>
        private string email;
        /// <summary>
        /// The password
        /// </summary>
        private string password;
        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }
        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password
        {
            get
            {
                return this.password;

            }
            set
            {
                this.password = value;
            }
        }

    }
}
