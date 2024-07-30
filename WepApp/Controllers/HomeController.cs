using Microsoft.AspNetCore.Mvc;
using WepApp.DAL;
using WepApp.Models;

namespace WepApp.Controllers
{
    public class HomeController : Controller
    {
        List<Marka> Markas;
        CarDbContext _carDbContext;

        public HomeController(CarDbContext carDbContext)
        {
            _carDbContext = carDbContext;
        }


        public IActionResult Index()
        {
            return View(_carDbContext.Markas.ToList());
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
