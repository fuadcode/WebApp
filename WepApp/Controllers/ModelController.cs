using Microsoft.AspNetCore.Mvc;
using WepApp.DAL;

namespace WepApp.Controllers
{
    public class ModelController : Controller
    {
        readonly CarDbContext _carDbContext;

        public ModelController(CarDbContext carDbContext)
        {
            _carDbContext = carDbContext;
        }

        public IActionResult Index(int? markaId)
        {
            if (markaId is null) return View(_carDbContext.Models.ToList());
            if (_carDbContext.Models.Any(m => m.MarkaId == markaId)) return View(_carDbContext.Models.Where(m => m.MarkaId == markaId).ToList());
            return BadRequest();
        }
    }
}