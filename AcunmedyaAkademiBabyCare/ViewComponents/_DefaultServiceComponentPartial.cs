using AcunmedyaAkademiBabyCare.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunmedyaAkademiBabyCare.ViewComponents
{
    public class _DefaultServiceComponentPartial:ViewComponent
    {
        private readonly BabyCareContext _context;

        public _DefaultServiceComponentPartial(BabyCareContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.Services.OrderByDescending(x => x.ServiceId).Take(4).ToList();
            return View(values);
        }
    }
}
