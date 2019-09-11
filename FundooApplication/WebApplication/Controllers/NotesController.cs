// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NotesController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using BussinessManager.Interface;
using FundooModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Web;
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
        public readonly INotes notes;

        
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
            if (result == 1)
            {
                // connect.Add(model);
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
        /// <returns></returns>
        [HttpPut]
        [Route("update")]
        public async Task<IHttpActionResult> UpdateNotes(NotesModel model)
        {
            try
            {
                await this.notes.UpdateAsync(model, model.Id);
                return this.Ok();
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Gets the specified unique identifier.
        /// </summary>
        /// <param name="email">The unique identifier.</param>
        /// <returns></returns>
        public IHttpActionResult Get(string email)
        {
            IList<NotesModel> notesModel = this.notes.GetNotes(email);
            if (notesModel == null)
            {
                return this.BadRequest("Couldnt find the required notes");
            }
            return this.Ok(notes);
        }
        /// <summary>
        /// Reminders the specified unique identifier.
        /// </summary>
        /// <param name="email">The unique identifier.</param>
        /// <returns></returns>
        public IHttpActionResult Reminder(string email)
        {
            IList<NotesModel> notesModel = this.notes.Reminder(email);
            if (notesModel == null)
            {
                return this.BadRequest("Couldnt find the required notes");
            }
            return this.Ok(notes);
        }
        /// <summary>
        /// Archives the specified unique identifier.
        /// </summary>
        /// <param name="email">The unique identifier.</param>
        /// <returns></returns>
        public IHttpActionResult Archive(string email)
        {
            IList<NotesModel> notesModel = this.notes.Archive(email);
            if (notesModel == null)
            {
                return this.BadRequest("Couldnt find the required notes");
            }
            return this.Ok(notes);
        }
        /// <summary>
        /// Adds the note label.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("notelabel")]
        public IHttpActionResult AddNoteLabel(NotesLabelModel model)
        {
            var result = this.notes.AddNotesLabel(model);
            if (result == null)
            {
                return this.NotFound();
            }
            else
            {
                return this.Ok(new { result });
            }
        }
        /// <summary>
        /// Gets the note label.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("getnotelabel")]
        public IHttpActionResult GetNoteLabel(string email)
        {
            IList<NotesLabelModel> result = this.notes.GetNotesLabel(email);
            if (result == null)
            {
                return this.NotFound();
            }
            else
            {
                return this.Ok(new { result });
            }
        }
        /// <summary>
        /// Deletes the note label.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("deletenotelabel")]
        public IHttpActionResult DeleteNoteLabel(int id)
        {
            var result = this.notes.DeleteNotesLabel(id);
            if (result == null)
            {
                return this.NotFound();
            }
            else
            {
                return this.Ok(new { result });
            }
        }

        /// <summary>
        /// Adds the collaborator to note.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("collaborator")]
        public IHttpActionResult AddCollaboratorToNote(CollaboratorModel model)
        {
            var result = this.notes.AddCollaboratorToNote(model);
            if (result == null)
            {
                return this.NotFound();
            }
            else
            {
                return this.Ok(new { result });
            }
        }
        /// <summary>
        /// Removes the collaborator to note.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("removecollaborator")]
        public IHttpActionResult RemoveCollaboratorToNote(int id)
        {
            var result = this.notes.RemoveCollaboratorToNote(id);
            if (result == null)
            {
                return this.NotFound();
            }
            else
            {
                return this.Ok(new { result });
            }
        }
        /// <summary>
        /// Collaborators the note.
        /// </summary>
        /// <param name="receiverEmail">The receiver email.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("collaboratormail")]
        public IHttpActionResult CollaboratorNote(string receiverEmail)
        {
            var result = this.notes.CollaboratorNote(receiverEmail);
            if (result == null)
            {
                return this.NotFound();
            }
            else
            {
                return this.Ok(new { result });
            }
        }
        /// <summary>
        /// Images this instance.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("image")]
        public IHttpActionResult Image()
        {

            var file = HttpContext.Current.Request.Files.Count > 0 ? HttpContext.Current.Request.Files[0] : null;
            var email = HttpContext.Current.Request.Params.Get("email");
            if (file == null)
            {
                return this.NotFound();
            }
            else
            {

                var result = this.notes.Image(file.InputStream, email);
                return this.Ok(new { result });

            }
        }
    }
}
