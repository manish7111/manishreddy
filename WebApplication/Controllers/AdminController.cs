// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AdminController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using BussinessManager.Interface;
using BussinessManager.Interfaces;
using FundooModel;
using FundooModel.UserModel;
using FundooRepository.ContextConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    /// <summary>
    /// AdminController is a Controller which implements ApiController.
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class AdminController : ApiController
    {
        /// <summary>
        /// The admin
        /// </summary>
        private readonly IAdmin admin = null;
        /// <summary>
        /// The notes
        /// </summary>
        public readonly INotes notes;
        /// <summary>
        /// The admin connection
        /// </summary>
        AdminConnection adminConnection = new AdminConnection();
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminController"/> class.
        /// </summary>
        public AdminController()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminController"/> class.
        /// </summary>
        /// <param name="admin">The admin.</param>
        public AdminController(IAdmin admin)
        {
            this.admin = admin;
        }
        /// <summary>
        /// Admins the registration.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("adminregister")]
        public async Task<IHttpActionResult> AdminRegistration(AdminLoginModel model)
        {
            try
            { 
                var result = await this.admin.RegistrationAsync(model);
                adminConnection.Register(model);
                return this.Ok(new { result });
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Admins the login.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("adminlogin")]
        public async Task<IHttpActionResult> AdminLogin(AdminLoginModel loginModel)
        {
            var result = await this.admin.LoginAsync(loginModel);
            var list=adminConnection.Details();
           
            if (result == false)
            {
                return this.BadRequest();
            }
            else
            {
                return this.Ok(new { list });
            }
        }

        /// <summary>
        /// Gets the user details.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("get")]
        public IHttpActionResult GetUserDetails()
        {
            int basicCount = 0, advanceCount = 0;
            var list = adminConnection.Display();   
            
            foreach(var item in list)
            {
                IList<NotesModel> items = adminConnection.GetNotes(item.Email);
                if (item.Service=="Basic")
                {
                    basicCount++;
                }
                else if(item.Service=="Advance")
                {
                    advanceCount++;
                } 
            }
           
            return Ok(new { list,basicCount,advanceCount});
        }
        /// <summary>
        /// Bulks the trash.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("trash")]
        public IHttpActionResult BulkTrash()
        {
            try
            {
                var list = this.admin.TrashAsync();
                return this.Ok(new { list });
            }
            catch(Exception e)
            {
                return this.BadRequest(e.Message);
            }
           
        }

    }
}
