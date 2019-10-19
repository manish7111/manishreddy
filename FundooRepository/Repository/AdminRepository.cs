// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AdminRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using FundooModel;
using FundooModel.UserModel;
using FundooRepository.Interface;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.Repository
{
    /// <summary>
    /// AdminRepository is a Repository class which implements IAdminRepository.
    /// </summary>
    /// <seealso cref="FundooRepository.Interface.IAdminRepository" />
    public class AdminRepository:IAdminRepository
    {
        /// <summary>
        /// The context
        /// </summary>
        private readonly UserContext context = null;
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminRepository"/> class.
        /// </summary>
        public AdminRepository()
        {

        }
        public AdminRepository(UserContext context)
        {
            this.context = context;
        }
        /// <summary>
        /// Creates the asynchronous.
        /// </summary>
        /// <param name="userModel">The user model.</param>
        /// <returns></returns>
        public Task CreateAsync(AdminLoginModel userModel)
        {
            AdminLoginModel model = new AdminLoginModel()
            {
                Email = userModel.Email,
                FirstName= userModel.FirstName,
                LastName= userModel.LastName,
                Password = userModel.Password
            };
            return Task.Run(() => context.SaveChanges());
        }
        /// <summary>
        /// Logins the asynchronous.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<bool> LoginAsync(AdminLoginModel loginModel)
        {
            var user = await this.FindByEmailAsync(loginModel.Email);
            if (user != null && await this.CheckPasswordAsync(loginModel.Password))
            {
                try
                { 
                    return true;
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
            return false;
        }
        /// <summary>
        /// Checks the password asynchronous.
        /// </summary>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public Task<bool> CheckPasswordAsync(string password)
        {
            bool obj = context.AdminLogin.Where(userName => userName.Password == password).SingleOrDefault().Password != null ? true : false;

            return Task.Run(() => obj);
        }
        /// <summary>
        /// Finds the by email asynchronous.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public Task<IdentityUser> FindByEmailAsync(string email)
        {
            AdminLoginModel user = context.AdminLogin.Where(r => r.Email == email).SingleOrDefault();
            IdentityUser Iuser = new IdentityUser()
            {
                Email = user.Email
            };
            return Task.Run(() => Iuser);
        }

        /// <summary>
        /// Trashes the asynchronous.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<NotesModel> TrashAsync()
        {
            var list = new List<NotesModel>();
            var model = from notes in this.context.Notes where (notes.IsTrash != false) select notes;

            foreach (var data in model)
            {
                list.Add(data);
            }
            return list;
        }
    }
}
