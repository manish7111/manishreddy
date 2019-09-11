// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IUserContext.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------


using FundooModel;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Threading.Tasks;

/// <summary>
/// FundooRepository is the namespace.
/// </summary>
namespace FundooRepository
{
    /// <summary>
    /// IUserContext is the interface.
    /// </summary>
    public interface IUserContext
    {
        /// <summary>
        /// Creates the asynchronous.
        /// </summary>
        /// <param name="userModel">The user model.</param>
        /// <returns></returns>
        Task CreateAsync(UserModels userModel);
        /// <summary>
        /// Logins the asynchronous.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        Task<string> LoginAsync(LoginModel loginModel);
        /// <summary>
        /// Finds the by name asynchronous.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <returns></returns>
        Task<IdentityUser> FindByNameAsync(string userName);
        /// <summary>
        /// Checks the password asynchronous.
        /// </summary>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        Task<bool> CheckPasswordAsync(string password);
        /// <summary>
        /// Resets the password asynchronous.
        /// </summary>
        /// <param name="resetPasswordModel">The reset password model.</param>
        /// <returns></returns>
        Task ResetPasswordAsync(ResetPasswordModel resetPasswordModel);
        /// <summary>
        /// Finds the by email asynchronous.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        Task<IdentityUser> FindByEmailAsync(string email);
        /// <summary>
        /// Forgets the password asynchronous.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        Task ForgetPasswordAsync(ResetPasswordModel model);

        /// <summary>
        /// Faces the book login asynchronous.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        Task<string> FaceBookLoginAsync(string email);
    }
}
