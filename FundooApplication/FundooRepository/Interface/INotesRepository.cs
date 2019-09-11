// --------------------------------------------------------------------------------------------------------------------
// <copyright file=INotes.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using FundooModel;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
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
        IList<NotesModel> GetNotesAsync(string email);

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
        IList<NotesModel> Reminder(string email);

        /// <summary>
        /// Archives the specified user identifier.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns>returns list</returns>
        IList<NotesModel> Archive(string email);
        /// <summary>
        /// Adds the notes label.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        string AddNotesLabel(NotesLabelModel model);
        /// <summary>
        /// Gets the notes label.
        /// </summary>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        List<NotesLabelModel> GetNotesLabel(string Email);
        /// <summary>
        /// Deletes the notes label.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        string DeleteNotesLabel(int id);
        /// <summary>
        /// Adds the collaborator to note.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        string AddCollaboratorToNote(CollaboratorModel model);
        /// <summary>
        /// Removes the collaborator to note.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        string RemoveCollaboratorToNote(int id);
        /// <summary>
        /// Collaborators the note.
        /// </summary>
        /// <param name="receiverEmail">The receiver email.</param>
        /// <returns></returns>
        string CollaboratorNote(string receiverEmail);
        /// <summary>
        /// Images the specified file.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        string Image(Stream file, string email);


    }
}
