// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Connection.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using FundooModel;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public void Add(UserModels userModel)
        {
            context.UserData.Add(userModel);
            context.SaveChanges();
        }
        /// <summary>
        /// Updates the specified user model.
        /// </summary>
        /// <param name="userModel">The user model.</param>
        public void Update(UserModels userModel)
        {
            UserModels person = context.UserData.Find(userModel.Email);                 
            person.Password = userModel.Password;
            context.SaveChanges();
        }
        /// <summary>
        /// Detailses this instance.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<UserModels> Details()
        {
            var list = context.UserData.ToList<UserModels>();
            return list;
        }
        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        public IEnumerable<UserModels> GetDetails(string Email)

        {
            var list = new List<UserModels>();
            var data = from t in this.context.UserData.Where(t => t.Email == Email) select t;
            foreach(var item in data)
            {
                list.Add(item);
            }
            return list;
        }
    }
}
