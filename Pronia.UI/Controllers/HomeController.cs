using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pronia.DataAccess.Contexts;
using Pronia.UI.ViewModels;

namespace Pronia.UI.Controllers
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
            HomeVM homeVM = new() {
                Sliders= await _context.Sliders.ToListAsync(),
                Shippings= await _context.Shippings.ToListAsync(),
                Products= await _context.Products.ToListAsync(),
                Banners= await _context.Banners.ToListAsync(),
                NewProducts= await _context.NewProducts.ToListAsync(),
            };
            return View(homeVM);
        }
    }
}
