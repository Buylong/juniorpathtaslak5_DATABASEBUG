using Microsoft.AspNetCore.Mvc;
using System.Linq;
using juniorpathtaslak5.Models;
using juniorpathtaslak5;

namespace juniorpathtaslak5.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Admins.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Admin admin)
        {
            if (ModelState.IsValid)
            {
                _context.Admins.Add(admin);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(admin);
        }

        public IActionResult Edit(int id)
        {
            var admin = _context.Admins.Find(id);
            if (admin == null)
            {
                return NotFound();
            }
            return View(admin);
        }

        [HttpPost]
        public IActionResult Edit(Admin admin)
        {
            if (ModelState.IsValid)
            {
                _context.Admins.Update(admin);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(admin);
        }

        public IActionResult Delete(int id)
        {
            var admin = _context.Admins.Find(id);
            if (admin == null)
            {
                return NotFound();
            }
            return View(admin);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var admin = _context.Admins.Find(id);
            _context.Admins.Remove(admin);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
