using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using CuisineTracker.Models;



namespace CuisineTracker.Controllers
{
  public class HomeController : Controller
  {
    private readonly CuisineContext _db;

    public HomeController(CuisineContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.CuisineId = new SelectList(_db.Cuisines, "CuisineId", "Description");
      return View();
    }


    [HttpPost]
    public ActionResult Index(int CuisineId)
    {
      return RedirectToAction("Details","Cuisines", new { id = CuisineId });
    }



  }
}