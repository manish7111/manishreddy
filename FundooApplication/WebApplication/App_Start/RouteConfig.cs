// --------------------------------------------------------------------------------------------------------------------
// <copyright file=RouteConfig.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System.Web.Mvc;
using System.Web.Routing;

/// <summary>
/// WebApplication is the project.
/// </summary>
namespace WebApplication1
{
    /// <summary>
    /// RouteConfig is the class.
    /// </summary>
    public class RouteConfig
    {
        /// <summary>
        /// Registers the routes.
        /// </summary>
        /// <param name="routes">The routes.</param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute("Notes/Add", "add", new { controller = "Notes", action = "Add", id = UrlParameter.Optional });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Account", action = "Registration", id = UrlParameter.Optional }
            );
        }
    }
}
