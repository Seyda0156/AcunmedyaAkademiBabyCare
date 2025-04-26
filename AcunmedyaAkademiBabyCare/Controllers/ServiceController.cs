using Microsoft.AspNetCore.Mvc;

namespace AcunmedyaAkademiBabyCare.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
