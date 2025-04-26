using Microsoft.AspNetCore.Mvc;

namespace AcunmedyaAkademiBabyCare.ViewComponents
{
    public class _DefaultNavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
