using AcunmedyaAkademiBabyCare.Context;
using AcunmedyaAkademiBabyCare.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AcunmedyaAkademiBabyCare.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TestimonialController : Controller
    {
        private readonly BabyCareContext _context;

        public TestimonialController(BabyCareContext context)
        {
            _context = context;
        }

        public IActionResult TestimonialList()
        {
            var values = _context.Testimonials.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateTestimonial()
        {
            return View();

        }
        [HttpPost]
        public IActionResult CreateTestimonial(Testimonial Testimonial)
        {
            if (!ModelState.IsValid)//Kurallara uymuyorsa
            {
                return View(Testimonial);
            }
            _context.Testimonials.Add(Testimonial);
            _context.SaveChanges();
            return RedirectToAction("TestimonialList");

        }
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _context.Testimonials.Find(id);
            _context.Testimonials.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
        [HttpGet]
        public IActionResult UpdateTestimonial(int id)
        {
            var values = _context.Testimonials.Find(id);
            return View(values);

        }
        [HttpPost]
        public IActionResult UpdateTestimonial(Testimonial Testimonial)
        {
            var values = _context.Testimonials.Update(Testimonial);
            _context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
    }
}
