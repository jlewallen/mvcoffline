using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Routing;
using System.Web.Mvc;

namespace Offline
{
  public class MvcApplication : HttpApplication
  {
    public static void RegisterRoutes(RouteCollection routes)
    {
      routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
      routes.IgnoreRoute("Offline/*");
      routes.Add(new EverythingGoesToOneController());
    }

    protected void Application_Start()
    {
      RegisterRoutes(RouteTable.Routes);
    }
  }
}