using System.Security.Cryptography;
using System.Text;
using InternetBankingSystem.Data;
using InternetBankingSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace InternetBankingSystem.Controllers
{
    public class AuthController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AuthController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            string hashedPassword = HashPassword(password);

            var user = _context.Users.FirstOrDefault(x =>
                x.Email == email &&
                x.PasswordHash == hashedPassword);

            if (user == null)
            {
                ViewBag.Error = "E-posta veya şifre hatalı!";
                return View();
            }

            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public IActionResult Register(User user)
        {
            user.Role = "Customer";
            user.IsActive = true;
            user.CreatedAt = DateTime.Now;
            user.PasswordHash = HashPassword(user.PasswordHash);
            _context.Users.Add(user);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
        private string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();

            var bytes = Encoding.UTF8.GetBytes(password);
            var hashBytes = sha256.ComputeHash(bytes);

            return Convert.ToBase64String(hashBytes);
        }
    }
}
