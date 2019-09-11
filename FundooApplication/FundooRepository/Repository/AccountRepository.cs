// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using FundooModel;
using FundooRepository.ContextConnection;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.IdentityModel.Tokens;

/// <summary>
/// FundooRepository is the namespace
/// </summary>
namespace FundooRepository
{
    /// <summary>
    /// AccountRepository is a class which implements IUserContext.
    /// </summary>
    /// <seealso cref="FundooRepository.IUserContext" />
    public class AccountRepository : IUserContext
    {
        /// <summary>
        /// The context
        /// </summary>
        private readonly UserContext context = null;
        /// <summary>
        /// The application settings
        /// </summary>
        private readonly ApplicationSettings applicationSettings;
        /// <summary>
        /// The distributed cache
        /// </summary>
        private readonly IDistributedCache distributedCache=null;
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountRepository"/> class.
        /// </summary>
        public AccountRepository()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="applicationSettings">The application settings.</param>
        public AccountRepository(UserContext context, ApplicationSettings applicationSettings)
        {
            this.context = context;
            this.applicationSettings = applicationSettings;
           
        }
        /// <summary>
        /// Creates the asynchronous.
        /// </summary>
        /// <param name="userModel">The user model.</param>
        /// <returns></returns>
        public Task CreateAsync(UserModels userModel)
        {
            UserModels userDbModel = new UserModels()
            {
                UserName = userModel.UserName,
                FirstName = userModel.FirstName,
                LastName = userModel.LastName,
                Email = userModel.Email,
                Password = userModel.Password
            };
            return Task.Run(() => context.SaveChanges());
        }
        /// <summary>
        /// Logins the asynchronous.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        public async Task<string> LoginAsync(LoginModel loginModel)
        {
            var user = await this.FindByEmailAsync(loginModel.Email);
            if (user != null && await this.CheckPasswordAsync(loginModel.Password))
            {
                try
                {
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                        {
                       new Claim("Email",user.Email)
                        }),
                        Expires = DateTime.UtcNow.AddDays(1),
                       // SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.applicationSettings.JWT_Secret)), SecurityAlgorithms.HmacSha256Signature)
                    };
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                    var token = tokenHandler.WriteToken(securityToken);
                    var cacheKey = loginModel.Email;
                    //this.distributedCache.GetString(cacheKey);
                    //this.distributedCache.SetString(cacheKey, token);
                    return token;
                }catch(Exception  e)
                {
                    throw new Exception(e.Message);
                }
            }
            return "invalid user";
        }
        /// <summary>
        /// Finds the by name asynchronous.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <returns></returns>
        public Task<IdentityUser> FindByNameAsync(string userName)
        {
            UserModels user = context.UserData.Where(run => run.UserName == userName).SingleOrDefault();
            IdentityUser Iuser = new IdentityUser()
            {
                UserName = user.UserName
            };
            return Task.Run(() => Iuser);
        }

        public Task<bool> CheckPasswordAsync(string password)
        {
            bool obj = context.UserData.Where(userName => userName.Password == password).SingleOrDefault().Password != null ? true : false;

            return Task.Run(() => obj);
        }
        /// <summary>
        /// Resets the password asynchronous.
        /// </summary>
        /// <param name="resetPasswordModel">The reset password model.</param>
        /// <returns></returns>
        public Task ResetPasswordAsync(ResetPasswordModel resetPasswordModel)
        {
            Connection connection = new Connection();
            UserModels obj = context.UserData.Where(userName => userName.Email == resetPasswordModel.Email).SingleOrDefault();
            obj.Password = resetPasswordModel.Password;
            connection.Update(obj);
            return Task.Run(() => context.SaveChanges());
        }
        /// <summary>
        /// Finds the by email asynchronous.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public Task<IdentityUser> FindByEmailAsync(string email)
        {
            UserModels user = context.UserData.Where(r => r.Email == email).SingleOrDefault();
            IdentityUser Iuser = new IdentityUser()
            {
                Email = user.Email
            };
            return Task.Run(() => Iuser);
        }
        /// <summary>
        /// Forgets the password asynchronous.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        public Task ForgetPasswordAsync(ResetPasswordModel model)
        {
            Connection connection = new Connection();
            UserModels obj = context.UserData.Where(userName => userName.Email == model.Email).SingleOrDefault();
            obj.Password = model.Password;
            connection.Update(obj);
            return Task.Run(() => context.SaveChanges());
        }
        /// <summary>
        /// Faces the book login asynchronous.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public async Task<string> FaceBookLoginAsync(string email)
        {
            var user = await this.FindByEmailAsync(email);
            if (user != null)
            {
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                        {
                        new Claim("Email", user.Email)
                        }),
                    Expires = DateTime.UtcNow.AddDays(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.applicationSettings.JWT_Secret)), SecurityAlgorithms.HmacSha256Signature)
                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                var token = tokenHandler.WriteToken(securityToken);
                var cacheKey = email;
                this.distributedCache.GetString(cacheKey);
                this.distributedCache.SetString(cacheKey, token);
                return token;
            }
            return "invalid user";
        }
    
    }
}
