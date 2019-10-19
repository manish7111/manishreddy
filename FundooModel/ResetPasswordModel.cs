// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ResetPasswordModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;

/// <summary>
/// FundooModel is a namespace.
/// </summary>
namespace FundooModel
{
    /// <summary>
    /// ResetPasswordModel is a model class.
    /// </summary>
    public class ResetPasswordModel
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
        public string UserName
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
            set
            {
                this.password = value;
            }
            get
            {
                return this.password;
            }
        }
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email
        {
            set
            {
                this.email = value;
            }
            get
            {
                return this.email;
            }
        }

    }
}
