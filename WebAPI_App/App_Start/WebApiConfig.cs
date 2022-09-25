using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebAPI_App
{
    public static class WebApiConfig
    {
        // Web API configuration and services
        public static void Register(HttpConfiguration config)
        {
            // fixed rounting
            config.MapHttpAttributeRoutes();

            // Web API custom route. It allow home controller action only using meta keywork in url.
            config.Routes.MapHttpRoute(
                name: "route",
                routeTemplate: "api/meta/{controller}/{action}/{id}",
                defaults: new { controller = "Home",action =RouteParameter.Optional, id = RouteParameter.Optional});

            // Default route for web api request.
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
