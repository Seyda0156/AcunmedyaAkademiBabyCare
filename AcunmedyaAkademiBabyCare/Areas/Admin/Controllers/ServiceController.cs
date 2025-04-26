using AcunmedyaAkademiBabyCare.Context;
using AcunmedyaAkademiBabyCare.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AcunmedyaAkademiBabyCare.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceController : Controller
    {
        private readonly BabyCareContext _context;

        public ServiceController(BabyCareContext context)
        {
            _context = context;
        }

        public IActionResult ServiceList()
        {
            var values = _context.Services.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateService()
        {
            return View();

        }
        [HttpPost]
        public IActionResult CreateService(Service Service)
        {
            if (!ModelState.IsValid)//Kurallara uymuyorsa
            {
                return View(Service);
            }
            _context.Services.Add(Service);
            _context.SaveChanges();
            return RedirectToAction("ServiceList");

        }
        public IActionResult DeleteService(int id)
        {
            var value = _context.Services.Find(id);
            _context.Services.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("ServiceList");
        }
        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            var values = _context.Services.Find(id);
            return View(values);

        }
        [HttpPost]
        public IActionResult UpdateService(Service Service)
        {
            var values = _context.Services.Update(Service);
            _context.SaveChanges();
            return RedirectToAction("ServiceList");
        }
    }
}
