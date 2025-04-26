using AcunmedyaAkademiBabyCare.Context;
using AcunmedyaAkademiBabyCare.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AcunmedyaAkademiBabyCare.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ClassController : Controller
    {
        private readonly BabyCareContext _context;

        public ClassController(BabyCareContext context)
        {
            _context = context;
        }

        public IActionResult ClassList()
        {
            var values = _context.Classes.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateClass()
        {
            return View();

        }
        [HttpPost]
        public IActionResult CreateClass(Class Class)
        {
            if (!ModelState.IsValid)//Kurallara uymuyorsa
            {
                return View(Class);
            }
            _context.Classes.Add(Class);
            _context.SaveChanges();
            return RedirectToAction("ClassList");

        }
        public IActionResult DeleteClass(int id)
        {
            var value = _context.Classes.Find(id);
            _context.Classes.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("ClassList");
        }
        [HttpGet]
        public IActionResult UpdateClass(int id)
        {
            var values = _context.Classes.Find(id);
            return View(values);

        }
        [HttpPost]
        public IActionResult UpdateClass(Class Class)
        {
            var values = _context.Classes.Update(Class);
            _context.SaveChanges();
            return RedirectToAction("ClassList");
        }
    }
}
