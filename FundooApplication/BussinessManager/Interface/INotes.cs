﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file=INotes.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using FundooModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// BussinessManager is the project.
/// </summary>
namespace BussinessManager.Interface
{
    /// <summary>
    /// INotes is the interface.
    /// </summary>
    public interface INotes
    {
        /// <summary>
        /// Adds the notes asynchronous.
        /// </summary>
        /// <param name="notes">The notes.</param>
        /// <returns>returns int value</returns>
        Task<int> AddNotesAsync(NotesModel notes);

        /// <summary>
        /// Gets all notes asynchronous.
        /// </summary>
        /// <returns>returns list</returns>
        IEnumerable<NotesModel> GetAllNotesAsync();

        /// <summary>
        /// Deletes the asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>returns int value</returns>
        Task<int> DeleteAsync(int id);

        /// <summary>
        /// Updates the asynchronous.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="id">The identifier.</param>
        /// <returns>returns response</returns>
        Task UpdateAsync(NotesModel model, int id);

        /// <summary>
        /// Gets the notes.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns>returns list</returns>
        IList<NotesModel> GetNotes(Guid userId);

        /// <summary>
        /// Reminders the specified user identifier.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns>returns list</returns>
        IList<NotesModel> Reminder(Guid userId);

        /// <summary>
        /// Archives the specified user identifier.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns>returns list</returns>
        IList<NotesModel> Archive(Guid userId);
    }

}