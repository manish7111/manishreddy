// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NotesRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using FundooModel;
using FundooRepository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.Repository
{
    /// <summary>
    /// NotesRepository is the class.
    /// </summary>
    public class NotesRepository : INotesRepository
    {
        /// <summary>
        /// UserContext is the class wich connects to the database.
        /// </summary>
        private UserContext context = null;
        /// <summary>
        /// NotesRepository default constructor.
        /// </summary>
        public NotesRepository()
        {
            
        }
        /// <summary>
        /// NotesRepository parameterised constructor.
        /// </summary>
        /// <param name="userContext"></param>
        public NotesRepository(UserContext userContext)
        {
            this.context = userContext;
        }
        /// <summary>
        /// Add is the method to add the notes .
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Add(NotesModel model)
        {
            NotesModel notesModel = new NotesModel()
            {
                Title = model.Title,
                Description = model.Description,
                Reminder = model.Reminder,
                IsArchive = model.IsArchive,
                IsTrash = model.IsTrash,
                IsPin = model.IsPin,
                Color = model.Color
            };
            var result = this.context.Notes.Add(notesModel);
            return null;
        }
        /// <summary>
        /// FindAsync is the method which is used to find the notes with respect to id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<NotesModel> FindAsync(int id)
        {
            var result = this.context.Notes.FindAsync(id);
            return result;
        }
        /// <summary>
        /// Remove method is used to delete the notes.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<int> Remove(int id)
        {
            var note = await this.FindAsync(id);
            this.context.Notes.Remove(note);
            var result = this.context.SaveChanges();
            return result;
        }
        /// <summary>
        /// SaveChangesAsync methos is used to save the changes made in the notes.
        /// </summary>
        /// <returns></returns>
        public Task<int> SaveChangesAsync()
        {
            var result = this.context.SaveChangesAsync();
            return result;
        }
        /// <summary>
        /// UpdateNotes methos is used to update the current notes.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="id"></param>

        public void UpdateNotes(NotesModel model,int id)
        {
            NotesModel notes = this.context.Notes.Where<NotesModel>(table => table.Id == id).FirstOrDefault();
            notes.Title = model.Title;
            notes.Description = model.Description;
            notes.Reminder = model.Reminder;
            notes.Color = model.Color;
            notes.IsArchive = model.IsArchive;
            notes.IsTrash = model.IsTrash;
            notes.IsPin = model.IsPin;
        }
        /// <summary>
        /// GetAllNotesAsync to get the list .
        /// </summary>
        /// <returns></returns>
        public IEnumerable<NotesModel> GetAllNotesAsync()
        {
            var result = this.context.Notes.ToList<NotesModel>();
            return result;
        }
        /// <summary>
        /// GetNotesAsync is used to get the list withrespect to guid.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IList<NotesModel> GetNotesAsync(Guid id)
        {
            var list = new List<NotesModel>();
            var note = from notes in this.context.Notes where notes.UserId == id orderby notes.Id descending select notes;
            foreach (var item in note)
            {
                list.Add(item);
            }
            return note.ToArray();

        }
        /// <summary>
        /// reminder is the notification reminder method.
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public IList<NotesModel> Reminder(Guid userid)
        {
            var list = new List<NotesModel>();
            var note = from notes in this.context.Notes where (notes.UserId == userid) && (notes.Reminder != null) select notes ;
            foreach (var item in note)
            {
                list.Add(item);
            }
            return list;
        }
        /// <summary>
        /// Archive is to get the list interms of zip file format.
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public IList<NotesModel> Archive(Guid userid)
        {
            var list = new List<NotesModel>();
            var note = from notes in this.context.Notes where (notes.UserId == userid) && (notes.IsArchive != true) && (notes.IsTrash != false) select notes;
            foreach (var item in note)
            {
                list.Add(item);
            }
            return list;
        }
    }
}
