// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IAccount.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using FundooModel;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// BussinessManager is the project.
/// </summary>
namespace BussinessManager.Interface
{
    /// <summary>
    /// IAccount is the interface.
    /// </summary>
    public interface IAccount
    {
        /// <summary>
        /// Registrations the asynchronous.
        /// </summary>
        /// <param name="userModel">The user model.</param>
        /// <returns></returns>
        Task<bool> RegistrationAsync(UserModels userModel);
        /// <summary>
        /// Logins the asynchronous.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        Task<string> LoginAsync(LoginModel loginModel);
       
        /// <summary>
        /// Forgets the password.
        /// </summary>
        /// <param name="resetModel">The reset model.</param>
        /// <returns></returns>
        Task<bool> ForgetPassword(ForgetPasswordModel resetModel);
        /// <summary>
        /// Resets the password.
        /// </summary>
        /// <param name="resetModel">The reset model.</param>
        /// <returns></returns>
        Task<bool> ResetPassword(ResetPasswordModel resetModel);
        /// <summary>
        /// Faces the book login asynchronous.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        Task<string> FaceBookLoginAsync(string email);
        /// <summary>
        /// Images the specified file.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        string Image(Stream file, string email);
    }
}
