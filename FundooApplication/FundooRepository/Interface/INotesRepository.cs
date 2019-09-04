// --------------------------------------------------------------------------------------------------------------------
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

namespace FundooRepository.Interface
{
    /// <summary>
    /// INotesRepository is the interface.
    /// </summary>
    public interface INotesRepository
    {
        /// <summary>
        /// Adds the specified notes.
        /// </summary>
        /// <param name="notes">The notes.</param>
        /// <returns>returns response</returns>
        string Add(NotesModel notes);

        /// <summary>
        /// Saves the changes asynchronous.
        /// </summary>
        /// <returns>return response</returns>
        Task<int> SaveChangesAsync();

        /// <summary>
        /// Removes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>return response</returns>
        Task<int> Remove(int id);

        /// <summary>
        /// Finds the asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>return response</returns>
        Task<NotesModel> FindAsync(int id);

        /// <summary>
        /// Gets all notes asynchronous.
        /// </summary>
        /// <returns>return response</returns>
        IEnumerable<NotesModel> GetAllNotesAsync();

        /// <summary>
        /// Gets the notes asynchronous.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns>return response</returns>
        IList<NotesModel> GetNotesAsync(Guid userId);

        /// <summary>
        /// Updates the notes.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="id">The identifier.</param>
        void UpdateNotes(NotesModel model, int id);

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
