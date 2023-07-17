using EduHome.DataAccess.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EduHome.UI.Areas.Admin.Controllers;
[Area("Admin")]
public class NoticeBoardController : Controller
{
    public readonly AppDbContext _context;

    public NoticeBoardController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var notice = await _context.NoticeBoards.ToListAsync();
        return View(notice);
    }
}
