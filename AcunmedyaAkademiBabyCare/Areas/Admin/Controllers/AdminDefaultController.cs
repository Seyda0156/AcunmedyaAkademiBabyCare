using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AcunmedyaAkademiBabyCare.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminDefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
