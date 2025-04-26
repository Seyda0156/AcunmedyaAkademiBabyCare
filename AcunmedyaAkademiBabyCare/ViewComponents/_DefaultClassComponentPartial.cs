using AcunmedyaAkademiBabyCare.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunmedyaAkademiBabyCare.ViewComponents
{
    public class _DefaultClassComponentPartial:ViewComponent
    {
        private readonly BabyCareContext _context;

        public _DefaultClassComponentPartial(BabyCareContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.Classes.OrderByDescending(x => x.ClassId).Take(3).ToList();
            var teachers = _context.Teams.ToList(); // Eğer öğretmenlerin olduğu tablo buysa

            ViewBag.Teachers = teachers;
            return View(values);
        }
    }
}
