using Nancy;
using System.Collections.Generic;
using PingPong.Objects;

namespace PingPong
{
  public class HomeModule : NancyModule
  {
    public HomeModule() {

      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Post["/number_added"] = _ => {
        return View["number_added.cshtml"];
      };
    }
  }
}
