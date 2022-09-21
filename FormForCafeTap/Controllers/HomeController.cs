using FormForCafeTap.DAL;
using FormForCafeTap.Models;
using FormForCafeTap.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FormForCafeTap.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(bool isSuccess = false)
        {
            ViewBag.IsSuccess = isSuccess;
            ViewBag.Work = await _context.Works.ToListAsync();
            ViewBag.University = await _context.Universities.ToListAsync();

           Form forms = await _context.Forms.Include(c=>c.Work).Include(c=>c.Uni).FirstOrDefaultAsync();
            return View(forms);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Index(Form form)
        {
            ViewBag.Work = await _context.Works.ToListAsync();
            ViewBag.University = await _context.Universities.ToListAsync();


            Form forms = await _context.Forms.Include(c => c.Work).Include(c => c.Uni).FirstOrDefaultAsync();

            if (!ModelState.IsValid) return View(form);

            await _context.Forms.AddAsync(form);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", new { IsSuccess = true });
        }
    }
}
