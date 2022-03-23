using FrontToBackProductCategory.Models;
using FrontToBackProductCategory.ViewModels;
using FrontToBackProductCategory.Data;

//using Data;
//using Models;
//using ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBackProductCategory.Controllers
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

            List<Slider> sliders = await _context.Sliders.ToListAsync();
            SliderDetail detail = await _context.SliderDetails.FirstOrDefaultAsync();
            List<Catergory> catergories = await _context.Catergories.Where(c => c.IsDeleted == false).ToListAsync();
            List<Product> products = await _context.Products.Where(p => p.IsDeleted == false)
                
                .Include(m => m.Images)
                .OrderByDescending(m => m.Id)
                .Take(8)
                .ToListAsync();

            HomeVM homeVM = new HomeVM
            {
                Sliders = sliders,
                Detail = detail,
                
                Products = products
            };

            return View(homeVM);
        }

       

    }
}
