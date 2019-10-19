// --------------------------------------------------------------------------------------------------------------------
// <copyright file=CollaboratorModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FundooModel
{
    /// <summary>
    /// CollaboratorModel is a class.
    /// </summary>
    public class CollaboratorModel
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
        /// The note identifier
        /// </summary>
        private int noteId;
        /// <summary>
        /// The sender email
        /// </summary>
        private string senderEmail;
        /// <summary>
        /// The receiver email
        /// </summary>
        private string receiverEmail;
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
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
        [ForeignKey("UserModel")]
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
        /// Gets or sets the note identifier.
        /// </summary>
        /// <value>
        /// The note identifier.
        /// </value>
        public int NoteId
        {
            set
            {
                this.noteId = value;
            }
            get
            {
                return this.noteId;
            }
        }
        /// <summary>
        /// Gets or sets the sender email.
        /// </summary>
        /// <value>
        /// The sender email.
        /// </value>
        [EmailAddress]
        public string SenderEmail
        {
            set
            {
                this.senderEmail = value;
            }
            get
            {
                return this.senderEmail;
            }
        }
        /// <summary>
        /// Gets or sets the receiver email.
        /// </summary>
        /// <value>
        /// The receiver email.
        /// </value>
        [EmailAddress]
        public string ReceiverEmail
        {
            set
            {
                this.receiverEmail = value;
            }
            get
            {
                return this.receiverEmail;
            }
        }
        /// <summary>
        /// Gets or sets the user model.
        /// </summary>
        /// <value>
        /// The user model.
        /// </value>
        public UserModels UserModel
        {
            get;
            set;
        }
    }
}
