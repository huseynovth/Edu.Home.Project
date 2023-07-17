using EduHome.DataAccess.Contexts;
using Microsoft.AspNetCore.Mvc;
using EduHome.UI.ViewModels;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace EduHome.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            HomeVM homevm = new()
            {
                Sliders = await _context.Sliders.ToListAsync(),
                NoticeBoards=await _context.NoticeBoards.ToListAsync(),
            };
            return View(homevm); 
        }

    }
}