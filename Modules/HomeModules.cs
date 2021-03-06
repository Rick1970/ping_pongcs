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
        Ping newPing = new Ping(Request.Form[int.Parse("number")]);

        newPing.Calculate();
        newPing.Save();
        List<Ping> allPings = Ping.GetAll();

        return View["/number_added.cshtml", allPings];
      };
    }
  }
}
