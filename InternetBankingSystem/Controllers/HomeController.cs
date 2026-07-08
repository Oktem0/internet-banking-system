using InternetBankingSystem.Models;
using InternetBankingSystem.Data;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace InternetBankingSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            var userCount = _context.Users.Count();

            ViewBag.UserCount = userCount;
            ViewBag.FullName = HttpContext.Session.GetString("FullName");

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
