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
                defaults: new { controller = "Inventory", action = "Stock", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Add Inventory SKU",
                url: "inventory/addsku/{id}",
                defaults: new { controller = "Inventory", action = "AddSku", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "View/Audit Full Inventory",
                url: "inventory/full/",
                defaults: new { controller = "Inventory", action = "FullInv" }
            );


            routes.MapRoute(
                name: "Add Recipe",
                url: "recipe/add/{id}",
                defaults: new { controller = "Recipe", action = "Add", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Choose A Recipe To Cook",
                url: "recipe/cook/",
                defaults: new { controller = "Recipe", action = "ChooseRecipe" }
            );

            routes.MapRoute(
                name: "Cook A Recipe",
                url: "recipe/cook/{id}",
                defaults: new { controller = "Recipe", action = "Cook", id = UrlParameter.Optional }
            );



            routes.MapRoute(
                name: "Generate Shopping List",
                url: "shopping/list/",
                defaults: new { controller = "Shopping", action = "Index" }
            );


           routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
