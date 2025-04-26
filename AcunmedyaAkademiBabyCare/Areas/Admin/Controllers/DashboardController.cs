using AcunmedyaAkademiBabyCare.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AcunmedyaAkademiBabyCare.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private readonly BabyCareContext _context;

        public DashboardController(BabyCareContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var value =_context.Events.ToList();
            ViewBag.v1 = _context.Teams.ToList().Count();
            ViewBag.v2 = _context.Events.ToList().Count();
            ViewBag.v3 = _context.Services.ToList().Count();
            ViewBag.v4 = _context.Classes.ToList().Count();
            return View(value);
        }
    }
}
