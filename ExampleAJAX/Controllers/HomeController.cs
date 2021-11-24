using ExampleAJAX.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace ExampleAJAX.Controllers
{
    public class HomeController : Controller
    {
        StateContext db = new StateContext();

        public ActionResult Index()
        {
            int selectedIndex = 1;
            SelectList country = new SelectList(db.Countries, "ID", "Name", selectedIndex);
            ViewBag.Countries = country;
            SelectList city = new SelectList(db.Cities.Where(c => c.IDCountry == selectedIndex), "ID", "Name");
            ViewBag.Cities = city;
            return View();
        }
        public ActionResult GetItems(int id)
        {
            return PartialView(db.Cities.Where(c => c.IDCountry == id).ToList());
        }
    }
}
