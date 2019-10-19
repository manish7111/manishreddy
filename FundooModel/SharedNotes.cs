// --------------------------------------------------------------------------------------------------------------------
// <copyright file=SharedNotes.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------\
using System;
using System.Collections.Generic;
using System.Text;

namespace FundooModel
{
    /// <summary>
    /// SharedNotes is a class.
    /// </summary>
    public class SharedNotes
    {
        /// <summary>
        /// The note identifier
        /// </summary>
        private int noteId;
        /// <summary>
        /// The title
        /// </summary>
        private string title;
        /// <summary>
        /// The take a note
        /// </summary>
        private string takeANote;
        /// <summary>
        /// The sender email
        /// </summary>
        private string senderEmail;
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
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title
        {
            set
            {
                this.title = value;
            }
            get
            {
                return this.title;
            }
        }
        /// <summary>
        /// Gets or sets the take a note.
        /// </summary>
        /// <value>
        /// The take a note.
        /// </value>
        public string TakeANote
        {
            set
            {
                this.takeANote = value;
            }
            get
            {
                return this.takeANote;
            }
        }
        /// <summary>
        /// Gets or sets the sendermail.
        /// </summary>
        /// <value>
        /// The sendermail.
        /// </value>
        public string Sendermail
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
    }

}
