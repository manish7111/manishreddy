// --------------------------------------------------------------------------------------------------------------------
// <copyright file=UserModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
/// <summary>
/// FundooModel is a namespace.
/// </summary>
namespace FundooModel
{
    /// <summary>
    /// UserModel is a model class .
    /// </summary>
    public class UserModels
    {
      
        /// <summary>
        /// The first name
        /// </summary>
        private string firstName;
        /// <summary>
        /// The last name
        /// </summary>
        private string lastName;
        /// <summary>
        /// The password
        /// </summary>
        private string password;
        /// <summary>
        /// The email
        /// </summary>
        private string email;
        public string ProfilePic { get; set; }
        public string Service { get; set; }
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName
        {
            set
            {
                this.firstName = value;
            }
            get
            {
                return this.firstName;
            }
        }
        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName
        {
            set
            {
                this.lastName = value;
            }
            get
            {
                return this.lastName;
            }
        }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [EmailAddress]
        [Required(ErrorMessage = "Mandatory field", AllowEmptyStrings = false)]
        [Display(Name = "Email Address")]
        [Key]
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
        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        [Required(ErrorMessage = "Mandatory field", AllowEmptyStrings = false)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Password must contain 8 characters")]
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
       
    }
}
