﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using BussinessManager.Interface;
using FundooModel;
using FundooRepository;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// BussinessManager is the project.
/// </summary>
namespace BussinessManager.Manager
{
    /// <summary>
    /// AccountManager is the class which is implementing IAccount interface.
    /// </summary>
    /// <seealso cref="BussinessManager.Interface.IAccount" />
    public class AccountManager : IAccount
    {
        /// <summary>
        /// The context
        /// </summary>
        private readonly IUserContext context;
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountManager"/> class.
        /// </summary>
        public AccountManager()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountManager"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public AccountManager(IUserContext context)
        {
            this.context = context;
        }
        /// <summary>
        /// Registrations the asynchronous.
        /// </summary>
        /// <param name="userModel">The user model.</param>
        /// <returns></returns>
        public async Task<bool> RegistrationAsync(UserModels userModel)
        {
            await this.context.CreateAsync(userModel);
            return true;
        }
        /// <summary>
        /// Logins the asynchronous.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        public Task<string> LoginAsync(LoginModel loginModel)
        {
            var result = this.context.LoginAsync(loginModel);
            return result;
        }
       
        /// <summary>
        /// Resets the password.
        /// </summary>
        /// <param name="resetPasswordModel">The reset password model.</param>
        /// <returns></returns>
        public async Task<bool> ResetPassword(ResetPasswordModel resetPasswordModel)
        {
            await this.context.ResetPasswordAsync(resetPasswordModel);
            return true;

        }
        /// <summary>
        /// Forgets the password.
        /// </summary>
        /// <param name="resetPasswordModel">The reset password model.</param>
        /// <returns></returns>
        public async Task<bool> ForgetPassword(ForgetPasswordModel resetPasswordModel)
        {

            await this.context.ForgetPasswordAsync(resetPasswordModel);
            return true;
        }
        /// <summary>
        /// Faces the book login asynchronous.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public Task<string> FaceBookLoginAsync(string email)
        {
            var result = this.context.FaceBookLoginAsync(email);
            return result;
        }
        /// <summary>
        /// Images the specified file.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public string Image(Stream file, string email)
        {
            var result = this.context.Image(file, email);
            return result;
        }
    }
}