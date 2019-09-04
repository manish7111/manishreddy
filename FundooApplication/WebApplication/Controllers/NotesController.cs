// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NotesController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using BussinessManager.Interface;
using FundooModel;
using FundooRepository.ContextConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    /// <summary>
    /// NotesController  is the controller class.
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class NotesController : ApiController
    {
        /// <summary>
        /// The notes
        /// </summary>
        public readonly INotes notes ;
        /// <summary>
        /// The connect
        /// </summary>
        NotesConnection connect = new NotesConnection();
        /// <summary>
        /// Initializes a new instance of the <see cref="NotesController"/> class.
        /// </summary>
        public NotesController()
        {
           
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="NotesController"/> class.
        /// </summary>
        /// <param name="notes">The notes.</param>
        public NotesController(INotes notes)
        {
            this.notes = notes;
        }
        /// <summary>
        /// Adds the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("add")]
        public async Task<IHttpActionResult> Add(NotesModel model)
        {
          
            var result = await this.notes.AddNotesAsync(model);
            if(result==1)
            {
                connect.Add(model);
                return this.Ok();
            }
            else
            {
                return this.BadRequest();
            }
        }
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("delete")]
        public async Task<IHttpActionResult> Delete(int id)
        {
            var result = await this.notes.DeleteAsync(id);
            if (result == 1)
            {
                return this.Ok();
            }
            else
            {
                return this.BadRequest();
            }
        }
        /// <summary>
        /// Gets all notes.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("get")]
        public IEnumerable<NotesModel> GetAllNotes()
        {
            return this.notes.GetAllNotesAsync();
        }
        /// <summary>
        /// Updates the notes.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("update")]
        public async Task<IHttpActionResult> UpdateNotes(NotesModel model,int id)
        {
            try
            {
                await this.notes.UpdateAsync(model, id);
                return this.Ok();
            }catch(Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Gets the specified unique identifier.
        /// </summary>
        /// <param name="guid">The unique identifier.</param>
        /// <returns></returns>
        public IHttpActionResult Get(Guid guid)
        {
            IList<NotesModel> notesModel = this.notes.GetNotes(guid);
            if(notesModel==null)
            {
                return this.BadRequest("Couldnt find the required notes");
            }
            return this.Ok(notes);
        }
        /// <summary>
        /// Reminders the specified unique identifier.
        /// </summary>
        /// <param name="guid">The unique identifier.</param>
        /// <returns></returns>
        public IHttpActionResult Reminder(Guid guid)
        {
            IList<NotesModel> notesModel = this.notes.Reminder(guid);
            if (notesModel == null)
            {
                return this.BadRequest("Couldnt find the required notes");
            }
            return this.Ok(notes);
        }
        /// <summary>
        /// Archives the specified unique identifier.
        /// </summary>
        /// <param name="guid">The unique identifier.</param>
        /// <returns></returns>
        public IHttpActionResult Archive(Guid guid)
        {
            IList<NotesModel> notesModel = this.notes.Archive(guid);
            if (notesModel == null)
            {
                return this.BadRequest("Couldnt find the required notes");
            }
            return this.Ok(notes);
        }
    }
}
