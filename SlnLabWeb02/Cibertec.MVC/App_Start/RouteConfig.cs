using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Cibertec.MVC
{
    public class RouteConfig
    {
        //Se define la tabla de enrutamiento del sitio web
        public static void RegisterRoutes(RouteCollection routes)
        {
            //Indica al motor de ruteo que los request que involucren recursos axd no no se van a tomar en cuenta,
            //van a ser gestionadas directamente por IIS
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Ruta estática
            routes.MapRoute(
                name: "Clientes",
                url: "Clientes",
                defaults: new { controller = "Customer", action = "Index" }
            );

        //Ruta dinámica
        //http://localhost/Thomas

            routes.MapRoute(
                name: "ClientesDinamica",
                url: "Clientes/{id}/{action}",
                defaults: new { controller = "Customer", action = "Details" },
                constraints: new { id = @"\d+" }
            );

            //Ruta seo
            routes.MapRoute(
                name: "ClientesSEO",
                url: "{ClientName}",
                defaults: new { controller = "Customer", action = "DetailsName" }
            );

            routes.MapRoute(
             name: "Default",
             url: "{controller}/{action}/{id}",
             defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
         );
        }
    }
}
