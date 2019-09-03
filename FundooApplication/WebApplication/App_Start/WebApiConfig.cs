// --------------------------------------------------------------------------------------------------------------------
// <copyright file=WebApiConfig.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using BussinessManager.Interface;
using BussinessManager.Manager;
using FundooRepository;
using System.Web.Http;
using Unity;
using WebApplication1.DependencyInjection;

/// <summary>
/// WebApplication1 is a namespace.
/// </summary>
namespace WebApplication1
{
    /// <summary>
    /// WebApiConfig is a class.
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// Registers the specified configuration.
        /// </summary>
        /// <param name="config">The configuration.</param>
        public static void Register(HttpConfiguration config)
        {
            var container = new UnityContainer();
            
            container.RegisterType<IUserContext, AccountRepository>();
            container.RegisterType<IAccount, AccountManager>();
            config.DependencyResolver = new UnityResolver(container);



            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
