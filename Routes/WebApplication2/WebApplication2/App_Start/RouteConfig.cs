using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using PageService.Controllers;
using JsonService.Controllers;
using System.Web.Mvc.Routing.Constraints;

namespace WebApplication2
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
                namespaces: new[] { "PageService.Controllers" },
                defaults: new { controller = "Example", action = "Index", data = "missing data:)" }
            );

            routes.MapRoute(
                name: "ServiceJson",
                url: "Service/{data}",
                constraints: new { httpMethod = new HttpMethodConstraint("POST") },
                namespaces: new[] { "JsonService.Controllers" },
                defaults: new { controller = "Example", action = "Index", data = "missing data:)" }
            );

            routes.MapRoute(
                name: "Compound",
                url: "Compound/{data}",
                constraints: new {
                    data = new CompoundRouteConstraint(new IRouteConstraint[] {
                        new IntRouteConstraint(),
                        new MinLengthRouteConstraint(4)
                    })
                },
                defaults: new { controller = "Compound", action = "Index", data = "1234567" }
            );

        }
    }
}
