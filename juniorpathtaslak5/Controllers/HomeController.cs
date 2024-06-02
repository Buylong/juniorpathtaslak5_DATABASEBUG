using Microsoft.AspNetCore.Mvc;
using juniorpathtaslak5.Models;
using System.Linq;
using juniorpathtaslak5;

namespace juniorpathtaslak5.Controllers
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
            return View(_context.Students.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // Ya� hesaplamalar�n� do�ru �ekilde kullanma
        public IActionResult Test()
        {
            var students = _context.Students.ToList();
            foreach (var student in students)
            {
                int age = student.Age; // Ya�� hesaplayarak kullanabiliriz
            }
            return View(students);
        }
    }
}
