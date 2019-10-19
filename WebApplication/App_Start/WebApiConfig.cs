// --------------------------------------------------------------------------------------------------------------------
// <copyright file=WebApiConfig.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using BussinessManager.Interface;
using BussinessManager.Interfaces;
using BussinessManager.Manager;
using FundooRepository;
using FundooRepository.Interface;
using FundooRepository.Repository;
using System.Web.Http;
using System.Web.Http.Cors;
using Unity;
using WebApplication1.DependencyInjection;


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
            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);
            var container = new UnityContainer();
            
            container.RegisterType<IUserContext, AccountRepository>();
            container.RegisterType<IAccount, AccountManager>();
            container.RegisterType<INotesRepository, NotesRepository>();
            container.RegisterType<INotes, NotesManager>();
            container.RegisterType<ILabelRepository, LabelRepository>();
            container.RegisterType<ILabel, LabelManager>();
            container.RegisterType<IAdminRepository, AdminRepository>();
            container.RegisterType<IAdmin, AdminManager>();
            config.DependencyResolver = new UnityResolver(container);

            GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();


            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Formatters.XmlFormatter.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("multipart/form-data"));

        }
    }
}
