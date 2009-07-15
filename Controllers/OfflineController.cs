using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Offline.Controllers
{
  [HandleError]
  public class OfflineController : Controller
  {
    public ActionResult Splash()
    {
      var rootPath = this.ApplicationPathWithTrailingSlash + "Offline/";
      var path = Server.MapPath(@"~\offline\index.html");
      var body = System.IO.File.ReadAllText(path);
      body = body.Replace("${PATH_TO_ASSETS}", rootPath);
      return Content(body, "text/html");
    }

    protected string ApplicationPathWithTrailingSlash
    {
      get
      {
        if (this.Request.ApplicationPath.EndsWith("/"))
          return this.Request.ApplicationPath;
        return this.Request.ApplicationPath + "/";
      }
    }
  }
}
