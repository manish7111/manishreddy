// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ForgetPasswordModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;

/// <summary>
/// FundooModel is the Namespace.
/// </summary>
namespace FundooModel
{
    /// <summary>
    /// ForgetPasswordModel is the class.
    /// </summary>
    public class ForgetPasswordModel
    {
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [EmailAddress]
        [Required]
        public string Email
        {
            get;
            set;
        }
    }
}
