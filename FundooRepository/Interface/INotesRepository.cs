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
        /// Removes the note.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<int> RemoveNote(int id);
        /// <summary>
        /// Searches the notes asynchronous.
        /// </summary>
        /// <param name="Title">The title.</param>
        /// <returns></returns>
        IList<NotesModel> SearchNotesAsync(string Title);

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
        /// Deletes the trash asynchronous.
        /// </summary>
        /// <returns></returns>
        Task DeleteTrashAsync();

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
        Task UnReminder(int id);

        /// <summary>
        /// Archives the specified user identifier.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns>returns list</returns>
        IList<NotesModel> Archive(int Id);
        /// <summary>
        /// Determines whether the specified identifier is archive.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task IsArchive(int id);
        /// <summary>
        /// Uns the archive.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task UnArchive(int id);
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
        List<NotesLabelModel> GetNotesLabel(int id);
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
        string AddCollaboratorToNote(int id, string receiverEmail);
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
        string Image(Stream file,int id);
        /// <summary>
        /// Restores the notes asynchronous.
        /// </summary>
        /// <returns></returns>
        Task RestoreNotesAsync();
        /// <summary>
        /// Pins the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task Pin(int id);
        /// <summary>
        /// Uns the pin.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task UnPin(int id);
        /// <summary>
        /// Drags the and drop asynchronous.
        /// </summary>
        /// <param name="dragId">The drag identifier.</param>
        /// <param name="dropId">The drop identifier.</param>
        /// <returns></returns>
        Task DragAndDropAsync(int dragId, int dropId);

    }
}
