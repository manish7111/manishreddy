// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IAdmin.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using FundooModel;
using FundooModel.UserModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BussinessManager.Interfaces
{
    /// <summary>
    /// IAdmin is a interface.
    /// </summary>
    public interface IAdmin
    {
        /// <summary>
        /// Registrations the asynchronous.
        /// </summary>
        /// <param name="userModel">The user model.</param>
        /// <returns></returns>
        Task<bool> RegistrationAsync(AdminLoginModel userModel);
        /// <summary>
        /// Logins the asynchronous.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        Task<bool> LoginAsync(AdminLoginModel loginModel);
        /// <summary>
        /// Trashes the asynchronous.
        /// </summary>
        /// <returns></returns>
        IEnumerable<NotesModel> TrashAsync();
    }
}
