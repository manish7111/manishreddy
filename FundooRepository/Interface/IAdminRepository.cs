// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IAdminRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using FundooModel;
using FundooModel.UserModel;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.Interface
{
    /// <summary>
    /// IAdminRepository is a Interface
    /// </summary>
    public interface IAdminRepository
    {
        /// <summary>
        /// Creates the asynchronous.
        /// </summary>
        /// <param name="userModel">The user model.</param>
        /// <returns></returns>
        Task CreateAsync(AdminLoginModel userModel);
        /// <summary>
        /// Logins the asynchronous.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        Task<bool> LoginAsync(AdminLoginModel loginModel);
        /// <summary>
        /// Checks the password asynchronous.
        /// </summary>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        Task<bool> CheckPasswordAsync(string password);
        /// <summary>
        /// Finds the by email asynchronous.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        Task<IdentityUser> FindByEmailAsync(string email);
        /// <summary>
        /// Trashes the asynchronous.
        /// </summary>
        /// <returns></returns>
        IEnumerable<NotesModel> TrashAsync();
    }
}
