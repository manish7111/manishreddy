// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NotesManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using BussinessManager.Interface;
using FundooModel;
using FundooRepository.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BussinessManager.Manager
{
    /// <summary>
    /// NotesManager is the class.
    /// </summary>
    /// <seealso cref="BussinessManager.Interface.INotes" />
    public class NotesManager:INotes
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
        public IList<NotesModel> GetNotes(Guid userid)
        {
            return this.notes.GetNotesAsync(userid);
        }
        /// <summary>
        /// Reminders the specified userid.
        /// </summary>
        /// <param name="userid">The userid.</param>
        /// <returns></returns>
        public IList<NotesModel> Reminder(Guid userid)
        {
            return this.notes.Reminder(userid);
        }
        /// <summary>
        /// Updates the asynchronous.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// returns response
        /// </returns>
        public Task UpdateAsync(NotesModel model,int id)
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
        public IList<NotesModel> Archive(Guid userid)
        {
            return this.notes.Archive(userid);
        }
    }
}
