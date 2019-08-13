// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RouteConfig.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System.Web;
using System.Web.Mvc;

namespace Employee_Management_System
{
    /// <summary>
    /// FilterConfig is a class.
    /// </summary>
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
