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
using System.Web;
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
        /// <summary>
        /// The connection
        /// </summary>
        readonly Connection connection = new Connection();
        /// <summary>
        /// The admin
        /// </summary>
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
        /// Registrations the specified models.
        /// </summary>
        /// <param name="models">The models.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("register")]
        public async Task<IHttpActionResult> Registration(UserModels models)
        {
            try
            {
                connection.Add(models);
                var result = await this.account.RegistrationAsync(models);
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
            var data = connection.GetDetails(loginModel.Email);
            foreach(var item in data)
            {
                model.Service = item.Service;
            }
            admin.Add(model);
            if (result == "invalid user")
            {
                return this.BadRequest();
            }
            else
            {
                return this.Ok(new {result,data});
            }
        }
        /// <summary>
        /// Forgets the password.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("forget")]
        public IHttpActionResult ForgetPassword(ForgetPasswordModel model)
       {
            try
            {
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
        /// <param name="resetPasswordModel">The reset password model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("reset")]
        public async Task<IHttpActionResult> ResetPassword(ResetPasswordModel resetPasswordModel)
        {
            try
            {
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
        /// <param name="Email">The email.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("fblogin")]
        public async Task<IHttpActionResult> FaceBookLogin(string Email)
        {
            try
            {
                var result = await this.account.FaceBookLoginAsync(Email);
                AdminModel model = new AdminModel();
                model.Email = Email;
                DateTime time = DateTime.Now;
                model.LoginTime = time.ToString();
                admin.Add(model);
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
        /// <summary>
        /// Images this instance.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("profileupload")]
        public IHttpActionResult Image()
        {
            var file = HttpContext.Current.Request.Files.Count > 0 ? HttpContext.Current.Request.Files[0] : null;
            var email = HttpContext.Current.Request.Params.Get("email");
            if (file == null)
            {
                return this.NotFound();
            }
            else
            {
                var result = this.account.Image(file.InputStream, email);
                return this.Ok(new { result });

            }
        }

    }
}
