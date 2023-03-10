using Microsoft.AspNetCore.Mvc;
using CuisineTracker.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace CuisineTracker.Controllers
{
  public class ReviewsController : Controller
  {
    private readonly CuisineContext _db;

    public ReviewsController(CuisineContext db)
    {
      _db = db;
    }


    public ActionResult Create(int id)
    {
      ViewBag.RestaurantId = id;
      return View();
    }


    [HttpPost]
    public ActionResult Create(Review review)
    {
      // Review thisReview = _db.Reviews.FirstOrDefault(review => review.RestaurantId == id);
      if (review.RestaurantId == 0)
      {
        return RedirectToAction("Create");
      }
      _db.Reviews.Add(review);
      _db.SaveChanges();

      return RedirectToAction("Details", "Restaurants", new { id = review.RestaurantId } );
    }

  }
}
