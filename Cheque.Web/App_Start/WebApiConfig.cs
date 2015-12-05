using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Cheque.Web
{
  
class WebApiConfig
{
    public static void Register(HttpConfiguration configuration)
    {
        configuration.Routes.MapHttpRoute("API Default", "api/{controller}/{amount}",
             defaults: new { controller = "Converter" });
    }
}
}