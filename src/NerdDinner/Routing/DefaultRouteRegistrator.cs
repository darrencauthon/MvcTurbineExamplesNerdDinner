﻿using System.Web.Mvc;
using System.Web.Routing;
using MvcTurbine.Routing;

namespace NerdDinner.Routing
{
    public class DefaultRouteRegistrator : IRouteRegistrator
    {
        public void Register(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "PrettyDetails",
                "{Id}",
                new {controller = "Dinners", action = "Details"},
                new {Id = @"\d+"}
                );

            routes.MapRoute(
                "UpcomingDinners",
                "Dinners/Page/{page}",
                new {controller = "Dinners", action = "Index"}
                );

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new {controller = "Home", action = "Index", id = ""} // Parameter defaults
                );
        }
    }
}