// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Connection.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using FundooModel;
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// FundooRepository is the namespace.
/// </summary>
namespace FundooRepository.ContextConnection
{
    /// <summary>
    /// Connection is the classs which connects to database.
    /// </summary>
    public class Connection
    {
        /// <summary>
        /// The context
        /// </summary>
        UserContext context = new UserContext();
        /// <summary>
        /// Adds the specified user model.
        /// </summary>
        /// <param name="userModel">The user model.</param>
        public void Add(UserModel userModel)
        {
            context.UserData.Add(userModel);
            context.SaveChanges();
        }
        /// <summary>
        /// Updates the specified user model.
        /// </summary>
        /// <param name="userModel">The user model.</param>
        public void Update(UserModel userModel)
        {
            UserModel person = context.UserData.Find(userModel.Email);                 
            person.Password = userModel.Password;
            context.SaveChanges();
        }
    }
}
