using AcunmedyaAkademiBabyCare.Context;
using AcunmedyaAkademiBabyCare.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AcunmedyaAkademiBabyCare.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
    {
        private readonly BabyCareContext _context;

        public AboutController(BabyCareContext context)
        {
            _context = context;
        }

        public IActionResult AboutList()
        {
            var values = _context.Abouts.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateAbout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateAbout(About About)
        {
            //Fast Fail
            if (!ModelState.IsValid)//Kurallara uymuyorsa
            {
                return View(About);
            }
            _context.Abouts.Add(About);
            _context.SaveChanges();
            return RedirectToAction("AboutList");

        }
        public IActionResult DeleteAbout(int id)
        {
            var value = _context.Abouts.Find(id);
            _context.Abouts.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("AboutList");
        }
        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var values = _context.Abouts.Find(id);
            return View(values);

        }
        [HttpPost]
        public IActionResult UpdateAbout(About About)
        {
            var values = _context.Abouts.Update(About);
            _context.SaveChanges();
            return RedirectToAction("AboutList");
        }
    }
}
