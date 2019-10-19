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
        /// The identifier
        /// </summary>
        private int id;
        /// <summary>
        /// The email
        /// </summary>
        private string email;
        /// <summary>
        /// The login time
        /// </summary>
        private string loginTime;
        /// <summary>
        /// The service
        /// </summary>
        private string service;
        /// <summary>
        /// The notes count
        /// </summary>
        private int notesCount;

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [Key]
        public int Id
        {
            set
            {
                this.id = value;
            }
            get
            {
                return this.id;
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

        /// <summary>
        /// Gets or sets the login time.
        /// </summary>
        /// <value>
        /// The login time.
        /// </value>
        public string LoginTime
        {
            set
            {
                this.loginTime = value;
            }
            get
            {
                return this.loginTime;
            }
        }
        /// <summary>
        /// Gets or sets the service.
        /// </summary>
        /// <value>
        /// The service.
        /// </value>
        public string Service
        {
            set
            {
                this.service = value;
            }
            get
            {
                return this.service;
            }
        }
        /// <summary>
        /// Gets or sets the notes count.
        /// </summary>
        /// <value>
        /// The notes count.
        /// </value>
        public int NotesCount
        {
            set
            {
                this.notesCount = value;
            }
            get
            {
                return this.notesCount;
            }
        }
    }
}
