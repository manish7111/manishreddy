// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RouteConfig.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Raavi Ramcharan"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

/// <summary>
/// EmployeeManagementSystem is a namespace.
/// </summary>
namespace Employee_Management_System
{
    /// <summary>
    /// RouteConfig is a class where i declared the routing.
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

            ////Mapping the routes with the controller and by default it will open the starting page.
            routes.MapRoute("Home/ListOfEmployees", "home/list", new { Controller = "Home", action = "ListOfEmployees", id = UrlParameter.Optional });

            routes.MapRoute("Home/AddEmployee", "home/add", new { Controller = "Home", action = "AddEmployee", id = UrlParameter.Optional });
            routes.MapRoute("Home/UpdateEmployee", "home/update", new { Controller = "Home", action = "UpdateEmployee", id = UrlParameter.Optional });
            routes.MapRoute("Home/DeleteEmployee", "home/delete", new { Controller = "Home", action = "DeleteEmployee", id = UrlParameter.Optional });
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "AddEmployee", id = UrlParameter.Optional }
            );
        }
    }
}
