// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using BussinessManager.Interface;
using FundooModel;
using FundooRepository.ContextConnection;
using System;
using System.Threading.Tasks;
using System.Web.Http;

/// <summary>
/// WebApplication is the Namespace
/// </summary>
namespace WebApplication1.Controllers
{
    /// <summary>
    /// AccountController is the class.
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class AccountController : ApiController
    {
        private IAccount account = null;
        Connection connection = new Connection();
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountController"/> class.
        /// </summary>
        public AccountController()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountController"/> class.
        /// </summary>
        /// <param name="account">The account.</param>
        public AccountController(IAccount account)
        {
            this.account = account;
        }
        /// <summary>
        /// Registrations the specified user name.
        /// </summary>
        /// <param name="UserName">Name of the user.</param>
        /// <param name="FirstName">The first name.</param>
        /// <param name="LastName">The last name.</param>
        /// <param name="Email">The email.</param>
        /// <param name="Password">The password.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("register")]
        public async Task<IHttpActionResult> Registration(string UserName, string FirstName, string LastName, string Email, string Password)
        {
            try
            {
                UserModel userModel = new UserModel();
                userModel.UserName = UserName;
                userModel.FirstName = FirstName;
                userModel.LastName = LastName;
                userModel.Email = Email;
                userModel.Password = Password;
                connection.Add(userModel);
                var result = await this.account.RegistrationAsync(userModel);
                return this.Ok(new { result });
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Logins the specified user name.
        /// </summary>
        /// <param name="UserName">Name of the user.</param>
        /// <param name="Password">The password.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("login")]
        public async Task<IHttpActionResult> Login(string UserName, string Password)
        {
            LoginModel loginModel = new LoginModel();
            loginModel.UserName = UserName;
            loginModel.Password = Password;
            var result = await this.account.LoginAsync(loginModel);
            var user = await this.account.FindByName(UserName);
            if (result == "invalid user")
            {
                return this.BadRequest();
            }
            else
            {
                return this.Ok(new { result, user });
            }
        }
        /// <summary>
        /// Forgets the password.
        /// </summary>
        /// <param name="Email">The email.</param>
        /// <param name="Password">The password.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("forget")]
        public IHttpActionResult ForgetPassword(string Email, string Password)
        {
            try
            {

                ResetPasswordModel model = new ResetPasswordModel();
                model.Email = Email;
                model.Password = Password;
                var result = this.account.ForgetPassword(model);

                return this.Ok(result);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Resets the password.
        /// </summary>
        /// <param name="Email">The email.</param>
        /// <param name="Password">The password.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("reset")]
        public async Task<IHttpActionResult> ResetPassword(string Email, string Password)
        {
            try
            {
               
                ResetPasswordModel resetPasswordModel = new ResetPasswordModel();
                resetPasswordModel.Email = Email;
                resetPasswordModel.Password = Password;
                var result = await this.account.ResetPassword(resetPasswordModel);
              
                return this.Ok(result);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }

        }
        /// <summary>
        /// Faces the book login.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("fblogin")]
        public async Task<IHttpActionResult> FaceBookLogin(string email)
        {
            try
            {
                var result = await this.account.FaceBookLoginAsync(email);
                if (result == "invalid user")
                {
                    return this.BadRequest();
                }
                else
                {
                    return this.Ok(new { result });
                }
            }catch(Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
    }
}
