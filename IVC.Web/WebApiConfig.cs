using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace IVC.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
         name: "DefaultAPI",
         routeTemplate: "api/{controller}/{id}",
         defaults: new { id = RouteParameter.Optional }
         );
        }
    }
}