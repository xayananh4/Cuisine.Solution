using Microsoft.AspNetCore.Mvc;

namespace CuisineTracker.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}