using BussinessManager.Interfaces;
using FundooModel;
using FundooModel.UserModel;
using FundooRepository;
using FundooRepository.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BussinessManager.Manager
{
    /// <summary>
    /// AdminManager is a class which implements IAdmin interface.
    /// </summary>
    /// <seealso cref="BussinessManager.Interfaces.IAdmin" />
    public class AdminManager:IAdmin
    {
        /// <summary>
        /// The admin
        /// </summary>
        private readonly IAdminRepository admin;
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminManager"/> class.
        /// </summary>
        public AdminManager()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminManager"/> class.
        /// </summary>
        /// <param name="admin">The admin.</param>
        public AdminManager(IAdminRepository admin)
        {
            this.admin = admin;
        }
        /// <summary>
        /// Registrations the asynchronous.
        /// </summary>
        /// <param name="userModel">The user model.</param>
        /// <returns></returns>
        public async Task<bool> RegistrationAsync(AdminLoginModel userModel)
        {
            await this.admin.CreateAsync(userModel);
            return true;
        }
        /// <summary>
        /// Logins the asynchronous.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        public Task<bool> LoginAsync(AdminLoginModel loginModel)
        {
            var result = this.admin.LoginAsync(loginModel);
            return result;
        }
        /// <summary>
        /// Trashes the asynchronous.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<NotesModel> TrashAsync()
        {
            var result = this.admin.TrashAsync();
            return result;
        }
    }
}
