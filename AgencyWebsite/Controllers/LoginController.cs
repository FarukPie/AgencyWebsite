using AgencyWebsite.Context;
using AgencyWebsite.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AgencyWebsite.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly spoilerContext _context;

        public LoginController(spoilerContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Login login)
        {
            var info = _context.Logins.FirstOrDefault(x => x.Username == login.Username && x.Password == login.Password);

            if (info != null)
            {
                var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, info.Username)
        };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                HttpContext.Session.SetString("Username", info.Username);

                // ✅ yönlendirme doğrudan URL ile yapılabilir
                return Redirect("/About/Index");
            }
            else
            {
                ViewBag.Error = "Kullanıcı adı veya şifre yanlış!";
                return View(); // aynı sayfaya hata ile dön
            }
        }



    }
}

