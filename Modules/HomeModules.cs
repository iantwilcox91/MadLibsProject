using Nancy;
using MadLibs.Objects;

namespace MadLibs
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        return View["mainpage.cshtml"];
      };

      Get["/madInsults"] = _ => {
        MadLibVariables myMadLibVariables = new MadLibVariables();
        myMadLibVariables.SetInsult1(Request.Query["insult1"]);
        myMadLibVariables.SetInsult2(Request.Query["insult2"]);
        myMadLibVariables.SetNameMom1(Request.Query["nameMom1"]);
        return View["madInsults.cshtml", myMadLibVariables];
      };
    }
  }
}
