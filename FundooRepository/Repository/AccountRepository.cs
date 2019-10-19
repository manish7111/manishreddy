// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
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
        public AccountRepository(UserContext context)
        {
            this.context = context;
            
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
            if (user != null && await this.CheckPasswordAsync(loginModel.Password,loginModel.Email))
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
                        //SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.applicationSettings.JWT_Secret)), SecurityAlgorithms.HmacSha256Signature)
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
        /// Checks the password asynchronous.
        /// </summary>
        /// <param name="password">The password.</param>
        /// <param name="email"></param>
        /// <returns></returns>
        public Task<bool> CheckPasswordAsync(string password,string email)
        {
            bool obj = context.UserData.Where(userName => userName.Password == password && userName.Email==email).SingleOrDefault().Email == email   ? true : false;

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
        public async Task ForgetPasswordAsync(ForgetPasswordModel model)
        {
            var user=await this.FindByEmailAsync(model.Email);
            if (user != null)
            {
                var fromAddress = new MailAddress("mmkr7111@gmail.com");
                var fromPassword = "manish7111";
                var toAddress = new MailAddress(model.Email);
                string subject = "Reset Password";
                string body = "To reset your password click link :-  http://localhost:3000/reset";
                SmtpClient smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new System.Net.NetworkCredential(fromAddress.Address, fromPassword)
                };

                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                    try
                    {
                        smtp.Send(message);
                    }
                    catch(Exception e)
                    {
                        throw new Exception(e.Message);
                    }
            }
        }
           

    
        /// <summary>
        /// Faces the book login asynchronous.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public async Task<string> FaceBookLoginAsync(string email)
        {
            UserModels user = context.UserData.Where(userName => userName.Email == email).SingleOrDefault();
            if (user != null)
            {
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                        {
                        new Claim("Email", user.Email)
                        }),
                    Expires = DateTime.UtcNow.AddDays(1),
                   // SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.applicationSettings.JWT_Secret)), SecurityAlgorithms.HmacSha256Signature)
                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                var token = tokenHandler.WriteToken(securityToken);
                var cacheKey = email;
                //this.distributedCache.GetString(cacheKey);
                //this.distributedCache.SetString(cacheKey, token);
                return token;
            }
            else
            {
                UserModels models = new UserModels();
                models.Email = email;
                models.Password = "12345667";
                models.FirstName = null;
                models.LastName = null;
                Connection connection = new Connection();
                connection.Add(models);
                var users = await this.FindByEmailAsync(email);
                if (users != null)
                {
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                            {
                        new Claim("Email", users.Email)
                            }),
                        Expires = DateTime.UtcNow.AddDays(1),
                        // SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.applicationSettings.JWT_Secret)), SecurityAlgorithms.HmacSha256Signature)
                    };
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                    var token = tokenHandler.WriteToken(securityToken);
                    var cacheKey = email;
                    //this.distributedCache.GetString(cacheKey);
                    //this.distributedCache.SetString(cacheKey, token);
                    return token;
                }
            }
            return "invalid user";
        }
        /// <summary>
        /// Images the specified file.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public string Image(Stream file, string email)
        {
            Account account = new Account("bridgelabz", "528399974555442", "Ts5d5Nso2b5SA1OwNPFMIdtutg0");
            Cloudinary cloudinary = new Cloudinary(account);
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(Guid.NewGuid().ToString(), file)
            };
            ImageUploadResult uploadResult = cloudinary.Upload(uploadParams);
            cloudinary.Api.UrlImgUp.BuildUrl(String.Format("{0}.{1}", uploadResult.PublicId, uploadResult.Format));
            var data = this.context.UserData.Where(t => t.Email == email).FirstOrDefault();
            data.ProfilePic = uploadResult.Uri.ToString();
            try
            {
                var result = this.context.SaveChanges();
                return data.ProfilePic;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}
