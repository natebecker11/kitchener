using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace kitchener
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");



            routes.MapRoute(
                name: "Add Inventory Stock",
                url: "inventory/addstock/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Add Recipe",
                url: "recipe/add/",
                defaults: new { controller = "Home", action = "FullInv", format = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Choose A Recipe To Cook",
                url: "recipe/cook/",
                defaults: new { controller = "Home", action = "FullInv", format = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Cook A Recipe",
                url: "recipe/cook/{id}",
                defaults: new { controller = "Home", action = "FullInv", format = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Add Inventory SKU",
                url: "inventory/addsku/",
                defaults: new { controller = "Home", action = "FullInv", format = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Generate Shopping List",
                url: "shopping/list/",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "View/Audit Full Inventory",
                url: "inventory/full/",
                defaults: new { controller = "Home", action = "FullInv", format = UrlParameter.Optional }
            );

           routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
