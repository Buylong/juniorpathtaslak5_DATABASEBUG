using Microsoft.AspNetCore.Mvc;
using System.Linq;
using juniorpathtaslak5.Models;
using juniorpathtaslak5;

namespace juniorpathtaslak5.Controllers
{
    public class DailyDataController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DailyDataController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.DailyData.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DailyData dailyData)
        {
            if (ModelState.IsValid)
            {
                _context.DailyData.Add(dailyData);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(dailyData);
        }

        public IActionResult Edit(int id)
        {
            var dailyData = _context.DailyData.Find(id);
            if (dailyData == null)
            {
                return NotFound();
            }
            return View(dailyData);
        }

        [HttpPost]
        public IActionResult Edit(DailyData dailyData)
        {
            if (ModelState.IsValid)
            {
                _context.DailyData.Update(dailyData);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(dailyData);
        }

        public IActionResult Delete(int id)
        {
            var dailyData = _context.DailyData.Find(id);
            if (dailyData == null)
            {
                return NotFound();
            }
            return View(dailyData);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var dailyData = _context.DailyData.Find(id);
            _context.DailyData.Remove(dailyData);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
