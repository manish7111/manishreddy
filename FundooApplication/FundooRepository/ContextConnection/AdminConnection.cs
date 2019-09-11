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
        public IEnumerable<UserModels> Display()
        {
            var list = context.UserData.ToList<UserModels>();
            return list;
        }
    }
}
