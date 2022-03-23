using FrontToBackProductCategory.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBackProductCategory.Areas.AdminArea.Controllers
{
    public class CatergoryController : Controller
    {

        [Area("AdminArea")]
        public class CategoryController : Controller
        {
            private readonly AppDbContext _context;
            public CategoryController(AppDbContext context)
            {
                _context = context;
            }
            public async Task<IActionResult> Index()
            {
                var categories = await _context.Catergories.Where(m => !m.IsDeleted).ToListAsync();
                return View(categories);
            }
            public IActionResult Detail(int id)
            {
                var category = _context.Catergories.FirstOrDefault(m => m.Id == id);
                return View(category);

            }
            public IActionResult Edit(int id)
            {
                return Json(new
                {
                    action = "Edit",
                    Id = id
                });
            }
            public IActionResult Delete(int id)
            {
                return Json(new
                {
                    action = "Delete",
                    Id = id
                });
            }
        }
    }
}
