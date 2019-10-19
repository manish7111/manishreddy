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
        /// <param name="Id">The identifier.</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("deletenotes")]
        public async Task<IHttpActionResult> Delete(int Id)
        {
            var result = await this.notes.DeleteAsync(Id);
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
        [Route("getNotes")]
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
        /// <param name="Email">The unique identifier.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("getnotess")]
        public IHttpActionResult Get(string Email)
        {
            IList<NotesModel> notesModel = this.notes.GetNotes(Email);
            if (notesModel == null)
            {
                return this.BadRequest("Couldnt find the required notes");
            }
            return this.Ok(notesModel);
        }
        /// <summary>
        /// Reminders the specified unique identifier.
        /// </summary>
        /// <param name="Id">The unique identifier.</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("unreminder")]
        public IHttpActionResult UnReminder(int Id)
        {
            var result = this.notes.UnReminder(Id);
            if (result == null)
            {
                return this.Ok(notes);
               
            }
            return this.BadRequest("Couldnt find the required notes");
        }
        /// <summary>
        /// Archives the specified unique identifier.
        /// </summary>
        /// <param name="Id">The unique identifier.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("archive")]
        public IHttpActionResult Archive(int Id)
        {
            IList<NotesModel> notesModel = this.notes.Archive(Id);
            if (notesModel == null)
            {
                return this.BadRequest("Couldnt find the required notes");
            }
            return this.Ok(notes);
        }
        /// <summary>
        /// Determines whether the specified identifier is archive.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("isarchive")]
        public async Task<IHttpActionResult> IsArchive(int Id)
        {
            try
            {
                var result = await this.notes.IsArchiveAsync(Id);
                return this.Ok(new { result });
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Uns the archive.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("unarchive")]
        public async Task<IHttpActionResult> UnArchive(int Id)
        {
            try
            {
                var result = await this.notes.UnArchiveAsync(Id);
                return this.Ok(new { result });
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Pins the specified identifier.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("pinnote")]
        public async Task<IHttpActionResult> Pin(int Id)
        {
            try
            {
                await this.notes.Pin(Id);
                return this.Ok("success");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return this.BadRequest();
            }
        }
        /// <summary>
        /// Uns the pin.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("unpinnote")]
        public async Task<IHttpActionResult> UnPin(int Id)
        {
            try
            {
                await this.notes.UnPin(Id);
                return this.Ok("success");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return this.BadRequest();
            }
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
        /// <param name="Id">The email.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("getnotelabel")]
        public IHttpActionResult GetNoteLabel(int Id)
        {
            IList<NotesLabelModel> result = this.notes.GetNotesLabel(Id);
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
        /// <param name="Id">The identifier.</param>
        /// <param name="ReceiverEmail">The receiver email.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("collaborator")]
        public IHttpActionResult AddCollaboratorToNote(int Id, string ReceiverEmail)
        {
            var result = this.notes.AddCollaboratorToNote(Id,ReceiverEmail);
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
        /// <param name="Id">The identifier.</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("removecollaborator")]
        public IHttpActionResult RemoveCollaboratorToNote(int Id)
        {
            var result = this.notes.RemoveCollaboratorToNote(Id);
            if (result == null)
            {
                return this.Ok(notes);

            }
            return this.BadRequest("Couldnt find the required notes");
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
        public IHttpActionResult Image(int Id)
        {
            var file = HttpContext.Current.Request.Files.Count > 0 ? HttpContext.Current.Request.Files[0] : null;
            //var email = HttpContext.Current.Request.Params.Get("email");
            if (file == null)
            {
                return this.NotFound();
            }
            else
            {
                var result = this.notes.Image(file.InputStream, Id);
                return this.Ok(new { result });

            }
        }
        /// <summary>
        /// Deletes the trash asynchronous.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("deleteTrash")]
        public IHttpActionResult DeleteTrashAsync()
        {
           
            var result = this.notes.DeleteTrashAsync();
            if (result == null)
            {
                return this.Ok(new { result });

            }
            else
            {
                return this.NotFound();
            }

        }
        /// <summary>
        /// Restores the notes asynchronous.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("restoreTrash")]
        public IHttpActionResult RestoreNotesAsync()
        {
            var result = this.notes.RestoreNotesAsync();
            if (result == null)
            {
                return this.Ok(new { result });
               
            }
            else
            {
                return this.NotFound();
            }
        }
        /// <summary>
        /// Deletes the trash notes.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("deleteTrashNotes")]
        public async Task<IHttpActionResult> DeleteTrashNotes(int Id)
        {
            var result = await this.notes.DeleteNoteAsync(Id);
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
        /// Searches the notes.
        /// </summary>
        /// <param name="Title">The title.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/search")]
        public IHttpActionResult SearchNotes(string Title)
        {
            IList<NotesModel> notesModel =  this.notes.SearchNotesAsync(Title);
            if (notesModel != null)
            {
                return this.Ok(new { notesModel });
            }
            else
            {
                return this.BadRequest();
            }
        }
        /// <summary>
        /// Drags the and drop.
        /// </summary>
        /// <param name="dragId">The drag identifier.</param>
        /// <param name="dropId">The drop identifier.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/DnD")]
        public IHttpActionResult DragAndDrop(int dragId,int dropId)
        {
            var result = this.notes.DragAndDrop(dragId, dropId);
            if (result != null)
            {
                return this.Ok(new { result });
            }
            else
            {
                return this.BadRequest();
            }

        }
    }
}
