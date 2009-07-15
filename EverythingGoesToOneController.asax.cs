using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Offline
{
  public class EverythingGoesToOneController : RouteBase
  {
    public override RouteData GetRouteData(HttpContextBase httpContext)
    {
      var routeData = new RouteData(this, new MvcRouteHandler());
      routeData.Values.Add("controller", "Offline");
      routeData.Values.Add("action", "Splash");
      return routeData;
    }

    public override VirtualPathData GetVirtualPath(RequestContext requestContext, RouteValueDictionary values)
    {
      var httpRequest = requestContext.HttpContext.Request;
      var virtualPath = httpRequest.AppRelativeCurrentExecutionFilePath.Substring(2) + httpRequest.PathInfo;
      return new VirtualPathData(this, virtualPath);
    }
  }
}