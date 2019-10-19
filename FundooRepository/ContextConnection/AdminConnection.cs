// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AdminConnection.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using FundooModel;
using FundooModel.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FundooRepository.ContextConnection
{
    /// <summary>
    /// AdminConnection is a class.
    /// </summary>
    public class AdminConnection
    {
        /// <summary>
        /// The context
        /// </summary>
        UserContext context = new UserContext();
        /// <summary>
        /// Adds the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        public void Add(AdminModel model)
        {
            context.AdminModel.Add(model);
            context.SaveChanges();
        }
        /// <summary>
        /// Registers the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        public void Register(AdminLoginModel model)
        {
            context.AdminLogin.Add(model);
            context.SaveChanges();
        }
        /// <summary>
        /// Detailses this instance.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AdminModel> Details()
        {
            var list = context.AdminModel.ToList<AdminModel>();
            return list;
        }
        /// <summary>
        /// Displays this instance.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AdminModel> Display()
        {
            var list = context.AdminModel.ToList<AdminModel>();
            return list;
        }
        public IList<NotesModel> GetNotesAsync(string email)
        {
            var list = new List<NotesModel>();

            var note = from notes in this.context.Notes where (notes.Email == email || notes.ReceiverEmail == email) select notes;
            foreach (var item in note)
            {
                list.Add(item);
            }

            return list;

        }
        /// <summary>
        /// Gets the notes.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public IList<NotesModel> GetNotes(string email)
        {
            var list = new List<NotesModel>();
            AdminModel model = new AdminModel();
            var countList = new List<int>();
            var note = from notes in this.context.Notes where (notes.Email == email) select notes;
            foreach (var item in note)
            {
                list.Add(item);
            }
            var result = this.Display();
            foreach(var items in result)
            {
                if(items.Email==email)
                {
                    items.NotesCount = list.Count();
                }
            }
            this.context.SaveChanges();
            return list;

        }

    }
}
