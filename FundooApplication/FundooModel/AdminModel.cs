// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AdminModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FundooModel.UserModel
{
    /// <summary>
    /// AdminModel is a model class.
    /// </summary>
    public class AdminModel
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [Key]
        public int Id
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the login time.
        /// </summary>
        /// <value>
        /// The login time.
        /// </value>
        public string LoginTime
        {
            get;
            set;
        }
    }
}
