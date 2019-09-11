// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NotesRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using FundooModel;
using FundooRepository.Interface;
using System;
using System.Collections.Generic;
using System.IO;
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
        private readonly UserContext context = null;
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
                Email=model.Email,
                Title = model.Title,
                Description = model.Description,
                Reminder = model.Reminder,
                IsArchive = model.IsArchive,
                IsTrash = model.IsTrash,
                IsPin = model.IsPin,
                Color = model.Color
            };
            this.context.Notes.Add(notesModel);
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
        public IList<NotesModel> GetNotesAsync(string email)
        {
            var list = new List<NotesModel>();
            var note = from notes in this.context.Notes where notes.Email == email orderby notes.Id descending select notes;
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
        public IList<NotesModel> Reminder(string email)
        {
            var list = new List<NotesModel>();
            var note = from notes in this.context.Notes where (notes.Email == email) && (notes.Reminder != null) select notes ;
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
        public IList<NotesModel> Archive(string email)
        {
            var list = new List<NotesModel>();
            var note = from notes in this.context.Notes where (notes.Email == email) && (notes.IsArchive != true) && (notes.IsTrash != false) select notes;
            foreach (var item in note)
            {
                list.Add(item);
            }
            return list;
        }
       
     
        /// <summary>
        /// Adds the notes label.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string AddNotesLabel(NotesLabelModel model)
        {
            try
            {
                var LabelData = from t in this.context.NoteLabel where t.Email == model.Email select t;
                foreach(var item in LabelData.ToList())
                {
                    if(item.NoteId==model.NoteId && item.LableId==model.LableId)
                    {
                        return false.ToString();
                    }
                }
                var data = new NotesLabelModel
                {
                    LableId = model.LableId,
                    NoteId = model.NoteId,
                    Email = model.Email

                };
                int result = 0;
                this.context.NoteLabel.Add(data);
                result = this.context.SaveChanges();
                return result.ToString();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        /// Deletes the notes label.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string DeleteNotesLabel(int id)
        {
            var label = this.context.NoteLabel.Where<NotesLabelModel>(t => t.Id == id).FirstOrDefault();
            try
            {
                this.context.NoteLabel.Remove(label);
                var result = this.context.SaveChanges();
                return result.ToString();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        /// Gets the notes label.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<NotesLabelModel> GetNotesLabel(string email)
        {
            var list = new List<NotesLabelModel>();
            var labelData = from t in this.context.NoteLabel where t.Email == email select t;
            try
            {
                foreach (var items in labelData)
                {
                    list.Add(items);
                }
               
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return list;
        }
        /// <summary>
        /// Adds the collaborator to note.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string AddCollaboratorToNote(CollaboratorModel model)
        {
            try
            {
                var data= from t in this.context.Collaborator where t.Email == model.Email select t;
                foreach (var items in data.ToList())
                {
                    if(items.NoteId.Equals(model.NoteId)&& items.ReceiverEmail.Equals(model.ReceiverEmail))
                    {
                        return false.ToString();
                    }
                }
                var newData = new CollaboratorModel()
                {
                    Email = model.Email,
                    NoteId = model.NoteId,
                    SenderEmail = model.SenderEmail,
                    ReceiverEmail = model.ReceiverEmail
                };
                this.context.Collaborator.Add(newData);
                var result = this.context.SaveChanges();
                return result.ToString();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        /// Removes the collaborator to note.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string RemoveCollaboratorToNote(int id)
        {
            try
            {
                var data = this.context.Collaborator.Where<CollaboratorModel>(t => t.Id == id).FirstOrDefault();
                this.context.Collaborator.Remove(data);
                var result = this.context.SaveChanges();
                return result.ToString();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        /// Collaborators the note.
        /// </summary>
        /// <param name="receiverMail">The receiver mail.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string CollaboratorNote(string receiverMail)
        {
            try
            {
                var collaboratorData = new List<NotesModel>();
                var sharedNotes = new List<SharedNotes>();
                var data = from collaborator in this.context.Collaborator where collaborator.ReceiverEmail == receiverMail
                           select new
                           {
                               collaborator.SenderEmail,
                               collaborator.NoteId
                           };
                foreach(var result in data)
                {
                    var collNotes = from notes in this.context.Notes
                                    where notes.Id == result.NoteId
                                    select new SharedNotes
                                    {
                                        NoteId = notes.Id,
                                        Title = notes.Title,
                                        TakeANote = notes.Description
                                    };
                    foreach(var collaborator in collNotes)
                    {
                        sharedNotes.Add(collaborator);
                    }
                }
                return sharedNotes.ToString();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        /// Images the specified file.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public string Image(Stream file,string email)
        {
            Account account = new Account("bridgelabz", "528399974555442", "Ts5d5Nso2b5SA1OwNPFMIdtutg0");
            Cloudinary cloudinary = new Cloudinary(account);
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(Guid.NewGuid().ToString(), file)
            };
            ImageUploadResult uploadResult = cloudinary.Upload(uploadParams);
            cloudinary.Api.UrlImgUp.BuildUrl(String.Format("{0}.{1}", uploadResult.PublicId, uploadResult.Format));
            var data = this.context.Notes.Where(t => t.Email == email).FirstOrDefault();
            data.Image = uploadResult.Uri.ToString();
            try
            {
                var result = this.context.SaveChanges();
                return data.Image;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
 