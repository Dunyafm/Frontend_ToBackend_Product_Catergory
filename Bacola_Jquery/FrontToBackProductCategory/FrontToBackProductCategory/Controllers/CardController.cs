using FrontToBackProductCategory.Data;
using FrontToBackProductCategory.Models;
using FrontToBackProductCategory.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBackEnd.Controllers
{

    public class CardController : Controller
    {
        private readonly AppDbContext _context;
        public CardController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Catergory> catergories = await _context.Catergories.ToListAsync();
            List<CatergoryName> catergoryNames = await _context.CatergoryNames.ToListAsync();
            List<Fruit> fruits = await _context.Fruits.ToListAsync();
            List<Beverage> beverages = await _context.Beverages.ToListAsync();
            HomeVM homeVM = new HomeVM
            {

                Catergories = catergories,
                CatergoryNames = catergoryNames,
                Fruits = fruits,
                Beverages = beverages

            };
            return View(homeVM);
        }
    }
}
