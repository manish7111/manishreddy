// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NotesManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using BussinessManager.Interface;
using FundooModel;
using FundooRepository.Interface;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace BussinessManager.Manager
{
    /// <summary>
    /// NotesManager is the class.
    /// </summary>
    /// <seealso cref="BussinessManager.Interface.INotes" />
    public class NotesManager : INotes
    {
        /// <summary>
        /// The notes
        /// </summary>
        private readonly INotesRepository notes;
        /// <summary>
        /// Initializes a new instance of the <see cref="NotesManager"/> class.
        /// </summary>
        public NotesManager()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="NotesManager"/> class.
        /// </summary>
        /// <param name="notes">The notes.</param>
        public NotesManager(INotesRepository notes)
        {
            this.notes = notes;
        }
        /// <summary>
        /// Adds the notes asynchronous.
        /// </summary>
        /// <param name="notes">The notes.</param>
        /// <returns>
        /// returns int value
        /// </returns>
        public Task<int> AddNotesAsync(NotesModel notes)
        {
            this.notes.Add(notes);
            var result = this.notes.SaveChangesAsync();
            return result;
        }
        /// <summary>
        /// Deletes the asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// returns int value
        /// </returns>
        public Task<int> DeleteAsync(int id)
        {
            var result = this.notes.Remove(id);
            return result;
        }
        /// <summary>
        /// Deletes the note asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public Task<int> DeleteNoteAsync(int id)
        {
            var result = this.notes.RemoveNote(id);
            return result;
        }
        /// <summary>
        /// Gets all notes asynchronous.
        /// </summary>
        /// <returns>
        /// returns list
        /// </returns>
        public IEnumerable<NotesModel> GetAllNotesAsync()
        {
            var list = new List<NotesModel>();
            var result = this.notes.GetAllNotesAsync();
            foreach (var item in result)
            {
                list.Add(item);
            }
            return list;
        }
        /// <summary>
        /// Gets the notes.
        /// </summary>
        /// <param name="userid">The userid.</param>
        /// <returns></returns>
        public IList<NotesModel> GetNotes(string email)
        {
            return this.notes.GetNotesAsync(email);
        }
        /// <summary>
        /// Reminders the specified userid.
        /// </summary>
        /// <param name="userid">The userid.</param>
        /// <returns></returns>
        public Task UnReminder(int id)
        {
            return this.notes.UnReminder(id);
        }
        /// <summary>
        /// Updates the asynchronous.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// returns response
        /// </returns>
        public Task UpdateAsync(NotesModel model, int id)
        {
            this.notes.UpdateNotes(model, id);
            var result = this.notes.SaveChangesAsync();
            return result;
        }
        /// <summary>
        /// Archives the specified userid.
        /// </summary>
        /// <param name="userid">The userid.</param>
        /// <returns></returns>
        public IList<NotesModel> Archive(int Id)
        {
            return this.notes.Archive(Id);
        }
        /// <summary>
        /// Adds the notes label.
        /// </summary>
        /// <param name="notesLabel">The notes label.</param>
        /// <returns></returns>
        public string AddNotesLabel(NotesLabelModel notesLabel)
        {
            var result = this.notes.AddNotesLabel(notesLabel);
            return result;
        }
        /// <summary>
        /// Gets the notes label.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public List<NotesLabelModel> GetNotesLabel(int id)
        {
            return this.notes.GetNotesLabel(id);
        }
        /// <summary>
        /// Deletes the notes label.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public string DeleteNotesLabel(int id)
        {
            return this.notes.DeleteNotesLabel(id);
        }
        /// <summary>
        /// Adds the collaborator to note.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        public string AddCollaboratorToNote(int id, string receiverEmail)
        {
            var result = this.notes.AddCollaboratorToNote(id,receiverEmail);
            return result;
        }
        /// <summary>
        /// Removes the collaborator to note.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public string RemoveCollaboratorToNote(int id)
        {
            var result = this.notes.RemoveCollaboratorToNote(id);
            return result;
        }
        /// <summary>
        /// Collaborators the note.
        /// </summary>
        /// <param name="receiverEmail">The receiver email.</param>
        /// <returns></returns>
        public string CollaboratorNote(string receiverEmail)
        {
            var result = this.notes.CollaboratorNote(receiverEmail);
            return result;
        }
        /// <summary>
        /// Images the specified file.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public string Image(Stream file, int id)
        {
            var result = this.notes.Image(file, id);
            return result;
        }
        /// <summary>
        /// Determines whether [is archive asynchronous] [the specified identifier].
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<string> IsArchiveAsync(int id)
        {
            await this.notes.IsArchive(id);
            return "Archive success";
        }
        /// <summary>
        /// Uns the archive asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<string> UnArchiveAsync(int id)
        {
            await this.notes.UnArchive(id);
            return "UnArchive success";
        }
        /// <summary>
        /// Deletes the trash asynchronous.
        /// </summary>
        /// <returns></returns>
        public Task DeleteTrashAsync()
        {
           
            var result = this.notes.DeleteTrashAsync();
            return result;
        }
        /// <summary>
        /// Restores the notes asynchronous.
        /// </summary>
        /// <returns></returns>
        public Task RestoreNotesAsync()
        {

            var result = this.notes.RestoreNotesAsync();
            return result;
        }
        /// <summary>
        /// Pins the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public Task Pin(int id)
        {
            return this.notes.Pin(id);
        }
        /// <summary>
        /// Uns the pin.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public Task UnPin(int id)
        {
            return this.notes.UnPin(id);
        }
        /// <summary>
        /// Searches the notes asynchronous.
        /// </summary>
        /// <param name="Title">The title.</param>
        /// <returns></returns>
        public IList<NotesModel> SearchNotesAsync(string Title)
        {
            return this.notes.SearchNotesAsync(Title);
        }
        /// <summary>
        /// Drags the and drop.
        /// </summary>
        /// <param name="dragId">The drag identifier.</param>
        /// <param name="dropId">The drop identifier.</param>
        /// <returns></returns>
        public Task DragAndDrop(int dragId,int dropId)
        {
            return this.notes.DragAndDropAsync(dragId, dropId);
        }
    }
}
