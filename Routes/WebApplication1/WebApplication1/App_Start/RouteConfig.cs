using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using PageService;
using JsonService;

namespace WebApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            var route = routes.MapRoute(
                name: "Default",
                url: "Home/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "WebApplication1.Controllers" }
            );

            routes.MapRoute(
                name: "ServicePage",
                url: "Service/{data}",                               
                constraints: new { httpMethod = new HttpMethodConstraint("GET") },
                namespaces: new[] { "PageService.Controllers" } ,
                defaults: new { controller = "Example", action="Index", data="missing data:)"}               
            );

            routes.MapRoute(
                name: "ServiceJson",
                url: "Service/{data}",
                constraints: new { httpMethod = new HttpMethodConstraint("POST") },
                namespaces: new[] { "JsonService.Controllers" },
                defaults: new { controller = "Example", action = "Index",  data = "missing data:)" }
            );

        }
    }
}
