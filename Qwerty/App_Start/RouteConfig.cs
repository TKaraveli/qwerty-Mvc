using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Qwerty
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            //routes.MapRoute(
            //    "MoviesByReleaseDate",
            //    "movies/released/{year}/{month}",
            //    new {controller = "Movies", action = "ByReleaseDate"},
            //    new { year = @"\{4}", month = @"\d{2}" } //yıl kısmına 4, ay kısmına 2 haneli sayı girilmesi zorunluluğu getiriyor.
            //    //new { year = @"2015|2016", month = @"\d{2}" } //yalnızca 2015 veya 2016 değerleri alabilir.
            //    );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
