using BiblioAsp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BiblioAsp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {


            routes.MapRoute(
            name: "AfficherAuteurs",
            url: "Afficher/{action}/{id}",
            defaults: new { controller = "Afficher", action = "Index", id = UrlParameter.Optional }, 
            constraints: new { id = @"\d+" }
            );

            routes.MapRoute(
           name: "RechercherLivre",
           url: "Rechercher/Livre/{titre}",
           defaults: new { controller = "Rechercher", action = "Livre" }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Index" }
            );

        
        }
    }
}
