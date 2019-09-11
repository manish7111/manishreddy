// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using BussinessManager.Interface;
using FundooModel;
using FundooModel.UserModel;
using FundooRepository.ContextConnection;
using System;
using System.Threading.Tasks;
using System.Web.Http;


namespace WebApplication1.Controllers
{
    /// <summary>
    /// AccountController is the class.
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class AccountController : ApiController
    {
        private readonly IAccount account = null;
        readonly Connection connection = new Connection();
        readonly AdminConnection admin = new AdminConnection();
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
                UserModels userModel = new UserModels();
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
       /// Logins the instance.
       /// </summary>
       /// <param name="loginModel"></param>
       /// <returns></returns>
        [HttpPost]
        [Route("login")]
        public async Task<IHttpActionResult> Login(LoginModel loginModel)
        {
            var result = await this.account.LoginAsync(loginModel);
            AdminModel model = new AdminModel();
            model.Email = loginModel.Email;
            DateTime time = DateTime.Now;
            model.LoginTime = time.ToString();
            admin.Add(model);
            if (result == "invalid user")
            {
                return this.BadRequest();
            }
            else
            {
                return this.Ok(new { result});
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
