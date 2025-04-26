using AcunmedyaAkademiBabyCare.Context;
using AcunmedyaAkademiBabyCare.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AcunmedyaAkademiBabyCare.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EventController : Controller
    {
        private readonly BabyCareContext _context;

        public EventController(BabyCareContext context)
        {
            _context = context;
        }

        public IActionResult EventList()
        {
            var values = _context.Events.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateEvent()
        {
            return View();

        }
        [HttpPost]
        public IActionResult CreateEvent(Event Event)
        {
            if (!ModelState.IsValid)//Kurallara uymuyorsa
            {
                return View(Event);
            }
            _context.Events.Add(Event);
            _context.SaveChanges();
            return RedirectToAction("EventList");

        }
        public IActionResult DeleteEvent(int id)
        {
            var value = _context.Events.Find(id);
            _context.Events.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("EventList");
        }
        [HttpGet]
        public IActionResult UpdateEvent(int id)
        {
            var values = _context.Events.Find(id);
            return View(values);

        }
        [HttpPost]
        public IActionResult UpdateEvent(Event Event)
        {
            var values = _context.Events.Update(Event);
            _context.SaveChanges();
            return RedirectToAction("EventList");
        }
    }
}
