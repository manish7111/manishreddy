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
        /// Gets or sets the note identifier.
        /// </summary>
        /// <value>
        /// The note identifier.
        /// </value>
        public int NoteId { get; set; }
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }
        /// <summary>
        /// Gets or sets the take a note.
        /// </summary>
        /// <value>
        /// The take a note.
        /// </value>
        public string TakeANote { get; set; }
        /// <summary>
        /// Gets or sets the sendermail.
        /// </summary>
        /// <value>
        /// The sendermail.
        /// </value>
        public string Sendermail { get; set; }
    }

}
