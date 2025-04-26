using System.Security.Claims;
using AcunmedyaAkademiBabyCare.Context;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace AcunmedyaAkademiBabyCare.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        private readonly BabyCareContext _context;

        public LoginController(BabyCareContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(string username, string password)
        {
            var admin = _context.Admins.FirstOrDefault(x => x.UserName == username);
            if (admin == null || admin.Password != password)
            {
                ViewBag.ErrorMessage = "Kullanıcı adı veya şifre hatalı";
                return View();
            }

            var claims = new List<Claim>
    {
        new Claim(ClaimTypes.Name, username),
        new Claim("AdminId", admin.AdminId.ToString())
    };

            var identity = new ClaimsIdentity(claims, "Cookies"); // veya ne kullanıyorsan
            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync("Cookies", principal);

            return RedirectToAction("Index", "Dashboard");
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync("Cookies");
            return RedirectToAction("Index", "Login");
        }

    }
}
