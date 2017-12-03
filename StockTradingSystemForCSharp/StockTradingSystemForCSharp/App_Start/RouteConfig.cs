using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace StockTradingSystemForCSharp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
<<<<<<< HEAD
                defaults: new { controller = "Users", action = "Login", id = UrlParameter.Optional }
=======
                defaults: new { controller = "Users", action = "Main", id = UrlParameter.Optional }
>>>>>>> refs/remotes/origin/workspace
            );
        }
    }
}
