using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PlaygroundMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();
            //routes.MapRoute(
            //    "MoviesByReleaseDate", 
            //    "movie/released/{year}/{month}",                 
            //    new { controller = "Movie", action ="ByReleaseDate" },
            //    new { year = @"2015|", month = @"\d{2}" }
            //    //new { year = @"\d{4}" , month = @"\d{2}"}
            //    );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
