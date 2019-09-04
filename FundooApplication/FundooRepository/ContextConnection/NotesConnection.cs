// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NotesConnection.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using FundooModel;

namespace FundooRepository.ContextConnection
{
    /// <summary>
    /// NotesConnection is the connection class.
    /// </summary>
    public class NotesConnection
    {
        /// <summary>
        /// The context
        /// </summary>
        UserContext context = new UserContext();
        /// <summary>
        /// Adds the specified user model.
        /// </summary>
        /// <param name="userModel">The user model.</param>
        public void Add(NotesModel userModel)
        {
            context.Notes.Add(userModel);
            context.SaveChanges();
        }
    }
}
