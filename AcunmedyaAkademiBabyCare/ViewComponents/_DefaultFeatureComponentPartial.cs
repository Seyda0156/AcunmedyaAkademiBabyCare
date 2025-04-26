using AcunmedyaAkademiBabyCare.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunmedyaAkademiBabyCare.ViewComponents
{
    public class _DefaultFeatureComponentPartial:ViewComponent
    {
        private readonly BabyCareContext _context;

        public _DefaultFeatureComponentPartial(BabyCareContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Features.ToList();
            return View(values);
        }
    }
}
