// --------------------------------------------------------------------------------------------------------------------
// <copyright file=INotes.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using FundooModel;
using System;
using System.Collections.Generic;
using System.IO;
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
        /// Deletes the trash asynchronous.
        /// </summary>
        /// <returns></returns>
        Task DeleteTrashAsync();
        /// <summary>
        /// Restores the notes asynchronous.
        /// </summary>
        /// <returns></returns>
        Task RestoreNotesAsync();
      

        /// <summary>
        /// Deletes the asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>returns int value</returns>
        Task<int> DeleteAsync(int id);
        /// <summary>
        /// Deletes the note asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<int> DeleteNoteAsync(int id);
        /// <summary>
        /// Searches the notes asynchronous.
        /// </summary>
        /// <param name="Title">The title.</param>
        /// <returns></returns>
        IList<NotesModel> SearchNotesAsync(string Title);
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
        IList<NotesModel> GetNotes(string email);

        /// <summary>
        /// Reminders the specified user identifier.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns>returns list</returns>
       Task UnReminder(int Id);

        /// <summary>
        /// Archives the specified user identifier.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns>returns list</returns>
        IList<NotesModel> Archive(int Id);
        /// <summary>
        /// Determines whether [is archive asynchronous] [the specified identifier].
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<string> IsArchiveAsync(int id);
        /// <summary>
        /// Uns the archive asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<string> UnArchiveAsync(int id);
        /// <summary>
        /// Adds the notes label.
        /// </summary>
        /// <param name="notesLabel">The notes label.</param>
        /// <returns></returns>
        string AddNotesLabel(NotesLabelModel notesLabel);
        /// <summary>
        /// Gets the notes label.
        /// </summary>
        /// <param name="email">The email.</param>
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
        string Image(Stream file, int id);
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
        /// Drags the and drop.
        /// </summary>
        /// <param name="dragId">The drag identifier.</param>
        /// <param name="dropId">The drop identifier.</param>
        /// <returns></returns>
        Task DragAndDrop(int dragId, int dropId);
    }

}

