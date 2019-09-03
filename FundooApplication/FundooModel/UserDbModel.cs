// --------------------------------------------------------------------------------------------------------------------
// <copyright file=UserDbModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

/// <summary>
/// FundooModel is the namespace.
/// </summary>
namespace FundooModel
{
    /// <summary>
    /// UserDbModel is the Model class which implements IdentityUser.
    /// </summary>
    /// <seealso cref="Microsoft.AspNet.Identity.EntityFramework.IdentityUser" />
    public class UserDbModel : IdentityUser
    {
        /// <summary>
        /// User name
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(TypeName = "nvarchar(50)")]
        public string UserName
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        [Column(TypeName = "nvarchar(50)")]
        public string FirstName
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        [Column(TypeName = "nvarchar(50)")]
        public string LastName
        {
            get;
            set;
        }
        /// <summary>
        /// Email
        /// </summary>
        [Column(TypeName = "nvarchar(50)")]
        public string Email
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
        [Column(TypeName = "nvarchar(50)")]
        public string Password
        {
            get;
            set;
        }
    }
}
